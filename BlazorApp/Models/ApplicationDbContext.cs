using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Server=JOY\\MSSQLSERVER01;Database=BlazorAppDb;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Product> products { get; set; }
    }
}
