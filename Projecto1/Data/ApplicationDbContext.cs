using Microsoft.EntityFrameworkCore;
using Projecto1.Models;


namespace Projecto1.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {      
        }

        // ADD MODELS
       public DbSet<Contact> Contacts { get; set; }
       public DbSet<Product> Products { get; set; }


    }
}
