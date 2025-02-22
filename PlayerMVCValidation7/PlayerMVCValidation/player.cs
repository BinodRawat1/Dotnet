using System;
using System.ComponentModel.DataAnnotations;

public class Player
{
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [Range(18, 40, ErrorMessage = "Age must be between 18 and 40.")]
    public int Age { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    public Player(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }

    // Method to validate the model
    public bool IsValid(out string errorMessage)
    {
        var validationResults = new System.Collections.Generic.List<ValidationResult>();
        var context = new ValidationContext(this, null, null);
        bool isValid = Validator.TryValidateObject(this, context, validationResults, true);

        if (!isValid)
        {
            errorMessage = string.Join("\n", validationResults.ConvertAll(e => e.ErrorMessage));
            return false;
        }

        errorMessage = string.Empty;
        return true;
    }
}


