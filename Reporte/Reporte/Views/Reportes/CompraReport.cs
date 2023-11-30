using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Reporte
{
    public partial class CompraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CompraReport()
        {
            InitializeComponent();
        }

        public void InitData(string compraid, DateTime compradate, string cliente, string direccion, string codigopostal, 
            string ciudad, string telefono, List<ComprasDetalle> data)
        {
            pCiudad.Value = ciudad;
            pCodigoPostal.Value = codigopostal;
            pCompraID.Value = compraid;
            pDate.Value = compradate.Date;
            pDireccion.Value = direccion;
            pNombreCliente.Value = cliente;
            pTelefono.Value = telefono;

            objectDataSource1.DataSource = data;
        }

    }
}
