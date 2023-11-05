using LibreriaClases.Interfaces;

namespace LibreriaClases.Entidades
{
    public class Persona : IIdentificable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public int ObtenerId()
        {
            return Id;
        }
    }

}