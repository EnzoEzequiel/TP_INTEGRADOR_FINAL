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

        public int ExisteUsuarioPorCorreo(string correoElectronico, string contra)
        {
            return _gestorSQL.ExisteUsuarioPorCorreo(correoElectronico, contra);
        }
    }
}
