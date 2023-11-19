using LibreriaClases.DataBase;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnUsuarioNuevo_Click(object sender, EventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.Show();
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string correoElectronico = txtBoxMail.Text;
                string contra = txtBoxContra.Text;
                GestorSQL gestorSQL = new GestorSQL();
                IVeterinariaRepository repository = new VeterinariaRepository(gestorSQL);

                int idUsuario = repository.ExisteUsuarioPorCorreo(correoElectronico, contra);

                if (idUsuario != 0)
                {
                    FrmCliente frmCliente = new FrmCliente(idUsuario);
                    frmCliente.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario no está registrado en la base de datos.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}