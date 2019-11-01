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
        }

        public bool Validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                 !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                  !string.IsNullOrWhiteSpace(txtCargo.Text) &&
                   !string.IsNullOrWhiteSpace(txtDocumento.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                     !string.IsNullOrWhiteSpace(txtSalario.Text) &&
                      !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
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
            cbSexo.Text = "";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
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
                    Limpiar(txtNombre, txtApellido, txtDocumento, txtDireccion, txtTelefono, txtEmail, txtUsuario, txtPaswword, txtCargo);
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los Campos Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error Al Agregar Trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void llenarGrid()
        {
            dataGridView1.DataSource = TrabajadorBL.SelectAllTrabajador();

        }

        private void FocusTextBox()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtNombre.Focus();

            }else if (tabControl1.SelectedIndex == 1)
            {
                txtBuscar.Focus();
            }
        }
        private void TrabajadorForm_Load(object sender, EventArgs e)
        {
            llenarGrid();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            
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

            catch (Exception) { MessageBox.Show("Error al llenar el gridView"); }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PaginarTrabajador();
                tabControl1.SelectedIndex = 0;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAgregar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error del DataGrid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
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
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los Campos Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error Al Modificar Trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Realmente desea eliminar el Trabajador: " + txtNombre.Text + "?",
                                   "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    TrabajadorBL.DeleteTrabajador(ID);
                    MessageBox.Show("Trabajador Eliminado.", "Informacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Limpiar(txtNombre, txtApellido, txtDocumento, txtDireccion, txtTelefono, txtEmail, txtUsuario, txtPaswword, txtCargo);
                    dataGridView1.Update();
                    llenarGrid();
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = true;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error Al Eliminar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Error Al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = TrabajadorBL.SelectNameTrabajador(txtBuscar.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Error Al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar(txtNombre, txtApellido, txtDocumento, txtDireccion, txtTelefono, txtEmail, txtUsuario, txtPaswword, txtCargo);
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FocusTextBox();
        }
    }
}
