using System;

namespace MyApplication
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            /*If-Else (4 exercises):

            Write a C# program that checks if a given number is even or odd and displays an appropriate message.*/
            int x = 6;
            if(x % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }



            /*Create a C# program that asks the user for their age and then checks if they are eligible to vote (age >= 18). Display a message accordingly.*/

            Console.WriteLine("Press your age: ");
            int checkAge = Convert.ToInt32(Console.ReadLine());

            if (checkAge >= 18) { Console.WriteLine("You are able to vote"); }else { Console.WriteLine("You are NOT able to vote"); }
           
            

            /*Build a C# program that calculates the discount amount based on a purchase amount. If the purchase amount is greater than $100, apply a 10% discount; otherwise, apply a 5% discount.*/
            
            Console.WriteLine("Press the price:");
            int valor = Convert.ToInt32(Console.ReadLine());
            if(valor >= 100)
            {
                double discountValue = 10.0 / 100.0;
                double newValue = valor - (discountValue * valor);
                Console.WriteLine(newValue);
            }else {
                double discountValue = 5.0 / 100.0;
                double newValue = valor - (discountValue * valor);
                Console.WriteLine(newValue); }
            

            
            /*Develop a C# program that prompts the user to enter two numbers and then checks and displays which one is larger, or if they are equal.*/
           
            Console.WriteLine("Press the first Number");
            int fNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press the second Number");
            int sNumb = Convert.ToInt32(Console.ReadLine());
            string maxMin = fNumb > sNumb ? $"{fNumb} is greater than {sNumb}" : $"{sNumb} is greater than {fNumb}";
            Console.WriteLine(maxMin);
        }
    }
    }