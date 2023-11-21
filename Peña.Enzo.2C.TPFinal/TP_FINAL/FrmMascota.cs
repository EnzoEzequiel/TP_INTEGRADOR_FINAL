using LibreriaClases;
using LibreriaClases.DataBase;
using LibreriaClases.Interfaces;
using LibreriaClases.Modelos;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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
        private int idUsuario;
        public event EventHandler MascotaAgregada;
        private FrmCliente frmCliente;
        public FrmMascota(int idUsuario, FrmCliente frmCliente)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.frmCliente=frmCliente;
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
                string nombre = txtBoxNombreMascotaNueva.Text;
                string especie = txtBoxEspecieMascotaNueva.Text;
                DateTime fNacimiento = dateTimePicker1.Value;
                bool altaMedica = false;
                bool vacunasAplicadas = false;

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(especie) || fNacimiento==null)
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GestorSQL gestorSQL = new GestorSQL();
                int idDueño = gestorSQL.ObtenerDueñoByIdPersona(idUsuario);

                string queryInsertUsuario = $"INSERT INTO Mascotas (Nombre, Especie, FechaNacimiento, IdDueño, AltaMedica, VacunasAplicadas) " +
                            $"VALUES ('{nombre}', '{especie}', '{fNacimiento.ToString("yyyy-MM-dd")}', '{idDueño}', '{altaMedica}', '{vacunasAplicadas}')";

                gestorSQL.EjecutarQuery(queryInsertUsuario);

                MessageBox.Show("Mascota agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmCliente.actualizarListaMascotas();

                this.Close();
                
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
