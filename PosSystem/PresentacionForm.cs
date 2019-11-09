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
        public PresentacionForm()
        {
            InitializeComponent();
           
        }
        private static PresentacionForm presentacionForm = null;
        private int ID;
        
        public static PresentacionForm Instance()
        {
            if (((presentacionForm == null)
                        || (presentacionForm.IsDisposed == true)))
            {
                presentacionForm = new PresentacionForm();
            }
            presentacionForm.BringToFront();
            return presentacionForm;
        }
        public bool Validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(txtID.Text) &&
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
           
                try
                {
                    dataGridView1.DataSource = PresentacionBL.SelectNombrePresentacion(BtnBuscar.Text);
                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.Message + "Error Al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PresentacionForm_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        public void LlenarGrid()
        {
            dataGridView1.DataSource = PresentacionBL.SelectAllPresentacion();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            
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

        private void txtIDproducto_TextChanged(object sender, EventArgs e)
        {

        }

        //public bool Validar()
        //{
        //    bool valor = false;



        //    if (!string.IsNullOrWhiteSpace(txtID.Text) &&
        //        !string.IsNullOrWhiteSpace(txtNombreProducto.Text) &&
        //        !string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
        //    {
        //        valor = true;
        //    }

        //    return valor;
        //}

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(txtID.Text);
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
                    Limpiar(txtID, txtDescripcionProducto, txtNombreProducto);
                   
                                       
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(txtID.Text);
            try
            {
                DialogResult resultado = MessageBox.Show("Realmente desea eliminar el Articulo: " + txtNombreProducto.Text + "?",
                                   "¿Desea eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    PresentacionBL.DeletePresentacion(ID);
                    MessageBox.Show("Articulo Eliminado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar(txtID, txtDescripcionProducto,txtNombreProducto);
                    dataGridView1.Update();
                    LlenarGrid();
                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error Al Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
