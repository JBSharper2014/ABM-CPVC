using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRegistracion
    {
        SqlConnection cn;

        public DataTable SelectRegistracionesCompras()
        {
            DataTable miTabla = new DataTable("1_registracion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectRegistracionesCompras", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectRegistracionesComprasByCodReg(int cod_reg)
        {
            DataTable miTabla = new DataTable("1_registracion");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectRegistracionesComprasByCodReg", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@cod_reg", cod_reg);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public void InsertRegistracionCompra(int cod_ir, DateTime fecha_reg)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertRegistracionCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_ir", cod_ir);
                cmd.Parameters.AddWithValue("@fecha_reg", fecha_reg);
                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }
    }
}
