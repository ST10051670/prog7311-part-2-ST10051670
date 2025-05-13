using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Models;

namespace MUHAMMED_ZIA_DESAI.ST10051670.POE.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
   
        public DbSet<Product> Products { get; set; }

    }
}
