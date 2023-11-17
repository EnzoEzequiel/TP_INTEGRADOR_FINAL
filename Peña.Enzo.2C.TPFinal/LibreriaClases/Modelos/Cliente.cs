using LibreriaClases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Entidades
{
    public class Cliente : Persona, IIdentificable
    {
        public string Email { get; set; }
        public List<Animal> Mascotas { get; set; }

        public Cliente()
        {
            Mascotas = new List<Animal>();
        }
    }
}
