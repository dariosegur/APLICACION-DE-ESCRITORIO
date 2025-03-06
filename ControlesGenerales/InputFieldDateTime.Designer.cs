namespace LabManager.General
{
    partial class InputFieldDateTime
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
            this.mControl = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // mControl
            // 
            this.mControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mControl.CustomFormat = "yyyy-MM-dd";
            this.mControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mControl.Location = new System.Drawing.Point(3, 22);
            this.mControl.MinimumSize = new System.Drawing.Size(0, 29);
            this.mControl.Name = "mControl";
            this.mControl.Size = new System.Drawing.Size(200, 29);
            this.mControl.TabIndex = 2;
            // 
            // InputFieldDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mControl);
            this.Name = "InputFieldDateTime";
            this.Size = new System.Drawing.Size(211, 54);
            this.Controls.SetChildIndex(this.mLabel, 0);
            this.Controls.SetChildIndex(this.mControl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroDateTime mControl;
    }
}
