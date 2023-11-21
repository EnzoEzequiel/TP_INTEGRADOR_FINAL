
using LibreriaClases.DataBase;
using LibreriaClases.Excepciones;
using LibreriaClases.Interfaces;
using LibreriaClases.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP_FINAL
{
    public partial class FrmCliente : Form
    {
        private List<Mascota> mascotas = new List<Mascota>();
        private int idUsuario;
        public GestorSQL gestorSQL = new GestorSQL();

        public FrmCliente(int idUsuario)
        {
            InitializeComponent();
            this.Load += FrmCliente_Load;
            this.idUsuario = idUsuario;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            lblNombreCliente.Text = gestorSQL.ObtenerNombrePorId(idUsuario).ToUpper()+"!!!";
            //Para aplicar el uso de hilos y evitar bloquear la interfaz de usuario
            //mientras se cargan las mascotas desde la base de datos

            actualizarListaMascotas();
        }


        private async Task CargarMascotasAsync()
        {
            try
            {
                await Task.Run(() =>
                {
                    int idDueño = gestorSQL.ObtenerDueñoByIdPersona(idUsuario);
                    mascotas = gestorSQL.ObtenerMascotasByIdPersona(idDueño).ToList();
                });
            }
            catch (BaseDeDatosException ex)
            {
                MessageBox.Show($"Error al cargar mascotas desde la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Mascota mascotaSeleccionada)
            {
                bool calendarioVacunas = mascotaSeleccionada.estadoCalendario;
                bool enfermo = mascotaSeleccionada.estadoEnfermo;
                bool altaMedica = mascotaSeleccionada.altaMedica;

                lblCalendario.Text = $"Calendario de vacunas: {(calendarioVacunas ? "Completo" : "Incompleto")}";
                lblEnfermo.Text = $"Estado de salud: {(enfermo ? "Enfermo" : "Sano")}";
                lblAlta.Text = $"Estado de alta médica: {(altaMedica ? "Dado de alta" : "No dado de alta")}";
            }
        }
        private void RellenarComboBoxMascotas()
        {
            if (mascotas.Any())
            {
                comboBox1.DataSource = mascotas;
                comboBox1.DisplayMember = "nombreMascota";
                comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            }
        }

        public async void actualizarListaMascotas()
        {
            await CargarMascotasAsync();
            RellenarComboBoxMascotas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMascota frmMascota = new FrmMascota(idUsuario, this);
            frmMascota.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
            saveFileDialog.Title = "Guardar archivo XML";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Mascota>));
                using (TextWriter writer = new StreamWriter(rutaArchivo))
                {
                    //SERIALIZACION XML PARA GUARDAR EL OBJETO
                    serializer.Serialize(writer, mascotas);
                }

                MessageBox.Show("Archivo XML guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
