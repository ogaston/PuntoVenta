using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PosSystem
{
    public partial class PrincipalForm : Form
    {
        public string OptenerID = Login.guardaID;
        public PrincipalForm()
        {
            InitializeComponent();
            UserAccess();
        }
        
        private void UserAccess()
        {
            if (Login.guardaRango == "Ventas")
            {
                almacenMenuItem.Visible = false;
                comprasMenuItem.Visible = false;
                mantenimientoMenuItem.Visible = false;

            }else if (Login.guardaRango =="Almacen")
            {
                comprasMenuItem.Visible = false;
                ventaMenuItem.Visible = false;
                mantenimientoMenuItem.Visible = false;

            }else if (Login.guardaRango =="Compras")
            {
                almacenMenuItem.Visible = false;
                ventaMenuItem.Visible = false;
                mantenimientoMenuItem.Visible = false;

            }else if(Login.guardaRango == "Empleado")
            {
                mantenimientoMenuItem.Visible = false;
            }
        }

        private void ReturnColor(string nameItem)
        {
            if (nameItem == "almacen")
            {
                ventaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                comprasMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                mantenimientoMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ayudaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                cerrarSesionMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                salirMenuItem.BackColor = Color.FromArgb(70, 179, 254);

            }
            else if(nameItem == "venta")
            {
                almacenMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                comprasMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                mantenimientoMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ayudaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                cerrarSesionMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                salirMenuItem.BackColor = Color.FromArgb(70, 179, 254);
            }
            else if (nameItem == "compras")
            {
                almacenMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ventaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                mantenimientoMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ayudaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                cerrarSesionMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                salirMenuItem.BackColor = Color.FromArgb(70, 179, 254);
            }
            else if (nameItem == "mantenimiento")
            {
                almacenMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ventaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                comprasMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ayudaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                cerrarSesionMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                salirMenuItem.BackColor = Color.FromArgb(70, 179, 254);
            }
            else if (nameItem =="ayuda")
            {
                almacenMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ventaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                comprasMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                mantenimientoMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                cerrarSesionMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                salirMenuItem.BackColor = Color.FromArgb(70, 179, 254);
            }
            else if (nameItem == "CerrarSesion")
            {
                almacenMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ventaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                comprasMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                mantenimientoMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ayudaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                salirMenuItem.BackColor = Color.FromArgb(70, 179, 254);
            }
            else if (nameItem == "salir")
            {
                almacenMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ventaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                comprasMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                mantenimientoMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ayudaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                cerrarSesionMenuItem.BackColor = Color.FromArgb(70, 179, 254);
            }
            else if(nameItem =="")
            {
                almacenMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ventaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                comprasMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                mantenimientoMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                ayudaMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                cerrarSesionMenuItem.BackColor = Color.FromArgb(70, 179, 254);
                salirMenuItem.BackColor = Color.FromArgb(70, 179, 254);
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea Salir?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnlogoInicio_Click(null,e);
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            
            ReturnColor("salir");
            if (MessageBox.Show("Esta Seguro que desea Salir?","Informacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void articuloMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ArticuloForm());
        }

        private void trabajadorMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TrabajadorForm());
        }

        private void almacenMenuItem_Click(object sender, EventArgs e)
        {
            almacenMenuItem.BackColor = Color.FromArgb(203, 215, 245);
            ReturnColor("almacen");

        }

        private void ventaMenuItem_Click(object sender, EventArgs e)
        {
            ventaMenuItem.BackColor = Color.FromArgb(203, 215, 245);
            ReturnColor("venta");
        }

        private void comprasMenuItem_Click(object sender, EventArgs e)
        {
            comprasMenuItem.BackColor = Color.FromArgb(203, 215, 245);
            ReturnColor("compras");
        }

        private void mantenimientoMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoMenuItem.BackColor = Color.FromArgb(203, 215, 245);
            ReturnColor("mantenimiento");
        }

        private void ayudaMenuItem_Click(object sender, EventArgs e)
        {
            ayudaMenuItem.BackColor = Color.FromArgb(203, 215, 245);
            ReturnColor("ayuda");
        }

        private void cerrarSesionMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSesionMenuItem.BackColor = Color.FromArgb(203, 215, 245);
            ReturnColor("CerrarSesion");
              this.Hide();
            Login abril = new Login();
            abril.ShowDialog();
        }


        private void panelContenedor_Click(object sender, EventArgs e)
        {
            ReturnColor("");
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            ReturnColor("");
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoForm frm = new IngresoForm();
            AbrirFormEnPanel(frm);
        }

        private void mantenimientoVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentasForm frm = new VentasForm();
            AbrirFormEnPanel(frm);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm frm = new ClienteForm();
            AbrirFormEnPanel(frm);
        }

        private void ProveedoresMenuItem_Click(object sender, EventArgs e)
        {
            ProveedoresForm frm = new ProveedoresForm();
            AbrirFormEnPanel(frm);
        }

        private void CategoriaMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaForm frm = new CategoriaForm();
            AbrirFormEnPanel(frm);
        }

        private void presentacionMenuItem_Click(object sender, EventArgs e)
        {
            PresentacionForm frm = new PresentacionForm();
            AbrirFormEnPanel(frm);

        }
    }
}
