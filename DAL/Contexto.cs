using Microsoft.EntityFrameworkCore;
using RegistroPrestamo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/Prestamo.db");
        }
    }
}