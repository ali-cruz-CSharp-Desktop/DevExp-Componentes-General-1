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

namespace Reporte.Views.Dashboards
{
    public partial class DocumentMgrWidget1cs : DevExpress.XtraEditors.XtraForm
    {

        Dictionary<string, string> companyNames = new Dictionary<string, string>();

        public DocumentMgrWidget1cs()
        {
            InitializeComponent();
            FillCompanyInfo();
        }

        void FillCompanyInfo()
        {
            companyNames.Add("APPL", "Apple INC");
            companyNames.Add("AMZ", "Amazon");
            companyNames.Add("FB", "Facebook");
            companyNames.Add("GGL", "Google");
        }

        private void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {            
            //WidgetControl widget1 = new WidgetControl();


        }
    }
}