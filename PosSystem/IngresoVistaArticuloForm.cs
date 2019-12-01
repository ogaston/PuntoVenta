using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
namespace PosSystem
{
    public partial class IngresoVistaArticuloForm : Form
    {
        public IngresoVistaArticuloForm()
        {
            InitializeComponent();
        }


        // Metodo para ocultar Colummnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[6].Visible = false;
            this.dataListado.Columns[8].Visible = false;

        }
        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = IngresoBL.Buscar_Articulo_Ingreso_Nombre(txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        // Metodo Buscar
        private void Buscar_Articulo_Nombre()
        {
            this.dataListado.DataSource = IngresoBL.Buscar_Articulo_Ingreso_Nombre(txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar_Articulo_Nombre();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            IngresoForm form = IngresoForm.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(dataListado.CurrentRow.Cells["idarticulo"].Value);
            par2 = Convert.ToString(dataListado.CurrentRow.Cells["nombre"].Value);
            form.setArticulo(par1, par2);
            this.Hide();
        }

        private void IngresoVistaArticuloForm_Load(object sender, EventArgs e)
        {
            this.Buscar_Articulo_Nombre();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Codigo"))
            {
                this.Buscar_Articulo_Nombre();
            }
            else if (cbBuscar.Text.Equals("Nombre"))
            {
                this.Buscar_Articulo_Nombre();

            }
            else if (cbBuscar.Text.Equals("ID"))
            {
                this.Buscar_Articulo_Nombre();

            }
        }

        private void dataListado_DoubleClick_1(object sender, EventArgs e)
        {
            if (dataListado.Rows.Count >= 1)
            {
                IngresoForm form = IngresoForm.GetInstancia();
                string par1, par2;
                par1 = Convert.ToString(dataListado.CurrentRow.Cells["idarticulo"].Value);
                par2 = Convert.ToString(dataListado.CurrentRow.Cells["nombre"].Value);
                form.setArticulo(par1, par2);
                this.Hide();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
