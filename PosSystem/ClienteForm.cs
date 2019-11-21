
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Entity;
using System;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class ClienteForm : Form
    {

        DataSetCombox dtCombo = new DataSetCombox();
        static ClienteForm _instancia;
        DataSetComboxTableAdapters.CategoriaTableAdapter categoria = new DataSetComboxTableAdapters.CategoriaTableAdapter();
        DataSetComboxTableAdapters.PresentacionTableAdapter presentacion = new DataSetComboxTableAdapters.PresentacionTableAdapter();
        private int ID;

        public ClienteForm()
        {
            InitializeComponent();
            FillGrid();
        }

        public static ClienteForm GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ClienteForm();
            }
            return (_instancia);
        }
        
        private bool Validate()
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text)&&
                !string.IsNullOrWhiteSpace(txtDocumento.Text) &&
                !string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                return true;
            }
            return false;
        }

        public void CleanUp()
        {
            TextBox[] textArr = { txtApellido, txtDireccion, txtNombre, txtTelefono, txtDocumento, txtEmail };

            for (int i = 0; i < textArr.Length; i++)
            {
                textArr[i].Clear();
            }
        }

        private void FillGrid()
        {
            dataGridView1.DataSource = ClienteBL.SelectAll();
        }

        private DialogResult ShowMessage(string msg, string type = "Informacion")
        {
            if (type == "Error")
            {
                return MessageBox.Show(msg, type, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MessageBox.Show(msg, type, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Cliente GetClientFormData()
        {
            Cliente nuevo = new Cliente();

            nuevo.Apellido = txtApellido.Text;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Num_Documento = txtDocumento.Text;
            nuevo.Sexo = radioMasc.Checked ? radioMasc.Text : radioFem.Text;
            nuevo.Fecha_Nacimiento = dateTpFechaNacimiento.Value;
            nuevo.Telofono = txtTelefono.Text;
            nuevo.Tipo_Documento = radCedula.Checked ? radCedula.Text : radPassport.Text;
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Email = txtEmail.Text;

            return nuevo;
        }

        private void FocusTextBox()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtApellido.Focus();

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtBuscar.Focus();
            }
        }
 
        private void EditView()
        {
            int fila = dataGridView1.CurrentRow.Index;
            try 
            { 
                ID = Convert.ToInt32(dataGridView1.Rows[fila].Cells["IDCliente"].Value);

                txtApellido.Text = dataGridView1.Rows[fila].Cells["Apellido"].Value.ToString();
                txtNombre.Text = dataGridView1.Rows[fila].Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dataGridView1.Rows[fila].Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[fila].Cells["Telefono"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[fila].Cells["Email"].Value.ToString();
                txtDocumento.Text = dataGridView1.Rows[fila].Cells["Num_Documento"].Value.ToString();
                dateTpFechaNacimiento.Value = DateTime.Parse(dataGridView1.Rows[fila].Cells["Fecha_Nacimiento"].Value.ToString());

                bool isMasc = dataGridView1.Rows[fila].Cells["Sexo"].Value.ToString() == "Masculino";
                radioMasc.Checked = isMasc;
                radioFem.Checked = !isMasc;

                bool isCed = dataGridView1.Rows[fila].Cells["Tipo_Documento"].Value.ToString() == "Cédula";
                radCedula.Checked = isCed;
                radPassport.Checked = !isCed;
            }
            catch (Exception e) {
                ShowMessage(e.Message + "| Error al llenar el gridView", "Error");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    Cliente newClient = GetClientFormData();
                    ClienteBL.Create(newClient);
                    dataGridView1.Update();
                    FillGrid();
                    ShowMessage("Cliente Agregado Exitosamente");
                    CleanUp();
                }
                else
                {
                    ShowMessage("Debe llenar todos los Campos Requeridos", "Error");
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message + " Error Al Agregar el Cliente", "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanUp();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
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
                ShowMessage(ex.Message + "Error Al Consultar", "Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ClienteBL.SelectById(txtBuscar.Text);
            }
            catch (Exception ex)
            {

                ShowMessage(ex.Message + "Error Al Consultar", "Error");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EditView();
                tabControl1.SelectedIndex = 0;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAgregar.Enabled = false;
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message + "Error del DataGrid", "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    Cliente modifica = GetClientFormData();
                    ClienteBL.Update(modifica);
                    dataGridView1.Update();
                    FillGrid();
                    ShowMessage("Cliente Modificado Exitosamente");
                    CleanUp();
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = true;
                }
                else
                {
                    ShowMessage("Debe llenar todos los Campos Requeridos", "Error");

                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message + " Error Al Modificar Cliente", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "Realmente desea eliminar el Cliente: " + txtNombre.Text + "?";
                DialogResult resultado = ShowMessage(Msg, "¿Desea eliminar?");
                if (resultado == DialogResult.Yes)
                {
                    ClienteBL.Delete(ID);
                    ShowMessage("Cliente Eliminado.");
                    CleanUp();
                    dataGridView1.Update();
                    FillGrid();
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message + " Error Al Eliminar", "Error");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPageMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
