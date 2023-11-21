
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
        int ExisteUsuarioPorCorreo(string correoElectronico, string contra);
    }

}