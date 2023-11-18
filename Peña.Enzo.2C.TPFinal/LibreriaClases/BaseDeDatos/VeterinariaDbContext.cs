using LibreriaClases.Entidades;
using LibreriaClases.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.DataBase
{
    public class VeterinariaDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Dueño> Dueños { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Veterinaria;Trusted_Connection=True;" +
                "TrustServerCertificate=Yes;");
        }
    }
}