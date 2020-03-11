using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCotizacionSC
    {
        private SqlConnection cn;

        public DataTable SelectCotizacionesSC()
        {
            DataTable miTabla = new DataTable("1_cotizacion_solicitud_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectCotizacionesSC", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectCotizacionesSCByCodBienUsoAndCodSC(int cod_pro_buso, int cod_sc)
        {
            DataTable miTabla = new DataTable("1_cotizacion_solicitud_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectCotizacionesSCByCodBienUsoAndCodSC", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);
                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public void UpdateCotizacionSC(int cod_sc, int codOrdenCompra)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateCotizacionSC", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);
                cmd.Parameters.AddWithValue("@cod_ord_cpr", codOrdenCompra);

                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public int InsertCotizacionSC(int codBienUso, int cod_sc, string tiempo_entrega,
            DateTime fecha_cotizacion, decimal precio_cotizado)
        {
            int resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertCotizacionSC", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_buso", codBienUso);
                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);
                cmd.Parameters.AddWithValue("@tiempo_entrega", tiempo_entrega);
                cmd.Parameters.AddWithValue("@fecha_cotizacion", fecha_cotizacion);
                cmd.Parameters.AddWithValue("@precio_cotizado", precio_cotizado);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();
                return resultado;

            }
        }

        public decimal GetPrecioCotizadoByCodBienUsoSC(int codBienUso, int cod_cotizacion)
        {
            decimal resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetPrecioCotizadoByCodBienUsoSC", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", codBienUso);
                cmd.Parameters.AddWithValue("@cod_cotizacion", cod_cotizacion);


                resultado = (decimal)cmd.ExecuteScalar();

                cn.Close();
                return resultado;

            }
        }

        public bool CotizacionSCTieneOrdenCompraAsociada(int cod_cotizacion)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("CotizacionSCTieneOrdenCompraAsociada", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", cod_cotizacion);

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

        public void DeleteCotizacionSC(int cod_cotizacion)
        {

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteCotizacionSC", cn)
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
