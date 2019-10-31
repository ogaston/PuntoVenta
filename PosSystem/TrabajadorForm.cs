using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BusinessLogic;

namespace PosSystem
{
    public partial class TrabajadorForm : Form
    {
        private static TrabajadorForm trabajadorForm = null;

        public static TrabajadorForm Instance()
        {
            if (((trabajadorForm == null)
                        || (trabajadorForm.IsDisposed == true)))
            {
                trabajadorForm = new TrabajadorForm();
            }
            trabajadorForm.BringToFront();
            return trabajadorForm;
        }
        public TrabajadorForm()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        public bool Validar()
        {
            bool valor = false;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && 
                !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                 !string.IsNullOrWhiteSpace(txtApellido.Text)&&
                  !string.IsNullOrWhiteSpace(txtCargo.Text)&&
                   !string.IsNullOrWhiteSpace(txtDocumento.Text)&&
                    !string.IsNullOrWhiteSpace(txtEmail.Text)&&
                     !string.IsNullOrWhiteSpace(txtSalario.Text)&&
                      !string.IsNullOrWhiteSpace(txtTelefono.Text)&&
                       !string.IsNullOrWhiteSpace(cbSexo.Text))
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
            txtSalario.Text = "";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Trabajador nuevo = new Trabajador();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.Sexo = cbSexo.Text;
                nuevo.Fecha_Nacimiento = dateTimeNacimiento.Value;
                nuevo.Cedula = txtDocumento.Text;
                nuevo.Direccion = txtDireccion.Text;
                nuevo.Telefono = double.Parse(txtTelefono.Text);
                nuevo.Email = txtEmail.Text;
                nuevo.Salario = double.Parse(txtSalario.Text);
                nuevo.Usuario = txtUsuario.Text;
                nuevo.Password = txtPaswword.Text;
                nuevo.Cargo = txtCargo.Text;
                TrabajadorBL.InsertTrabajador(nuevo);
                dataGridView1.Update();
                llenarGrid();
                MessageBox.Show("Trabajador Agregado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar(txtNombre, txtApellido, txtDocumento, txtDireccion, txtTelefono, txtEmail, txtUsuario, txtPaswword,txtCargo);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los Campos Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void llenarGrid()
        {
            dataGridView1.DataSource = TrabajadorBL.SelectAllTrabajador();

        }
        private void TrabajadorForm_Load(object sender, EventArgs e)
        {
            llenarGrid();
            btnGuardar.Enabled = false;
        }
    }
}
