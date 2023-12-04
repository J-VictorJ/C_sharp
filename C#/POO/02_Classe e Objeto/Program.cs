using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car objeto = new Car();
            Console.WriteLine(objeto.Color);

            // Create multiple objects of the same class
            Car objeto2 = new Car();
            Console.WriteLine(objeto2.Color);
        }
    }
}
