using Microsoft.EntityFrameworkCore;
using RentACar.DataAccess.Concrete.Mapping;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=RentACarDb; Integrated Security = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new BrandMap());
            modelBuilder.ApplyConfiguration(new CarMap());
            modelBuilder.ApplyConfiguration(new ColorMap());
            modelBuilder.ApplyConfiguration(new RentalMap());
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
