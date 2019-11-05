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
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea Salir?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           bool validate = LoginBL.ValidatedUsuario(txtUsuario.Text, txtClave.Text);
            if (validate)
            {
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
