using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DMarcaBienUso
    {
        
        SqlConnection cn;
        public string InsertMarcaBienUso(int cod_mar, int cod_pro_buso)
        {
            string respuesta;

            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("InsertMarcaBienUso", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_mar", cod_mar);
                    cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);

                    cmd.ExecuteNonQuery(); 

                    cn.Close();

                }

                respuesta = "Marca agregada al bien de uso correctamente";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar la marca al bien de uso. " + Environment.NewLine +
                    "Ya existe la marca seleccionada con el bien de uso seleccionado"; ;
            }

            return respuesta;
        }


        public string DeleteMarcaBienUso(int cod_pro_buso)
        {
            string respuesta;

            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("DeleteMarcaBienUso", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    
                    cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);

                    cmd.ExecuteNonQuery();

                    cn.Close();

                }
                respuesta = "Se borró la marca al bien de uso correctamente";
            }
            catch (Exception ex)
            {
                respuesta = "No se pudo borrar la marca al bien de uso. " + Environment.NewLine +
                    ex.Message ;
            }

            return respuesta;
        }

        public bool BienUsoTieneMarcaAsociada(int cod_pro_buso)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("BienUsoTieneMarcaAsociada", cn)
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
