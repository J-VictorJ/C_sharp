using System;
using System.Drawing;

namespace TypeCasting;

class TypeCg
{
    static void Main(string[] args)
    {
        // Implicit Casting (automatically) - converting a smaller type to a larger type size
        // char -> int -> long -> float -> double

        // Explicit Casting(manually) - converting a larger type to a smaller size type
        // double -> float -> long -> int -> char
        int myInt = 8;
        double myDouble = myInt; // automatic casting
        Console.WriteLine(myDouble);

        double myDouble2 = 9.54;
        int myInt2 = (int)myDouble2;


        // Type Conversion Methods

        int myInt3 = 10;
        double myDouble3 = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
    }

}