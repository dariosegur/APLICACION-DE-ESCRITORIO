namespace LabManager.PrestamoRecepcion
{
    partial class Restricciones
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
            this.BtnAcepta = new System.Windows.Forms.Button();
            this.BtnRechaza = new System.Windows.Forms.Button();
            this.Lb_Restricciones = new System.Windows.Forms.Label();
            this.Tb_Restricciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAcepta
            // 
            this.BtnAcepta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnAcepta.Location = new System.Drawing.Point(23, 177);
            this.BtnAcepta.Name = "BtnAcepta";
            this.BtnAcepta.Size = new System.Drawing.Size(200, 100);
            this.BtnAcepta.TabIndex = 1;
            this.BtnAcepta.Text = "Acepta";
            this.BtnAcepta.Click += new System.EventHandler(this.BtnAcepta_Click);
            // 
            // BtnRechaza
            // 
            this.BtnRechaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechaza.Location = new System.Drawing.Point(427, 177);
            this.BtnRechaza.Name = "BtnRechaza";
            this.BtnRechaza.Size = new System.Drawing.Size(200, 100);
            this.BtnRechaza.TabIndex = 2;
            this.BtnRechaza.Text = "Rechaza ";
            this.BtnRechaza.Click += new System.EventHandler(this.BtnRechaza_Click);
            // 
            // Lb_Restricciones
            // 
            this.Lb_Restricciones.AutoSize = true;
            this.Lb_Restricciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Restricciones.Location = new System.Drawing.Point(229, 20);
            this.Lb_Restricciones.Name = "Lb_Restricciones";
            this.Lb_Restricciones.Size = new System.Drawing.Size(192, 31);
            this.Lb_Restricciones.TabIndex = 3;
            this.Lb_Restricciones.Text = "Restricciones";
            // 
            // Tb_Restricciones
            // 
            this.Tb_Restricciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Restricciones.Location = new System.Drawing.Point(23, 63);
            this.Tb_Restricciones.Multiline = true;
            this.Tb_Restricciones.Name = "Tb_Restricciones";
            this.Tb_Restricciones.ReadOnly = true;
            this.Tb_Restricciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tb_Restricciones.Size = new System.Drawing.Size(604, 108);
            this.Tb_Restricciones.TabIndex = 4;
            // 
            // Restricciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 300);
            this.Controls.Add(this.Tb_Restricciones);
            this.Controls.Add(this.Lb_Restricciones);
            this.Controls.Add(this.BtnRechaza);
            this.Controls.Add(this.BtnAcepta);
            this.MaximumSize = new System.Drawing.Size(650, 300);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "Restricciones";
            this.Load += new System.EventHandler(this.Restricciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAcepta;
        private System.Windows.Forms.Button BtnRechaza;
        private System.Windows.Forms.Label Lb_Restricciones;
        private System.Windows.Forms.TextBox Tb_Restricciones;
    }
}