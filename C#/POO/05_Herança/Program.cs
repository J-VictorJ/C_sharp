using System;

namespace Inheritance
{
    class Car : Vehicle
    {
        public string model = "Mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine($"{myCar.brand} {myCar.model}");

        }
    }
}