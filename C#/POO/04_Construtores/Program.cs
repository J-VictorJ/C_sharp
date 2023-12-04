using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Constructor Ford = new Constructor("Mustang", "Black", 2021);
            Console.WriteLine($"{Ford.color} {Ford.year} {Ford.model}");

            Constructor Opel = new Constructor("Astra", "White", 2009);
            Console.WriteLine($"{Opel.color} {Opel.year} {Opel.model}");
        }
    }
}