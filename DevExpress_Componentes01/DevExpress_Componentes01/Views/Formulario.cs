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

namespace DevExpress_Componentes01.Views
{
    public partial class Formulario : DevExpress.XtraEditors.XtraForm
    {
        public Formulario()
        {
            InitializeComponent();
            panelControl2.BackColor = Color.Red;
        }
    }
}