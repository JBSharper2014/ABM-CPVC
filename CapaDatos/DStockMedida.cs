using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DStockMedida
    {

        SqlConnection cn;
        public string InsertStockMedida(int cod_med, int cod_pro_stock)
        {
            string respuesta;


            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("InsertStockMedida", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_med", cod_med);
                    cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);

                    cmd.ExecuteNonQuery();
                }
                respuesta = "Producto por medida agregado correctamente.";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el producto por medida." + Environment.NewLine +
                    "Ya existe el producto seleccionado con la medida seleccionada.";
            }

            cn.Close();
            return respuesta;
        }

        public string DeleteStockMedida(int cod_pro_stock)
        {
            string respuesta;

            try
            {

                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("DeleteStockMedida", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);

                    cmd.ExecuteNonQuery();
                }
                respuesta = "Producto por medida eliminado correctamente";
            }
            catch (Exception ex)
            {

                respuesta = "Error al eliminar producto por medida: " + ex.Message;
            }

            return respuesta;
        }
    }
}
