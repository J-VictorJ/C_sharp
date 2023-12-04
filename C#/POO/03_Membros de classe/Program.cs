using System;
using System.Runtime.ConstrainedExecution;

namespace ClassMembers;

class Program
{
    static void Main(string[] args)
    {
       /* MyCar carro1 = new MyCar();
        Console.WriteLine(carro1.MaxSpeed);
        Console.WriteLine(carro1.Color);*/


        MyCar Ford = new MyCar();
        Ford.Model = "Mustang";
        Ford.Color = "Black";
        Ford.Year = 2023;
        Ford.fullThrottle(Ford.Model);
        Console.WriteLine($"The car: {Ford.Model}, color {Ford.Color}, year {Ford.Year}, is avalible!");


        MyCar Opel = new MyCar();
        Opel.Model = "Astra";
        Opel.Color = "white";
        Opel.Year = 2005;
        Opel.fullThrottle(Opel.Model);

        Console.WriteLine($"The car: {Opel.Model}, color {Opel.Color}, year {Opel.Year}, is avalible!");
        
    }
}