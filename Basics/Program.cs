
Desk d1 = new Desk();

d1.colour = "green";
d1.height = 0.5m;
d1.brand = "Auchan";

while(true)
{
    d1.Lift();
    Thread.Sleep(500);
}


class Desk
{
    public const decimal MAX_HEIGHT = 2.0m;
    public decimal height;
    public string colour;
    public string brand;

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

