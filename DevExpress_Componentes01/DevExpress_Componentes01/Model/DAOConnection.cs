using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress_Componentes01.Model
{
    public class DAOConnection
    {
        private string LocalHost = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public ResponseData Consulta(string uspName)
        {
            ResponseData response = new ResponseData();
            response.Dt = new System.Data.DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(LocalHost))
                {
                    using (SqlCommand cmd = new SqlCommand(uspName, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;                        
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);                        
                        dataAdapter.Fill(response.Dt);
                        return response;
                    }
                }
            } catch (Exception ex)
            {
                response.ExistError = true;
            }

            return response;
        }

    }
}
