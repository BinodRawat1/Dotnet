using System;
using System.Collections.Generic;

class Program
{
    // Dictionary to store users: Username → (Password, Role)
    static Dictionary<string, (string Password, string Role)> users = new Dictionary<string, (string, string)>
    {
        { "Binod", ("password123", "Admin") },
        { "user1", ("password1", "User") },
        { "user2", ("password2", "User") }
    };

    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (Authenticate(username, password, out string role))
        {
            Console.WriteLine($"Login successful! Welcome, {username}.");
            Authorize(role);
        }
        else
        {
            Console.WriteLine("Invalid credentials!");
        }
    }

    static bool Authenticate(string username, string password, out string role)
    {
        if (users.ContainsKey(username) && users[username].Password == password)
        {
            role = users[username].Role;
            return true;
        }
        role = null;
        return false;
    }

    static void Authorize(string role)
    {
        Console.WriteLine($"Your role: {role}");
        if (role == "Admin")
        {
            Console.WriteLine("Access granted to Admin panel.");
            Console.WriteLine("You can manage users and settings.");
        }
        else if (role == "User")
        {
            Console.WriteLine("Access granted to User dashboard.");
            Console.WriteLine("You can view content.");
        }
        else
        {
            Console.WriteLine("Access denied! Unknown role.");
        }
    }
}
