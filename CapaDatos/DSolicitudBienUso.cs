using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DSolicitudBienUso
    {
        private SqlConnection cn;

        public void InsertSolicitudBienDeUso(int cod_sc, int cod_pro_buso, int cantidad, int cod_mar)
        {
            using (cn = Conexion.ConexionDB())
            {
                
                SqlCommand cmd = new SqlCommand("InsertSolicitudBienDeUso", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);
                cmd.Parameters.AddWithValue("@cod_pro_buso", cod_pro_buso);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@cod_mar", cod_mar);

                cmd.ExecuteNonQuery() ;

                cn.Close();

            }
        }

        public void DeleteBienesPorSolcitudCompra(int cod_sc)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteBienesPorSolcitudCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);

                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public DataTable GetBienesUsoEnSolicitudCompra(int cod_sc)
        {
            DataTable miTabla = new DataTable("1_buso_sc");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetBienesUsoEnSolicitudCompra", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_sc", cod_sc);

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }
    }
    
}
