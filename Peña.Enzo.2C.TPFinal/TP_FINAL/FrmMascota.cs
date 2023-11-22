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
        private FrmCliente frmCliente;

        // Declaración del evento utilizando EventHandler
        public event EventHandler MascotaAgregada;

        public FrmMascota(int idUsuario, FrmCliente frmCliente)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.frmCliente = frmCliente;
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
                Random random = new Random();
                string nombre = txtBoxNombreMascotaNueva.Text;
                string especie = txtBoxEspecieMascotaNueva.Text;
                DateTime fNacimiento = dateTimePicker1.Value;
                bool altaMedica = false;
                bool vacunasAplicadas = false;
                bool estadoEnfermo = true;
                //ya que no tengo el tiempo para generar una logica especifica para asignar un doctor dependiendo el tipo de enfermedad
                //prefiero simplemente asignarle uno de los dos veterinarios y listo
                int idVeterinario = random.Next(1, 3);

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(especie) || fNacimiento == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GestorSQL gestorSQL = new GestorSQL();
                int idDueño = gestorSQL.ObtenerDueñoByIdPersona(idUsuario);

                if (idDueño == 0)
                {
                    long numeroAleatorioLong = random.Next(1000000000, int.MaxValue) * 1000000000L + random.Next(1000000000);
                    string numeroAleatorio = numeroAleatorioLong.ToString();
                    string queryInsertarDueño = $"INSERT INTO Dueños (Telefono, IdPersona) VALUES ('{numeroAleatorio}', '{idUsuario}')";
                    gestorSQL.EjecutarQuery(queryInsertarDueño, command => command.ExecuteNonQuery());
                    idDueño = gestorSQL.ObtenerDueñoByIdPersona(idUsuario);
                }

                string queryInsertUsuario = $"INSERT INTO Mascotas (Nombre, Especie, FechaNacimiento, IdDueño, AltaMedica, VacunasAplicadas, EstadoEnfermo , IdVeterinario) VALUES ('{nombre}', '{especie}', '{fNacimiento.ToString("yyyy-MM-dd")}', '{idDueño}', '{altaMedica}', '{vacunasAplicadas}', '{estadoEnfermo}', '{idVeterinario}')";

                gestorSQL.EjecutarQuery(queryInsertUsuario, command => command.ExecuteNonQuery());

                MessageBox.Show("Mascota agregada correctamente con veterinario asignado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmCliente.actualizarListaMascotas();

                // Lanzamiento del evento al agregar la mascota
                OnMascotaAgregada(EventArgs.Empty);

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

        // Método protegido para lanzar el evento MascotaAgregada
        protected virtual void OnMascotaAgregada(EventArgs e)
        {
            MascotaAgregada?.Invoke(this, e);
        }
    }
}
