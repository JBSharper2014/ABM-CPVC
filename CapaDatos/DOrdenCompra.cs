using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DOrdenCompra
    {
        SqlConnection cn;

        public DataTable SelectOrdenesCompra()
        {
            DataTable miTabla = new DataTable("1_orden_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectOrdenesCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectOrdenesCompraSinFactura()
        {
            DataTable miTabla = new DataTable("1_orden_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectOrdenesCompraSinFactura", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectOrdenCompraSinInforme()
        {
            DataTable miTabla = new DataTable("1_orden_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectOrdenCompraSinInforme", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectOrdenesCompraByTipo(string tipo)
        {
            DataTable miTabla = new DataTable("1_orden_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectOrdenesCompraByTipo", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@tipo", tipo);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable GetStockOrdenCompraPR(int cod_ord_cpr)
        {
            DataTable miTabla = new DataTable("1_stock_pr");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetStockOrdenCompraPR", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", cod_ord_cpr);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }



        public int InsertOrdenCompra(bool emitido, string tipo)
        {
            int resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@emitido", emitido);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();
                return resultado;

            }
        }

        public string GetTipoOrdenCompra(int codOrdenCompra)
        {
            string resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetTipoOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", codOrdenCompra);

                resultado = cmd.ExecuteScalar().ToString();

                cn.Close();
                return resultado;

            }
        }

        public int GetProveedorEnOrdenCompra(int codOrdenCompra)
        {
            int resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetProveedorEnOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", codOrdenCompra);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();
                return resultado;

            }
        }

        public string EmitirOrdenCompra(DateTime fecha, int codOrdenCompra)
        {
            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("EmitirOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@cod_ord_cpr", codOrdenCompra);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se emitió la orden de compra correctamente" : "Error al emitir la orden";

                cn.Close();
                return respuesta;

            }
        }

        public void DeleteOrdenCompra(int cod_ord_cpr)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", cod_ord_cpr);

                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }

        public string EmitirOrdenCompra(int cod_ord_cpr, DateTime fecha)
        {
            string respuesta;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("EmitirOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", cod_ord_cpr);
                cmd.Parameters.AddWithValue("@fecha", fecha);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se emitió la orden de compra correctamente" : "Error al emitir la orden";

                cn.Close();
                return respuesta;
            }
        }

        public bool OrdenCompraTieneFacturaAsociada(int cod_ord_cpr)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("OrdenCompraTieneFacturaAsociada", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", cod_ord_cpr);

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
    }
}
