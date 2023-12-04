using System;

namespace Var;
class Variables
{
    static void Main (String[] args)
    {
        // Data types
        int i = 0;
        double d = 1.0D;
        char c = 'a';
        string s = "String";
        bool b = true;
        // The syntax of 'em is: type variableName = value;

        Console.WriteLine (i);
        Console.WriteLine(d);
        Console.WriteLine(c);
        Console.WriteLine(s);
        Console.WriteLine(b);

        int num;
        num = 0;
        Console.WriteLine (num);
        num = 220;
        Console.WriteLine ("The new value of num is " + num);


                    // Constants

        // used to do not overwrite.  
        const int x = 20; // value required
        Console.WriteLine (x);
        // x = 15


                   // Display variables

        Console.WriteLine ("Hello " + c + " " + s);


        // Declare many Variables

        int e = 5, f = 6, g = 7;
        Console.WriteLine (e + f + g); // just it, cannot add comma
        int y, z;
        y = z = 50;
        Console.WriteLine (y + z);


                  // Identifiers is the rules, nothing much

    }

}