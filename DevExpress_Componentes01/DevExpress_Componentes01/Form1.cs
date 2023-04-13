using System;
using DevExpress.Utils.OAuth.Provider;
using DevExpress_Componentes01.Controllers;
using System.Data;
using System.Windows.Forms;
using DevExpress_Componentes01.Model;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System.Drawing;

namespace DevExpress_Componentes01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserController userC = new UserController();
            ResponseData res = new ResponseData();

            if (!res.ExistError)
            {
                res = userC.GetAllUsers();
                gridControl1.DataSource = res.Dt;
                string[] columnsToHide = { "Description", "CreatedBy" };
                HideColumnsOfGrid(gridView1, columnsToHide);

                AddOneColumn();
            } else
            {
                MessageBox.Show("Existe un error.");
            }


            Color[] colorArray = {
                   SystemColors.ActiveCaption,
                   SystemColors.ActiveCaptionText,
                   SystemColors.AppWorkspace,
                   SystemColors.Control,
                   SystemColors.ControlDark,
                   SystemColors.ControlLight,
                   SystemColors.ControlText,
                   SystemColors.Desktop,
                   SystemColors.Highlight,
                   SystemColors.InactiveBorder,
                   SystemColors.InactiveCaption,
                   SystemColors.Info,
                   SystemColors.InfoText,
                   SystemColors.Menu,
                   SystemColors.MenuText,
                   SystemColors.ScrollBar,
                   SystemColors.Window,
                   SystemColors.WindowFrame
                };
            listBoxControl1.DataSource = colorArray;
            listBoxControl1.DisplayMember = "Name";
            listBoxControl1.SelectedIndexChanged += ListBoxControl1_SelectedIndexChanged;

            searchControl1.Client = listBoxControl1;
            


        }

        private void ListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedValue != null)
                this.BackColor = (Color)listBoxControl1.SelectedValue;
            else
                this.BackColor = Color.Black;
        }

        private void AddOneColumn()
        {
            GridColumn columnButton = new GridColumn();
            columnButton.FieldName = "Boton";
            
            columnButton.ColumnEdit = repositoryItemButtonEdit1;

            gridView1.Columns.AddVisible("CreatedBy");
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("Boton");
        }

        private void gridView1_ColumnPositionChanged(object sender, EventArgs e)
        {
            int tot = gridView1.VisibleColumns.Sum(column => column.Width);
            gridView1.OptionsView.ColumnAutoWidth = tot < gridControl1.Width;
        }

        private void HideColumnsOfGrid(DevExpress.XtraGrid.Views.Grid.GridView dgv, string[] columns)
        {
            foreach (string columnName in columns)
            {
                GridColumn column = dgv.Columns[columnName];

                if (column != null)
                {
                    dgv.Columns[columnName].Visible = false;
                }                
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Formulario form = new Views.Formulario();
            form.ShowDialog();
        }
    }
}
