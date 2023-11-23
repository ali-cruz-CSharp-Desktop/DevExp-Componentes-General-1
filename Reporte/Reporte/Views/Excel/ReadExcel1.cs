using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using ExcelDataReader;

namespace Reporte.Views.Excel
{
    public partial class ReadExcel1 : DevExpress.XtraEditors.XtraForm
    {
        DataSet result;

        public ReadExcel1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfileDialog = new OpenFileDialog() { Filter = "Libro Excel|*.xls", ValidateNames = true })
            {
                if (openfileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = File.Open(openfileDialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader iexcelDataReader = ExcelReaderFactory.CreateBinaryReader(fileStream);
                    //iexcelDataReader.IsFirstRowAsColumnNames = true;
                    //result = iexcelDataReader.AsDataSet();
                }
            }
        }


    }
}