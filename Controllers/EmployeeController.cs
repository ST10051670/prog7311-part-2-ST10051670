using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Data;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MUHAMMED_ZIA_DESAI.ST10051670.POE.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexFarmer()      //Listing all the farmers
        {
            var farmers = await _context.Users
                .Where(r => r.Role == "Farmer")
                .Select(r => new
                {
                    r.UserId,
                    r.FullName,
                    r.Email,
                })
                .ToListAsync();

            return View(farmers);
        }

        public IActionResult AddFarmer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddFarmer(Register model)  //Page to add a farmer
        {
            if (ModelState.IsValid)
            {
                model.Role = "Farmer";

                var farmer = new User
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Password = model.Password,
                    Role = model.Role,
                    PhoneNumber = model.PhoneNumber,
                    Location = model.Location
                };

                _context.Users.Add(farmer);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexFarmer", "Employee");
            }

            return View(model);
        }

        public async Task<IActionResult> IndexProduct(string category, DateTime? startDate, DateTime? endDate)
        {
            var productsQuery = _context.Products.AsQueryable();            //Searching the database 

            if (!string.IsNullOrEmpty(category))
            {
                productsQuery = productsQuery.Where(p => p.Category.Contains(category));
            }

            if (startDate.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.ProductionDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.ProductionDate <= endDate.Value);
            }

            var products = await productsQuery.ToListAsync();
            return View(products);
        }
    }
}
