using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Reporte.Views.Layouts;

namespace Reporte
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLayout1_Click(object sender, EventArgs e)
        {
            Views.Layouts.LayoutControl1 layout1 = new Views.Layouts.LayoutControl1();
            layout1.ShowDialog();
        }

        private void btnRibbon_Click(object sender, EventArgs e)
        {
            Ribbon1 ribbon = new Ribbon1();
            ribbon.ShowDialog();
        }

        private void btnReadExcel1_Click(object sender, EventArgs e)
        {
            Views.Excel.ReadExcel1 readExcel1 = new Views.Excel.ReadExcel1();
            readExcel1.ShowDialog();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}