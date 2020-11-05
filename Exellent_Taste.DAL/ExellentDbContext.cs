using Exellent_Taste.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Exellent_Taste.DAL
{
    public class ExellentDbContext : DbContext
    {

        public ExellentDbContext(DbContextOptions<ExellentDbContext> options) : base(options) { }

        public DbSet<Gebruikers> Gebruikers { get; set; }
        public DbSet<Reseveringen> Reseveringen { get; set; }
        public DbSet<BlackList> BlackList { get; set; }
        public DbSet<Bestellingen> Bestellingen { get; set; }
        public DbSet<Bestellingen_Lijst> Bestellingen_Lijst { get; set; }
        public DbSet<Menukaart> Menukaart { get; set; }
        public DbSet<Menusoort> Menusoort { get; set; }
        public DbSet<Adress> Adress { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Menusoort>()
                        .HasOne(o => o.menusoort);


            modelBuilder.Entity<Menukaart>()
                        .HasOne(o => o.menusoort).WithMany(m => m.Menukaarts)
                        .HasForeignKey(fk => fk.MenuSoort_id)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Bestellingen_Lijst>()
                        .HasOne(o => o.menukaart).WithMany(m => m.Bestellingen_Lijst)
                        .HasForeignKey(fk => fk.MenuKaart_Id)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Bestellingen_Lijst>()
                        .HasOne(o => o.bestellingen).WithMany(m => m.Bestellingen_Lijst)
                        .HasForeignKey(fk => fk.Bestelling_Id)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reseveringen>()
                        .HasOne(o => o.Bestellingen).WithMany(m => m.Reseveringen)
                        .HasForeignKey(fk => fk.Bestelling_id)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reseveringen>()
                        .HasOne(o => o.Adress).WithMany(m => m.Reseveringen)
                        .HasForeignKey(fk => fk.Adress_id)
                        .OnDelete(DeleteBehavior.Cascade);


            //modelBuilder.Entity<Menukaart>().HasOne(b => b.menusoort).WithOne(o => o.)
            //modelBuilder.Entity<Menusoort>().HasMany(a => a.Menusoorts).WithOne(m => m.menusoort).HasForeignKey(fk => fk.MenuSoort_id);

            //modelBuilder.Entity<Bestellingen>().HasMany(ms => ms.Bestellingen_Lijst).WithOne(w => w.bestellingen).HasForeignKey(fk => fk.Bestelling_Id);
            //modelBuilder.Entity<Bestellingen_Lijst>().HasOne(b => b.bestellingen).WithMany();

            //modelBuilder.Entity<Bestellingen_Lijst>().HasOne(b => b.menukaart);
            //modelBuilder.Entity<Menukaart>().HasMany(a => a.Bestellingen_Lijst).WithOne(b => b.menukaart).HasForeignKey(fk => fk.MenuKaart_Id);

            //modelBuilder.Entity<BlackList>().HasOne(b => b.reseveringen);
            //modelBuilder.Entity<Reseveringen>().HasOne(b => b.Bestellingen);

            //base.OnModelCreating(modelBuilder);


        }

        //public override int SaveChanges()
        //{
        //    AddAuitInfo();
        //    return base.SaveChanges();
        //}

        ////public async Task SaveChangesAsync()
        ////{
        ////    AddAuitInfo();
        ////    return await base.SaveChangesAsync();
        ////}

        //private void AddAuitInfo()
        //{
        //    var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseModel && (x.State == EntityState.Added || x.State == EntityState.Modified));
        //    foreach (var entry in entries)
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            ((BaseModel)entry.Entity).Created_Datum = DateTime.UtcNow;
        //        }
        //    ((BaseModel)entry.Entity).Updated_Datum = DateTime.UtcNow;
        //    }
        //}
    }
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ExellentDbContext>
    {
        public ExellentDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../Exellent_Taste.WEB/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<ExellentDbContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new ExellentDbContext(builder.Options);
        }
    }
}
