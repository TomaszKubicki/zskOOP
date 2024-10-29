using System.Security.Cryptography;

Car v1 = new Car("Mercedes", "C klasa", "2007");
v1.DisplayInfo();
class Car(string brand, string model,string data)
{
    public string Brand = brand;
    public string Model = model;
    public string Data = data;
    public void DisplayInfo()
    {
        Console.WriteLine(Model);
        Console.WriteLine(Brand);
        Console.WriteLine(Data);
    }
}
