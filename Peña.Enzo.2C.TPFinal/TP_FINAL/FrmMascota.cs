using LibreriaClases;
using LibreriaClases.Entidades;
using LibreriaClases.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FINAL
{
    public partial class FrmMascota : Form
    {
        public FrmMascota()
        {
            InitializeComponent();
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            IVeterinariaRepository repository = new VeterinariaRepository();

            // Ejemplo de agregar un nuevo animal
            Animal nuevoAnimal = new Animal { Nombre = "Firulais", Especie = "Perro", FechaNacimiento = DateTime.Now };
            repository.AgregarAnimal(nuevoAnimal);

            Animal nuevaMascota = new Animal
            {
                //Nombre = txtNombreMascota.Text,
                //Especie = txtEspecie.Text,

            };

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            //txtNombreMascota.Clear();
            //txtEspecie.Clear();
        }
    }
}
