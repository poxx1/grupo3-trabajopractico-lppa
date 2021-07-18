using Business.Models;
using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain.Data
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext()
        : base("DefaultConnection") 
        {
        }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}