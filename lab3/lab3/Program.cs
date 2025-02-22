using System;
using System.Collections.Generic;
using System.Linq;

// Student class with attributes
class Student
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    // Constructor
    public Student(int id, int departmentId, string name, string address)
    {
        Id = id;
        DepartmentId = departmentId;
        Name = name;
        Address = address;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // List of students
        List<Student> students = new List<Student>
        {
            new Student(1, 101, "Alice", "Kathmandu"),
            new Student(2, 102, "Rahul", "Pokhara"),
            new Student(3, 101, "Charlie", "789 Street C"),
            new Student(4, 103, "David", "321 Street D"),
            new Student(5, 102, "Anu", "Dhangadhi")
        };

        // DepartmentId to filter by
        int departmentIdToFilter = 102;

        // Using lambda expression to filter students by DepartmentId
        var filteredStudents = students.Where(s => s.DepartmentId == departmentIdToFilter).ToList();

        // Display filtered list
        Console.WriteLine($"Students in Department {departmentIdToFilter}:");
        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Address: {student.Address}");
        }
    }
}
