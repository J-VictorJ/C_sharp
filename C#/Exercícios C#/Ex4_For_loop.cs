using System;

namespace Exercices
{
    class LoopsExercices
    {
        static void Main(string[] args)
        {
            /*For Loop(3 exercises):

            Write a C# program that uses a for loop to display the numbers from 1 to 10.*/


            for (int x = 1; x <= 10; x++) { Console.WriteLine(x); }


            /*Create a C# program that calculates the factorial of a given number using a for loop.*/

            Console.WriteLine("Press a number to see its factorial:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = n;
            int nFa = 0;
            for (i = n; i > nFa; i--)
            {
                nFa = n * (n - 1) * (n - 2);

            }
            Console.WriteLine($"The factorial of {n} is: {nFa}");



            /*Build a C# program that calculates and displays the sum of all even numbers from 1 to 100 using a for loop.*/

            int calc = 0;
            for (int y = 0; y < 100; y++)
            {
                if (y % 2 == 0)
                {
                    calc += y;
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine(calc);



            /*For Each Loop(2 exercises):

            Create a C# program that uses a foreach loop to iterate through an array of names and displays each name.*/
            string[] cars = { "Red Bull Racing", "Ford Cosworth", "Ferrari", "Mercedão" };
            foreach (string vehicles in cars)
            {
                Console.WriteLine(vehicles);
            }


            /*Write a C# program that calculates the average score of students in a class using a foreach loop to iterate through an array of scores.*/

            double[] scores = { 5.0, 5.0, 8.0, 4.0 };
            double sum = 0;
            foreach (double note in scores)
            {
                sum += note / scores.Length;
            }
            Console.WriteLine(sum);
        }
    }
}