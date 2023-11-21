using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Modelos
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public string nombreMascota { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool altaMedica { get; set; }
        public bool estadoCalendario { get; set; }
        public bool estadoEnfermo { get; set; }
        public int idVeterinario { get; set; }
    }
}
