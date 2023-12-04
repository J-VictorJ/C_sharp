using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties person1 = new Properties();
            person1.Name = "Test";
            person1.Age = 19;
            person1.Car = "Astra";
            Console.WriteLine(person1.Name + " " + person1.Age + " " + person1.Car);
        }
    }
}