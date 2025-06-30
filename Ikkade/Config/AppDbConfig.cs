using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ikkade.model;

namespace Ikkade.Config
{
    public class AppDbConfig: DbContext
    {
        public DbSet<model.Admin> Admins { get; set; }
        public DbSet<model.Biller> Biller { get; set; }
        public DbSet<model.Orders> Orders { get; set; }
        public DbSet<model.Items> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use your actual database connection string here
            optionsBuilder.UseMySql(
           "server=localhost;database=Ikkade;user=root;password=root;",
           new MySqlServerVersion(new Version(8, 0, 37)) // replace with your MySQL version
       );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity properties and relationships here if needed
            modelBuilder.Entity<model.Admin>().ToTable("Admins");
            modelBuilder.Entity<model.Biller>().ToTable("Billers");
            modelBuilder.Entity<model.Orders>().ToTable("Orders");
            modelBuilder.Entity<model.Items>().ToTable("Items");
            // Example: Configure primary key for Admin
            modelBuilder.Entity<model.Admin>().HasKey(a => a.Id);
            modelBuilder.Entity<model.Biller>().HasKey(b => b.Id);
            modelBuilder.Entity<model.Orders>().HasKey(o => o.OrderId);
            modelBuilder.Entity<model.Items>().HasKey(i => i.ItemId);

            // Add more configurations as needed
            modelBuilder.Entity<model.Orders>()
                .HasOne(o => o.Biller)
                .WithMany(b => b.Orders)
                .HasForeignKey(o => o.BillerId);
            modelBuilder.Entity<model.Items>()
                .HasOne(i => i.Order)
                .WithMany(o => o.items)
                .HasForeignKey(i => i.OrderId);

        }                       
    }
}
