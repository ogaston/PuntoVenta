using BusinessLogic;
using Entity;
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
    public partial class CategoriaForm : Form
    {
        static CategoriaForm _instancia;
        public CategoriaForm()
        {
            InitializeComponent();
        }
        public static CategoriaForm GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new CategoriaForm();
            }
            return (_instancia);
        }

        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }
           

        }

        public bool Validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text) )
            {
                valor = true;
            }
            return valor;
        }

        private void llenarGrid()
        {
            dataGridView1.DataSource = CategoriaBL.SelectAllCategoria();
        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            llenarGrid();
            txtNombre.Focus();
        
        }

        public int ID;
        private void PaginarCategoria()
        {
            int fila = dataGridView1.CurrentRow.Index;
            try
            {
                                
                ID = Convert.ToInt32(dataGridView1.Rows[fila].Cells["IDCategoria"].Value);
                txtNombre.Text = dataGridView1.Rows[fila].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.Rows[fila].Cells["Descripcion"].Value.ToString();

            }

            catch (Exception) { MessageBox.Show("Error al llenar el gridView"); }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Categoria nuevo = new Categoria();
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Descripcion = txtDescripcion.Text;
                    
                    CategoriaBL.InsertCategoria(nuevo);
                    dataGridView1.Update();
                    llenarGrid();
                    MessageBox.Show("Categoria Agregado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar(txtNombre, txtDescripcion);
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los Campos Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error Al Agregar el Categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar(txtNombre, txtDescripcion);
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Categoria modifica = new Categoria();
                    modifica.IDCategoria = ID;
                    modifica.Nombre = txtNombre.Text;
                    modifica.Descripcion = txtDescripcion.Text;

                    CategoriaBL.UpdateCategoria(modifica);
                    dataGridView1.Update();
                    llenarGrid();
                    MessageBox.Show("Categoria Modificado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar(txtNombre, txtDescripcion);
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
                MessageBox.Show(ex.Message + " Error Al Modificar Categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Realmente desea eliminar el Categoria: " + txtNombre.Text + "?",
                                   "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    CategoriaBL.DeleteCategoria(ID);
                    MessageBox.Show("Categoria Eliminado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar(txtNombre, txtDescripcion);
                    dataGridView1.Update();
                    llenarGrid();
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error Al Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataGridView1.DataSource = CategoriaBL.SelectIdCategoria(txtBuscar.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Error Al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PaginarCategoria();
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
    }
}
