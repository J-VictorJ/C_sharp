using System;

namespace MyApp;

class Loops
{
    static void Main(string[] args)
    {
        // Loop for, when you know how much times the code need to run
        /* for (statement 1; statement 2; statement 3) 
            {
             // code block to be executed
            }
        Statement 1 is executed (one time) before the execution of the code block.

        Statement 2 defines the condition for executing the code block.

        Statement 3 is executed (every time) after the code block has been executed.
       */

        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        for (int j = 5; j > 0; j--)
        {
            Console.WriteLine(j);
        }
        Console.WriteLine();
        for (int x = 0; x < 15; x = x + 3) {Console.WriteLine(x); }

        // Nested Loop
        for (int i = 1; i <= 2; ++i)
        {
            Console.WriteLine("Outer: " + i);  // Executes 2 times

            // Inner loop
            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
            }
        }

        Console.WriteLine();

        // For Each

        /*foreach (type variableName in arrayName) 
        {
          // code block to be executed
        }*/
        string[] cars = {" Ford Cosworth "," Red Bull Racing "," Ferrari"};
        foreach(string car in cars) // the new str "car" can be any name
        {
            Console.WriteLine(car);
        }
    }
}