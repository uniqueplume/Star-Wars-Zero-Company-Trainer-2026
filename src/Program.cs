// Build: 640e9c44b5abb4b8dfab8ea0e1561f75
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
