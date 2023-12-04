using System;

namespace ChatGpt;
class exercicios
{
    static void Main(string[] args)
    {
        //1. **Output:**
        //Write a C# program that displays the message "Hello, C# World!" to the console.
        
        Console.WriteLine("Hello, C# World!");

        //2. **Variables:**
        //Create a C# program that calculates the area of a rectangle. Define variables for the length and width of the rectangle, and then calculate and display the area.
        double width = 7.00;
        double length = 10;
        double rectangle = width * length;
        Console.WriteLine($"The rectangle area's {rectangle}");
       
        //3. **Data Types:**
        //Write a C# program that converts a user's input (which is a string) to an integer and then adds 10 to it. Display the result.
       
        Console.WriteLine("Put a number ");
        string convert = Console.ReadLine();
        int numb = Convert.ToInt32(convert);
        int calc = numb + 10;
        Console.WriteLine($"The sum is {calc}");
        
        //4. **Type Casting:**
        //Create a C# program that takes a double number as input and casts it to an integer to truncate the decimal part. Display the integer result.

        Console.WriteLine("Put a double number ");
        
        double toDouble = Convert.ToDouble(Console.ReadLine());
        int rounded = (int)Math.Round(toDouble);
        int toInt = (int)rounded;
        Console.WriteLine(toInt);

        //5. **User Input:**
        //Build a C# program that asks the user to enter their name and then displays a personalized greeting message using their input.
       
        Console.WriteLine("Put your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hy, {name}, have a good day!");
        
        //6. **Operators:**
        //Write a C# program that calculates the result of the following expression: (5 * 4) + (10 / 2) - (7 % 3). Display the result.
        
        Console.WriteLine((5 * 4) + (10 / 2) - (7 % 3));
        
        //7. **Math:**
        //Develop a C# program that calculates the area of a circle. Prompt the user to enter the radius, and then use the Math library to perform the calculation. Display the area.

        double pi = Math.PI;
        Console.WriteLine("Enter Radius");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = pi * radius * radius;
        Console.WriteLine(Math.Round(area));


        //These exercises cover a range of fundamental concepts in C# programming and should help you practice various aspects of the language.
    }
}
