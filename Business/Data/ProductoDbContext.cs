using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain.Data
{
    public class ProductoDbContext : DbContext
    {
        public ProductoDbContext()
        : base("DefaultConnection") 
        {
        }
        public DbSet<Producto> Producto{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}