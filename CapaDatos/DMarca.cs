using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMarca
    {
        SqlConnection cn;

        public DataTable SelectMarcas()
        {
            DataTable miTabla = new DataTable("1_marca");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectMarcas", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectMarcasByCodProducto(int codBienUso)
        {
            DataTable miTabla = new DataTable("1_marca_buso");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectMarcasByCodProducto", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@cod_pro_buso", codBienUso);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectMarcasByCodStock(int codStock)
        {
            DataTable miTabla = new DataTable("1_stock_marca");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectMarcasByCodStock", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@cod_pro_stock", codStock);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public string GetNombreMarcaByCodMarca(int cod_mar)
        {
            string resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetNombreMarcaByCodMarca", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_marca", cod_mar);

                resultado = cmd.ExecuteScalar().ToString();

                cn.Close();

            }
            return resultado;
        }

        public int GetCodMarcaByNombreMarca(string nombre)
        {
            int resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetCodMarcaByNombreMarca", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@nombre", nombre);

                resultado = (int)cmd.ExecuteScalar();

                cn.Close();

            }
            return resultado;
        }

    }
}
