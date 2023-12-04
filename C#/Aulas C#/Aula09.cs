using System;

namespace Decision;
class Decision
{
    static void Main(string[] args)
    {
        // If
        if (20>0)
        {
            Console.WriteLine("20 is greater 18");
        }

        // Else
        int x = 0;
        if (20<x)
        {
            Console.WriteLine("if something is false");
        }
        else
        {
            Console.WriteLine("it'll apears here");
        }

        // Else if
        int time = 22;
        if (time < 10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }

        // Ternary Operator
        // variable = (condition) ? expressionTrue :  expressionFalse;

        string result = (time > 18) ? "Good Morning" : "Good evening";
        Console.WriteLine(result);
    }
}