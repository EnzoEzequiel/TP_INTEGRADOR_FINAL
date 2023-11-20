
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
        void ActualizarMascota(Mascota mascota);

        void EliminarMascota(int id);

        //ObtenerPorId(string nombre,int id);

        IEnumerable<Mascota> ObtenerTodasLasMascotas();

        int ExisteUsuarioPorCorreo(string correoElectronico, string contra);
    }

}