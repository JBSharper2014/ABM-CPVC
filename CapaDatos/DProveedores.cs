using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DProveedores
    {


        SqlConnection cn;


        public DataTable SelectProveedores()
        {
            DataTable miTabla = new DataTable("1_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectProveedores", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectNombresProveedores()
        {
            DataTable miTabla = new DataTable("1_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectNombresProveedores", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public string InsertProveedor(string nombre, string telefono, int cod_dir, int cp, string email, string razon_social)
        {
            string respuesta;


            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertProveedor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@cod_dir", cod_dir);
                cmd.Parameters.AddWithValue("@cp", cp);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@razon_social", razon_social);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se ingresó el proveedor correctamente" : "Error al ingresar el proveedor";

                cn.Close();

            }

            return respuesta;
        }

        public string UpdateProveedor(int cod_proveedor, string nombre, string telefono, int cod_dir, int cp, string email,
            string razon_social)
        {

            string respuesta;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateProveedor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@cod_dir", cod_dir);
                cmd.Parameters.AddWithValue("@cp", cp);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@razon_social", razon_social);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Se modificó el proveedor correctamente" : "Error al modificar el proveedor";

                cn.Close();
                return respuesta;

            }
        }

        public void DeleteProveedor(int cod_proveedor)
        {

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteProveedor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);

                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }

        public DataTable SelectProveedorByNombre(string nombre)
        {
            DataTable miTabla = new DataTable("1_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectProveedorByNombre", cn)
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

        public DataTable SelectCodAndRazonProveedoresSinCuentaCorriente()
        {
            DataTable miTabla = new DataTable("1_proveedor");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectCodAndRazonProveedoresSinCuentaCorriente", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public string InsertStockProveedor(int cod_proveedor, int cod_pro_stock)
        {
            string respuesta;

            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("InsertStockProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);
                    cmd.Parameters.AddWithValue("@cod_pro_stock", cod_pro_stock);
                    cmd.ExecuteNonQuery();

                    cn.Close();

                }
                respuesta = "Se agregó el producto al proveedor correctamente.";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el producto al proveedor. " + Environment.NewLine +
                    "Ya existe el producto seleccionado con el proveedor seleccionado";
            }


            return respuesta;
        }

        public string InsertBienUsoProveedor(int cod_proveedor, int cod_pro_buso)
        {
            string respuesta;

            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("InsertBienUsoProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);
                    cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);
                    cmd.ExecuteNonQuery();

                    cn.Close();

                }
                respuesta = "Se agregó el bien de uso al proveedor correctamente.";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el bien de uso al proveedor. " + Environment.NewLine +
                    "Ya existe el bien de uso seleccionado con el proveedor seleccionado";
            }


            return respuesta;
        }

        public bool ExisteStockProveedor(int cod_pro_stock)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("ExisteStockProveedor", cn)
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



        public bool ExisteBienUsoProveedor(int cod_pro_buso)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("ExisteBienUsoProveedor", cn)
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

        public string DeleteStockProveedor(int cod_proveedor)
        {
            string respuesta;

            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("DeleteStockProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);
                    cmd.ExecuteNonQuery();

                    cn.Close();

                }
                respuesta = "Se eliminó la asociación del proveedor con los productos que proveía";
            }
            catch (Exception ex)
            {
                respuesta = "No se pudo eliminar la asociación del proveedor con los productos que provee:" +
                    Environment.NewLine + ex.Message;
            }

            return respuesta;
        }

        public string DeleteBienesUsoProveedor(int cod_proveedor)
        {
            string respuesta;

            try
            {
                using (cn = Conexion.ConexionDB())
                {

                    SqlCommand cmd = new SqlCommand("DeleteBienesUsoProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);
                    cmd.ExecuteNonQuery();

                    cn.Close();

                }
                respuesta = "Se eliminó la asociación del proveedor con los bienes de uso que proveía";
            }
            catch (Exception ex)
            {
                respuesta = "No se pudo eliminar la asociación del proveedor con los bienes de uso que provee:" +
                    Environment.NewLine + ex.Message;
            }

            return respuesta;
        }

        public bool ProveedorTieneCBU(int cod_proveedor)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("ProveedorTieneCBU", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_proveedor", cod_proveedor);

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
