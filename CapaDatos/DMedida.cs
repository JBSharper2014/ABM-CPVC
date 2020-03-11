using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DMedida
    {
        SqlConnection cn;

        public DataTable SelectMedidas()
        {
            DataTable miTabla = new DataTable("1_medida");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectMedidas", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectCodAndNombreMedidaByCategoria(string categoria)
        {
            DataTable miTabla = new DataTable("1_medida");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectCodAndNombreMedidaByCategoria", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@categoria", categoria);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectMedidasByCodStock(int codStock)
        {
            DataTable miTabla = new DataTable("1_stock_medida");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectMEdidasByCodStock", cn)
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

        public string GetMedidaByCodMedida(int cod_med)
        {
            string resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetMedidaByCodMedida", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_med", cod_med);

                resultado = cmd.ExecuteScalar().ToString();

                cn.Close();

            }
            return resultado;
        }

        public int GetCodMedidaByNombreMedida(string nombre)
        {
            int resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetCodMedidaByNombreMedida", cn)
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
