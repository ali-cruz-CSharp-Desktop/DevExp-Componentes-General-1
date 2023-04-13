using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    public class AccessDAO
    {
        private string LocalHome = ConfigurationManager.ConnectionStrings["LocalHome"].ConnectionString;

        public Response Consulta(string query)
        {
            Response res = new Response();
            res.dt = new System.Data.DataTable();
            
            try
            {
                using (SqlConnection conn = new SqlConnection(LocalHome))
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    sda.Fill(res.dt);
                    return res;
                }
            } catch (Exception e)
            {
                return null;
            }
        }


    }
}
