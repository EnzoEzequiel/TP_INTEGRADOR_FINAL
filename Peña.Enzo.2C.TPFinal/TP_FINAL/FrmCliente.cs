using LibreriaClases.Entidades;
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
        private List<Animal> mascotas = new List<Animal>();
        private string connectionString = "";

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarMascotasDesdeBaseDeDatos();

            RellenarComboBoxMascotas();

            //lblEstadoEnfermedad.Text = GenerarDatoAleatorio().ToString();
            //lblEstadoDeAlta.Text = GenerarDatoAleatorio().ToString();
        }

        private void CargarMascotasDesdeBaseDeDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        private void RellenarComboBoxMascotas()
        {
            //comboBoxMascotas.DataSource = mascotas;
            //comboBoxMascotas.DisplayMember = "Nombre"; 
        }

        private bool GenerarDatoAleatorio()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>));
            using (TextWriter writer = new StreamWriter("Mascotas.xml"))
            {
                serializer.Serialize(writer, mascotas);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMascota frmMascota = new FrmMascota();
            frmMascota.Show();
            this.Hide();
        }
    }
}
