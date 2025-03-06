namespace LabManager
{
    partial class EsperaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsperaForm));
            this.pbEspera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEspera)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEspera
            // 
            this.pbEspera.BackColor = System.Drawing.Color.Transparent;
            this.pbEspera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEspera.Image = ((System.Drawing.Image)(resources.GetObject("pbEspera.Image")));
            this.pbEspera.Location = new System.Drawing.Point(0, 0);
            this.pbEspera.Name = "pbEspera";
            this.pbEspera.Size = new System.Drawing.Size(284, 261);
            this.pbEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEspera.TabIndex = 0;
            this.pbEspera.TabStop = false;
            // 
            // EsperaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbEspera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EsperaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EsperaForm";
            this.Load += new System.EventHandler(this.EsperaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEspera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEspera;
    }
}