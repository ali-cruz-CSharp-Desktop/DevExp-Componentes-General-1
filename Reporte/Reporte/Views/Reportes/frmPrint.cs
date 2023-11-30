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

namespace Reporte
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }


        public void PrintCompra(Compras compras, List<ComprasDetalle> data)
        {
            CompraReport reporte = new CompraReport();

            foreach (DevExpress.XtraReports.Parameters.Parameter p in reporte.Parameters)
            {
                p.Visible = false;
            }
                reporte.InitData(compras.CompraID.ToString(), compras.FechaCompra, compras.NombreContacto, 
                    compras.Direccion, compras.CodigoPostal, compras.Ciudad, compras.Telefono, data);
                documentViewer1.DocumentSource = reporte;
                reporte.CreateDocument();
        }



    }
}