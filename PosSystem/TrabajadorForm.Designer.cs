namespace PosSystem
{
    partial class TrabajadorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFind = new System.Windows.Forms.TabPage();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCreate);
            this.tabControl1.Controls.Add(this.tabPageFind);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFind
            // 
            this.tabPageFind.Location = new System.Drawing.Point(4, 22);
            this.tabPageFind.Name = "tabPageFind";
            this.tabPageFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFind.Size = new System.Drawing.Size(792, 424);
            this.tabPageFind.TabIndex = 1;
            this.tabPageFind.Text = "BUSCAR TRABAJADOR";
            this.tabPageFind.ToolTipText = "Listado de Trabajadores";
            this.tabPageFind.UseVisualStyleBackColor = true;
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreate.Size = new System.Drawing.Size(792, 424);
            this.tabPageCreate.TabIndex = 2;
            this.tabPageCreate.Text = "MANTENIMIENTO";
            this.tabPageCreate.ToolTipText = "Formulario De Trabajador";
            this.tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // TrabajadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrabajadorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFind;
        private System.Windows.Forms.TabPage tabPageCreate;
    }
}