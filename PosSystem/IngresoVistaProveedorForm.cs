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
    public partial class IngresoVistaProveedorForm : Form
    {
        public IngresoVistaProveedorForm()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;

        }
        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = IngresoBL.MostrarProveedor();
           // this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        // Metodo BuscarRazon_Social
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = IngresoBL.Buscar_Proveedor_Ingreso_Nombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        // Metodo BuscarNumero_Documento
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = IngresoBL.Buscar_Proveedor_Ingreso_RNC(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void IngresoVistaProveedorForm_Load(object sender, EventArgs e)
        {
            BuscarRazon_Social();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Identificacion"))
            {
                this.BuscarRazon_Social();
            }
            else if (cbBuscar.Text.Equals("Razon Social"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            if (dataListado.Rows.Count >= 1)
            {
                IngresoForm form = IngresoForm.GetInstancia();
                string par1, par2;
                par1 = Convert.ToString(dataListado.CurrentRow.Cells["idproveedor"].Value);
                par2 = Convert.ToString(dataListado.CurrentRow.Cells["razon_social"].Value);
                form.setProveedor(par1, par2);
                this.Hide();
            }
        }
    }
}
