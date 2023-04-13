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

namespace MainForm.Views
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        private readonly int longitudMinimaCampos = 3;
        public Form2()
        {
            InitializeComponent();
        }

        private void FillGridUsers()
        {
            UsuarioController uC = new UsuarioController();
            Response res = uC.RecuperarListadoUsuarios();
            GCUsers.DataSource = res.dt;
        }

        private void FillCMBRoles()
        {
            RolesController rolesC = new RolesController();
            Response resRoles = rolesC.RecuperarListadoRoles();

            LUERoles.Properties.DataSource = resRoles.dt;
            LUERoles.Properties.ValueMember = "RoleID";
            LUERoles.Properties.DisplayMember = "RoleTitle";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillGridUsers();
            FillCMBRoles();
        }

        private void BBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Users user = new Users();
            user.UserName = TxbUserName.Text.Trim();
            user.Descripcion = TxbDescription.Text.Trim();
            user.RoleID = Convert.ToInt32(LUERoles.EditValue);
            user.Activo = ChkActivo.Checked;
            
            if (ValidaFormUser(user).Length > 0)
            {
                XtraMessageBox.Show(ValidaFormUser(user), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            


        }

        private string ValidaFormUser(Users user)
        {
            string msgResultValidation = "";

            if (user.UserName.Length < longitudMinimaCampos)
            {
                msgResultValidation += "UserName is required and must be minimun 3 characters.\n";
            }

            if (user.Descripcion.Length < longitudMinimaCampos)
            {
                msgResultValidation += "Description is required and must be minimum 3 characters.\n";
            }

            if (user.RoleID == -1 || user.RoleID == 0)
            {
                msgResultValidation += "Role is required.\n";
            }

            return msgResultValidation;
        }

    }
}