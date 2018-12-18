using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KhanaMangwana
{
    class DatabaseConnection
    {
        public static SqlConnection Connection;
        private static DatabaseConnection dbcon = new DatabaseConnection(); //To initialize the connection. Dont need to use;

        string ConnString;
        
        private DatabaseConnection()
        {
            string DataSource = "DESKTOP-HMD9H15\\SQLEXPRESS;"; //Set this to your machine's specific

            ConnString = "Data Source = " + DataSource + "Initial Catalog = KhanaMangwanaDatabase;" + "Integrated Security = True";
            Connection = new SqlConnection(ConnString);
            
        }

        static public SqlDataReader Select(string table_name, String[] Collumns)
        {
            Connection.Open();
            string QueryString = "SELECT ";
            for (int i = 0; i < Collumns.Length ; i++)
            {
                QueryString += Collumns[i];
                if (i + 1 != Collumns.Length)
                {
                    QueryString += ", ";
                }
                else
                {
                    QueryString += " ";
                }
            }
            QueryString += "FROM " + table_name + ";";
            SqlCommand command = new SqlCommand(QueryString, DatabaseConnection.Connection);
            SqlDataReader reader = command.ExecuteReader();
            Connection.Close();
            return reader;
        }

        static public SqlDataReader SelectAll(string table_name)
        {
            string QueryString = "SELECT * FROM " + table_name + ";";
            SqlCommand command = new SqlCommand(QueryString, DatabaseConnection.Connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        static public List<string[]> Parse(SqlDataReader reader)
        {
            List<string[]> TableData = new List<string[]>();

            int collumns = reader.FieldCount;
            while (reader.Read())
            {
                string[] temp = new string[collumns];
                for (int i = 0; i < collumns; i++)
                {
                    temp[i] = reader[i].ToString();
                }
                TableData.Add(temp);
            }
            return TableData;
        }

        static public void InsertInto()
        { 
        }

        static public void UpdateIn()
        {
            
        }

        static public void DeleteFrom()
        {
        }

    }
}
