using System;

namespace UserImput;
class User
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string username = Console.ReadLine();
        Console.WriteLine("Username is: " +  username);
        Console.WriteLine("Hello, " + username + ", how are you?");
        Console.WriteLine("How old are you?");
        string age = Console.ReadLine(); // just string
        Console.WriteLine(username + " are " + Convert.ToInt32(age)); // convert... can be used as a variable too
    }
}