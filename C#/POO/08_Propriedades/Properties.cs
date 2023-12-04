namespace Properties;

class Properties
{
    private string car;
    public string Car { get { return car; } set { car = value; } }

    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }

    private int age;
    public int Age
    {
        get; set; // Short hand
    }
}