namespace Constructors
{
    class Constructor //Car
    {
        public string model;
        public string color;
        public int year;
        // Create a constructor with parameters
        public Constructor(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        // Without Constructor
        /*
         static void Main(string[] args)
          {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
         */
    }
}