using LibreriaClases.Entidades;
using System;
using System.Collections.Generic;
using System.Data.EntityFrameWork;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.DataBase
{
    public class VeterinariaDbContext : DbContext
    {
        public DbSet<Animal> Animales { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
       
        public VeterinariaDbContext() : base("NombreDeTuConexion")
        {
        }
    }
}
