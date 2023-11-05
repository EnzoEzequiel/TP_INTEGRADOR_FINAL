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
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
            this.Hide();
        }
    }
}
