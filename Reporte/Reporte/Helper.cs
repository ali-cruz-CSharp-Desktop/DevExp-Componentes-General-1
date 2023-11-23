using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte
{
    public static class Helper
    {
        public static string Conection(string name)
        {
            string res = string.Empty;

            try
            {
                res = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            } catch (Exception ex)
            {
                res = "Error al intentar interactuar con la BD seleccionada. " + ex;
            }

            return res;
        }


    }

}
