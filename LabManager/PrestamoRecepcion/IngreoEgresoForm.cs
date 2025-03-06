﻿using LabManagerCliente.PrestamoRecepcionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager.PrestamoRecepcion
{
    public partial class IngresoEgresoForm : MetroFramework.Forms.MetroForm
    {
        public View_EquiposACargo equipo {
            set {
                tbTipoEquipo.Text = value.TipoEquipo;
                tbCodigoLab.Text= value.CodigoLaboratorio;
                pbEntra.Visible = !value.Prestado;
                pbSale.Visible = value.Prestado;
            }
        }
        public IngresoEgresoForm()
        {
            InitializeComponent();
        }

        private void IngreoEgresoForm_Load(object sender, EventArgs e)
        {
            try
            {
                var timeToShow = ConfigurationManager.AppSettings["TiempoRealimentacion"];
                Timer t = new Timer();
                t.Interval = int.Parse(timeToShow);
                t.Tick += T_Tick;
                t.Enabled = true;
                this.TopMost = true;
            }
            catch (Exception ex)
            {
                Mensaje.Error("IngreoEgresoForm_Load", ex.Message);
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
