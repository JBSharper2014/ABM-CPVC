using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DCBU
    {
        SqlConnection cn;

        public DataTable SelectCBU()
        {
            DataTable miTabla = new DataTable("1_cbu_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectCBU", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }


        public string InsertCBU(string CBU, int cod_proveedor)
        {
            string respuesta;


            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertCBU", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };


                cmd.Parameters.AddWithValue("@cbu", CBU);
                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se agregó el CBU correctamente" : "Error al ingresar el CBU";

                cn.Close();

            }
            


            return respuesta;
        }
        
    }
}
