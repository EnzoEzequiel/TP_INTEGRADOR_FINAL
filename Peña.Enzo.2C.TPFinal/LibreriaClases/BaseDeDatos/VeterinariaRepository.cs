using LibreriaClases.Entidades;
using LibreriaClases.Interfaces;
using LibreriaClases.Modelos;
using System.Collections.Generic;
using System.Linq;

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
        /// Agrega una nueva mascota a la base de datos.
        /// </summary>
        /// <param name="mascota">La mascota que se va a agregar.</param>
        public void AgregarMascota(Mascota mascota)
        {
            _contexto.Mascotas.Add(mascota);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Actualiza la información de una mascota en la base de datos.
        /// </summary>
        /// <param name="mascota">La mascota con la información actualizada.</param>
        public void ActualizarMascota(Mascota mascota)
        {
            var mascotaExistente = _contexto.Mascotas.Find(mascota.IdMascota);
            if (mascotaExistente != null)
            {
                
                mascotaExistente.nombreMascota = mascota.nombreMascota;
                mascotaExistente.fechaNacimiento = mascota.fechaNacimiento;
                mascotaExistente.altaMedica = false;

                _contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Elimina una mascota de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID de la mascota que se va a eliminar.</param>
        public void EliminarMascota(int id)
        {
            var mascota = _contexto.Mascotas.Find(id);
            if (mascota != null)
            {
                _contexto.Mascotas.Remove(mascota);
                _contexto.SaveChanges();
            }
            // Puedes considerar manejar el caso cuando la mascota no existe, dependiendo de tus requerimientos.
        }

        /// <summary>
        /// Obtiene una mascota de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID de la mascota que se va a obtener.</param>
        /// <returns>La mascota con el ID especificado.</returns>
        public Mascota ObtenerMascotaPorId(int id)
        {
            return _contexto.Mascotas.Find(id);
        }

        /// <summary>
        /// Obtiene todas las mascotas almacenadas en la base de datos.
        /// </summary>
        /// <returns>Una colección de todas las mascotas.</returns>
        public IEnumerable<Mascota> ObtenerTodasLasMascotas()
        {
            return _contexto.Mascotas.ToList();
        }

        /// <summary>
        /// Verifica si existe un usuario en la base de datos con el correo electrónico proporcionado.
        /// </summary>
        /// <param name="correoElectronico">El correo electrónico del usuario.</param>
        /// <returns>True si el usuario existe, False si no.</returns>
        public bool ExisteUsuarioPorCorreo(string correoElectronico)
        {
            return _contexto.Dueños.Any(u => u.Email == correoElectronico);
        }
    }
}