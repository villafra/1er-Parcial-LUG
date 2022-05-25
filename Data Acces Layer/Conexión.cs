using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces_Layer
{
    public class Conexión
    {
        private SqlConnection conexion;

        private void AbrirConexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["Conexión"].ToString();
            conexion.Open();
        }

        private void CerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }

        public DataSet DevolverListado(string query)
        {
            AbrirConexion();
            DataSet Ds = new DataSet();
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter(query, conexion);
                DataAdapter.Fill(Ds);
            }
            catch (SqlException sql)
            {
                throw new Exception(sql.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return Ds;
        }

        public DataSet ListarStoreProcedure(string query)
        {                
            AbrirConexion();
            DataSet Ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DataAdapter = new SqlDataAdapter();
                DataAdapter.SelectCommand = cmd;
                DataAdapter.Fill(Ds);
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return Ds;
        }
        public bool LeerScalar(string query)
        {
            AbrirConexion();
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool EscribirTransaction(string query)
        {
            AbrirConexion();
            SqlTransaction sqlTransaction;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = query;
            sqlTransaction = conexion.BeginTransaction();
            bool status = false;
            try
            {
                cmd.Transaction = sqlTransaction;
                cmd.ExecuteNonQuery();
                sqlTransaction.Commit();
                status = true;
            }
            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                status = false;
                throw ex;
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                status = false;
                throw ex;
            }
            finally
            {
                CerrarConexion();
               
            }
            return status;
        }

        public bool EscribirTransaction(string[] query)
        {
            AbrirConexion();
            SqlTransaction sqlTransaction;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            sqlTransaction = conexion.BeginTransaction();
            bool status = false;
            try
            {
                for (int i = 0; i < query.Length; i++)
                {
                    cmd.CommandText = query[i];
                    cmd.Transaction = sqlTransaction;
                    cmd.ExecuteNonQuery();
                }
                sqlTransaction.Commit();
                status = true;
            }
            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                status = false;
                throw ex;
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                status = false;
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return status;
        }
    }
}
