using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCotizacionPR
    {
        private SqlConnection cn;

        public DataTable SelectCotizacionesPR()
        {
            DataTable miTabla = new DataTable("1_cotizacion_pedido_reaprovisionamiento");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectCotizacionesPR", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectCotizacionesPRByCodStockAndCodPR(int cod_pro_stock, int cod_pr)
        {
            DataTable miTabla = new DataTable("1_cotizacion_pedido_reaprovisionamiento");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectCotizacionesPRByCodStockAndCodPR", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);
                cmd.Parameters.AddWithValue("@cod_pr", cod_pr);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }


        public void UpdateCotizacionPR(int cod_pr, int codOrdenCompra)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateCotizacionPR", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pr", cod_pr);
                cmd.Parameters.AddWithValue("@cod_ord_cpr", codOrdenCompra);

                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public int InsertCotizacionPR(int codStock, int cod_pr, string tiempo_entrega,
            DateTime fecha_cotizacion, decimal precio_cotizado)
        {
            int resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertCotizacionPR", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", codStock);
                cmd.Parameters.AddWithValue("@cod_pr", cod_pr);
                cmd.Parameters.AddWithValue("@tiempo_entrega", tiempo_entrega);
                cmd.Parameters.AddWithValue("@fecha_cotizacion", fecha_cotizacion);
                cmd.Parameters.AddWithValue("@precio_cotizado", precio_cotizado);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();
                return resultado;

            }
        }

        public decimal GetPrecioCotizadoByCodCotizacionPR(int codStock, int cod_cotizacion)
        {
            decimal resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetPrecioCotizadoByCodCotizacionPR", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", codStock);
                cmd.Parameters.AddWithValue("@cod_cotizacion", cod_cotizacion);

                resultado = (decimal)cmd.ExecuteScalar();

                cn.Close();
                return resultado;

            }
        }

        public bool CotizacionPRTieneOrdenCompraAsociada(int cod_cotizacion)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("CotizacionPRTieneOrdenCompraAsociada", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_cotizacion", cod_cotizacion);

                SqlDataReader dr = cmd.ExecuteReader(); 

                if (dr.Read())
                {
                    cn.Close();
                    return true;
                }
                else
                {
                    cn.Close();
                    return false;
                }
            }
        }

        public void DeleteCotizacionPR(int cod_cotizacion)
        {

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteCotizacionPR", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_cotizacion", cod_cotizacion);

                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }
    }
}
