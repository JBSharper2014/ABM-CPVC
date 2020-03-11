using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCuentaCorriente
    {
        SqlConnection cn;

        public DataTable SelectCuentasCorriente()
        {
            DataTable miTabla = new DataTable("1_cuenta_corriente_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectCuentasCorrientes", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public int GetCuentaCorrienteByCodProveedor(int cod_proveedor)
        {
            int resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetCuentaCorrienteByCodProveedor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();

            }
            return resultado;
        }

        public string InsertCuentaProveedor(int cod_proveedor, decimal debe, decimal haber)
        {
            string respuesta;


            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertProveedor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);
                cmd.Parameters.AddWithValue("@debe", debe);
                cmd.Parameters.AddWithValue("@haber", haber);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se ingresó la cuenta correctamente" : "Error al ingresar la cuenta";

                cn.Close();

            }

            return respuesta;
        }

        public string UpdateCuentaProveedor(int cod_proveedor)
        {
            string respuesta;


            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateCuentaProveedor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se actualizó la cuenta correctamente" : "Error al actualizar la cuenta";

                cn.Close();

            }

            return respuesta;
        }

        public string UpdateDebeHaberCuentaProveedor(int cod_cuenta_corriente, decimal debe, decimal haber)
        {
            string respuesta;


            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateDebeHaberCuentaProveedor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_cuenta_corriente", cod_cuenta_corriente);
                cmd.Parameters.AddWithValue("@debe", debe);

                cmd.Parameters.AddWithValue("@haber", haber);


                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se actualizó la cuenta correctamente" : "Error al actualizar la cuenta";

                cn.Close();

            }

            return respuesta;
        }

        public string DeleteCuentaProveedor(int cod_proveedor)
        {
            string respuesta;


            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteCuentaProveedor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se borró la cuenta correctamente" : "Error al borrar la cuenta";

                cn.Close();

            }

            return respuesta;
        }

        public void UpdateDebeCuenta(decimal debe, int cod_cuenta_corriente)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateDebeCuenta", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_cuenta_corriente", cod_cuenta_corriente);
                cmd.Parameters.AddWithValue("@debe", debe);


                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public void UpdateHaberCuenta(decimal haber, int cod_cuenta_corriente)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateHaberCuenta", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_cuenta_corriente", cod_cuenta_corriente);
                cmd.Parameters.AddWithValue("@haber", haber);


                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }
    }
}
