using LibreriaClases.Entidades;
using LibreriaClases.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Interfaces
{
    public interface IVeterinariaRepository
    {
        void AgregarMascota(Mascota mascota);

        void ActualizarMascota(Mascota mascota);

        void EliminarMascota(int id);

        Mascota ObtenerMascotaPorId(int id);

        IEnumerable<Mascota> ObtenerTodasLasMascotas();

        bool ExisteUsuarioPorCorreo(string correoElectronico);
    }

}