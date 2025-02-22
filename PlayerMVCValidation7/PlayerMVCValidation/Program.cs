using System;

class Program
{
    static void Main()
    {
        PlayerController controller = new PlayerController();

        Console.WriteLine("Enter Player Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Age:");
        // It's a good idea to validate user input to avoid exceptions.
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Invalid input for Age. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine();

        string result = controller.SavePlayer(name, age, email);
        Console.WriteLine(result);
    }
}
