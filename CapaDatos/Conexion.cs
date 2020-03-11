using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public static SqlConnection ConexionDB()
        {
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-E0RO2U7\\SQLSERVER; Initial Catalog =Sistemas_II_CPVC; Integrated Security = true");
            conexion.Open();
            return conexion;

            //PC NACHO
            //Data Source = DESKTOP-TJUAL38\\SQLSERVER; Initial Catalog =Sistemas_II_CPVC; Integrated Security = true

            // PC Jonathan:
            // Data Source = DESKTOP-E0RO2U7\\SQLSERVER; Initial Catalog =Sistemas_II_CPVC; Integrated Security = true
        }
    }
}
