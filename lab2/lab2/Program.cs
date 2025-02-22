using System;

// Interface 1: Flyable
interface IFlyable
{
    void Fly();
}

// Interface 2: Swimmable
interface ISwimmable
{
    void Swim();
}

// Derived class: Duck, implementing both interfaces
class Duck : IFlyable, ISwimmable
{
    // Implementing Fly method from IFlyable
    public void Fly()
    {
        Console.WriteLine("The duck can fly.");
    }

    // Implementing Swim method from ISwimmable
    public void Swim()
    {
        Console.WriteLine("The duck can swim.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Duck
        Duck duck = new Duck();

        // Calling both the Fly and Swim methods
        duck.Fly();
        duck.Swim();
    }
}
