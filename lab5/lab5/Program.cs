using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Ask the user to input the price
            Console.Write("Please enter the price: ");
            string input = Console.ReadLine();

            // Try to convert the input to a decimal (price)
            decimal price = Convert.ToDecimal(input);

            // If successful, print the price
            Console.WriteLine($"The price entered is: {price}");
        }
        catch (FormatException ex)
        {
            // Handle the exception if the input is not a valid decimal number
            Console.WriteLine("Error: You entered an invalid price. Please enter a numeric value.");
        }
        catch (Exception ex)
        {
            // Catch any other unexpected exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            // This block will run whether an exception occurs or not
            Console.WriteLine("Thank you for using the program.");
        }
    }
}
