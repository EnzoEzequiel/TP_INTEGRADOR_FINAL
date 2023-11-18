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
                // Obtener el correo electrónico del formulario o de donde sea que esté almacenado
                string correoElectronico = ObtenerCorreoElectronicoDesdeFormulario(); // Ajusta según tu implementación

                IVeterinariaRepository repository = new VeterinariaRepository();

                // Realizar la consulta para verificar si el correo existe en la base de datos
                bool existeUsuario = repository.ExisteUsuarioPorCorreo(correoElectronico);

                if (existeUsuario)
                {
                    FrmCliente frmCliente = new FrmCliente();
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

        // Método ficticio para obtener el correo electrónico del formulario
        private string ObtenerCorreoElectronicoDesdeFormulario()
        {
            // Implementa según tu estructura de formulario
            return "correo@ejemplo.com";
        }

    }
}