using System;

namespace Exercicios
{
    class loopsWhile
    {
        static void Main(string[] args)
        {
            /*While Loop (6 exercises):

            Implement a C# program that counts down from 10 to 1 using a while loop and displays each number.*/

            int z = 10;
            while (z > 0) { Console.WriteLine(z); z--; }


            /*Create a C# program that asks the user to guess a secret number (e.g., 42) using a while loop until they guess it correctly.*/

            int secretNumber = 1;
            Console.WriteLine("Guess a secret number");
            int userNumb = Convert.ToInt32(Console.ReadLine()); ;
            while (true)
            {
                if (userNumb == secretNumber)
                {
                    Console.WriteLine($"You GET IT, the number was: {userNumb}");
                    break;
                }

                
                if (userNumb != secretNumber)
                {
                    Console.WriteLine($"Keep Trying, the number isn't: {userNumb}");
                    Console.WriteLine("Guess again");
                    userNumb = Convert.ToInt32(Console.ReadLine());
                }
                
                }


            /* Write a C# program that calculates the sum of integers from 1 to N, where N is entered by the user using a while loop.*/

            Console.WriteLine("Press a number to sum");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int varia = 0;
            while (n >= 1)
            {
                sum++;
                n--;
               varia = sum += n;
                
            }
            Console.WriteLine(varia);

           
            /* Build a C# program that generates and displays a random number between 1 and 100, and the user has to guess it using a while loop.*/
           
            Console.WriteLine("Guess who's back");
            int userImput = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int random = rand.Next(100);
            while (true)
            {
                if (random == userImput)
                {
                    Console.WriteLine($"You was smooth {random}");
                    break;
                }

                while (random != userImput)
                {
                    Console.WriteLine($"Incorrect, the number was: {random} \n Keep Trying");
                    random = rand.Next(100);
                    userImput = Convert.ToInt32(Console.ReadLine());
                }
                
            }


            /* Develop a C# program that simulates a simple ATM machine. The user can withdraw money until they have a balance of zero or choose to exit using a while loop.*/
           
            double money = 250.00;
            Console.WriteLine($"Your actually balance is {money} '" +
                "\n How much do you want to withdraw.");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            double saque = money - withdraw;
            int exit = 0;
            while (true)
            {
                if (saque > 0)
                {
                    Console.WriteLine($"Your balance is: {saque} \n");
                    Console.WriteLine("Continue, press '0'" +
                        "\n            Break press '1'");
                    exit = Convert.ToInt32(Console.ReadLine());

                    if (exit == 1)
                    {
                        break;
                    }
                    else if (exit == 0)
                    {
                        
                        Console.WriteLine("How much do you want to withdraw \n" +
                            $"Balance: {saque}");
                        withdraw = Convert.ToDouble(Console.ReadLine());
                        saque -= withdraw;
                    }
   
                }
                else
                {
                    Console.WriteLine($"Your balance is {saque}, so you do not have money");
                    break;
                }
            }


            /* Create a C# program that prints the Fibonacci sequence up to a specified number of terms using a while loop.*/
            int f = 10;
            int a = 0;
            int b = 1;
            int c;
            int i = 0;
            Console.Write("{0} {1}", a, b);
            while (i < f - 2)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a= b; b= c; i++;
            }
            Console.WriteLine();


            /* Do While (3 exercises):

             Write a C# program that asks the user to enter a password. Keep prompting them until they enter the correct password using a do while loop.*/
            string password = "MyDog1234";
            Console.WriteLine("Press your password");
            string userPassword = Console.ReadLine();
            do {
                Console.WriteLine("Incorrect.\n Try again");
                userPassword = Console.ReadLine();
                if (password == userPassword)
                {
                    Console.WriteLine("Welcome");
                    break;
                }
            } while (password != userPassword);


            /* Implement a C# program that simulates a basic menu system where the user can choose options until they choose to exit using a do while loop.*/
            Console.WriteLine("Chose an option\n" +
                    "Press 0 to: singlePlayer \n" +
                    "Press 1 to: multiPlayer \n" +
                    "Press 2 to: exit");
            int singlePlayer = 0;
            int multiPlayer = 1;
            int sair = 2;
            do {
                
                int chose = Convert.ToInt32(Console.ReadLine());
                if(chose == 0)
                {
                    Console.WriteLine("Welcome to Single Player mode");
                    Console.WriteLine("Chose an option\n" +
                    "Press 0 to: singlePlayer \n" +
                    "Press 1 to: multiPlayer \n" +
                    "Press 2 to: exit");
                    
                }
                else if (chose == 1)
                {
                    Console.WriteLine("Welcome to Multi Player mode");
                    Console.WriteLine("Chose an option\n" +
                    "Press 0 to: singlePlayer \n" +
                    "Press 1 to: multiPlayer \n" +
                    "Press 2 to: exit");
                    
                }
                else
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }while (true);
            /*Build a C# program that asks the user to input a number between 1 and 10. Keep prompting until they enter a valid number using a do while loop.*/
            
            
            Console.WriteLine("Input some integer number");
            int input = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (input >= 0 && input <= 10)
                {
                    Console.WriteLine("Valid number");
                    break;
                }
                else
                {
                    Console.WriteLine("Keep trying");
                    input = Convert.ToInt32(Console.ReadLine());
                }

            }while (true);
        }
    }
}