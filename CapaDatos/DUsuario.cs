using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DUsuario
    {
        //private static usuarioTableAdapter adapter = new usuarioTableAdapter();

        public int IDUsuario { get; set; }
        public int CodEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public bool CuentaActiva { get; set; }
        SqlConnection cn;

        public bool ValidarUsuario(string IDUsuario, string Clave)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("ValidarUsuario", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@nom_usu", IDUsuario);
                cmd.Parameters.AddWithValue("@psw_usud", Clave);

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


        public DUsuario GetUsuario(string IDUsuario)
        {
            DUsuario miUsuario = null;
            DataTable miTabla = new DataTable("1_usuario");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetUsuario", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@nom_usu", IDUsuario);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            if (miTabla.Rows.Count == 0) return miUsuario;


            DataRow miRegistro = miTabla.Rows[0];
            miUsuario = new DUsuario
            {
                IDUsuario = (int)miRegistro["cod_usu"],
                CodEmpleado = (int)miRegistro["cod_emp"],
                NombreUsuario = miRegistro["nom_usu"].ToString(),
                Clave = miRegistro["psw_usu"].ToString(),
                CuentaActiva = (bool)miRegistro["cuenta_activa_usu"]
            };

            cn.Close();
            return miUsuario;
        }
    }
}
