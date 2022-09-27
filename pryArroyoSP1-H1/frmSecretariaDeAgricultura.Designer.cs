namespace pryArroyoSP1_H1
{
    partial class frmSecretariaDeAgricultura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecretariaDeAgricultura));
            this.msAgricultura = new System.Windows.Forms.MenuStrip();
            this.tsmMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCultivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAgricultura.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAgricultura
            // 
            this.msAgricultura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMantenimiento,
            this.tsmConsultas});
            this.msAgricultura.Location = new System.Drawing.Point(0, 0);
            this.msAgricultura.Name = "msAgricultura";
            this.msAgricultura.Size = new System.Drawing.Size(396, 24);
            this.msAgricultura.TabIndex = 0;
            this.msAgricultura.Text = "menuStrip1";
            // 
            // tsmMantenimiento
            // 
            this.tsmMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalidades,
            this.tsmCultivos,
            this.tsmProduccion,
            this.tsmSalir});
            this.tsmMantenimiento.Name = "tsmMantenimiento";
            this.tsmMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.tsmMantenimiento.Text = "Mantenimiento";
            // 
            // tsmLocalidades
            // 
            this.tsmLocalidades.Name = "tsmLocalidades";
            this.tsmLocalidades.Size = new System.Drawing.Size(136, 22);
            this.tsmLocalidades.Text = "Localidades";
            this.tsmLocalidades.Click += new System.EventHandler(this.tsmLocalidades_Click);
            // 
            // tsmCultivos
            // 
            this.tsmCultivos.Name = "tsmCultivos";
            this.tsmCultivos.Size = new System.Drawing.Size(136, 22);
            this.tsmCultivos.Text = "Cultivos";
            this.tsmCultivos.Click += new System.EventHandler(this.tsmCultivos_Click);
            // 
            // tsmProduccion
            // 
            this.tsmProduccion.Name = "tsmProduccion";
            this.tsmProduccion.Size = new System.Drawing.Size(136, 22);
            this.tsmProduccion.Text = "Producción";
            this.tsmProduccion.Click += new System.EventHandler(this.tsmProduccion_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(136, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmConsultas
            // 
            this.tsmConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produccionToolStripMenuItem});
            this.tsmConsultas.Name = "tsmConsultas";
            this.tsmConsultas.Size = new System.Drawing.Size(71, 20);
            this.tsmConsultas.Text = "Consultas";
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.produccionToolStripMenuItem.Text = "Produccion";
            this.produccionToolStripMenuItem.Click += new System.EventHandler(this.produccionToolStripMenuItem_Click);
            // 
            // frmSecretariaDeAgricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 185);
            this.Controls.Add(this.msAgricultura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msAgricultura;
            this.Name = "frmSecretariaDeAgricultura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaria de Agricultura";
            this.Load += new System.EventHandler(this.frmSecretariaDeAgricultura_Load);
            this.msAgricultura.ResumeLayout(false);
            this.msAgricultura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAgricultura;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalidades;
        private System.Windows.Forms.ToolStripMenuItem tsmCultivos;
        private System.Windows.Forms.ToolStripMenuItem tsmProduccion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultas;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
    }
}

