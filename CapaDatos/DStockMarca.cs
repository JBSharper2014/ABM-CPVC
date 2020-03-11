
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DStockMarca
    {
        

        SqlConnection cn;

        public DataTable SelectStockMarca()
        {
            DataTable miTabla = new DataTable("1_stock_marca");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectStockMarca", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public string InsertStockMarca(int cod_mar, int cod_pro_stock)
        {
            string respuesta;

            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("InsertStockMarca", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_mar", cod_mar);
                    cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);

                    cmd.ExecuteNonQuery();



                }
                respuesta = "Producto por marca agregado correctamente.";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el producto por marca." + Environment.NewLine +
                    "Ya existe el producto seleccionado con la marca seleccionada.";
            }

            cn.Close();
            return respuesta;
        }

        public string DeleteStockMarca(int cod_pro_stock)
        {
            string respuesta;

            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("DeLETEStockMarca", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);

                    cmd.ExecuteNonQuery();

                }
                respuesta = "Producto por marca eliminado correctamente";
            }
            catch (Exception ex)
            {

                respuesta = "Error al eliminar producto por marca: " + ex.Message;
            }
            cn.Close();
            return respuesta;
        }

        //public bool StockTieneMarcaAsociada(int cod_pro_stock)
        //{
        //    using (cn = Conexion.ConexionDB())
        //    {

        //        SqlCommand cmd = new SqlCommand("StockTieneMarcaAsociada", cn)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };

        //        cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr.Read())
        //        {
        //            cn.Close();
        //            return true;
        //        }
        //        else
        //        {
        //            cn.Close();
        //            return false;
        //        }
        //    }

        //}
    }
}
