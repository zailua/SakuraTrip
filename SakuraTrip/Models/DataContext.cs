
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakuraTrip.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Destino> Viagem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=SakuraTripBD;Integrated Security=True");
        }
    }
}