using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DNotaCredito
    {
        SqlConnection cn;

        public DataTable SelectNotasCredito()
        {
            DataTable miTabla = new DataTable("1_nota_credito");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectNotasCredito", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectNotasCreditoNoRegistradas()
        {
            DataTable miTabla = new DataTable("1_nota_credito");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectNotasCreditoNoRegistradas", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable SelectNotasCreditoByCodNotaAndSumado(int cod_nc, bool sumado)
        {
            DataTable miTabla = new DataTable("1_nota_credito");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("SelectNotasCreditoByCodNotaAndSumado", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_nc", cod_nc);
                cmd.Parameters.AddWithValue("@sumado", sumado);


                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public DataTable GetImporteAndDetalleNotaByCodNota(int cod_nc)
        {
            DataTable miTabla = new DataTable("1_nota_credito");
            SqlDataAdapter adapter;

            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("GetImporteAndDetalleNotaByCodNota", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_nc", cod_nc);


                adapter = new SqlDataAdapter(cmd);

                adapter.Fill(miTabla);

            }

            cn.Close();
            return miTabla;
        }

        public void InsertNotaCredito(int cod_pd, bool sumado, string detalle, decimal importe)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("InsertNotaCredito", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_pd", cod_pd);
                cmd.Parameters.AddWithValue("@sumado", sumado);
                cmd.Parameters.AddWithValue("@detalle", detalle);
                cmd.Parameters.AddWithValue("@importe", importe);


                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public void UpdateNotaCredito(int cod_nc, string detalle, decimal importe)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("UpdateNotaCredito", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_nc", cod_nc);
                cmd.Parameters.AddWithValue("@detalle", detalle);
                cmd.Parameters.AddWithValue("@importe", importe);


                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public void DeleteNotaCredito(int cod_nc)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("DeleteNotaCredito", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_nc", cod_nc);


                cmd.ExecuteNonQuery();

                cn.Close();

            }
        }

        public void RegistrarNotaCredito(int cod_nc, int cod_cuenta_corriente)
        {
            using (cn = Conexion.ConexionDB())
            {

                SqlCommand cmd = new SqlCommand("RegistrarNotaCredito", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@cod_nc", cod_nc);
                cmd.Parameters.AddWithValue("@cod_cuenta_corriente", cod_cuenta_corriente);


                cmd.ExecuteNonQuery();

                cn.Close();
            }
        }

    }
}
