namespace LabManager
{
    partial class InformacionRegistro
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreadoPor = new LabManager.General.InputFieldText();
            this.ModificadoPor = new LabManager.General.InputFieldText();
            this.FechaCreado = new LabManager.General.InputFieldDateTime();
            this.FechaModificado = new LabManager.General.InputFieldDateTime();
            this.SuspendLayout();
            // 
            // CreadoPor
            // 
            this.CreadoPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreadoPor.Enabled = false;
            this.CreadoPor.Location = new System.Drawing.Point(0, 3);
            this.CreadoPor.Multiline = false;
            this.CreadoPor.Name = "CreadoPor";
            this.CreadoPor.PasswordChar = '\0';
            this.CreadoPor.Size = new System.Drawing.Size(177, 60);
            this.CreadoPor.TabIndex = 17;
            this.CreadoPor.Titulo = "Creado por";
            this.CreadoPor.UseSelectable = true;
            this.CreadoPor.Valor = "";
            this.CreadoPor.WaterMark = "";
            // 
            // ModificadoPor
            // 
            this.ModificadoPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModificadoPor.Enabled = false;
            this.ModificadoPor.Location = new System.Drawing.Point(3, 134);
            this.ModificadoPor.Multiline = false;
            this.ModificadoPor.Name = "ModificadoPor";
            this.ModificadoPor.PasswordChar = '\0';
            this.ModificadoPor.Size = new System.Drawing.Size(177, 60);
            this.ModificadoPor.TabIndex = 16;
            this.ModificadoPor.Titulo = "Modificado por";
            this.ModificadoPor.UseSelectable = true;
            this.ModificadoPor.Valor = "";
            this.ModificadoPor.WaterMark = "";
            // 
            // FechaCreado
            // 
            this.FechaCreado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaCreado.Enabled = false;
            this.FechaCreado.Location = new System.Drawing.Point(0, 69);
            this.FechaCreado.Name = "FechaCreado";
            this.FechaCreado.Size = new System.Drawing.Size(177, 59);
            this.FechaCreado.TabIndex = 15;
            this.FechaCreado.Titulo = "Fecha de creación";
            this.FechaCreado.UseSelectable = true;
            this.FechaCreado.Valor = new System.DateTime(2016, 11, 25, 0, 22, 37, 65);
            // 
            // FechaModificado
            // 
            this.FechaModificado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaModificado.Enabled = false;
            this.FechaModificado.Location = new System.Drawing.Point(0, 200);
            this.FechaModificado.Name = "FechaModificado";
            this.FechaModificado.Size = new System.Drawing.Size(177, 59);
            this.FechaModificado.TabIndex = 14;
            this.FechaModificado.Titulo = "Fecha de modificación";
            this.FechaModificado.UseSelectable = true;
            this.FechaModificado.Valor = new System.DateTime(2016, 11, 25, 0, 22, 37, 88);
            // 
            // InformacionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CreadoPor);
            this.Controls.Add(this.ModificadoPor);
            this.Controls.Add(this.FechaCreado);
            this.Controls.Add(this.FechaModificado);
            this.Name = "InformacionRegistro";
            this.Size = new System.Drawing.Size(179, 268);
            this.ResumeLayout(false);

        }

        #endregion

        public General.InputFieldText CreadoPor;
        public General.InputFieldText ModificadoPor;
        public General.InputFieldDateTime FechaCreado;
        public General.InputFieldDateTime FechaModificado;
    }
}
