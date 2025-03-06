namespace LabManager
{
    partial class Vprincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vprincipal));
            this.SpCn_Usuario = new System.Windows.Forms.SplitContainer();
            this.Gb_Usuario = new System.Windows.Forms.GroupBox();
            this.Pn_AnotacionesMultas = new System.Windows.Forms.Panel();
            this.Lb_Anotaciones = new System.Windows.Forms.Label();
            this.Tb_Anotaciones = new System.Windows.Forms.TextBox();
            this.Tb_Multas = new System.Windows.Forms.TextBox();
            this.Lb_Multas = new System.Windows.Forms.Label();
            this.Btn_Ok_Cod_usuario = new System.Windows.Forms.Button();
            this.Lb_Facultad = new System.Windows.Forms.Label();
            this.Lb_Codigo_usuario = new System.Windows.Forms.Label();
            this.Lb_Apellidos = new System.Windows.Forms.Label();
            this.Lb_Nombres = new System.Windows.Forms.Label();
            this.Tb_Facultad = new System.Windows.Forms.Label();
            this.Tb_Codigo_usuario = new System.Windows.Forms.TextBox();
            this.Tb_Apellidos = new System.Windows.Forms.Label();
            this.Tb_Nombres = new System.Windows.Forms.Label();
            this.SpCn_EquiposInformacion = new System.Windows.Forms.SplitContainer();
            this.Gb_Equipos = new System.Windows.Forms.GroupBox();
            this.DataGV_Equipos = new System.Windows.Forms.DataGridView();
            this.Clm_TipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_CodigoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gb_Informacion = new System.Windows.Forms.GroupBox();
            this.Pn_informacion = new System.Windows.Forms.Panel();
            this.lAuxilliar = new System.Windows.Forms.Label();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.iconos = new System.Windows.Forms.ImageList(this.components);
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.Btn_Nequipos = new System.Windows.Forms.Button();
            this.Lb_Codigo_equipo = new System.Windows.Forms.Label();
            this.Tb_Codigo_equipo = new System.Windows.Forms.TextBox();
            this.Btn_Ok_Cod_Equipo = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Visor_equipos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpCn_Usuario)).BeginInit();
            this.SpCn_Usuario.Panel1.SuspendLayout();
            this.SpCn_Usuario.Panel2.SuspendLayout();
            this.SpCn_Usuario.SuspendLayout();
            this.Gb_Usuario.SuspendLayout();
            this.Pn_AnotacionesMultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpCn_EquiposInformacion)).BeginInit();
            this.SpCn_EquiposInformacion.Panel1.SuspendLayout();
            this.SpCn_EquiposInformacion.Panel2.SuspendLayout();
            this.SpCn_EquiposInformacion.SuspendLayout();
            this.Gb_Equipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV_Equipos)).BeginInit();
            this.Gb_Informacion.SuspendLayout();
            this.Pn_informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpCn_Usuario
            // 
            this.SpCn_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpCn_Usuario.Location = new System.Drawing.Point(6, 5);
            this.SpCn_Usuario.Margin = new System.Windows.Forms.Padding(9);
            this.SpCn_Usuario.Name = "SpCn_Usuario";
            // 
            // SpCn_Usuario.Panel1
            // 
            this.SpCn_Usuario.Panel1.Controls.Add(this.Gb_Usuario);
            // 
            // SpCn_Usuario.Panel2
            // 
            this.SpCn_Usuario.Panel2.Controls.Add(this.SpCn_EquiposInformacion);
            this.SpCn_Usuario.Size = new System.Drawing.Size(1340, 720);
            this.SpCn_Usuario.SplitterDistance = 443;
            this.SpCn_Usuario.SplitterWidth = 15;
            this.SpCn_Usuario.TabIndex = 4;
            // 
            // Gb_Usuario
            // 
            this.Gb_Usuario.Controls.Add(this.Pn_AnotacionesMultas);
            this.Gb_Usuario.Controls.Add(this.Btn_Ok_Cod_usuario);
            this.Gb_Usuario.Controls.Add(this.Lb_Facultad);
            this.Gb_Usuario.Controls.Add(this.Lb_Codigo_usuario);
            this.Gb_Usuario.Controls.Add(this.Lb_Apellidos);
            this.Gb_Usuario.Controls.Add(this.Lb_Nombres);
            this.Gb_Usuario.Controls.Add(this.Tb_Facultad);
            this.Gb_Usuario.Controls.Add(this.Tb_Codigo_usuario);
            this.Gb_Usuario.Controls.Add(this.Tb_Apellidos);
            this.Gb_Usuario.Controls.Add(this.Tb_Nombres);
            this.Gb_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gb_Usuario.Location = new System.Drawing.Point(0, 0);
            this.Gb_Usuario.Margin = new System.Windows.Forms.Padding(9);
            this.Gb_Usuario.Name = "Gb_Usuario";
            this.Gb_Usuario.Padding = new System.Windows.Forms.Padding(9);
            this.Gb_Usuario.Size = new System.Drawing.Size(443, 720);
            this.Gb_Usuario.TabIndex = 0;
            this.Gb_Usuario.TabStop = false;
            this.Gb_Usuario.Text = "Usuario";
            // 
            // Pn_AnotacionesMultas
            // 
            this.Pn_AnotacionesMultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pn_AnotacionesMultas.AutoScroll = true;
            this.Pn_AnotacionesMultas.Controls.Add(this.Lb_Anotaciones);
            this.Pn_AnotacionesMultas.Controls.Add(this.Tb_Anotaciones);
            this.Pn_AnotacionesMultas.Controls.Add(this.Tb_Multas);
            this.Pn_AnotacionesMultas.Controls.Add(this.Lb_Multas);
            this.Pn_AnotacionesMultas.Location = new System.Drawing.Point(12, 483);
            this.Pn_AnotacionesMultas.Name = "Pn_AnotacionesMultas";
            this.Pn_AnotacionesMultas.Size = new System.Drawing.Size(423, 226);
            this.Pn_AnotacionesMultas.TabIndex = 26;
            // 
            // Lb_Anotaciones
            // 
            this.Lb_Anotaciones.AutoSize = true;
            this.Lb_Anotaciones.Location = new System.Drawing.Point(6, 204);
            this.Lb_Anotaciones.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Lb_Anotaciones.Name = "Lb_Anotaciones";
            this.Lb_Anotaciones.Size = new System.Drawing.Size(208, 39);
            this.Lb_Anotaciones.TabIndex = 20;
            this.Lb_Anotaciones.Text = "Anotaciones";
            // 
            // Tb_Anotaciones
            // 
            this.Tb_Anotaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Anotaciones.BackColor = System.Drawing.Color.White;
            this.Tb_Anotaciones.Location = new System.Drawing.Point(6, 252);
            this.Tb_Anotaciones.Margin = new System.Windows.Forms.Padding(9);
            this.Tb_Anotaciones.Multiline = true;
            this.Tb_Anotaciones.Name = "Tb_Anotaciones";
            this.Tb_Anotaciones.ReadOnly = true;
            this.Tb_Anotaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Anotaciones.Size = new System.Drawing.Size(306, 140);
            this.Tb_Anotaciones.TabIndex = 18;
            // 
            // Tb_Multas
            // 
            this.Tb_Multas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Multas.BackColor = System.Drawing.Color.White;
            this.Tb_Multas.Location = new System.Drawing.Point(11, 55);
            this.Tb_Multas.Margin = new System.Windows.Forms.Padding(9);
            this.Tb_Multas.Multiline = true;
            this.Tb_Multas.Name = "Tb_Multas";
            this.Tb_Multas.ReadOnly = true;
            this.Tb_Multas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Multas.Size = new System.Drawing.Size(301, 140);
            this.Tb_Multas.TabIndex = 19;
            // 
            // Lb_Multas
            // 
            this.Lb_Multas.AutoSize = true;
            this.Lb_Multas.Location = new System.Drawing.Point(11, 7);
            this.Lb_Multas.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Lb_Multas.Name = "Lb_Multas";
            this.Lb_Multas.Size = new System.Drawing.Size(120, 39);
            this.Lb_Multas.TabIndex = 17;
            this.Lb_Multas.Text = "Multas";
            // 
            // Btn_Ok_Cod_usuario
            // 
            this.Btn_Ok_Cod_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ok_Cod_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Ok_Cod_usuario.Location = new System.Drawing.Point(307, 294);
            this.Btn_Ok_Cod_usuario.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Ok_Cod_usuario.Name = "Btn_Ok_Cod_usuario";
            this.Btn_Ok_Cod_usuario.Size = new System.Drawing.Size(122, 67);
            this.Btn_Ok_Cod_usuario.TabIndex = 20;
            this.Btn_Ok_Cod_usuario.Text = "Ok";
            this.Btn_Ok_Cod_usuario.UseVisualStyleBackColor = false;
            this.Btn_Ok_Cod_usuario.Click += new System.EventHandler(this.Btn_Ok_Cod_usuario_Click);
            // 
            // Lb_Facultad
            // 
            this.Lb_Facultad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Facultad.AutoSize = true;
            this.Lb_Facultad.Location = new System.Drawing.Point(18, 358);
            this.Lb_Facultad.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Lb_Facultad.Name = "Lb_Facultad";
            this.Lb_Facultad.Size = new System.Drawing.Size(150, 39);
            this.Lb_Facultad.TabIndex = 25;
            this.Lb_Facultad.Text = "Facultad";
            // 
            // Lb_Codigo_usuario
            // 
            this.Lb_Codigo_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Codigo_usuario.AutoSize = true;
            this.Lb_Codigo_usuario.Location = new System.Drawing.Point(18, 257);
            this.Lb_Codigo_usuario.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Lb_Codigo_usuario.Name = "Lb_Codigo_usuario";
            this.Lb_Codigo_usuario.Size = new System.Drawing.Size(126, 39);
            this.Lb_Codigo_usuario.TabIndex = 24;
            this.Lb_Codigo_usuario.Text = "Código";
            // 
            // Lb_Apellidos
            // 
            this.Lb_Apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Apellidos.AutoSize = true;
            this.Lb_Apellidos.Location = new System.Drawing.Point(18, 153);
            this.Lb_Apellidos.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Lb_Apellidos.Name = "Lb_Apellidos";
            this.Lb_Apellidos.Size = new System.Drawing.Size(158, 39);
            this.Lb_Apellidos.TabIndex = 23;
            this.Lb_Apellidos.Text = "Apellidos";
            // 
            // Lb_Nombres
            // 
            this.Lb_Nombres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Nombres.AutoSize = true;
            this.Lb_Nombres.Location = new System.Drawing.Point(18, 49);
            this.Lb_Nombres.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Lb_Nombres.Name = "Lb_Nombres";
            this.Lb_Nombres.Size = new System.Drawing.Size(159, 39);
            this.Lb_Nombres.TabIndex = 22;
            this.Lb_Nombres.Text = "Nombres";
            // 
            // Tb_Facultad
            // 
            this.Tb_Facultad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Facultad.BackColor = System.Drawing.Color.White;
            this.Tb_Facultad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Facultad.Location = new System.Drawing.Point(18, 406);
            this.Tb_Facultad.Margin = new System.Windows.Forms.Padding(9);
            this.Tb_Facultad.Name = "Tb_Facultad";
            this.Tb_Facultad.Size = new System.Drawing.Size(411, 47);
            this.Tb_Facultad.TabIndex = 21;
            // 
            // Tb_Codigo_usuario
            // 
            this.Tb_Codigo_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Codigo_usuario.Location = new System.Drawing.Point(25, 305);
            this.Tb_Codigo_usuario.Margin = new System.Windows.Forms.Padding(9);
            this.Tb_Codigo_usuario.Name = "Tb_Codigo_usuario";
            this.Tb_Codigo_usuario.Size = new System.Drawing.Size(264, 47);
            this.Tb_Codigo_usuario.TabIndex = 19;
            this.Tb_Codigo_usuario.Enter += new System.EventHandler(this.Tb_Codigo_usuario_Enter);
            this.Tb_Codigo_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_Codigo_usuario_KeyDown);
            // 
            // Tb_Apellidos
            // 
            this.Tb_Apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Apellidos.BackColor = System.Drawing.Color.White;
            this.Tb_Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Apellidos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Tb_Apellidos.Location = new System.Drawing.Point(25, 201);
            this.Tb_Apellidos.Margin = new System.Windows.Forms.Padding(9);
            this.Tb_Apellidos.Name = "Tb_Apellidos";
            this.Tb_Apellidos.Size = new System.Drawing.Size(404, 47);
            this.Tb_Apellidos.TabIndex = 18;
            // 
            // Tb_Nombres
            // 
            this.Tb_Nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Nombres.BackColor = System.Drawing.Color.White;
            this.Tb_Nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Nombres.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Tb_Nombres.Location = new System.Drawing.Point(25, 97);
            this.Tb_Nombres.Margin = new System.Windows.Forms.Padding(9);
            this.Tb_Nombres.Name = "Tb_Nombres";
            this.Tb_Nombres.Size = new System.Drawing.Size(404, 47);
            this.Tb_Nombres.TabIndex = 17;
            // 
            // SpCn_EquiposInformacion
            // 
            this.SpCn_EquiposInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpCn_EquiposInformacion.Location = new System.Drawing.Point(0, 0);
            this.SpCn_EquiposInformacion.Margin = new System.Windows.Forms.Padding(9);
            this.SpCn_EquiposInformacion.Name = "SpCn_EquiposInformacion";
            this.SpCn_EquiposInformacion.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpCn_EquiposInformacion.Panel1
            // 
            this.SpCn_EquiposInformacion.Panel1.Controls.Add(this.Gb_Equipos);
            // 
            // SpCn_EquiposInformacion.Panel2
            // 
            this.SpCn_EquiposInformacion.Panel2.Controls.Add(this.Gb_Informacion);
            this.SpCn_EquiposInformacion.Size = new System.Drawing.Size(882, 720);
            this.SpCn_EquiposInformacion.SplitterDistance = 425;
            this.SpCn_EquiposInformacion.SplitterWidth = 15;
            this.SpCn_EquiposInformacion.TabIndex = 0;
            // 
            // Gb_Equipos
            // 
            this.Gb_Equipos.Controls.Add(this.DataGV_Equipos);
            this.Gb_Equipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gb_Equipos.Location = new System.Drawing.Point(0, 0);
            this.Gb_Equipos.Margin = new System.Windows.Forms.Padding(9);
            this.Gb_Equipos.Name = "Gb_Equipos";
            this.Gb_Equipos.Padding = new System.Windows.Forms.Padding(9);
            this.Gb_Equipos.Size = new System.Drawing.Size(882, 425);
            this.Gb_Equipos.TabIndex = 1;
            this.Gb_Equipos.TabStop = false;
            this.Gb_Equipos.Text = "Equipos";
            this.Gb_Equipos.Enter += new System.EventHandler(this.Gb_Equipos_Enter);
            // 
            // DataGV_Equipos
            // 
            this.DataGV_Equipos.AllowUserToAddRows = false;
            this.DataGV_Equipos.AllowUserToDeleteRows = false;
            this.DataGV_Equipos.AllowUserToOrderColumns = true;
            this.DataGV_Equipos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGV_Equipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGV_Equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV_Equipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_TipoEquipo,
            this.Clm_CodigoEquipo});
            this.DataGV_Equipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV_Equipos.EnableHeadersVisualStyles = false;
            this.DataGV_Equipos.Location = new System.Drawing.Point(9, 49);
            this.DataGV_Equipos.Margin = new System.Windows.Forms.Padding(9);
            this.DataGV_Equipos.Name = "DataGV_Equipos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGV_Equipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGV_Equipos.RowHeadersVisible = false;
            this.DataGV_Equipos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGV_Equipos.Size = new System.Drawing.Size(864, 367);
            this.DataGV_Equipos.TabIndex = 0;
            this.DataGV_Equipos.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGV_Equipos_ColumnWidthChanged);
            this.DataGV_Equipos.Resize += new System.EventHandler(this.DataGV_Equipos_Resize);
            // 
            // Clm_TipoEquipo
            // 
            this.Clm_TipoEquipo.Frozen = true;
            this.Clm_TipoEquipo.HeaderText = "Descripción del equipo";
            this.Clm_TipoEquipo.Name = "Clm_TipoEquipo";
            this.Clm_TipoEquipo.ReadOnly = true;
            this.Clm_TipoEquipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Clm_TipoEquipo.Width = 185;
            // 
            // Clm_CodigoEquipo
            // 
            this.Clm_CodigoEquipo.Frozen = true;
            this.Clm_CodigoEquipo.HeaderText = "Código del equipo";
            this.Clm_CodigoEquipo.Name = "Clm_CodigoEquipo";
            this.Clm_CodigoEquipo.ReadOnly = true;
            this.Clm_CodigoEquipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Clm_CodigoEquipo.Width = 216;
            // 
            // Gb_Informacion
            // 
            this.Gb_Informacion.Controls.Add(this.Pn_informacion);
            this.Gb_Informacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gb_Informacion.Location = new System.Drawing.Point(0, 0);
            this.Gb_Informacion.Margin = new System.Windows.Forms.Padding(9);
            this.Gb_Informacion.Name = "Gb_Informacion";
            this.Gb_Informacion.Padding = new System.Windows.Forms.Padding(9);
            this.Gb_Informacion.Size = new System.Drawing.Size(882, 280);
            this.Gb_Informacion.TabIndex = 6;
            this.Gb_Informacion.TabStop = false;
            this.Gb_Informacion.Text = "Información";
            // 
            // Pn_informacion
            // 
            this.Pn_informacion.AutoScroll = true;
            this.Pn_informacion.BackColor = System.Drawing.Color.White;
            this.Pn_informacion.Controls.Add(this.lAuxilliar);
            this.Pn_informacion.Controls.Add(this.btnAcercaDe);
            this.Pn_informacion.Controls.Add(this.btnAdministrar);
            this.Pn_informacion.Controls.Add(this.Btn_Nequipos);
            this.Pn_informacion.Controls.Add(this.Lb_Codigo_equipo);
            this.Pn_informacion.Controls.Add(this.Tb_Codigo_equipo);
            this.Pn_informacion.Controls.Add(this.Btn_Ok_Cod_Equipo);
            this.Pn_informacion.Controls.Add(this.Btn_Salir);
            this.Pn_informacion.Controls.Add(this.Btn_Visor_equipos);
            this.Pn_informacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_informacion.Location = new System.Drawing.Point(9, 49);
            this.Pn_informacion.Margin = new System.Windows.Forms.Padding(4);
            this.Pn_informacion.Name = "Pn_informacion";
            this.Pn_informacion.Size = new System.Drawing.Size(864, 222);
            this.Pn_informacion.TabIndex = 0;
            // 
            // lAuxilliar
            // 
            this.lAuxilliar.AutoSize = true;
            this.lAuxilliar.Location = new System.Drawing.Point(7, 176);
            this.lAuxilliar.Name = "lAuxilliar";
            this.lAuxilliar.Size = new System.Drawing.Size(0, 39);
            this.lAuxilliar.TabIndex = 31;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.White;
            this.btnAcercaDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.ImageIndex = 3;
            this.btnAcercaDe.ImageList = this.iconos;
            this.btnAcercaDe.Location = new System.Drawing.Point(855, 108);
            this.btnAcercaDe.Margin = new System.Windows.Forms.Padding(9);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(84, 53);
            this.btnAcercaDe.TabIndex = 30;
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // iconos
            // 
            this.iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconos.ImageStream")));
            this.iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconos.Images.SetKeyName(0, "Delete-512.png");
            this.iconos.Images.SetKeyName(1, "Contacts-512.png");
            this.iconos.Images.SetKeyName(2, "Accounting-96.png");
            this.iconos.Images.SetKeyName(3, "About-512.png");
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.BackColor = System.Drawing.Color.White;
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.ImageIndex = 1;
            this.btnAdministrar.ImageList = this.iconos;
            this.btnAdministrar.Location = new System.Drawing.Point(475, 108);
            this.btnAdministrar.Margin = new System.Windows.Forms.Padding(9);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(206, 53);
            this.btnAdministrar.TabIndex = 29;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrar.UseVisualStyleBackColor = false;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // Btn_Nequipos
            // 
            this.Btn_Nequipos.BackColor = System.Drawing.Color.White;
            this.Btn_Nequipos.Enabled = false;
            this.Btn_Nequipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nequipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nequipos.Location = new System.Drawing.Point(14, 108);
            this.Btn_Nequipos.Name = "Btn_Nequipos";
            this.Btn_Nequipos.Size = new System.Drawing.Size(158, 53);
            this.Btn_Nequipos.TabIndex = 28;
            this.Btn_Nequipos.UseVisualStyleBackColor = false;
            this.Btn_Nequipos.Click += new System.EventHandler(this.Btn_Nequipos_Click);
            // 
            // Lb_Codigo_equipo
            // 
            this.Lb_Codigo_equipo.AutoSize = true;
            this.Lb_Codigo_equipo.Location = new System.Drawing.Point(7, 1);
            this.Lb_Codigo_equipo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Lb_Codigo_equipo.Name = "Lb_Codigo_equipo";
            this.Lb_Codigo_equipo.Size = new System.Drawing.Size(293, 39);
            this.Lb_Codigo_equipo.TabIndex = 27;
            this.Lb_Codigo_equipo.Text = "Codigo del equipo";
            // 
            // Tb_Codigo_equipo
            // 
            this.Tb_Codigo_equipo.BackColor = System.Drawing.Color.White;
            this.Tb_Codigo_equipo.Location = new System.Drawing.Point(14, 49);
            this.Tb_Codigo_equipo.Margin = new System.Windows.Forms.Padding(9);
            this.Tb_Codigo_equipo.Name = "Tb_Codigo_equipo";
            this.Tb_Codigo_equipo.Size = new System.Drawing.Size(667, 47);
            this.Tb_Codigo_equipo.TabIndex = 25;
            this.Tb_Codigo_equipo.Enter += new System.EventHandler(this.Tb_Codigo_equipo_Enter);
            this.Tb_Codigo_equipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_Codigo_equipo_KeyDown);
            // 
            // Btn_Ok_Cod_Equipo
            // 
            this.Btn_Ok_Cod_Equipo.BackColor = System.Drawing.Color.White;
            this.Btn_Ok_Cod_Equipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ok_Cod_Equipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Ok_Cod_Equipo.Location = new System.Drawing.Point(699, 49);
            this.Btn_Ok_Cod_Equipo.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Ok_Cod_Equipo.Name = "Btn_Ok_Cod_Equipo";
            this.Btn_Ok_Cod_Equipo.Size = new System.Drawing.Size(240, 47);
            this.Btn_Ok_Cod_Equipo.TabIndex = 26;
            this.Btn_Ok_Cod_Equipo.Text = "Ok";
            this.Btn_Ok_Cod_Equipo.UseVisualStyleBackColor = false;
            this.Btn_Ok_Cod_Equipo.Click += new System.EventHandler(this.Btn_Ok_Cod_Equipo_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.White;
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.ImageIndex = 0;
            this.Btn_Salir.ImageList = this.iconos;
            this.Btn_Salir.Location = new System.Drawing.Point(699, 108);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(138, 53);
            this.Btn_Salir.TabIndex = 24;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Visor_equipos
            // 
            this.Btn_Visor_equipos.BackColor = System.Drawing.Color.White;
            this.Btn_Visor_equipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Visor_equipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Visor_equipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Visor_equipos.ImageIndex = 2;
            this.Btn_Visor_equipos.ImageList = this.iconos;
            this.Btn_Visor_equipos.Location = new System.Drawing.Point(184, 108);
            this.Btn_Visor_equipos.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Visor_equipos.Name = "Btn_Visor_equipos";
            this.Btn_Visor_equipos.Size = new System.Drawing.Size(273, 53);
            this.Btn_Visor_equipos.TabIndex = 23;
            this.Btn_Visor_equipos.Text = "Visor de equipos";
            this.Btn_Visor_equipos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Visor_equipos.UseVisualStyleBackColor = false;
            this.Btn_Visor_equipos.Click += new System.EventHandler(this.Btn_Visor_equipos_Click);
            // 
            // Vprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.SpCn_Usuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vprincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vprincipal_FormClosing);
            this.Load += new System.EventHandler(this.Vprincipal_Load);
            this.SpCn_Usuario.Panel1.ResumeLayout(false);
            this.SpCn_Usuario.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpCn_Usuario)).EndInit();
            this.SpCn_Usuario.ResumeLayout(false);
            this.Gb_Usuario.ResumeLayout(false);
            this.Gb_Usuario.PerformLayout();
            this.Pn_AnotacionesMultas.ResumeLayout(false);
            this.Pn_AnotacionesMultas.PerformLayout();
            this.SpCn_EquiposInformacion.Panel1.ResumeLayout(false);
            this.SpCn_EquiposInformacion.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpCn_EquiposInformacion)).EndInit();
            this.SpCn_EquiposInformacion.ResumeLayout(false);
            this.Gb_Equipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV_Equipos)).EndInit();
            this.Gb_Informacion.ResumeLayout(false);
            this.Pn_informacion.ResumeLayout(false);
            this.Pn_informacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpCn_Usuario;
        private System.Windows.Forms.SplitContainer SpCn_EquiposInformacion;
        private System.Windows.Forms.GroupBox Gb_Equipos;
        private System.Windows.Forms.DataGridView DataGV_Equipos;
        private System.Windows.Forms.GroupBox Gb_Usuario;
        private System.Windows.Forms.GroupBox Gb_Informacion;
        private System.Windows.Forms.Panel Pn_informacion;
        private System.Windows.Forms.Label Lb_Codigo_equipo;
        private System.Windows.Forms.TextBox Tb_Codigo_equipo;
        private System.Windows.Forms.Button Btn_Ok_Cod_Equipo;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Visor_equipos;
        private System.Windows.Forms.Button Btn_Nequipos;
        private System.Windows.Forms.Button Btn_Ok_Cod_usuario;
        private System.Windows.Forms.Label Lb_Facultad;
        private System.Windows.Forms.Label Lb_Codigo_usuario;
        private System.Windows.Forms.Label Lb_Apellidos;
        private System.Windows.Forms.Label Lb_Nombres;
        private System.Windows.Forms.Label Tb_Facultad;
        private System.Windows.Forms.TextBox Tb_Codigo_usuario;
        private System.Windows.Forms.Label Tb_Apellidos;
        private System.Windows.Forms.Label Tb_Nombres;
        private System.Windows.Forms.Panel Pn_AnotacionesMultas;
        private System.Windows.Forms.TextBox Tb_Multas;
        private System.Windows.Forms.Label Lb_Anotaciones;
        private System.Windows.Forms.Label Lb_Multas;
        private System.Windows.Forms.TextBox Tb_Anotaciones;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.ImageList iconos;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_TipoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_CodigoEquipo;
        private System.Windows.Forms.Label lAuxilliar;
    }
}

