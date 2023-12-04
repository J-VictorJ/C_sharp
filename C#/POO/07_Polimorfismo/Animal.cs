using System;

namespace Poly { 
    public class Animal {
        public virtual void animalSound() 
        {Console.WriteLine("Animal makes a sound");}
    }
    class Dog : Animal
    {
        public override void animalSound() // without, I never can see line 12 and 19
        {
            Console.WriteLine("The dogs says: bow wow");
        }
    }
    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}