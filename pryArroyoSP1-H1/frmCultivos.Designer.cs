namespace pryArroyoSP1_H1
{
    partial class frmCultivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCultivos));
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtCultivo = new System.Windows.Forms.TextBox();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblNumeroCultivo = new System.Windows.Forms.Label();
            this.mtbNumeroCultivo = new System.Windows.Forms.MaskedTextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(246, 119);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(90, 28);
            this.cmdCargar.TabIndex = 9;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtCultivo
            // 
            this.txtCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCultivo.Location = new System.Drawing.Point(144, 70);
            this.txtCultivo.Name = "txtCultivo";
            this.txtCultivo.Size = new System.Drawing.Size(192, 26);
            this.txtCultivo.TabIndex = 8;
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivo.Location = new System.Drawing.Point(12, 76);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(56, 20);
            this.lblCultivo.TabIndex = 7;
            this.lblCultivo.Text = "Cultivo";
            // 
            // lblNumeroCultivo
            // 
            this.lblNumeroCultivo.AutoSize = true;
            this.lblNumeroCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCultivo.Location = new System.Drawing.Point(12, 26);
            this.lblNumeroCultivo.Name = "lblNumeroCultivo";
            this.lblNumeroCultivo.Size = new System.Drawing.Size(116, 20);
            this.lblNumeroCultivo.TabIndex = 6;
            this.lblNumeroCultivo.Text = "Numero Cultivo";
            // 
            // mtbNumeroCultivo
            // 
            this.mtbNumeroCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumeroCultivo.Location = new System.Drawing.Point(144, 20);
            this.mtbNumeroCultivo.Mask = "999";
            this.mtbNumeroCultivo.Name = "mtbNumeroCultivo";
            this.mtbNumeroCultivo.Size = new System.Drawing.Size(39, 26);
            this.mtbNumeroCultivo.TabIndex = 10;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(144, 119);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(90, 28);
            this.cmdBorrar.TabIndex = 11;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 161);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.mtbNumeroCultivo);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.txtCultivo);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblNumeroCultivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCultivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Cultivos";
            this.Load += new System.EventHandler(this.frmCultivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtCultivo;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblNumeroCultivo;
        private System.Windows.Forms.MaskedTextBox mtbNumeroCultivo;
        private System.Windows.Forms.Button cmdBorrar;
    }
}