namespace PosSystem
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blancoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.almacenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComprasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(254)))));
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnMenu);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1044, 45);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "PDV SYSTEM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(254)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 35);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blancoMenuItem,
            this.almacenMenuItem,
            this.ventaMenuItem,
            this.ComprasMenuItem,
            this.mantenimientoMenuItem,
            this.ayudaMenuItem,
            this.cerrarSesionMenuItem,
            this.salirMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 45);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(183, 551);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blancoMenuItem
            // 
            this.blancoMenuItem.Enabled = false;
            this.blancoMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.blancoMenuItem.ForeColor = System.Drawing.Color.Transparent;
            this.blancoMenuItem.Name = "blancoMenuItem";
            this.blancoMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.blancoMenuItem.Size = new System.Drawing.Size(170, 16);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Location = new System.Drawing.Point(186, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(858, 551);
            this.panelContenedor.TabIndex = 2;
            // 
            // almacenMenuItem
            // 
            this.almacenMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(254)))));
            this.almacenMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloMenuItem,
            this.CategoriaMenuItem,
            this.presentacionMenuItem});
            this.almacenMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almacenMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(73)))));
            this.almacenMenuItem.Image = global::PosSystem.Properties.Resources.almacen_de_fabrica;
            this.almacenMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.almacenMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.almacenMenuItem.Name = "almacenMenuItem";
            this.almacenMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.almacenMenuItem.Size = new System.Drawing.Size(170, 48);
            this.almacenMenuItem.Text = "ALMACEN";
            // 
            // articuloMenuItem
            // 
            this.articuloMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.articuloMenuItem.Image = global::PosSystem.Properties.Resources.articulo;
            this.articuloMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.articuloMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.articuloMenuItem.Name = "articuloMenuItem";
            this.articuloMenuItem.Size = new System.Drawing.Size(182, 38);
            this.articuloMenuItem.Text = "Articulo";
            this.articuloMenuItem.Click += new System.EventHandler(this.articuloMenuItem_Click);
            // 
            // CategoriaMenuItem
            // 
            this.CategoriaMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.CategoriaMenuItem.Image = global::PosSystem.Properties.Resources.categoria;
            this.CategoriaMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoriaMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CategoriaMenuItem.Name = "CategoriaMenuItem";
            this.CategoriaMenuItem.Size = new System.Drawing.Size(182, 38);
            this.CategoriaMenuItem.Text = "Categoria";
            // 
            // presentacionMenuItem
            // 
            this.presentacionMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.presentacionMenuItem.Image = global::PosSystem.Properties.Resources.presentacion;
            this.presentacionMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.presentacionMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.presentacionMenuItem.Name = "presentacionMenuItem";
            this.presentacionMenuItem.Size = new System.Drawing.Size(182, 38);
            this.presentacionMenuItem.Text = "Presentacion";
            // 
            // ventaMenuItem
            // 
            this.ventaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionMenuItem,
            this.clienteToolStripMenuItem});
            this.ventaMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ventaMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(73)))));
            this.ventaMenuItem.Image = global::PosSystem.Properties.Resources.carrito_de_compras;
            this.ventaMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventaMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ventaMenuItem.Name = "ventaMenuItem";
            this.ventaMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 6, 6);
            this.ventaMenuItem.Size = new System.Drawing.Size(170, 48);
            this.ventaMenuItem.Text = "VENTAS";
            // 
            // facturacionMenuItem
            // 
            this.facturacionMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.facturacionMenuItem.Image = global::PosSystem.Properties.Resources.facturacion;
            this.facturacionMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facturacionMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturacionMenuItem.Name = "facturacionMenuItem";
            this.facturacionMenuItem.Size = new System.Drawing.Size(173, 38);
            this.facturacionMenuItem.Text = "Facturacion";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.clienteToolStripMenuItem.Image = global::PosSystem.Properties.Resources.cliente;
            this.clienteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.clienteToolStripMenuItem.Text = "Clientes";
            // 
            // ComprasMenuItem
            // 
            this.ComprasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosMenuItem,
            this.proveedoresMenuItem});
            this.ComprasMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ComprasMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(73)))));
            this.ComprasMenuItem.Image = global::PosSystem.Properties.Resources.camion;
            this.ComprasMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComprasMenuItem.Name = "ComprasMenuItem";
            this.ComprasMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ComprasMenuItem.Size = new System.Drawing.Size(170, 48);
            this.ComprasMenuItem.Text = "COMPRAS";
            // 
            // ingresosMenuItem
            // 
            this.ingresosMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.ingresosMenuItem.Image = global::PosSystem.Properties.Resources.mayores_ingresos;
            this.ingresosMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ingresosMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ingresosMenuItem.Name = "ingresosMenuItem";
            this.ingresosMenuItem.Size = new System.Drawing.Size(180, 38);
            this.ingresosMenuItem.Text = "Ingresos";
            // 
            // proveedoresMenuItem
            // 
            this.proveedoresMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.proveedoresMenuItem.Image = global::PosSystem.Properties.Resources.fabricar;
            this.proveedoresMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedoresMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.proveedoresMenuItem.Name = "proveedoresMenuItem";
            this.proveedoresMenuItem.Size = new System.Drawing.Size(180, 38);
            this.proveedoresMenuItem.Text = "Proveedores";
            // 
            // mantenimientoMenuItem
            // 
            this.mantenimientoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajadorMenuItem});
            this.mantenimientoMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.mantenimientoMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(73)))));
            this.mantenimientoMenuItem.Image = global::PosSystem.Properties.Resources.mantenimiento;
            this.mantenimientoMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mantenimientoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mantenimientoMenuItem.Name = "mantenimientoMenuItem";
            this.mantenimientoMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mantenimientoMenuItem.Size = new System.Drawing.Size(170, 48);
            this.mantenimientoMenuItem.Text = "MANTENIMIENTO";
            // 
            // trabajadorMenuItem
            // 
            this.trabajadorMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.trabajadorMenuItem.Image = global::PosSystem.Properties.Resources.trabajador;
            this.trabajadorMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trabajadorMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trabajadorMenuItem.Name = "trabajadorMenuItem";
            this.trabajadorMenuItem.Size = new System.Drawing.Size(168, 38);
            this.trabajadorMenuItem.Text = "Trabajador";
            this.trabajadorMenuItem.Click += new System.EventHandler(this.trabajadorMenuItem_Click);
            // 
            // ayudaMenuItem
            // 
            this.ayudaMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ayudaMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(73)))));
            this.ayudaMenuItem.Image = global::PosSystem.Properties.Resources.pregunta;
            this.ayudaMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ayudaMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ayudaMenuItem.Name = "ayudaMenuItem";
            this.ayudaMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ayudaMenuItem.Size = new System.Drawing.Size(170, 48);
            this.ayudaMenuItem.Text = "AYUDA";
            // 
            // cerrarSesionMenuItem
            // 
            this.cerrarSesionMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cerrarSesionMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(73)))));
            this.cerrarSesionMenuItem.Image = global::PosSystem.Properties.Resources.finalizar;
            this.cerrarSesionMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarSesionMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrarSesionMenuItem.Name = "cerrarSesionMenuItem";
            this.cerrarSesionMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cerrarSesionMenuItem.Size = new System.Drawing.Size(170, 48);
            this.cerrarSesionMenuItem.Text = "CERRAR SESION";
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(254)))));
            this.salirMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.salirMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(73)))));
            this.salirMenuItem.Image = global::PosSystem.Properties.Resources.salida;
            this.salirMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.salirMenuItem.Size = new System.Drawing.Size(170, 48);
            this.salirMenuItem.Text = "SALIR";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(963, 5);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(18, 18);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 4;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(989, 5);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(18, 18);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 3;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(989, 5);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(18, 18);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1015, 5);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::PosSystem.Properties.Resources.cashier_;
            this.btnMenu.Location = new System.Drawing.Point(5, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 596);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem almacenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriaMenuItem;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripMenuItem articuloMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentacionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComprasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadorMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blancoMenuItem;
    }
}

