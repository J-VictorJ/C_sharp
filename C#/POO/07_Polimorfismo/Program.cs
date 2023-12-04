using System;

namespace Poly
{
    class Polymorphism
    {
        
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal pig = new Pig();

            animal.animalSound();
            dog.animalSound();
            pig.animalSound();
            // Output == Animal makes a sound

            /*However, C# provides an option to override the base class method,
             * by adding the "virtual" keyword to the method inside the base class,
               and by using the "override" keyword for each derived class methods:*/
        }
    }

}