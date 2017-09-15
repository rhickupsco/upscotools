using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LabelPrinter.Data_Access
{
    public class SQLDataAccess
    {
        private SqlConnection Conn;
        private SqlCommand Comm;
        private SqlDataReader Dr;
        private string ConnectionString;

        private DataTable Dt;
        public DataTable GetAllDataFromQuery(string sql, string parameter = null)
        {
            DataTable dtLocal = new DataTable();

            if (parameter != null)
            {
                //create a variable to store a parameter in, this parameter will replace the ? in the query you see from the database
                SqlParameter itemParam = new SqlParameter("@parameter", parameter);

                Initialize();
                Comm.Parameters.Add(itemParam);
                try
                {
                    Connect(sql);
                    dtLocal = Fill();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                Initialize();
                Connect(sql);
                dtLocal = Fill();
            }
            return dtLocal;
        }
        //public DataTable GetDynamicTableFromQuery(string sql, string[] parameter)
        //{
        //    return null;
        //}
        //public string GetSingleString(string sql, string parameter = null)
        //{

        //    if (parameter != null)
        //    {
        //        //create a variable to store a parameter in, this parameter will replace the ? in the query you see from the database
        //        SqlParameter itemParam = new SqlParameter("@parameter", parameter);

        //        Initialize();
        //        Comm.Parameters.Add(itemParam);
        //        try
        //        {
        //            Connect(sql);
        //            DataTable dtLocal = new DataTable();
        //            dtLocal = Fill();
        //            string strValue = null;
        //       //     strValue = dtLocal.Rows(0)(0).ToString;
        //            return strValue;
        //        }
        //        catch (Exception ex)
        //        {
        //            //MessageBox.Show(ex.ToString);
        //        }

        //    }
        //    else
        //    {
        //    }
        //    return null;
        //}

        //public DataRow GetSingleRow(string sql, string parameter = null)
        //{

        //    if (parameter != null)
        //    {
        //        //create a variable to store a parameter in, this parameter will replace the @parameter value in the query you see from the database
        //        SqlParameter itemParam = new SqlParameter("@parameter", parameter);

        //        Initialize();
        //        Comm.Parameters.Add(itemParam);
        //        try
        //        {
        //            Connect(sql);
        //            return DataRow;
        //        }
        //        catch (Exception ex)
        //        {
        //            //MessageBox.Show(ex.ToString);
        //        }

        //    }
        //    else
        //    {
        //    }
        //    return null;
        //}

        //public bool GetBooleanValue(string sql)
        //{
        //    return string.Empty();
        //}
        //public int GetCount(string sql)
        //{
        //    return null;
        //}
        //public double GetDouble(string sql)
        //{
        //    return null;
        //}
        //public int GetInteger(string sql)
        //{
        //    return null;
        //}

        private void Initialize()
        {
            Dt = new DataTable();
            //this is the reference to the SQL Connection string which is the login details and location of the SQL Database, 
            //can be modified in the APP.Config
            ConnectionString = LabelPrinter.Properties.Settings.Default.SqlDbConnection;
            Conn = new SqlConnection(ConnectionString);
            Comm = new SqlCommand();
        }

        private void Connect(string sql)
        {
            Comm.CommandText = sql;
            Comm.Connection = Conn;
            Conn.Open();
        }

        private DataTable Fill()
        {
            DataTable dt = new DataTable();

            Dr = Comm.ExecuteReader();
            //Fill dataTable with contents from datareader
            dt.Load(Dr);
            return dt;

        }

        public void Disconnect()
        {
            Conn.Close();
            Dr.Close();
            Comm.Dispose();
            Conn.Dispose();
            Dt.Dispose();
        }

    }
}
