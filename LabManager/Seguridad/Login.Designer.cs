namespace LabManager.Seguridad
{
    partial class Login
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
            this.mbAceptar = new MetroFramework.Controls.MetroButton();
            this.lError = new MetroFramework.Controls.MetroLabel();
            this.ifContra = new LabManager.General.InputFieldText();
            this.ifIdentificacion = new LabManager.General.InputFieldText();
            this.lVersion = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mbAceptar
            // 
            this.mbAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbAceptar.Location = new System.Drawing.Point(152, 296);
            this.mbAceptar.Name = "mbAceptar";
            this.mbAceptar.Size = new System.Drawing.Size(369, 35);
            this.mbAceptar.TabIndex = 2;
            this.mbAceptar.Text = "Aceptar";
            this.mbAceptar.UseSelectable = true;
            this.mbAceptar.Click += new System.EventHandler(this.mbAceptar_Click);
            // 
            // lError
            // 
            this.lError.ForeColor = System.Drawing.Color.Red;
            this.lError.Location = new System.Drawing.Point(152, 262);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(369, 23);
            this.lError.TabIndex = 3;
            this.lError.UseCustomForeColor = true;
            this.lError.UseStyleColors = true;
            // 
            // ifContra
            // 
            this.ifContra.Location = new System.Drawing.Point(152, 167);
            this.ifContra.Margin = new System.Windows.Forms.Padding(6);
            this.ifContra.MaxLength = 50;
            this.ifContra.Multiline = false;
            this.ifContra.Name = "ifContra";
            this.ifContra.PasswordChar = '*';
            this.ifContra.Size = new System.Drawing.Size(369, 85);
            this.ifContra.TabIndex = 1;
            this.ifContra.Titulo = "Contraseña";
            this.ifContra.UseSelectable = true;
            this.ifContra.Valor = "";
            this.ifContra.WaterMark = "Digite la contraseña";
            // 
            // ifIdentificacion
            // 
            this.ifIdentificacion.Location = new System.Drawing.Point(152, 68);
            this.ifIdentificacion.Margin = new System.Windows.Forms.Padding(6);
            this.ifIdentificacion.MaxLength = 50;
            this.ifIdentificacion.Multiline = false;
            this.ifIdentificacion.Name = "ifIdentificacion";
            this.ifIdentificacion.PasswordChar = '\0';
            this.ifIdentificacion.Size = new System.Drawing.Size(369, 87);
            this.ifIdentificacion.TabIndex = 0;
            this.ifIdentificacion.Titulo = "Identificación";
            this.ifIdentificacion.UseSelectable = true;
            this.ifIdentificacion.Valor = "";
            this.ifIdentificacion.WaterMark = "Digite el valor";
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Location = new System.Drawing.Point(2, 325);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(60, 19);
            this.lVersion.TabIndex = 4;
            this.lVersion.Text = "Version...";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(648, 345);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.mbAceptar);
            this.Controls.Add(this.ifContra);
            this.Controls.Add(this.ifIdentificacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(37, 111, 37, 37);
            this.Text = "LabManager II";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private General.InputFieldText ifIdentificacion;
        private General.InputFieldText ifContra;
        private MetroFramework.Controls.MetroButton mbAceptar;
        private MetroFramework.Controls.MetroLabel lError;
        private MetroFramework.Controls.MetroLabel lVersion;
    }
}