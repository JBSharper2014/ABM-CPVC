using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DFacturasProv
    {
        SqlConnection cn;

        public DataTable SelectFacturas()
        {
            DataTable miTabla = new DataTable("1_factura_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectFacturas", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectFacturasByCodFactura(int codFactura)
        {
            DataTable miTabla = new DataTable("1_factura_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectFacturasByCodFactura", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_factura", codFactura);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectFacturasNoRegistradas()
        {
            DataTable miTabla = new DataTable("1_factura_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectFacturasNoRegistradas", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public string InsertFacturaProv(int cod_ord_cpr, int numero_factura, DateTime fecha_recepcion, decimal importe,
            string observaciones, bool sumada)
        {

            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertFacturaProv", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", cod_ord_cpr);
                cmd.Parameters.AddWithValue("@numero_factura", numero_factura);
                cmd.Parameters.AddWithValue("@fecha_recepcion", fecha_recepcion);
                cmd.Parameters.AddWithValue("@observaciones", observaciones);
                cmd.Parameters.AddWithValue("@importe", importe);
                cmd.Parameters.AddWithValue("@sumada", sumada);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se ingresó la factura correctamente" : "Error al ingresarla factura";

                cn.Close();
                return respuesta;

            }
        }

        public string UpdateFactura(int cod_factura, int numero_factura, decimal importe, string observaciones)
        {

            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateFacturaProv", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_factura", cod_factura);
                cmd.Parameters.AddWithValue("@numero_factura", numero_factura);
                cmd.Parameters.AddWithValue("@observacion", observaciones);
                cmd.Parameters.AddWithValue("@importe", importe);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se actualizó la factura correctamente" : "Error al actualizar la factura";

                cn.Close();
                return respuesta;

            }
        }

        public string GetObservacionesFacturaProv(int cod_factura)
        {
            string resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetObservacionesFacturaProv", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_factura", cod_factura);

                resultado = cmd.ExecuteScalar().ToString();

                cn.Close();

            }
            return resultado;
        }

        public decimal CalcularImporteDeFacturaPR(int codOrdenCompra)
        {
            decimal resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("CalcularImporteDeFacturaPR", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", codOrdenCompra);

                resultado = (decimal)cmd.ExecuteScalar();

                cn.Close();

            }
            return resultado;
        }

        public decimal CalcularImporteDeFacturaSC(int codOrdenCompra)
        {
            decimal resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("CalcularImporteDeFacturaSC", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ord_cpr", codOrdenCompra);

                resultado = (decimal)cmd.ExecuteScalar();

                cn.Close();

            }
            return resultado;
        }

        public string DeleteFacturaProv(int cod_factura)
        {
            string respuesta;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteFacturaProv", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_factura", cod_factura);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se eliminó el registro correctamente" : "Error al eliminar el registro";

                cn.Close();
                return respuesta;
            }
        }


        public bool FacturaProvTieneInformeAsociado(int @cod_factura)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("FacturaProvTieneInformeAsociado", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_factura", @cod_factura);

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

        public void RegistrarFactura(int cod_factura, int cod_cuenta_corriente)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("RegistrarFactura", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_factura", cod_factura);
                cmd.Parameters.AddWithValue("@cod_cuenta_corriente", cod_cuenta_corriente);


                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }
    }
}
