
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
    public partial class ProveedoresForm : Form
    {

        DataSetCombox dtCombo = new DataSetCombox();
        static ProveedoresForm _instancia;
        DataSetComboxTableAdapters.CategoriaTableAdapter categoria = new DataSetComboxTableAdapters.CategoriaTableAdapter();
        DataSetComboxTableAdapters.PresentacionTableAdapter presentacion = new DataSetComboxTableAdapters.PresentacionTableAdapter();
        private int ID;

        public ProveedoresForm()
        {
            InitializeComponent();
            FillGrid();
        }

        public static ProveedoresForm GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ProveedoresForm();
            }
            return (_instancia);
        }
        
        private bool Validate()
        {
            if (!string.IsNullOrWhiteSpace(txtRazonSocial.Text) &&
                !string.IsNullOrWhiteSpace(txtSectorComercial.Text)&&
                !string.IsNullOrWhiteSpace(txtIdentificacion.Text) &&
                !string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                return true;
            }
            return false;
        }

        public void CleanUp()
        {
            TextBox[] textArr = { txtSectorComercial, txtDireccion, txtRazonSocial, txtTelefono, txtIdentificacion, txtEmail };

            for (int i = 0; i < textArr.Length; i++)
            {
                textArr[i].Clear();
            }
        }

        private void FillGrid()
        {
            dataGridView1.DataSource = ProveedoresBL.SelectAll();
        }

        private DialogResult ShowMessage(string msg, string type = "Informacion")
        {
            if (type == "Error")
            {
                return MessageBox.Show(msg, type, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MessageBox.Show(msg, type, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Proveedores GetProviderFormData()
        {
            Proveedores nuevo = new Proveedores();

            nuevo.razon_social = txtRazonSocial.Text;
            nuevo.Sector_Comercial = txtSectorComercial.Text;
            nuevo.Identificacion = txtIdentificacion.Text;
            nuevo.Telefono = txtTelefono.Text;
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Email = txtEmail.Text;

            return nuevo;
        }

        private void FocusTextBox()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtSectorComercial.Focus();

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
                ID = Convert.ToInt32(dataGridView1.Rows[fila].Cells["IDProveedor"].Value);

                txtSectorComercial.Text = dataGridView1.Rows[fila].Cells["Sector_Comercial"].Value.ToString();
                txtRazonSocial.Text = dataGridView1.Rows[fila].Cells["razon_social"].Value.ToString();
                txtDireccion.Text = dataGridView1.Rows[fila].Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[fila].Cells["Telefono"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[fila].Cells["Email"].Value.ToString();
                txtIdentificacion.Text = dataGridView1.Rows[fila].Cells["Identificacion"].Value.ToString();
               
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
                    Proveedores newProvider = GetProviderFormData();
                    ProveedoresBL.Create(newProvider);
                    dataGridView1.Update();
                    FillGrid();
                    ShowMessage("Proveedores Agregado Exitosamente");
                    CleanUp();
                }
                else
                {
                    ShowMessage("Debe llenar todos los Campos Requeridos", "Error");
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message + " Error Al Agregar el Proveedores", "Error");
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
                if (txtBuscar.Text.Length > 0)
                {
                    dataGridView1.DataSource = ProveedoresBL.SelectById(txtBuscar.Text);
                } else
                {
                    FillGrid();
                }
                
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
                    Proveedores modifica = GetProviderFormData();
                    modifica.IDProveedores = ID;
                    ProveedoresBL.Update(modifica);
                    dataGridView1.Update();
                    FillGrid();
                    ShowMessage("Proveedores Modificado Exitosamente");
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
                ShowMessage(ex.Message + " Error Al Modificar Proveedores", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "Realmente desea eliminar el Proveedores: " + txtRazonSocial.Text + "?";
                DialogResult resultado = MessageBox.Show(Msg, "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    ProveedoresBL.Delete(ID);
                    ShowMessage("Proveedores Eliminado.");
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
