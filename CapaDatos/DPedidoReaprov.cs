using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPedidoReaprov
    {
        private SqlConnection cn;

        public DataTable SelectPedidosReaprov()
        {
            DataTable miTabla = new DataTable("1_pedido_reaprovisionamiento");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectPedidosReaprov", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectPRSinOrdenCompra()
        {
            DataTable miTabla = new DataTable("1_pedido_reaprovisionamiento");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectPRSinOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectPedidosReaprovByCodPedido(int cod_pr)
        {
            DataTable miTabla = new DataTable("1_pedido_reaprovisionamiento");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectPedidosReaprovByCodPedido", cn)
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



        public int InsertPedidoReaprov(DateTime fecha_emision, bool cancelado, bool automatizado, int cod_proveedor)
        {
            int resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertPedidoReaprov", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@fecha_emision", fecha_emision);
                cmd.Parameters.AddWithValue("@cancelado", cancelado);
                cmd.Parameters.AddWithValue("@automatizado", automatizado);
                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();
                return resultado;

            }
        }

        //public void UpdateListadoPedidosReaprovOrdenesToNull()
        //{
        //    adapter.UpdateListadoPedidosReaprovOrdenesToNull();
        //}

        public string UpdatePedidoReaprov(int cod_pr, bool cancelado)
        {
            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdatePedidoReaprov", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pr", cod_pr);
                cmd.Parameters.AddWithValue("@cancelado", cancelado);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se actualizó el pedido correctamente" : "Error al actualizar el pedido";

                cn.Close();
                return respuesta;

            }
        }

        public string DeletePedidoReaprov(int cod_pr)
        {
            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeletePedidoReaprov", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pr", cod_pr);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se eliminó el pedido correctamente" : "Error al eliminar el pedido";

                cn.Close();

                return respuesta;
            }
        }

        public DataTable SelectPedidosReaprovSinCotizacion()
        {
            DataTable miTabla = new DataTable("1_pedido_reaprovisionamiento");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectPedidosReaprovSinCotizacion", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public int GetCodPedidoReaprovByCodOrdenCompra(int cod_ord_cpr)
        {
            int resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetCodPedidoReaprovByCodOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", cod_ord_cpr);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();

            }
            return resultado;
        }

        //public DataTable SelectPedidosReaprovSinOrdenCompra()
        //{
        //    DataTable pedidosSinOrdenCompra;
        //    try
        //    {
        //        pedidosSinOrdenCompra = adapter.SelectPedidosReaprovSinOrdenCompra();
        //    }
        //    catch (Exception)
        //    {

        //        pedidosSinOrdenCompra = null;
        //    }
        //    return pedidosSinOrdenCompra;
        //}
    }
}
