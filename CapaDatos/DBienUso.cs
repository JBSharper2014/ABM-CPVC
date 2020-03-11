
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DBienUso
    {
        
        SqlConnection cn;

        public DataTable SelectBienesUso()
        {
            DataTable miTabla = new DataTable("1_bien_uso");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectBienesUso", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectBienesUsoSinProveedoresAsociados(int cod_proveedor)
        {
            DataTable miTabla = new DataTable("1_bien_uso");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectBienesUsoSinProveedoresAsociados", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectNombresBienesUso()
        {
            DataTable miTabla = new DataTable("1_bien_uso");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectNombresBienesUso", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }
        

        public DataTable SelectBienesUsoByNombre(string nombre)
        {
            DataTable miTabla = new DataTable("1_bien_uso");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectBienesUsoByNombre", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@nombre", nombre);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public string InsertBienUso(string nombre, int stock, string descripcion, string observaciones)
        {

            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertBienUso", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@observacion", observaciones);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se ingresó el registro correctamente" : "Error al ingresar el registro";

                cn.Close();
                return respuesta;

            }
        }

        public string UpdateBienUso(int cod_pro_buso, string nombre, int stock, string descripcion, string observaciones)
        {

            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateBienUso", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@observacion", observaciones);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se actualizó el registro correctamente" : "Error al actualizar el registro";

                cn.Close();
                return respuesta;

            }
        }

        public string DeleteBienUso(int cod_pro_buso)
        {
            string respuesta;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteBienUso", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se eliminó el registro correctamente" : "Error al eliminar el registro"; 

                cn.Close();
                return respuesta;
            }
        }



        public string GetNombreBienUsoByCodBienUso(int cod_pro_buso)
        {
            string resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetNombreBienUsoByCodBienUso", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);

                resultado = cmd.ExecuteScalar().ToString();

                cn.Close();

            }
            return resultado;
        }

        public bool BienUsoTieneProveedorAsociado(int cod_pro_buso)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("BienUsoTieneProveedorAsociado", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);

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
