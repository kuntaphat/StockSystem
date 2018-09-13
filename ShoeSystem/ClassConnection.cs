using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace ShoeSystem
{
    public static class ClassConnection
    {
        public static string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb;Persist Security Info=True;";
        public static OleDbConnection connection;
        public static OleDbCommand command;
       // public static OleDbDataAdapter dataAdapter;
        //public static DataSet dataset;
        public static DataTable dataTable;
        public static int count = 0;
        public static string ID;

        public static void connectionDatabase()
        {
            connection = new OleDbConnection();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            else
            {

               
                connection.ConnectionString = strConn;
                connection.Open();
            }

        }
    }
}
