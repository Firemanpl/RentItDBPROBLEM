using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI.Entities
{
    public class AppDbContext: DbContext
    {
        public DbSet <Business> Businesses { get; set; }
        public DbSet <Item> Items { get; set; }
        public DbSet <Stock> Stocks { get; set; }

        public DbSet <Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>()
             .Property(b => b.Name)
             .IsRequired()
             .HasMaxLength(50);
            modelBuilder.Entity<Item>()
             .Property(i => i.Name)
             .IsRequired()
             .HasMaxLength(30);
            modelBuilder.Entity<Item>()
             .Property(i => i.RequestRequired)
             .IsRequired();

            modelBuilder.Entity<User>()
             .Property(u => u.Email)
             .IsRequired();
            modelBuilder.Entity<Role>()
             .Property(r => r.Name)
             .IsRequired()
             .HasMaxLength(30);

            modelBuilder.Entity<Stock>()
             .Property(s => s.StockCount)
             .IsRequired();
            modelBuilder.Entity<Stock>()
             .Property(s => s.AmountAvailable)
             .IsRequired();
        }
    }
}
