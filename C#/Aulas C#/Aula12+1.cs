using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Break
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // Continue
            for (int i = 0;i < 5; i++)
            {
                if(i == 3) // 3 won't be executed, it'll jump
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}