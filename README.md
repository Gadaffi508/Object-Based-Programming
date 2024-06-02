# Object-Based Programming in C#

Bu proje, C# dilinde temel nesne tabanlı programlama (OOP) kavramlarını ve uygulamalarını içermektedir. Aşağıda her bir dosyanın açıklaması ve örnek kod parçaları verilmiştir.

## AbstractExample.cs

Bu dosya, soyut sınıfların ve soyut yöntemlerin kullanımını göstermektedir.

### Örnek Kod

#### Abstract Örnek

```csharp Abstarct Örneği
using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Console.WriteLine("Area of circle: " + circle.CalculateArea());
    }
}
```
#### Constucter Örneği

```Constucter Örneği
class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Alice", 30);
        person.DisplayInfo();
    }
}
```
#### Database Örneği

```Database Örneği
using System;
using System.Data.SqlClient;

class DatabaseExample
{
    public void ConnectToDatabase()
    {
        string connectionString = "your_connection_string_here";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            Console.WriteLine("Database connected.");
        }
    }
}

class Program
{
    static void Main()
    {
        DatabaseExample dbExample = new DatabaseExample();
        dbExample.ConnectToDatabase();
    }
}
```
