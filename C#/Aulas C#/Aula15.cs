using System;
using System.Dynamic;
using System.Linq;

namespace arr2
{
    class array2
    {
        static void Main(String[] args)
        {
            // Array.sort()
            int[] ints = { 1, 58, 4, 0, 5};
            Array.Sort(ints);

            foreach (int n in ints)
            {
                Console.WriteLine(n);

            }
            Console.WriteLine();
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // System.Linq / line 2
            int[] numbs = { 10, 15, 4, 29, 8, 3, 9 };
            Console.WriteLine(numbs.Max());
            Console.WriteLine(numbs.Min());
            Console.WriteLine(numbs.Sum());


            Console.WriteLine();


            // Multidimensional Array
            int[,] mult = { {2, 8, 4}, {6, 12, 16 } };
            Console.WriteLine(mult[1,2]);
            Console.WriteLine(mult[0,1]);
            mult[0,0] = 10;
            Console.WriteLine(mult[0,0]);
            Console.WriteLine();

            // Loop through
            foreach (int num in mult)
            {
                Console.WriteLine(num);

            }
            Console.WriteLine();


            // For Loop / var.GetLength
            for (int j = 0; j < mult.GetLength(0); j++)
            {
                for (int g = 0; g < mult.GetLength(1); g++)
                {
                    Console.WriteLine(mult[j, g]);

                }
            }
        }
    }
}