using System;

namespace arr
{
    class arrays
    {
        static void Main(string[] args)
        {
            string[] teams = { "Ford Cosworth", "Red bull", "Aston Martin", "Ferrari" };
            int[] arr2 = { 1, 2, 3 };

            Console.WriteLine(teams[1]);
            Console.WriteLine(arr2[2]);

            // Change an Array Element
            teams[2] = "Dinoco";
            Console.WriteLine(teams[2]);

            // Array Length
            Console.WriteLine(arr2.Length);
            Console.WriteLine(teams.Length);
            Console.WriteLine();

            // Loop with arrays
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();

            foreach (string brand in teams)
            {
                Console.WriteLine(brand);
            }
        }
    }
}