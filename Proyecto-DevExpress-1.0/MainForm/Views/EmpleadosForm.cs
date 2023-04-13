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
using MainForm.Controllers;
using MainForm.Models;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MainForm.Views
{
    public partial class EmpleadosForm : DevExpress.XtraEditors.XtraForm
    {
        public EmpleadosForm()
        {
            InitializeComponent();
            FillGVUsers();
        }

        private void simpleButton1Imprimir_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void FillGVUsers()
        {
            UsuarioController uCon = new UsuarioController();
            Response res = uCon.RecuperarListadoUsuarios();

            gridControl1.DataSource = res.dt;
            GVUsers.Columns["Password"].Visible = false;

            GridColumn c = GVUsers.Columns[3];
            c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            c.DisplayFormat.FormatString = "c2";

            SumarItems();

        }

        private void SumarItems()
        {
            GVUsers.OptionsView.ShowFooter = true;
            GridColumn c = GVUsers.Columns[3];
            c.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            c.SummaryItem.DisplayFormat = "Total: Q.{0}";


        }
    }
}