using LibreriaClases;
using LibreriaClases.Entidades;
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
