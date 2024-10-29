
Desk d1 = new Desk("red","Nivea");
Console.WriteLine(d1.getHeight());
while(true)
{
    d1.Lift();
    Thread.Sleep(500);
}


class Desk(string color, string brand)
{
    public const decimal MAX_HEIGHT = 2.0m;
    public decimal height { get; private set; } = 1.0m;
    public string color { get; private set; } = color;
    public string brand { get; private set;} = brand;

    //Constructor (style 1)
    //public Desk(int h, string color, string brand)
    //{
    // this.height = h;
    //this.color = color;
    //this.brand = brand;
    //}

    public decimal getHeight()
    {
        return height;
    }

    public void Lift()
    {
        if (height < MAX_HEIGHT)
        {
            height += 0.1m;
        } else
        {
            Console.WriteLine($"Hey, it's too high. Max {MAX_HEIGHT}");
        }
        Console.WriteLine($"Desk is on {height} height");
    }
}


// public, private, protected

