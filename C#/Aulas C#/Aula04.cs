using System;

namespace DataTypes;
    class DataT
{
     static void Main(string[] args)
    {
         int x = 5;
         long y = 222L; // long is when you need to put more num than int is able
         Console.WriteLine(x);
        Console.WriteLine(y);

        float pi = 3.1415F;
        Console.WriteLine(pi);

        // Scientific Numbers
        float f1 = 35e3F;
        double d1 = 12E4D;
        Console.WriteLine(f1);
        Console.WriteLine(d1);

    }
}