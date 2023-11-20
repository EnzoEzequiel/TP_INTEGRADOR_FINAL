
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

        public FrmCliente(int idUsuario)
        {
            InitializeComponent();
            this.Load += FrmCliente_Load;
            this.idUsuario = idUsuario;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            GestorSQL gestorSQL = new GestorSQL();
            lblNombreCliente.Text = gestorSQL.ObtenerNombrePorId(idUsuario).ToUpper()+"!!!";

            CargarMascotasDesdeBaseDeDatos();

            RellenarComboBoxMascotas();

        }

        private void CargarMascotasDesdeBaseDeDatos()
        {
            try
            {
                GestorSQL gestorSQL = new GestorSQL();
                int idDueño = gestorSQL.ObtenerDueñoByIdPersona(idUsuario);
                mascotas = gestorSQL.ObtenerMascotasByIdPersona(idDueño).ToList();
            }
            catch (BaseDeDatosException ex)
            {
                MessageBox.Show($"Error al cargar mascotas desde la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RellenarComboBoxMascotas()
        {
            if (mascotas.Any())
            {
                comboBox1.DataSource = mascotas;
                comboBox1.DisplayMember = "nombreMascota";
            }
        }


        private bool GenerarDatoAleatorio()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Mascota>));
            using (TextWriter writer = new StreamWriter("Mascotas.xml"))
            {
                serializer.Serialize(writer, mascotas);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMascota frmMascota = new FrmMascota();
            frmMascota.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
