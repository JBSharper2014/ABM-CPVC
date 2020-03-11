using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DStockPedidoReaprov
    {
        SqlConnection cn;

        public void InsertStockPedidoReaprov(int cod_pr, int cod_pro_stock, int cantidad, int cod_mar, int cod_med)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertStockPedidoReaprov", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pr", cod_pr);
                cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@cod_mar", cod_mar);
                cmd.Parameters.AddWithValue("@cod_med", cod_med);

                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public void DeleteStockPedidoReaprov(int cod_pr)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteStockPedidoReaprov", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pr", cod_pr);

                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public DataTable GetStockEnPedidoReaprov(int cod_pr)
        {
            DataTable miTabla = new DataTable("1_stock_pr");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetStockEnPedidoReaprov", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pr", cod_pr);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }
    }
}
