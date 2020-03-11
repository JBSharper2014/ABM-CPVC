using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DStock
    {
        SqlConnection cn;

        public DataTable SelectStock()
        {
            DataTable miTabla = new DataTable("1_stock");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectStock", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectNombresStock()
        {
            DataTable miTabla = new DataTable("1_stock");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectNombresStock", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectNombresStockConMarcaAsociadaByCodProveedor(int cod_proveedor)
        {
            DataTable miTabla = new DataTable("1_stock");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectNombresStockConMarcaAsociadaByCodProveedor", cn)
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

        public DataTable SelectStockByNombre(string nombre)
        {
            DataTable miTabla = new DataTable("1_stock");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectStockByNombre", cn)
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

        public DataTable SelectStockSinProveedoresAsociados(int cod_proveedor)
        {
            DataTable miTabla = new DataTable("1_stock");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectStockSinProveedoresAsociados", cn)
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

        //public bool StockTieneMarcaAsociada (int cod_pro_stock)
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

        public string InsertStock(string nombre, int stk_act, int stk_opt, int stk_cri, int cod_cat)
        {
           
            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertStock", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@stk_act", stk_act);
                cmd.Parameters.AddWithValue("@stk_opt", stk_opt);
                cmd.Parameters.AddWithValue("@stk_cri", stk_cri);
                cmd.Parameters.AddWithValue("@cod_cat", cod_cat);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se ingresó el registro correctamente" : "Error al ingresar el registro";

                cn.Close();
                return respuesta;

            }
        }

        public string UpdateStock(int cod_pro_stock, string nombre, int stk_opt, int stk_cri, int cod_cat)
        {
            
            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateStock", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@stk_opt", stk_opt);
                cmd.Parameters.AddWithValue("@stk_cri", stk_cri);
                cmd.Parameters.AddWithValue("@cod_cat", cod_cat);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se modificó el registro correctamente" : "Error al modificar el registro";

                cn.Close();
                return respuesta;

            }
        }

        public void DeleteStock(int cod_pro_stock)
        {

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteStock", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);

                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }

        public string GetNombreStockByCodStock(int cod_pro_stock)
        {
            string resultado;
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetNombreStockByCodStock", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);

                resultado = cmd.ExecuteScalar().ToString();

                cn.Close();

            }
            return resultado;
        }

        //public bool StockActualEsMenorQueStockCritico(int cod_pro_stock)
        //{
        //    if (adapter.StockActualEsMenorQueStockCritico(cod_pro_stock) == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }


        //}

        // Especial atención a este método, es el que se usa para los pedidos automatizados
        public List<DStockParaPedidosAuto> SelectListadoStockActualMenorAlCritico(int cod_proveedor)
        {
            
            DataTable dt = new DataTable("1_stock");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectListadoStockActualMenorAlCritico", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);
                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

            }

            List<DStockParaPedidosAuto> valoresStock = new List<DStockParaPedidosAuto>();

            if (dt.Rows.Count == 0)
            {
                valoresStock = null;

            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var stock = new DStockParaPedidosAuto
                    {
                        CodStock = (int)dt.Rows[i]["CodStock"],
                        StockActual = (int)dt.Rows[i]["StockActual"],
                        StockCritico = (int)dt.Rows[i]["StockCritico"]
                    };

                    valoresStock.Add(stock);
                }
            }


            return valoresStock;
        }

        public bool StockTieneProveedorAsociado(int cod_pro_stock)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("StockTieneProveedorAsociado", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);

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

        public void UpdateStockActualRegis(int cod_pro_stock, int cantidad)
        {

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateStockActualRegis", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }
    }
}
