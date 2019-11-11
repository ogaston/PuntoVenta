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
    public partial class VentaVistaArticuloForm : Form
    {

        // Metodo para ocultar Colummnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;

        }

        // Metodo BuscarRazon_Social
        private void MostrarArticulo_Venta_Nombre()
        {
            this.dataListado.DataSource = VentaBL.BuscarArticuloVentaNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        // Metodo BuscarNumero_Documento
        private void MostrarArticulo_Venta_Codigo()
        {
            this.dataListado.DataSource = VentaBL.BuscarArticuloVentaCodigo(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void MostrarArticulo_Venta_Id()
        {
            this.dataListado.DataSource = VentaBL.BuscarArticuloVentaCodigo(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        public VentaVistaArticuloForm()
        {
            InitializeComponent();
        }

        private void VentaVistaArticuloForm_Load(object sender, EventArgs e)
        {
            MostrarArticulo_Venta_Nombre();
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Codigo"))
            {
                this.MostrarArticulo_Venta_Codigo();
            }
            else if (cbBuscar.Text.Equals("Nombre"))
            {
                this.MostrarArticulo_Venta_Nombre();
            }
            else if (cbBuscar.Text.Equals("ID"))
            {
                this.MostrarArticulo_Venta_Id();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            VentasForm form = VentasForm.GetInstancia();
            string par1, par2;
            decimal par3, par4;
            int par5;
            DateTime par6;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["iddetalle_ingreso"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            par3 = Convert.ToDecimal(this.dataListado.CurrentRow.Cells["precio_compra"].Value);
            par4 = Convert.ToDecimal(this.dataListado.CurrentRow.Cells["precio_venta"].Value);
            par5 = Convert.ToInt32(this.dataListado.CurrentRow.Cells["stock_actual"].Value);
            par6 = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_vencimiento"].Value);

            form.setArticulo(par1, par2, par3, par4, par5, par6);
            this.Close();

        }
    }
}
