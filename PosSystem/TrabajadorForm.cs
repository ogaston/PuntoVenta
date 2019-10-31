using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BusinessLogic;

namespace PosSystem
{
    public partial class TrabajadorForm : Form
    {
        private static TrabajadorForm trabajadorForm = null;
        private int ID;
        public static TrabajadorForm Instance()
        {
            if (((trabajadorForm == null)
                        || (trabajadorForm.IsDisposed == true)))
            {
                trabajadorForm = new TrabajadorForm();
            }
            trabajadorForm.BringToFront();
            return trabajadorForm;
        }
        public TrabajadorForm()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        public bool Validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && 
                !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                 !string.IsNullOrWhiteSpace(txtApellido.Text)&&
                  !string.IsNullOrWhiteSpace(txtCargo.Text)&&
                   !string.IsNullOrWhiteSpace(txtDocumento.Text)&&
                    !string.IsNullOrWhiteSpace(txtEmail.Text)&&
                     !string.IsNullOrWhiteSpace(txtSalario.Text)&&
                      !string.IsNullOrWhiteSpace(txtTelefono.Text)&&
                       !string.IsNullOrWhiteSpace(cbSexo.Text))
            {
                valor = true;
            }
            return valor;
        }

        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }
            txtSalario.Text = "";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Trabajador nuevo = new Trabajador();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.Sexo = cbSexo.Text;
                nuevo.Fecha_Nacimiento = dateTimeNacimiento.Value;
                nuevo.Cedula = txtDocumento.Text;
                nuevo.Direccion = txtDireccion.Text;
                nuevo.Telefono = double.Parse(txtTelefono.Text);
                nuevo.Email = txtEmail.Text;
                nuevo.Salario = double.Parse(txtSalario.Text);
                nuevo.Usuario = txtUsuario.Text;
                nuevo.Password = txtPaswword.Text;
                nuevo.Cargo = txtCargo.Text;
                TrabajadorBL.InsertTrabajador(nuevo);
                dataGridView1.Update();
                llenarGrid();
                MessageBox.Show("Trabajador Agregado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar(txtNombre, txtApellido, txtDocumento, txtDireccion, txtTelefono, txtEmail, txtUsuario, txtPaswword,txtCargo);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los Campos Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void llenarGrid()
        {
            dataGridView1.DataSource = TrabajadorBL.SelectAllTrabajador();

        }
        private void TrabajadorForm_Load(object sender, EventArgs e)
        {
            llenarGrid();
            btnGuardar.Enabled = false;
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar)
             || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo puede aceptar números. Intente colocando algún valor", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar)
             || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo puede aceptar números. Intente colocando algún valor", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar)
             || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo puede aceptar números. Intente colocando algún valor", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void PaginarTrabajador()
        {
            int fila = dataGridView1.CurrentRow.Index;
            try
            {
                ID = Convert.ToInt32(dataGridView1.Rows[fila].Cells["IDTrabajador"].Value);
                txtNombre.Text = dataGridView1.Rows[fila].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.Rows[fila].Cells["Apellido"].Value.ToString();
                cbSexo.Text = dataGridView1.Rows[fila].Cells["Sexo"].Value.ToString();
                dateTimeNacimiento.Text = dataGridView1.Rows[fila].Cells["Fecha_Nacimiento"].Value.ToString();
                txtDocumento.Text = dataGridView1.Rows[fila].Cells["Cedula"].Value.ToString();
                txtDireccion.Text = dataGridView1.Rows[fila].Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[fila].Cells["Telefono"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[fila].Cells["Email"].Value.ToString();
                txtSalario.Text = dataGridView1.Rows[fila].Cells["Salario"].Value.ToString();
                txtUsuario.Text = dataGridView1.Rows[fila].Cells["Usuario"].Value.ToString();
                txtPaswword.Text = dataGridView1.Rows[fila].Cells["Password"].Value.ToString();
                txtCargo.Text = dataGridView1.Rows[fila].Cells["Cargo"].Value.ToString();
                
            }

            catch (Exception) { }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PaginarTrabajador();
            tabControl1.SelectedIndex = 0;
            btnGuardar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Trabajador modifica = new Trabajador();
                modifica.IDTrabajador = ID;
                modifica.Nombre = txtNombre.Text;
                modifica.Apellido = txtApellido.Text;
                modifica.Sexo = cbSexo.Text;
                modifica.Fecha_Nacimiento = dateTimeNacimiento.Value;
                modifica.Cedula = txtDocumento.Text;
                modifica.Direccion = txtDireccion.Text;
                modifica.Telefono = double.Parse(txtTelefono.Text);
                modifica.Email = txtEmail.Text;
                modifica.Salario = double.Parse(txtSalario.Text);
                modifica.Usuario = txtUsuario.Text;
                modifica.Password = txtPaswword.Text;
                modifica.Cargo = txtCargo.Text;
                TrabajadorBL.UpdateTrabajador(modifica);
                dataGridView1.Update();
                llenarGrid();
                MessageBox.Show("Trabajador Modificado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar(txtNombre, txtApellido, txtDocumento, txtDireccion, txtTelefono, txtEmail, txtUsuario, txtPaswword, txtCargo);
                btnGuardar.Enabled = false;
                btnAgregar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe llenar todos los Campos Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
