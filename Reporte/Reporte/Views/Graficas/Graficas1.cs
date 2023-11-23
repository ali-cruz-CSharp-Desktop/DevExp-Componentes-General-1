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
using System.Data.SqlClient;
using System.Configuration;

namespace Reporte.Views.Graficas
{
    public partial class Graficas1 : DevExpress.XtraEditors.XtraForm
    {
        public Graficas1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Controllers.GraficasController graficasController = new Controllers.GraficasController();

            List<Models.Graficas.Orders> listOrders = new List<Models.Graficas.Orders>();
            listOrders = graficasController.GetTotOrdersByYear();
            dgv1.DataSource = listOrders;
        }
    }
}