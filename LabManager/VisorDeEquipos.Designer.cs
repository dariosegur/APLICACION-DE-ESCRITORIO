namespace LabManager
{
    partial class VisorDeEquipos
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
            this.visorEquipos = new ControlVisorEquipos.VisorDeEquipos();
            this.SuspendLayout();
            // 
            // visorEquipos
            // 
            this.visorEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visorEquipos.Location = new System.Drawing.Point(23, 63);
            this.visorEquipos.Name = "visorEquipos";
            this.visorEquipos.Size = new System.Drawing.Size(681, 420);
            this.visorEquipos.TabIndex = 0;
            // 
            // VisorDeEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 506);
            this.Controls.Add(this.visorEquipos);
            this.Name = "VisorDeEquipos";
            this.Text = "Visor De Equipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ControlVisorEquipos.VisorDeEquipos visorEquipos;
    }
}