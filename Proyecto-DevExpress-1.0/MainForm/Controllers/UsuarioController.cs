using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Controllers
{
    public class UsuarioController
    {
        public Response RecuperarListadoUsuarios()
        {
            AccessDAO access = new AccessDAO();
            string sp = $"EXEC usp_Users_Select_AllUsers";
            System.Diagnostics.Debug.WriteLine("EXEC usp_Users_Select_AllUsers");

            Response res = access.Consulta(sp);
            return res;
        }

        //public Response InsertaNuevoUsuario(Users user)
        //{


        //}

    }
}
