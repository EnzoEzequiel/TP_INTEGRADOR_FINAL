using LibreriaClases;
using LibreriaClases.DataBase;
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

        private void LimpiarCampos()
        {
            txtBoxNombreMascotaNueva.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtBoxEspecieMascotaNueva.Clear();
        }

        private void btnCancelarAgregarMascota_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarMascotaNueva_Click(object sender, EventArgs e)
        {
            try
            {
                GestorSQL gestorSQL = new GestorSQL();
                IVeterinariaRepository repository = new VeterinariaRepository(gestorSQL);

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

        private void btnLimpiarCamposMascota_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
