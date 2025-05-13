using MUHAMMED_ZIA_DESAI.ST10051670.POE.Data;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Models;
using Microsoft.EntityFrameworkCore;

namespace MUHAMMED_ZIA_DESAI.ST10051670.POE.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetProductsByUserId(string userId)
        {
            return _context.Products
                           .Where(p => p.UserId == userId)
                           .ToList();
        }

        public void AddProduct(Product product, string userId)
        {
            product.UserId = userId; 
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
