using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte.Controllers
{
    public class GraficasController
    {

        public List<Models.Graficas.Orders> GetTotOrdersByYear()
        {
            using (IDbConnection conn = new SqlConnection(Helper.Conection("DB_Northwind")))
            {
                return conn.Query<Models.Graficas.Orders>("dbo.usp_orders_select_allOrders_byYear").ToList();
            }
        }


    }
}
