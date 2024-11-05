using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Car v1 = new Car("Mercedes", "C klasa", new DateTime(2007,05,06));
v1.DisplayInfo();

Student student = new Student("Jan Kowalski", 5);
Console.WriteLine(student.Name);
if (student.IsPassing()==true)
{
    Console.WriteLine("Zdał");
}
else
{
    Console.WriteLine("Nie zdał");
}
Book ks = new Book("Nicho", "Wojciech Kowalewski", 2137);
Console.WriteLine(ks.GetSummary());
Book ks1 = new Book();
Console.WriteLine(ks1.GetSummary());

class Car
{
    public string Brand;
    public string Model;
    public DateTime Data;
    public Car(string model, string brand, DateTime data)
    {
        Brand = brand;
        Model = model;
        Data = data;
    }
    public void DisplayInfo()
    {
        Console.WriteLine(Model);
        Console.WriteLine(Brand);
        Console.WriteLine(Data);
    }
}

class Student(string Name, int grade)
{
    public string Name { get; private set; } = Name;
    private int _grade=ValidateGrade(grade);
    public int Grade
    {
        get { return _grade;}
        set 
        {
            _grade = ValidateGrade(Grade);
        }
    } 
    static private int ValidateGrade(int val)
    {
        if (val >= 1 && val <= 6)
        {
            return val;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Ocena poza zakresem");
        }

    }
    public bool IsPassing()
    {
        if(Grade >=2)
            return true;
        else
            return false;
    }

}
class Book(string Title, string Author, int Pages)
{
    public string title {get; private set; } = Title;
    public string author { get; private set; } = Author;
    public int pages { get; private set; }  = Pages;
    public string GetSummary()
    {
        return (title + " by " + author + " pages: " + pages);
    }
    public Book() : this("Cursed book","Anonim",2137){} 
}

class BankAccount(string OwnerName,double Balance)
{
    public string OwnerName { get; private set; }
    private double Balance;

}


