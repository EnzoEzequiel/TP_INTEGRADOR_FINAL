using LibreriaClases;
using LibreriaClases.DataBase;
using LibreriaClases.Entidades;
using LibreriaClases.Interfaces;
using LibreriaClases.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            try
            {
                IVeterinariaRepository repository = new VeterinariaRepository();
               
                Mascota nuevaMascota = new Mascota
                {
                    nombreMascota = txtBoxNombreMascotaNueva.Text,
                    altaMedica = false,  
                    fechaNacimiento = dateTimePicker1.Value  
                };

               
                repository.AgregarMascota(nuevaMascota);

              
                MessageBox.Show("Mascota agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la mascota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtBoxNombreMascotaNueva.Clear();
            dateTimePicker1.Value = DateTime.Now;  
        }

        private void btnCancelarAgregarMascota_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
            this.Hide();
        }
    }
}
