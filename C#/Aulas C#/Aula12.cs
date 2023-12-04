using System;

namespace MyApp;
class WhileLoop
{
    static void Main(string[] args)
    {
        // Syntax
        /*while (true)
          {
              // code
          }*/

        int i = 5;
        while(i>0)
        {
            Console.WriteLine(i);
            i--;
        }
        Console.WriteLine("                ");
        // Do While

        /*do 
        {
          // code block to be executed
        }
        while (condition);
         */
        int j = 0;
        do {
            Console.WriteLine(j);
            j++;
        }
        while (j < 5);
    }
}


