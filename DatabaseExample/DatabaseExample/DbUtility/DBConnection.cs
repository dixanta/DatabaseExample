using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseExample.DbUtility
{
    public class DBConnection
    {
        IDbConnection _Connection = null;

        public DBConnection(IDbConnection pConnection)
        {
            _Connection = pConnection;
        }

        //public string ConnectionString { get; set; }

        IDbCommand _Command = null;
        public void Open()
        {
            //_Connection.ConnectionString = ConnectionString;
            _Connection.Open();
        }

        public IDbCommand InitCommand(string sql,CommandType commandType)
        {
             _Command = new SqlCommand();
            _Command.CommandText = sql;
            _Command.CommandType = commandType;
            _Command.Connection = _Connection;
            return _Command;
        }

        public IDbDataParameter AddInParameter(string paramName, object paramValue, SqlDbType paramDbType)
        {
            SqlParameter _Param = new SqlParameter();
            _Param.ParameterName = paramName;
            _Param.Value = paramValue;
            _Param.SqlDbType = paramDbType;
            _Param.Direction = ParameterDirection.Input;
            return _Param;
        }

        public int ExecuteNonQuery()
        {
            return _Command.ExecuteNonQuery();
        }

        public IDataReader ExecuteReader()
        {
            return _Command.ExecuteReader();
        }

        public void Close()
        {
            if (_Connection.State != ConnectionState.Closed && _Connection != null)
            {
                _Connection.Close();
                _Connection = null;
            }
        }
    }
}
