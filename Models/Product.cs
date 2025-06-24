using System.ComponentModel.DataAnnotations;

namespace MUHAMMED_ZIA_DESAI.ST10051670.POE.Models
{
    public class Product    //Product model for all the details of the product being added
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Production date is required.")]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
        public string UserId { get; set; }
    }
}

//wadepickett (2024).
//Part 4, add a model to an ASP.NET Core MVC app.
//Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-9.0&tabs=visual-studio. (Accessed: 5 May 2025).‌