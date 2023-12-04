using System;

namespace Interface
{
    interface ICarro // ever start with I
    {
        void engineSound();  // it is abstract and public
    }

    class Car : ICarro
    {
        public void engineSound()
        {
            Console.WriteLine("Engine starting");
        }

    }
    // multiple interfaces
    class Noise : Car, ICarro  // just add a comma
    {
        public void engineNoise()
        {
            Console.WriteLine("Muscle car noises");

        }
    }
}