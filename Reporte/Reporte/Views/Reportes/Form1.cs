using DevExpress.XtraGrid.Views.Grid;
using Reporte.DATA;
using Reporte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Reporte
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        DAOConn DAOconn = new DAOConn();
        Compras compra = new Compras();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (compra != null)
            {
                List<ComprasDetalle> detalle = DAOconn.GetComprasDetalleById(compra.CompraID);
                if (detalle.Count <= 0)
                    return;

                using (frmPrint frmprint = new frmPrint())
                {
                    txbLog.Text += Environment.NewLine + $"Compra: {compra.CompraID} detalle: {detalle}";
                    frmprint.PrintCompra(compra, detalle);
                    frmprint.ShowDialog();
                }
            }
        }


        private void gridControl_Load(object sender, EventArgs e)
        {
            //Response res = DAOconn.ExecSP("usp_select_compras_all", "hola");

            //if (!res.ExistError)
            //{
            //    gridControl.DataSource = res.dt;
            //} else
            //{
            //    MessageBox.Show($"Existe un error {res.MsgDB}");
            //}            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Compras> compras = new List<Compras>();
            compras = DAOconn.GetComprasByRangeDate(dtDesde.DateTime.Date, dtHasta.DateTime.Date);
            gridControl.DataSource = compras;
            txbLog.Text = "Total de registros recuperados: " + compras.Count.ToString();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (view != null && view.IsValidRowHandle(e.FocusedRowHandle))
            {
                Compras compraSelected = (Compras)view.GetRow(e.PrevFocusedRowHandle);
                if (compraSelected != null)
                {
                    this.compra = compraSelected;
                }
            }
        }

    }
}
