using LibreriaClases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Modelos
{
    public class Dueño : Persona
    {
        public int IdDueño { get; set; }
        public string Telefono { get; set; }
        public int IdPersona { get; set; }
    }
}