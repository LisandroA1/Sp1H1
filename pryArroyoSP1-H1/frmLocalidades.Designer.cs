namespace pryArroyoSP1_H1
{
    partial class frmLocalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalidades));
            this.lblNumeroLocalidad = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mtbNumeroLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroLocalidad
            // 
            this.lblNumeroLocalidad.AutoSize = true;
            this.lblNumeroLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLocalidad.Location = new System.Drawing.Point(12, 15);
            this.lblNumeroLocalidad.Name = "lblNumeroLocalidad";
            this.lblNumeroLocalidad.Size = new System.Drawing.Size(137, 20);
            this.lblNumeroLocalidad.TabIndex = 0;
            this.lblNumeroLocalidad.Text = "Numero Localidad";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(12, 65);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 20);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(164, 59);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(192, 26);
            this.txtLocalidad.TabIndex = 3;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(266, 109);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(90, 28);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // mtbNumeroLocalidad
            // 
            this.mtbNumeroLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumeroLocalidad.Location = new System.Drawing.Point(164, 9);
            this.mtbNumeroLocalidad.Mask = "999";
            this.mtbNumeroLocalidad.Name = "mtbNumeroLocalidad";
            this.mtbNumeroLocalidad.Size = new System.Drawing.Size(43, 26);
            this.mtbNumeroLocalidad.TabIndex = 5;
            this.mtbNumeroLocalidad.ValidatingType = typeof(int);
            this.mtbNumeroLocalidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNumeroLocalidad_MaskInputRejected);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(164, 109);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(90, 28);
            this.cmdBorrar.TabIndex = 6;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 151);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.mtbNumeroLocalidad);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblNumeroLocalidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Localidades";
            this.Load += new System.EventHandler(this.frmLocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.MaskedTextBox mtbNumeroLocalidad;
        private System.Windows.Forms.Button cmdBorrar;
    }
}