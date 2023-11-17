using LibreriaClases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Interfaces
{
    public interface IVeterinariaRepository
    {
        /// <summary>
        /// Agrega un nuevo animal a la base de datos.
        /// </summary>
        /// <param name="animal">El animal que se va a agregar.</param>
        void AgregarAnimal(Animal animal);

        /// <summary>
        /// Actualiza la información de un animal en la base de datos.
        /// </summary>
        /// <param name="animal">El animal con la información actualizada.</param>
        void ActualizarAnimal(Animal animal);

        /// <summary>
        /// Elimina un animal de la base de datos según su ID.
        /// </summary>
        /// <param name="id">El ID del animal a eliminar.</param>
        void EliminarAnimal(int id);

        /// <summary>
        /// Obtiene un animal de la base de datos según su ID.
        /// </summary>
        /// <param name="id">El ID del animal a obtener.</param>
        /// <returns>El animal correspondiente al ID proporcionado.</returns>
        Animal ObtenerAnimalPorId(int id);

    }

}
