using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Login : Form
    {
        public static string guardaRango { get; set; }
        public static string guardaID { get; set; }
        public static string guardaNombre { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           string[] validate = LoginBL.ValidatedUsuario(txtUsuario.Text, txtClave.Text);
            if (validate.Length > 0)
            {
                guardaRango = validate[0];
                guardaID = validate[1];
                this.Hide();
                PrincipalForm abril = new PrincipalForm();
                abril.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Clave de acceso Errada", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Text = "";
                txtUsuario.Focus();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    btnEntrar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex +" Error En Inicio");
            }      
        }
    }
}
