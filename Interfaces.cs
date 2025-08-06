using System;

// Interface
interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}


class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class MovableDemo
{
    static void Main()
    {
        Console.WriteLine(" --Interfaces-- ");
        
        IMovable myCar = new Car();
        IMovable myBike = new Bicycle();
        
        myCar.Move();    
        myBike.Move();   
    }
}