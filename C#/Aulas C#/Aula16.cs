using System;

namespace MyApplication
{
    class Program
    {
       static void MeuMethod()
        {
            Console.WriteLine("Primeiro method no C#");
        }


        // Parameters and Arguments
        static void SegundoMethod(string nome, int idade)
        {
            Console.WriteLine($"Hello, {nome}, you are {idade}");
        }


        // Default Parameter Value
        static void Nacionalidade(string pais = "Brasil")
        {
            Console.WriteLine($"Your Country is: {pais}");
        }


        static void Main(string[] args) // The main program will be executed here, because we need the Main method that contains everything
        {
            MeuMethod();
            SegundoMethod("Jvictor", 20);
            Nacionalidade();
            Nacionalidade("USA");
        }
        
    }
}