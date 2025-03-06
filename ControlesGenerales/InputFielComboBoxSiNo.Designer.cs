namespace LabManager.General
{
    partial class InputFielComboBoxSiNo
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
            this.mControl = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // mControl
            // 
            this.mControl.FormattingEnabled = true;
            this.mControl.ItemHeight = 23;
            this.mControl.Items.AddRange(new object[] {
            "",
            "Si",
            "No"});
            this.mControl.Location = new System.Drawing.Point(3, 22);
            this.mControl.Name = "mControl";
            this.mControl.Size = new System.Drawing.Size(175, 29);
            this.mControl.TabIndex = 2;
            this.mControl.UseSelectable = true;
            // 
            // InputFielComboBoxSiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mControl);
            this.Name = "InputFielComboBoxSiNo";
            this.Size = new System.Drawing.Size(181, 55);
            this.Controls.SetChildIndex(this.mLabel, 0);
            this.Controls.SetChildIndex(this.mControl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mControl;
    }
}
