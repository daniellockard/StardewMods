# OsxSdlClipboard

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public OsxSdlClipboard()

## Private Members
- - private const string DylibName = "libSDL2-2.0.0.dylib";
- - private static extern IntPtr SDL_GetClipboardText();
- - private static extern int SDL_SetClipboardText(IntPtr text);

## Protected Members
- - protected override IntPtr GetTextImpl()
- - protected override int SetTextImpl(IntPtr text)

## Internal Members
- *(None)*

## Other Members
- *(None)*
