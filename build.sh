#!/bin/bash

# Build script for Guinea Pig Mod
# Reads version from manifest.json and builds the mod

set -e  # Exit on any error

# Always operate from the directory where this script is located
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

# Function to print colored output
print_status() {
    echo -e "${BLUE}[INFO]${NC} $1"
}

print_success() {
    echo -e "${GREEN}[SUCCESS]${NC} $1"
}

print_warning() {
    echo -e "${YELLOW}[WARNING]${NC} $1"
}

print_error() {
    echo -e "${RED}[ERROR]${NC} $1"
}

# Check if jq is installed for JSON parsing
if ! command -v jq &> /dev/null; then
    print_error "jq is required but not installed. Please install jq to parse JSON."
    print_status "On macOS: brew install jq"
    print_status "On Ubuntu/Debian: sudo apt-get install jq"
    exit 1
fi

# Navigate to the mod directory
MOD_DIR="GuineaPigMod"
if [ ! -d "$MOD_DIR" ]; then
    print_error "Mod directory '$MOD_DIR' not found!"
    exit 1
fi

cd "$MOD_DIR"

# Read version from manifest.json
if [ ! -f "manifest.json" ]; then
    print_error "manifest.json not found!"
    exit 1
fi

VERSION=$(jq -r '.Version' manifest.json)
MOD_NAME=$(jq -r '.Name' manifest.json)

if [ "$VERSION" = "null" ] || [ -z "$VERSION" ]; then
    print_error "Could not read version from manifest.json"
    exit 1
fi

print_status "Building $MOD_NAME version $VERSION"

# Clean previous builds
print_status "Cleaning previous builds..."
if [ -d "bin" ]; then
    rm -rf bin
fi
if [ -d "obj" ]; then
    rm -rf obj
fi

# Build the project
print_status "Restoring NuGet packages..."
dotnet restore

print_status "Building mod..."
dotnet build --configuration Release --no-restore

if [ $? -eq 0 ]; then
    print_success "Build completed successfully!"
    
    # Check if the DLL was created
    DLL_PATH="bin/Release/net8.0/GuineaPigMod.dll"
    if [ -f "$DLL_PATH" ]; then
        print_success "Mod DLL created: $DLL_PATH"
        
        # Create release package
        RELEASE_DIR="../releases"
        PACKAGE_NAME="GuineaPigMod-v${VERSION}"
        PACKAGE_PATH="${RELEASE_DIR}/${PACKAGE_NAME}"
        MOD_FOLDER_NAME="GuineaPigMod"
        
        mkdir -p "$RELEASE_DIR"
        
        print_status "Creating release package..."
        
        # Create package directory with proper mod folder structure
        mkdir -p "$PACKAGE_PATH/$MOD_FOLDER_NAME"
        
        # Copy mod files into the GuineaPigMod folder
        cp manifest.json "$PACKAGE_PATH/$MOD_FOLDER_NAME/"
        cp "$DLL_PATH" "$PACKAGE_PATH/$MOD_FOLDER_NAME/"
        cp -r assets "$PACKAGE_PATH/$MOD_FOLDER_NAME/" 2>/dev/null || print_warning "No assets directory found"
        
        # Create zip file
        cd "$RELEASE_DIR"
        zip -r "${PACKAGE_NAME}.zip" "$PACKAGE_NAME"
        
        print_success "Release package created: ${PACKAGE_NAME}.zip"
        print_status "Package location: $RELEASE_DIR/${PACKAGE_NAME}.zip"
        
        # Clean up temporary package directory
        rm -rf "$PACKAGE_NAME"
        
    else
        print_error "DLL not found at expected location: $DLL_PATH"
        exit 1
    fi
else
    print_error "Build failed!"
    exit 1
fi

print_success "Build process completed!"
print_status "Version: $VERSION"
print_status "Mod Name: $MOD_NAME" 