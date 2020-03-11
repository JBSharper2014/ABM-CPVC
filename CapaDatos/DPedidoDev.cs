using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPedidoDev
    {
        SqlConnection cn;

        public DataTable SelectPedidosDev()
        {
            DataTable miTabla = new DataTable("1_pedido_devolucion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectPedidosDev", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectPedidosDevSinNotaCredito()
        {
            DataTable miTabla = new DataTable("1_pedido_devolucion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectPedidosDevSinNotaCredito", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectPedidosDevByCodPedDev(int cod_pd)
        {
            DataTable miTabla = new DataTable("1_pedido_devolucion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectPedidosDevByCodPedDev", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pd", cod_pd);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }


        public bool PedidoDevolucionTieneNotaCreditoAsociada(int cod_pd)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("PedidoDevolucionTieneNotaCreditoAsociada", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pd", cod_pd);

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

        public bool PedidoDevolucionTieneInformeAsociado(int cod_pd)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("PedidoDevolucionTieneInformeAsociado", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pd", cod_pd);

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

        public void InsertPedidoDev(int cod_ir, DateTime fecha_creacion)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertPedidoDev", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ir", cod_ir);
                cmd.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);

                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }
        

        public string DeletePedidoDev(int cod_pd)
        {
            string respuesta;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeletePedidoDev", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pd", cod_pd);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se eliminó el registro correctamente" : "Error al eliminar el registro";

                cn.Close();
                return respuesta;
            }
        }
    }
}
