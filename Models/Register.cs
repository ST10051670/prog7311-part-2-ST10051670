using System.ComponentModel.DataAnnotations;

namespace MUHAMMED_ZIA_DESAI.ST10051670.POE.Models
{
    public class Register   //Register model for all the information being entered when creating an account
    {
        [Required(ErrorMessage = "Full name is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "Only Gmail addresses are allowed.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[\W_]).{4,}$",
            ErrorMessage = "Password must be at least 4 characters long and include letters, numbers, and a special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm your password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        public string Role { get; set; }

        public string? PhoneNumber { get; set; }
        public string? Location { get; set; }
    }
}

//wadepickett (2024).
//Part 4, add a model to an ASP.NET Core MVC app.
//Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-9.0&tabs=visual-studio. (Accessed: 5 May 2025).‌
