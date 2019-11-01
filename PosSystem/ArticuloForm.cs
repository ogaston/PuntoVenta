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
    public partial class ArticuloForm : Form
    {
        private static ArticuloForm articuloForm = null;
        private int ID;
        public static ArticuloForm Instance()
        {
            if (((articuloForm == null)
                        || (articuloForm.IsDisposed == true)))
            {
                articuloForm = new ArticuloForm();
            }
            articuloForm.BringToFront();
            return articuloForm;
        }
        public ArticuloForm()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtCodigo.Text)&&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text)&&
                !string.IsNullOrWhiteSpace(cbCategoria.Text)&&
                !string.IsNullOrWhiteSpace(cbPresentacion.Text))
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
            cbCategoria.Text = "";
            cbPresentacion.Text = "";

        }

        private void Focus()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtNombre.Focus();

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtBuscar.Focus();
            }
        }

        private void ArticuloForm_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void PaginarTrabajador()
        {
            int fila = dataGridView1.CurrentRow.Index;
            try
            {
                //ID = Convert.ToInt32(dataGridView1.Rows[fila].Cells["IDTrabajador"].Value);
                //txtNombre.Text = dataGridView1.Rows[fila].Cells["Nombre"].Value.ToString();
                //txt.Text = dataGridView1.Rows[fila].Cells["Apellido"].Value.ToString();
                //cbSexo.Text = dataGridView1.Rows[fila].Cells["Sexo"].Value.ToString();
                //dateTimeNacimiento.Text = dataGridView1.Rows[fila].Cells["Fecha_Nacimiento"].Value.ToString();

            }

            catch (Exception) { MessageBox.Show("Error al llenar el gridView"); }
        }
    }
}
