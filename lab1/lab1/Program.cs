using System;
class Polygon
{
    // method to render a shape
    public virtual void render()
    {
        Console.WriteLine("Displaying Polygon...");
    }
}

class Square : Polygon
{
    // overriding render() method 
    public override void render()
    {
        Console.WriteLine("Displaying Square...");
    }
}
class myProgram
{
    public static void Main()
    {
        // obj1 is the object of Polygon class
        Polygon obj1 = new Polygon();

        // calls render() method of Polygon Superclass 
        obj1.render();

        // here, obj1 is the object of derived class Square 
        obj1 = new Square();

        // calls render() method of derived class Square
        obj1.render();
    }
}