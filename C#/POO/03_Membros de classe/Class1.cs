namespace ClassMembers
{
    /*public class MyCar
    {
        public string Color = "red";
        public int MaxSpeed = 200;
        
    }*/

    public class MyCar
    {
        public string Model;
        public string Color;
        public int Year;
        public void fullThrottle(string modelo)
        {
            Console.WriteLine($"The {modelo} is going as fast as it can!");
        }
    }
}

