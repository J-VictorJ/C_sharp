using System;


class Program
{
    static void Main(string[] args)
    {
        /*
        **Method Exercise 1: Calculate Area of a Rectangle**

        Write a C# program that defines a method called `CalculateRectangleArea` which takes two parameters, `width` and `height`, and calculates the area of a rectangle. The program should then prompt the user to enter the width and height of a rectangle and call the method to calculate and display the area.*/

        double CalculateRectangleArea()
        {
            Console.WriteLine("Press the width");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Press the height");
            double height = Convert.ToDouble(Console.ReadLine());
            return width * height;
            
        }

        Console.WriteLine(CalculateRectangleArea());

        /***Method Exercise 2: Find the Maximum of Three Numbers**

        Create a C# program that defines a method named `FindMaximum` which takes three integer parameters and returns the maximum of the three numbers. The program should prompt the user to enter three numbers and call the method to find and display the maximum number.*/

        void FindMaximum()
        {
            Console.WriteLine("Press first number");
            int nOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press second number");
            int nTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press thirt number");
            int nThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (nOne > nTwo && nOne > nThree){Console.WriteLine($"{nOne}, first input, is the bigger");
            }else if(nTwo > nOne && nTwo > nThree) { Console.WriteLine($"{nTwo}, second input, is the bigger"); }
            else { Console.WriteLine($"{nThree}, thirt input, is the bigger"); }
        }
        FindMaximum();
           
        /**Method Exercise 3: Check for Prime Numbers**

        Develop a C# program that defines a method called `IsPrime` which takes an integer parameter and returns `true` if the number is prime and `false` if it is not prime. The program should prompt the user to enter a number and use the `IsPrime` method to determine whether it's prime or not, and then display the result.*/
    
        Boolean IsPrime()
        {
            Console.WriteLine("Press to see if it's prime or not");
            int numb = Convert.ToInt32(Console.ReadLine());
            Boolean IsPrime = true;
            for (int divisor = 2; divisor <= Math.Sqrt(numb); divisor++)
            {
                if (numb % divisor == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
               
            return IsPrime;
        }
        Console.WriteLine(IsPrime());
    }

}