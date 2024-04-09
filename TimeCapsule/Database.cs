using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Reflection;
using System.Data.SqlClient;

namespace TimeCapsule
{
    internal class Database
    {
        private MySqlConnection connection;
        private static Database database;
        private Database()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }
        public static Database GetInstance()
        {
            if (database == null)
            {
                database = new Database();
            }
            return database;
        }

        public void Connect() // bağlantı kapalı ise bağlantı sağlar.
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void insert(string tableName, Dictionary<String, dynamic> FieldsAndValue)
        {
            string insertquery = insertPrepare(tableName, FieldsAndValue);
          
            MySqlCommand sqlCommand = new MySqlCommand(insertquery, connection);
            foreach (var field in FieldsAndValue)
            {
                sqlCommand.Parameters.Add(new MySqlParameter("@" + field.Key, field.Value));
            }
            //MessageBox.Show(sqlCommand.CommandText);
            sqlCommand.ExecuteNonQuery();
        }

        public void update(string tableName, Dictionary<String, dynamic> FieldsAndValue)
        {
            string updatequery = updatePrepare(tableName, FieldsAndValue);

            MySqlCommand sqlCommand = new MySqlCommand(updatequery, connection);
            foreach (var field in FieldsAndValue)
            {
                sqlCommand.Parameters.Add(new MySqlParameter("@" + field.Key, field.Value));
            }
            //MessageBox.Show(sqlCommand.CommandText);
            sqlCommand.ExecuteNonQuery();
        }
        public void delete(string tableName,int id)
        {
            string updatequery = deleteQueryPrepare(tableName);

            MySqlCommand sqlCommand = new MySqlCommand(updatequery, connection);
            sqlCommand.Parameters.Add(new MySqlParameter("@id", id));
            //MessageBox.Show(sqlCommand.CommandText);
            sqlCommand.ExecuteNonQuery();
        }
        public MySqlDataReader selectQuery(string tableName, Dictionary<string, string[]> joinTableandFields = null,Dictionary<string, object> parameters=null, string whereClause=null,string[] fields=null) { 
            string selectquery = selectQueryPrepare(tableName,joinTableandFields,whereClause,fields);
            MySqlCommand cmd = new MySqlCommand(selectquery, connection);
            MySqlDataReader reader;
            if (whereClause != null)
            {
                foreach (var field in parameters)
                {
                    cmd.Parameters.AddWithValue("@" + field.Key, field.Value);
                }
            }
            reader = cmd.ExecuteReader();
            return reader;
        }
        private string insertPrepare(string tableName, Dictionary<String, dynamic> FieldsAndValue)
        {
            
            string insertquery = "insert into " + tableName + "(";
            foreach (var field in FieldsAndValue)
            {
                insertquery += field.Key + ",";
            }
            insertquery = insertquery.Remove(insertquery.Length - 1);
            insertquery += ")Values(";
            foreach (var field in FieldsAndValue)
            {
                insertquery += "@" + field.Key + ",";
            }
            insertquery = insertquery.Remove(insertquery.Length - 1);
            insertquery += ");";
            return insertquery;
        }
        private string updatePrepare(string tableName, Dictionary<String, dynamic> FieldsAndValue)
        {
            string updatequery = "update " + tableName + " set ";
            foreach (var field in FieldsAndValue)
            {
                updatequery += field.Key + "="+"@"+field.Key+", ";
            }
            updatequery = updatequery.Remove(updatequery.Length - 1);
            updatequery = updatequery.Remove(updatequery.Length - 1);
            updatequery += " where id=@id";

            return updatequery;
        }
        private string deleteQueryPrepare(string tableName)
        {
            string deletequery = "delete from "+tableName+" where id=@id";
            return deletequery;
        }
        public string selectQueryPrepare(string tableName, Dictionary<string, string[]> joinTableandFields=null, string whereClause = null,string[] fields=null)
        {
            // SELECT kısmı oluşturulması
            string selectPart = "SELECT ";
            if (fields == null)
                selectPart += "*";
            else
            {
                foreach (var field in fields)
                {
                    selectPart += field + ",";
                }
                selectPart = selectPart.Remove(selectPart.Length - 1);
            }

            // FROM kısmı oluşturulması
            string fromPart = " FROM " + tableName;

            //JOIN kısmı oluşturulması
            string joinPart = "";
            if (joinTableandFields != null)
            {
                foreach (var field in joinTableandFields)
                {
                    joinPart += " inner join " + field.Key;
                    string alias = "";
                    if(field.Key.Contains(" "))
                        alias = field.Key.Split(' ')[1];
                    else
                        alias = field.Key;
                    joinPart += " on " + tableName + "." + field.Value[0]+"="+alias+"."+field.Value[1];
                }
               
            }
             
            // WHERE kısmı oluşturulması (eğer varsa)
            string wherePart = "";
            if (!string.IsNullOrEmpty(whereClause))
            {
                wherePart = " WHERE " + whereClause;
            }

            // Birleştirme ve son sorgunun oluşturulması
            string query = selectPart + fromPart+ joinPart + wherePart;
            //MessageBox.Show(query);
            return query;
        }
        public static Dictionary<string, object> ObjectToDictionary(object obj)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                dictionary.Add(property.Name, property.GetValue(obj));
            }

            return dictionary;
        }
    }
}
