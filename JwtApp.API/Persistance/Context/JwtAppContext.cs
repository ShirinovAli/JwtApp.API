using JwtApp.API.Core.Domain;
using JwtApp.API.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace JwtApp.API.Persistance.Context
{
    public class JwtAppContext : DbContext
    {
        public JwtAppContext(DbContextOptions<JwtAppContext> options) : base(options)
        {

        }
        public DbSet<AppRole> AppRoles => this.Set<AppRole>();
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<Product> Products => this.Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
