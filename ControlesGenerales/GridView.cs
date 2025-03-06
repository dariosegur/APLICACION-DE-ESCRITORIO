using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManager.General
{
    public partial class GridView : MetroFramework.Controls.MetroGrid
    {

        public GridView()
        {
            InitializeComponent();
            ColumnHeadersDefaultCellStyle.Font=
               new System.Drawing.Font("Segoe UI", 14.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }

        public void SetVisibleColumns(string[] columnas)
        {
            for (int i = 0; i < this.Columns.Count; i++)
            {
                this.Columns[i].Visible = false;
            }

            for (int i = 0; i < columnas.Length; i++)
            {
                this.Columns[columnas[i]].Visible = true;
                this.Columns[columnas[i]].DisplayIndex = i;
                ColumnHeadersDefaultCellStyle.Font =
                  new System.Drawing.Font("Segoe UI", 14.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }
        }

    }
}
