using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CqrsMediatR.Domain;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediatR.Data.ORM.EntityFramework
{
    public class DataContext:DbContext
    {


        public DataContext()
        {
            
        }


        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Customer> Customer { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
                .HasData(
                    new Customer { Id = 1, FirstName = "Jia", LastName = "Anu" },
                    new Customer { Id = 2, FirstName = "Naina", LastName = "Anu" },
                    new Customer { Id = 3, FirstName = "Sreena", LastName = "Anu" },
                    new Customer { Id = 4, FirstName = "Anu", LastName = "Viswan" }
                );
        }

    }
}
