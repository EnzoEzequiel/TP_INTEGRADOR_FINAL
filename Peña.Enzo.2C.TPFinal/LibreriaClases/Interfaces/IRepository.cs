using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T ObtenerPorId(int id);
        IEnumerable<T> ObtenerTodos();
        void Insertar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
    }

}