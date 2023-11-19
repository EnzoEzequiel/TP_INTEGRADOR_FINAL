using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Modelos
{
    public class Veterinario : Persona
    {
        public string Especialidad { get; set; }
    }
}