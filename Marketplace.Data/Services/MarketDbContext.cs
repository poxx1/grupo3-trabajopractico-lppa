using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Marketplace.Entities.Models;

namespace Marketplace.Data.Services
{
    public class MarketDbContext : DbContext
    {
        // crea todos los dbcontext de las entidades para guardar en bbdd
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<OrderedProduct> OrderedProducts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<LogInModel> LogIn { get; set; }
        public MarketDbContext(): base("DefaultConnection")
        {
        }

        // EntityFramework pluraliza las entidades cuando trabaja con las tablas
        // Para sobreescribir las convenciones con el mismo nombre que utilizo en mi modelo hago:
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
