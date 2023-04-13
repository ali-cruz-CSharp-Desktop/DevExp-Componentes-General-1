using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Controllers
{
    public class RolesController
    {
        public Response RecuperarListadoRoles()
        {
            AccessDAO access = new AccessDAO();
            string sp = $"EXEC usp_Roles_LoadDataIntoComboBox";
            System.Diagnostics.Debug.WriteLine("EXEC [usp_Roles_LoadDataIntoComboBox]");

            Response res = access.Consulta(sp);
            return res;
        }
    }
}
