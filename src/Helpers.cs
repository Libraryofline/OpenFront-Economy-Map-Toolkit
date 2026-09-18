// Build: 35f4ed917dbcd617f21d8fd6993fccfd
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
