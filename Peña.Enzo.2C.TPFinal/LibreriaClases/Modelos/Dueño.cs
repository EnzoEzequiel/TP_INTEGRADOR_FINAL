
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Modelos
{
    public class Dueño : Persona
    {
        public string Telefono { get; set; }
        public int IdPersona { get; set; }
    }
}