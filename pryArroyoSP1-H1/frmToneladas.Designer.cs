namespace pryArroyoSP1_H1
{
    partial class frmToneladas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToneladas));
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(7, 59);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 20);
            this.lblLocalidad.TabIndex = 7;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivo.Location = new System.Drawing.Point(7, 105);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(56, 20);
            this.lblCultivo.TabIndex = 8;
            this.lblCultivo.Text = "Cultivo";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(96, 51);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(228, 28);
            this.lstLocalidad.TabIndex = 9;
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(96, 98);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(228, 28);
            this.lstCultivo.TabIndex = 10;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(301, 192);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(90, 28);
            this.cmdCargar.TabIndex = 11;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToneladas.Location = new System.Drawing.Point(7, 151);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(83, 20);
            this.lblToneladas.TabIndex = 12;
            this.lblToneladas.Text = "Toneladas";
            // 
            // txtToneladas
            // 
            this.txtToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToneladas.Location = new System.Drawing.Point(96, 145);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(144, 26);
            this.txtToneladas.TabIndex = 13;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(96, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(295, 26);
            this.dtpFecha.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(7, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha";
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(188, 192);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(90, 28);
            this.cmdBorrar.TabIndex = 16;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmToneladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 234);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblLocalidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmToneladas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Toneladas";
            this.Load += new System.EventHandler(this.frmToneladas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button cmdBorrar;
    }
}