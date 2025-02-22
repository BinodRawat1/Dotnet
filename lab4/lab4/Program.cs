using System;
using System.Collections.Generic;
using System.Linq;

// Voter class with attributes
class Voter
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    // Constructor
    public Voter(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // List of voters
        List<Voter> voters = new List<Voter>
        {
            new Voter("Alisha", 20, "Patan"),
            new Voter("Bob", 17, "Kathmandu"),
            new Voter("Binod", 22, "Patan"),
            new Voter("David", 19, "Pokhara"),
            new Voter("Eve", 15, "Patan")
        };

        // LINQ query to filter voters who are greater than 18 and live in Patan
        var filteredVoters = from voter in voters
                             where voter.Age > 18 && voter.Address == "Patan"
                             select voter.Name;

        // Display the result
        Console.WriteLine("Voters over 18 and live in Patan:");
        foreach (var voter in filteredVoters)
        {
            Console.WriteLine(voter);
        }
    }
}
