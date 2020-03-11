using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSolicitudCompra
    {
        SqlConnection cn;

        public DataTable SelectSolicitudesCompra()
        {
            DataTable miTabla = new DataTable("1_solicitud_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectSolicitudesCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectSCSinOrdenCompra()
        {
            DataTable miTabla = new DataTable("1_solicitud_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectSCSinOrdenCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectSolicitudesComprasByCodSolicitud(int cod_sc)
        {
            DataTable miTabla = new DataTable("1_solicitud_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectSolicitudesComprasByCodSolicitud", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public string UpdateSolicitudCompra(string departamento, bool cancelado, int cod_sc)
        {
            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateSolicitudCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@departamento", departamento);
                cmd.Parameters.AddWithValue("@cancelado", cancelado);
                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se actualizó la solicitud correctamente" : "Error al actualizar la solicitud";

                cn.Close();
                return respuesta;

            }
        }

        public int InsertSolicitudCompra(DateTime fecha_emision, string departamento, bool cancelado)
        {
            int resultado;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertSolicitudCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@fecha_emision", fecha_emision);
                cmd.Parameters.AddWithValue("@departamento", departamento);
                cmd.Parameters.AddWithValue("@cancelado", cancelado);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();
                return resultado;

            }
        }

        ////public void UpdateListadoSolicitudesCompraOrdenesToNull()
        ////{
        ////    adapter.UpdateListadoSolicitudesCompraOrdenesToNull();
        ////}

        public string DeleteSolicitudCompra(int cod_sc)
        {
            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteSolicitudCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);
                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se eliminó la solicitud correctamente": "Error al eliminar la solicitud";

                cn.Close();
                return respuesta;

            }
        }

        //public string UpdateSolicitudCompra(string departamento, bool cancelado, int cod_sc)
        //{
        //    string respuesta;

        //    try
        //    {
        //        adapter.UpdateSolicitudCompra(departamento, cancelado, cod_sc);
        //        respuesta = string.Format("La solicitud de compra con código : {0} fue modificada correctamente",
        //        cod_sc.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        respuesta = "Error al modificar la solicitud:" + Environment.NewLine + ex.Message;
        //    }

        //    return respuesta;
        //}

        public DataTable SolicitudCompraSinCotizacion()
        {
            DataTable miTabla = new DataTable("1_solicitud_compra");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectSolicitudCompraSinCotizacion", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        //public DataTable SelectSolcitudesCompraSinOrdenCompra()
        //{
        //    DataTable solicitudesSinOrdenCompra;
        //    try
        //    {
        //        solicitudesSinOrdenCompra = adapter.SelectSolcitudesCompraSinOrdenCompra();
        //    }
        //    catch (Exception)
        //    {

        //        solicitudesSinOrdenCompra = null;
        //    }

        //    return solicitudesSinOrdenCompra;
        //}

    }
}

