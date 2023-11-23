using Reporte.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Reporte.DATA
{
    public class DAOConn
    {
        //private string myConnection = ConfigurationManager.ConnectionStrings["local_developer"].ConnectionString;


        //public Response ExecSP(string spName, string paramsSerializados)
        //{
        //    Response res = new Response();
        //    res.dt = new DataTable();

        //    try {
        //        using (SqlConnection conn = new SqlConnection(myConnection))
        //        {
        //            using (SqlCommand cmd = new SqlCommand(spName, conn))
        //            {
        //                cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
        //                sqlDataAdapter.Fill(res.dt);
        //                return res;
        //            }
        //        }
        //    } catch (Exception ex)
        //    {
        //        res.ExistError = true;
        //        res.MsgDB = ex.ToString();
        //        res.dt = null;
        //        return res;
        //    }
        //}

        public List<Compras> GetAllCompras()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.Conection("local_developer")))
            {
                return conn.Query<Compras>($"SELECT * FROM Compras WHERE CompraID >= 0").ToList(); // Mala Practica SQL Injection                
            }
        }

        public List<Compras> GetCompraById(int CompraID)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.Conection("local_developer")))
            {
                //return conn.Query<Compras>($"SELECT * FROM Compras WHERE CompraID >= 0").ToList();
                return conn.Query<Compras>("dbo.usp_compras_select_byID @CompraID", new { CompraID = CompraID }).ToList();
            }
        }


        public List<Compras> GetComprasByRangeDate(DateTime FIni, DateTime FFin)
        {
            if (FIni == default(DateTime))
            {
                FIni = DateTime.Now;
            }

            if (FFin == default(DateTime))
            {
                FFin = DateTime.Now;
            }

            using (IDbConnection conn = new SqlConnection(Helper.Conection("local_developer")))
            {
                return conn.Query<Compras>("dbo.usp_compras_select_byDate @FIni, @FFin", new { FIni = FIni, FFin = FFin }).ToList();
            }
        }

        public List<ComprasDetalle> GetComprasDetalleAll()
        {
            using (IDbConnection db = new SqlConnection(Helper.Conection("local_developer")))
            {
                return db.Query<ComprasDetalle>("dbo.usp_compraDetalle_select_all").ToList();
            }
        }

        public List<ComprasDetalle> GetComprasDetalleById(int CompraID)
        {
            using (IDbConnection db = new SqlConnection(Helper.Conection("local_developer")))
            {
                return db.Query<ComprasDetalle>("dbo.usp_compraDetalle_select_byId @CompraID", new { CompraID = CompraID }).ToList();
            }
        }

        

    }
}
