using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;





namespace Anovsys.DAL
{
    public class Database : IDisposable
    {

        protected Anovsys.Encryption.Encrypt.AE_Encrypt aee = new Anovsys.Encryption.Encrypt.AE_Encrypt("bengkel1q2w3e");

        string startPath = "SERVER={0};UID={1};PASSWORD={2};DATABASE={3};PORT={4}";
        MySqlConnection _connection;
        MySqlTransaction _transaction;

        List<Command> _command;
        public string conn;
        public Database()
        {
            string fileName = "dbconfig.ini";

            string server = "";
            string user = "";
            string password = "";
            string database = "";
            string port = "";
            List<string> element = new List<string>();

            if (!File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.CreateNew))
                {
                    using (TextWriter w = new StreamWriter(fs))
                    {
                        w.WriteLine("localhost");
                        w.WriteLine("root");
                        w.WriteLine("");
                        w.WriteLine("dmx_logistic");
                        w.WriteLine("3306");
                    }
                }
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (TextReader r = new StreamReader(fs))
                {
                    int Count = 1;
                    string line = r.ReadLine();
                    while (line != null)
                    {
                        element.Add(line);
                        line = r.ReadLine();
                        Count++;
                    }
                }
            }

            if (element.Count > 0)
            {
                server = element[0];
                user = element[1];
                if (element[2] == "")
                {
                    password = element[2];
                }
                else
                {
                    password = element[2]; //password = aee.Decrypt(element[2], "retail1q2w3e", 128);
                }
                database = element[3];
                port = element[4];
            }

            conn = string.Format(startPath, server, user, password, database, port);
            

            try
            {
                _connection = new MySqlConnection(conn);
                _command = new List<Command>();
                _connection.Open();
            }
            catch
            {
                FormCONFIG frm = new FormCONFIG();
                frm.ShowDialog();
                return;
            }
        }
        public string stringCONN()
        {
            return conn;
        }
        public MySqlConnection Connection
        {
            get
            {
                return _connection;
            }
        }

        public List<Command> Commands
        {
            get
            {
                return _command;
            }
        }

        public MySqlTransaction Transaction
        {
            get
            {
                return _transaction;
            }
        }


        public Command CreateCommand(string procName)
        {
            Command cmd = new Command(procName);
            cmd.Database = this;
            return cmd;
        }

        public void Open()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Close()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public void BeginTransaction()
        {
            _transaction = _connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
            }
        }

        public void RollbackTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
            }
        }

        public void Dispose()
        {
            this.Close();
            _connection.Dispose();
        }

        public string DecodePassword(string password)
        {
            string result = "";

            password = password.Trim();

            for (int i = 0; i < password.Length; i++)
            {
                int x = (int)password[i];

                result += char.ConvertFromUtf32((x / 2) - 5);
            }
            return result;
        }
       
        public string EncodePassword(string password)
        {
            string result = "";

            password = password.Trim();

            for (int i = 0; i < password.Length; i++)
            {
                int x = (int)password[i];

                result += char.ConvertFromUtf32((x + 5) * 2);
            }
            return result;
        }
    }
 
    public class Command
    {
        string _procedureName;
        Database _db;
        List<Parameter> _paramaters;

        MySqlCommand cmd;
           

        public Command(string textName)
        {
            cmd = new MySqlCommand();
            cmd.CommandText = textName;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 5000;
            _paramaters = new List<Parameter>();
        }

        public Database Database
        {
            set
            {
                _db = value;
                cmd.Connection = _db.Connection;
            }
        }

        public List<Parameter> Parameters
        {
            get
            {
                return _paramaters;
            }
        }

        public string ProcedureName
        {
            get
            {
                return _procedureName;
            }
            set
            {
                _procedureName = value;
            }
        }

        public CommandType CommandType
        {
            get
            {
                return cmd.CommandType;
            }
            set
            {
                cmd.CommandType = value;
            }
        }

        public DataSet ExecuteDataSet()
        {
            MySqlDataAdapter objDa;
            MySqlParameter mysqlParam;
            DataSet ds = new DataSet();

            try
            {
                cmd.Parameters.Clear();
                foreach (Parameter param in this.Parameters)
                {
                    mysqlParam = new MySqlParameter(param.ParameterName, param.DataType);
                    mysqlParam.Value = param.Value;
                    cmd.Parameters.Add(mysqlParam);
                }

                objDa = new MySqlDataAdapter(cmd);
                objDa.Fill(ds);

                return ds;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecuteDataTable()
        {
            MySqlDataAdapter objDa;
            MySqlParameter mysqlParam;
            DataTable dt = new DataTable();

            try
            {
                cmd.Parameters.Clear();
                foreach (Parameter param in this.Parameters)
                {
                    mysqlParam = new MySqlParameter(param.ParameterName, param.DataType);
                    mysqlParam.Value = param.Value;
                    cmd.Parameters.Add(mysqlParam);
                }

                objDa = new MySqlDataAdapter(cmd);
                objDa.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecuteNonQuery()
        {
            MySqlParameter mysqlParam;
            int affectedRows;

            try
            {
                cmd.Parameters.Clear();

                foreach (Parameter param in this.Parameters)
                {
                    mysqlParam = new MySqlParameter(param.ParameterName, param.DataType);
                    mysqlParam.Value = param.Value;
                    cmd.Parameters.Add(mysqlParam);
                }


                if (this._db.Transaction != null)
                {
                    cmd.Transaction = this._db.Transaction;
                }

                affectedRows = cmd.ExecuteNonQuery();

                return affectedRows;
            }

            catch (MySqlException ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ExecuteScalar()
        {
            MySqlParameter mysqlParam;
            object returnValue;

            try
            {
                cmd.Parameters.Clear();

                foreach (Parameter param in this.Parameters)
                {
                    mysqlParam = new MySqlParameter(param.ParameterName, param.DataType);
                    mysqlParam.Value = param.Value;
                    cmd.Parameters.Add(mysqlParam);
                }

                if (this._db.Transaction != null)
                {
                    cmd.Transaction = this._db.Transaction;
                }

                returnValue = cmd.ExecuteScalar();

                return returnValue;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader ExecuteReader()
        {
            MySqlParameter mysqlParam;
            MySqlDataReader returnValue;

            try
            {
                cmd.Parameters.Clear();

                foreach (Parameter param in this.Parameters)
                {
                    mysqlParam = new MySqlParameter(param.ParameterName, param.DataType);
                    mysqlParam.Value = param.Value;
                    cmd.Parameters.Add(mysqlParam);
                }

                if (this._db.Transaction != null)
                {
                    cmd.Transaction = this._db.Transaction;
                }

                returnValue = cmd.ExecuteReader();

                return returnValue;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class Parameter
    {
        string _parameterName;
        MySqlDbType _dataType;
        object _value;

        public Parameter(string parameterName, MySqlDbType dataType, object value)
        {
            _parameterName = parameterName;
            _dataType = dataType;
            _value = value;
        }

        public string ParameterName
        {
            get
            {
                return _parameterName;
            }
            set
            {
                _parameterName = value;
            }
        }

        public MySqlDbType DataType
        {
            get
            {
                return _dataType;
            }
            set
            {
                _dataType = value;
            }
        }

        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}
