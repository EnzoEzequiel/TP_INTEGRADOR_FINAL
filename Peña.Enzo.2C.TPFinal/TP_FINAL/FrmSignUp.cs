using LibreriaClases.DataBase;
using LibreriaClases.Interfaces;

namespace TP_FINAL
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBoxNombreNuevo.Text;
                string correo = txtBoxMailNuevo.Text;
                string telefono = txtBoxTelefonoNuevo.Text;
                string contra = txtBoxContraNueva.Text;
                string dire = txtBoxDireccion.Text;

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(contra)|| string.IsNullOrEmpty(dire))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GestorSQL gestorSQL = new GestorSQL();
                IVeterinariaRepository repository = new VeterinariaRepository(gestorSQL);


                int existeUsuario = repository.ExisteUsuarioPorCorreo(correo, contra);

                if (existeUsuario != 0)
                {
                    MessageBox.Show("Ya existe un usuario con este correo electrónico.", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string queryInsertUsuario = $"INSERT INTO Personas (Nombre, Email, Direccion, Contraseña) VALUES ('{nombre}', '{correo}', '{dire}', '{contra}')";

                    gestorSQL.EjecutarQuery(queryInsertUsuario, command => command.ExecuteNonQuery());

                    MessageBox.Show("Usuario agregado correctamente.", "Usuario Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarUsuarioNuevo_Click(object sender, EventArgs e)
        {
            txtBoxNombreNuevo.Text=string.Empty;
            txtBoxMailNuevo.Text=string.Empty;
            txtBoxTelefonoNuevo.Text=string.Empty;
            txtBoxContraNueva.Text=string.Empty;
            txtBoxDireccion.Text=string.Empty;
        }
    }

}