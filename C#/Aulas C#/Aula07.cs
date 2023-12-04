using System;

namespace Mathematic;

class Mathematic
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 10;
        int z = Math.Max(x, y);
        int a = Math.Min(x, y);
        double sqrt = Math.Sqrt(y);
        // The Math.Abs(x) method returns the absolute (positive) value of x
        double abs = Math.Abs(y);
        double round = Math.Round(8.91287);

        Console.WriteLine(z);
        Console.WriteLine(a);
        Console.WriteLine(sqrt);
        Console.WriteLine(abs);
        Console.WriteLine(round);
    }
}