namespace MetroUI_Compuesto
{
    partial class Error
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
            this.tbMensaje = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMensaje
            // 
            // 
            // 
            // 
            this.tbMensaje.CustomButton.Image = null;
            this.tbMensaje.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.tbMensaje.CustomButton.Name = "";
            this.tbMensaje.CustomButton.Size = new System.Drawing.Size(153, 153);
            this.tbMensaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMensaje.CustomButton.TabIndex = 1;
            this.tbMensaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMensaje.CustomButton.UseSelectable = true;
            this.tbMensaje.CustomButton.Visible = false;
            this.tbMensaje.Enabled = false;
            this.tbMensaje.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbMensaje.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbMensaje.Lines = new string[0];
            this.tbMensaje.Location = new System.Drawing.Point(23, 98);
            this.tbMensaje.MaxLength = 32767;
            this.tbMensaje.Multiline = true;
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.PasswordChar = '\0';
            this.tbMensaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMensaje.SelectedText = "";
            this.tbMensaje.SelectionLength = 0;
            this.tbMensaje.SelectionStart = 0;
            this.tbMensaje.ShortcutsEnabled = true;
            this.tbMensaje.Size = new System.Drawing.Size(415, 158);
            this.tbMensaje.TabIndex = 0;
            this.tbMensaje.UseSelectable = true;
            this.tbMensaje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMensaje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MetroUI_Compuesto.Properties.Resources.ERROR;
            this.pictureBox1.Location = new System.Drawing.Point(371, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(23, 262);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(415, 36);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 321);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbMensaje);
            this.Name = "Error";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnOk;
        public MetroFramework.Controls.MetroTextBox tbMensaje;
    }
}