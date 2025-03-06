namespace LabManager.General
{
    partial class InputFieldInteger
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
            this.mControl = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mControl
            // 
            this.mControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mControl.CustomButton.Image = null;
            this.mControl.CustomButton.Location = new System.Drawing.Point(143, 2);
            this.mControl.CustomButton.Name = "";
            this.mControl.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.mControl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mControl.CustomButton.TabIndex = 1;
            this.mControl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mControl.CustomButton.UseSelectable = true;
            this.mControl.CustomButton.Visible = false;
            this.mControl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mControl.Lines = new string[0];
            this.mControl.Location = new System.Drawing.Point(3, 22);
            this.mControl.MaxLength = 32767;
            this.mControl.Name = "mControl";
            this.mControl.PasswordChar = '\0';
            this.mControl.WaterMark = "Digite el valor";
            this.mControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mControl.SelectedText = "";
            this.mControl.SelectionLength = 0;
            this.mControl.SelectionStart = 0;
            this.mControl.ShortcutsEnabled = true;
            this.mControl.Size = new System.Drawing.Size(175, 34);
            this.mControl.TabIndex = 2;
            this.mControl.UseSelectable = true;
            this.mControl.WaterMark = "Digite el valor";
            this.mControl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mControl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mControl_KeyPress);
            // 
            // InputFieldInteger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mControl);
            this.Name = "InputFieldInteger";
            this.Size = new System.Drawing.Size(181, 60);
            this.Controls.SetChildIndex(this.mControl, 0);
            this.Controls.SetChildIndex(this.mLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox mControl;
    }
}
