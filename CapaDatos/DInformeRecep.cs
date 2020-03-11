using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DInformeRecep
    {
        SqlConnection cn;

        public DataTable SelectInformesRecepcion()
        {
            DataTable miTabla = new DataTable("1_informe_recepcion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectInformesRecepcion", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectInformesRecepcionSinProcesar()
        {
            DataTable miTabla = new DataTable("1_informe_recepcion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectInformesRecepcionSinProcesar", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectInformesRecepcionByCodInforme(int cod_ir)
        {
            DataTable miTabla = new DataTable("1_informe_recepcion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectInformesRecepcionByCodInforme", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ir", cod_ir);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectInformesSinRegistracion()
        {
            DataTable miTabla = new DataTable("1_informe_recepcion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectInformesSinRegistracion", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        

        public DataTable GetDatosInformeByCodOrdenCompra(int cod_ord_cpr)
        {
            DataTable miTabla = new DataTable("1_factura_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetDatosInformeByCodOrdenCompra", cn)
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

        public string InsertInformeRecep(int cod_ord_cpr, int cod_factura, string resultado_calidad, string problemas,
            string estado_pd, DateTime fecha_creacion)
        {

            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertInformeRecep", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", cod_ord_cpr);
                cmd.Parameters.AddWithValue("@cod_factura", cod_factura);
                cmd.Parameters.AddWithValue("@problemas", problemas);
                cmd.Parameters.AddWithValue("@estado_pd", estado_pd);
                cmd.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);
                cmd.Parameters.AddWithValue("@resultado_calidad", resultado_calidad);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se ingresó el registro correctamente" : "Error al ingresar el registro";

                cn.Close();
                return respuesta;

            }
        }
    }
}
