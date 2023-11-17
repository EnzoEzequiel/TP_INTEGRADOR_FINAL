using LibreriaClases.Entidades;
using LibreriaClases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.DataBase
{
    /// <summary>
    /// Clase que implementa la interfaz IVeterinariaRepository y maneja las operaciones de base de datos.
    /// </summary>
    public class VeterinariaRepository : IVeterinariaRepository
    {
        private VeterinariaDbContext _contexto;

        /// <summary>
        /// Constructor que inicializa el contexto de la base de datos.
        /// </summary>
        public VeterinariaRepository()
        {
            _contexto = new VeterinariaDbContext();
        }

        /// <summary>
        /// Agrega un nuevo animal a la base de datos.
        /// </summary>
        /// <param name="animal">El animal que se va a agregar.</param>
        public void AgregarAnimal(Animal animal)
        {
            _contexto.Animales.Add(animal);
            _contexto.SaveChanges();
        }

    }

}
