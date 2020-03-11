using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEmpleado
    {
       
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        SqlConnection cn;

        public DEmpleado GetNombreCompletoEmpleadoByCodEmpleado(int cod_emp)
        {
            DataTable miTabla = new DataTable("1_empleado");
            SqlDataAdapter adapter;
            DEmpleado miEmpleado = null;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetNombreCompletoEmpleadoByCodEmpleado", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_emp", cod_emp);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            if (miTabla.Rows.Count == 0) return miEmpleado;
            
            DataRow miRegistro = miTabla.Rows[0];

            miEmpleado = new DEmpleado
            {
                Nombre = miRegistro["nom_emp"].ToString(),
                Apellido = miRegistro["ape_emp"].ToString()
            };

            cn.Close();
            return miEmpleado;
        }


    }
}
