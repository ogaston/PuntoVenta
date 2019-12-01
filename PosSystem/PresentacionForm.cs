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
    public partial class PresentacionForm : Form
    {
        public int ID;
        public PresentacionForm()
        {
            InitializeComponent();
           
        }
        private static PresentacionForm presentacionForm = null;
      
        public bool Validar()
        {
            bool valor = false;

            if (
                !string.IsNullOrWhiteSpace(txtNombreProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
          
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
        }
      

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            if (Validar())
            {
              
                Presentacion nuevo = new Presentacion();
                nuevo.Nombre = txtNombreProducto.Text;
                nuevo.Descripcion = txtDescripcionProducto.Text;
                PresentacionBL.InsertPresentacion(nuevo);
                dataGridView1.Update();
                LlenarGrid(); 
                MessageBox.Show("Presentacion Agregada Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar(txtNombreProducto, txtDescripcionProducto);
          
            }
            else
            {
                MessageBox.Show("Debe llenar todos los Campos Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
           
                try
                {
                    dataGridView1.DataSource = PresentacionBL.SelectNombrePresentacion(txtBusqueda.Text);
                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.Message + "Error Al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           

        }
     
        private void PaginarPresentacion()
        {

            int fila = dataGridView1.CurrentRow.Index;
            try
            {
                ID = Convert.ToInt32( dataGridView1.Rows[fila].Cells["IDPresentacion"].Value);

                txtNombreProducto.Text = dataGridView1.Rows[fila].Cells["Nombre"].Value.ToString();
                txtDescripcionProducto.Text = dataGridView1.Rows[fila].Cells["Descripcion"].Value.ToString();
   
            }
            catch
            {
                MessageBox.Show("ocurrio un erroe al paginar");

            }


        }
       
        private void PresentacionForm_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
        }
        public void LlenarGrid()
        {
            dataGridView1.DataSource = PresentacionBL.SelectAllPresentacion();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnAgregar.Enabled = true ;
            tabControl1.SelectedIndex = 0;
            {
                Limpiar(txtNombreProducto, txtDescripcionProducto);
            }
            void Limpiar(params TextBox[] text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    text[i].Clear();

                }

            }
                     
           
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnAgregar.Enabled = true;
         
            try
            {
                if (Validar())
                {
                    Presentacion modifica = new Presentacion();
                    modifica.IDPresentacion = ID;
                    modifica.Nombre = txtNombreProducto.Text;
                    modifica.Descripcion = txtDescripcionProducto.Text;
                    
                    PresentacionBL.UpdatePresentacion(modifica);
                    dataGridView1.Update();
                    LlenarGrid();
                    MessageBox.Show("Presentacion Modificada Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar( txtDescripcionProducto, txtNombreProducto);
                    tabControl1.SelectedIndex = 1;

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los Campos Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error Al Modificar Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnAgregar.Enabled = true;
         
            try
            {
                DialogResult resultado = MessageBox.Show("Realmente desea eliminar el Articulo: " + txtNombreProducto.Text + "?",
                                   "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    PresentacionBL.DeletePresentacion(ID);
                    MessageBox.Show("Articulo Eliminado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar( txtDescripcionProducto,txtNombreProducto);
                    dataGridView1.Update();
                    LlenarGrid();
                    tabControl1.SelectedIndex = 1;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error Al Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PaginarPresentacion();
            tabControl1.SelectedIndex = 0;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
        }


        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar =='\r')
                {
                    e.Handled = true;
                    BtnBuscar.PerformClick();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No error al consutar datos");
                throw;
            }
        }


    }
}
