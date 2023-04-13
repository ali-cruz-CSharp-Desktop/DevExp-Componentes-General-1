using DevExpress_Componentes01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress_Componentes01.Controllers
{
    public class UserController
    {
        public ResponseData GetAllUsers()
        {
            DAOConnection daoConnection = new DAOConnection();
            ResponseData res = new ResponseData();
            res = daoConnection.Consulta("usp_Users_Select_AllUsers");


            return res;
        }


    }
}
