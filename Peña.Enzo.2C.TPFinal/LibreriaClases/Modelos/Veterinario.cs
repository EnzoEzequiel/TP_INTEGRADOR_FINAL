using LibreriaClases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Modelos
{
    public class Veterinario : Persona
    {
        public int IdVeterinario { get; set; }
        public string Especialidad { get; set; }
    }
}