using System;

namespace PointOF
{
    class NoReturn
    {
        static int MyMethod(int x)
        {
            return 8 + x;
        }

        static int MyCalculator(int x, int y)
        {
            return x * y;
        }


        // Named Arguments
        static void NamedArgs(string child1, string child2, string child3)
        {
            Console.WriteLine($"The youngest child is: {child3}, the older one is: {child2}");
        }


        // Overloading

        static int OverloadingMethods(int x, int y)
        {
            return x + y;
        }
        static double OverloadingMethods(double x, double y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(2));

            // Storing in Variables / line 12
            int z = MyCalculator(5, 7);
            Console.WriteLine(z);

            NamedArgs(child2: "Bagre", child1: "Adagia", child3: "Antonella");



            int myInt = OverloadingMethods(5, 7);
            double myDouble = OverloadingMethods(4.3, 6.26);
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
        }
    }

    
}