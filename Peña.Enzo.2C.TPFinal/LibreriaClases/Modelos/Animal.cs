using LibreriaClases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Entidades
{

    public class Animal : IIdentificable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int ObtenerId()
        {
            return Id;
        }
    }
}
