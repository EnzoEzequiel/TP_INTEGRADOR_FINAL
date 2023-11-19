using LibreriaClases.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LibreriaClases.Modelos
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}