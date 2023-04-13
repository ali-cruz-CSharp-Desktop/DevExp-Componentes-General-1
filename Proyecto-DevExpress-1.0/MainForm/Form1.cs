using MainForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1Empleados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        private void barButtonItem1Cerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void BBtnEmpleados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EmpleadosForm formEmpleado = new EmpleadosForm();
            formEmpleado.MdiParent = this;
            formEmpleado.Show();
        }

        private void BBtnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clientes clientesForm = new Clientes();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
