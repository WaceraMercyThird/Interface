// See https://aka.ms/new-console-template for more information

using System;  
public interface ClassRoom
{
    void Name();
    void Age();
    void Car();
}

public class Student1 : ClassRoom
{
    public void Name()
    {
        Console.WriteLine("Name: Jane Doe");
    }
    public void Age()
    {
        Console.WriteLine("Age: " + 26);
    }
    public void Car()
    {
        Console.WriteLine("Car: Land Rover - Defender");
    }
}

public class Student2 : ClassRoom
{
    public void Name()
    {
        Console.WriteLine("Name: John Doe");
    }
    public void Age()
    {
        Console.WriteLine("Age: " + 45);
    }
    public void Car()
    {
        Console.WriteLine("Car: Toyota");
    }
}
public class Student3 : ClassRoom
{
    public void Name()
    {
        Console.WriteLine("Name: John Doe");
    }
    public void Age()
    {
        Console.WriteLine("Age: " + 45);
    }
    public void Car()
    {
        Console.WriteLine("Car: Toyota");
    }
}

public class MyInterface  
{  
    public static void Main()
    {
        ClassRoom M;
        M = new Student1();
        M.Name();
        M.Age();
        M.Car();
        M = new Student2();
        M.Name();
        M.Age();
        M.Car();
        M = new Student3();
        M.Name();
        M.Age();
        M.Car();
        


    }  
}