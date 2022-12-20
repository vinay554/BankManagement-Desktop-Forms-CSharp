using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class BankDataClass
    {
        private SqlConnection BDBConnection;
        string BDBConnString = ConfigurationManager.ConnectionStrings["BankingApplication.Properties.Settings.banking_dbConnectionString"].ConnectionString;
        
        private SqlConnection GetConnection()
        {
            if(BDBConnection == null)
            {
                BDBConnection = new SqlConnection(BDBConnString);
            }
            return BDBConnection;
        }
        private void OpenConnection()
        {
            if(BDBConnection.State == ConnectionState.Closed)
            {
                BDBConnection.Open();
            }
        }
        private void CloseConnection()
        {
            BDBConnection.Close();  
        }
        internal SqlDataReader GetReader(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null)
        {
            SqlCommand BdbSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            BdbSqlCommand.CommandType = cmdType;    

            if(param1 != null)
            {
                BdbSqlCommand.Parameters.Add(param1);
            }
            if (param2 != null)
            {
                BdbSqlCommand.Parameters.Add(param2);
            }
            if (param3 != null)
            {
                BdbSqlCommand.Parameters.Add(param3);
            }

            try
            {
                this.OpenConnection();
                return BdbSqlCommand.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                BdbSqlCommand.Dispose();
            }
        }

        public DataTable GetTable(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null)
        {
            DataTable table = new DataTable();
            SqlDataReader reader = null;


            try
            {
                reader = GetReader(procNameOrQuery, cmdType, param1, param2, param3);
                table.Load(reader);
                reader.Close();
                return table;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int ExecNonQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null, SqlParameter param7 = null, SqlParameter param8 = null, SqlParameter param9 = null, SqlParameter param10 = null, SqlParameter param11 = null, SqlParameter param12 = null, SqlParameter param13 = null)
        {
            SqlCommand BdbSqlCommand = new SqlCommand(procNameOrQuery,this.GetConnection());
            BdbSqlCommand.CommandType = cmdType;

            if (param1 != null)
            {
                BdbSqlCommand.Parameters.Add(param1);
            }
            if (param2 != null)
            {
                BdbSqlCommand.Parameters.Add(param2);
            }
            if (param3 != null)
            {
                BdbSqlCommand.Parameters.Add(param3);
            }
            if (param4 != null)
            {
                BdbSqlCommand.Parameters.Add(param4);
            }
            if (param5 != null)
            {
                BdbSqlCommand.Parameters.Add(param5);
            }
            if (param6 != null)
            {
                BdbSqlCommand.Parameters.Add(param6);
            }
            if (param7 != null)
            {
                BdbSqlCommand.Parameters.Add(param7);
            }
            if (param8 != null)
            {
                BdbSqlCommand.Parameters.Add(param8);
            }
            if (param9 != null)
            {
                BdbSqlCommand.Parameters.Add(param9);
            }
            if (param10 != null)
            {
                BdbSqlCommand.Parameters.Add(param10);
            }
            if (param11 != null)
            {
                BdbSqlCommand.Parameters.Add(param11);
            }
            if (param12 != null)
            {
                BdbSqlCommand.Parameters.Add(param12);
            }
            if (param13 != null)
            {
                BdbSqlCommand.Parameters.Add(param13);
            }

            try
            {
                this.OpenConnection();
                return BdbSqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
                BdbSqlCommand.Dispose();
            }
        }
        public Object ExecuteScalarQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null)
        {
            SqlCommand BdbSqlCommand = new SqlCommand(procNameOrQuery,this.GetConnection());
            BdbSqlCommand.CommandType = cmdType;

            if (param1 != null)
            {
                BdbSqlCommand.Parameters.Add(param1);
            }
            if (param2 != null)
            {
                BdbSqlCommand.Parameters.Add(param2);
            }
            if (param3 != null)
            {
                BdbSqlCommand.Parameters.Add(param3);
            }

            try
            {
                this.OpenConnection();
                return BdbSqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
                BdbSqlCommand.Dispose();
            }

        } 
        public DataSet GetDataSet(string sqlString)
        {
            DataSet BdbDataSet = new DataSet();

            try
            {
                SqlDataAdapter BdbAdapter = new SqlDataAdapter(sqlString, this.GetConnection());
                this.OpenConnection();
                BdbAdapter.Fill(BdbDataSet);
                return BdbDataSet;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
