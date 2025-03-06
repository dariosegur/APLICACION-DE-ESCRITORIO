namespace LabManager.PrestamoRecepcion
{
    partial class IngresoEgresoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoEgresoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbTipoEquipo = new System.Windows.Forms.TextBox();
            this.tbCodigoLab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbEntra = new System.Windows.Forms.PictureBox();
            this.pbSale = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de equipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTipoEquipo
            // 
            this.tbTipoEquipo.Enabled = false;
            this.tbTipoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipoEquipo.Location = new System.Drawing.Point(23, 90);
            this.tbTipoEquipo.Name = "tbTipoEquipo";
            this.tbTipoEquipo.Size = new System.Drawing.Size(629, 80);
            this.tbTipoEquipo.TabIndex = 1;
            this.tbTipoEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCodigoLab
            // 
            this.tbCodigoLab.Enabled = false;
            this.tbCodigoLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoLab.Location = new System.Drawing.Point(23, 274);
            this.tbCodigoLab.Name = "tbCodigoLab";
            this.tbCodigoLab.Size = new System.Drawing.Size(629, 80);
            this.tbCodigoLab.TabIndex = 5;
            this.tbCodigoLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(629, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo Laboratorio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEntra
            // 
            this.pbEntra.Image = ((System.Drawing.Image)(resources.GetObject("pbEntra.Image")));
            this.pbEntra.Location = new System.Drawing.Point(146, 360);
            this.pbEntra.Name = "pbEntra";
            this.pbEntra.Size = new System.Drawing.Size(118, 117);
            this.pbEntra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEntra.TabIndex = 6;
            this.pbEntra.TabStop = false;
            // 
            // pbSale
            // 
            this.pbSale.Image = ((System.Drawing.Image)(resources.GetObject("pbSale.Image")));
            this.pbSale.Location = new System.Drawing.Point(425, 360);
            this.pbSale.Name = "pbSale";
            this.pbSale.Size = new System.Drawing.Size(118, 117);
            this.pbSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSale.TabIndex = 7;
            this.pbSale.TabStop = false;
            // 
            // IngresoEgresoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 489);
            this.Controls.Add(this.pbSale);
            this.Controls.Add(this.pbEntra);
            this.Controls.Add(this.tbCodigoLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTipoEquipo);
            this.Controls.Add(this.label1);
            this.Name = "IngresoEgresoForm";
            this.Load += new System.EventHandler(this.IngreoEgresoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEntra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTipoEquipo;
        private System.Windows.Forms.TextBox tbCodigoLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbEntra;
        private System.Windows.Forms.PictureBox pbSale;
    }
}