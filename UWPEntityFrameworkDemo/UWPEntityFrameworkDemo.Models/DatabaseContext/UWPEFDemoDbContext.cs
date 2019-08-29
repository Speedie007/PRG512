using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UWPEntityFrameworkDemo.Models.DataModels;

namespace UWPEntityFrameworkDemo.Models.DatabaseContext
{
    public class UWPEFDemoDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server=localhost;Database=UWPDatabaseDemo;user id=sa;pwd=Password!;"
            optionsBuilder.UseSqlServer("Server=localhost;Database=UWPDatabaseDemo;user id=sa;pwd=Password!;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
