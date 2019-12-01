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
    public partial class VentaVistaClienteForm : Form
    {
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;

        }
        private void BuscarClienteVentaNombre()
        {
            this.dataListado.DataSource = VentaBL.Buscar_Cliente_Venta_Nombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        // Metodo BuscarNumero_Documento
        private void BuscarClienteVentaDocumento()
        {
            this.dataListado.DataSource = VentaBL.Buscar_Cliente_Venta_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
       
        public VentaVistaClienteForm()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Nombre"))
            {
                this.BuscarClienteVentaNombre();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarClienteVentaDocumento();
            }
        }

        private void VentaVistaClienteForm_Load(object sender, EventArgs e)
        {
            BuscarClienteVentaNombre();
            txtBuscar.Focus();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            if (dataListado.Rows.Count >= 1)
            {
                VentasForm form = VentasForm.GetInstancia();
                string par1, par2, par3;
                par1 = Convert.ToString(dataListado.CurrentRow.Cells["IDCliente"].Value);
                par2 = Convert.ToString(dataListado.CurrentRow.Cells["Nombre"].Value) + " " +
                       Convert.ToString(dataListado.CurrentRow.Cells["Apellido"].Value);
                par3 = Convert.ToString(dataListado.CurrentRow.Cells["Num_Documeto"].Value);
                form.setCliente(par1, par2, par3);
                this.Close();
            }
        }
    }
}
