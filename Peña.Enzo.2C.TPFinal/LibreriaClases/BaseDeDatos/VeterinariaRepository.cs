using LibreriaClases.Interfaces;
using LibreriaClases.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;

namespace LibreriaClases.DataBase
{
    public class VeterinariaRepository : IVeterinariaRepository
    {
        private readonly GestorSQL _gestorSQL;

        public VeterinariaRepository(GestorSQL gestorSQL)
        {
            _gestorSQL = gestorSQL;
        }

        public void ActualizarMascota(Mascota mascota)
        {
             _gestorSQL.EjecutarQuery("UPDATE Mascotas SET nombreMascota = ..., fechaNacimiento = ..., altaMedica = ... WHERE IdMascota = ...");
        }

        public void EliminarMascota(int id)
        {
            _gestorSQL.EjecutarQuery("DELETE FROM Mascotas WHERE IdMascota = ...");
        }

        public Mascota ObtenerPorId(string nombreTabla, int id)
        {
            
            return _gestorSQL.ObtenerElementoPorId<Mascota>(nombreTabla,id);
        }

        public IEnumerable<Mascota> ObtenerTodasLasMascotas()
        {
            _gestorSQL.ObtenerTodos<Mascota>();
            return Enumerable.Empty<Mascota>(); // Reemplazar con la lógica real
        }

        public int ExisteUsuarioPorCorreo(string correoElectronico, string contra)
        {
            return _gestorSQL.ExisteUsuarioPorCorreo(correoElectronico, contra);
        }

        public bool ExisteMascotaPorNombreYNacimiento(string nombre, string fNacimiento)
        {
            return _gestorSQL.ExisteMascotaPorNombreYNacimiento(nombre, fNacimiento);
        }
    }
}
