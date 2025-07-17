# NoiseGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static int Seed { get; set; }
- - public static int Octaves { get; set; }
- - public static double Amplitude { get; set; }
- - public static double Persistence { get; set; }
- - public static double Frequency { get; set; }
- - public static double Noise(int x, int y)
- - public static double NoiseGeneration(int x, int y)

## Private Members
- - private static double Interpolate(double x, double y, double a)
- - private static double Smooth(double x, double y)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- - static NoiseGenerator()
