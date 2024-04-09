using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCapsule
{
    public class NoteModel : BaseModel
    {
        private string Note;
        private DateTime Display_date;
        private DateTime Created_at;
        private int Unread = 1;
        public int id { get => Id; set { } }
        public string note { get => Note; set => Note = value; }
        public DateTime display_date { get => Display_date; set => Display_date = value; }
        public DateTime created_at { get => Created_at; set => Created_at = value; }
        public int unread { get => Unread; set => Unread = value; } 
        public NoteModel(int id, string note, DateTime display_date, DateTime created_at)
        {
            this.Id = id;
            this.Note = note;
            this.Display_date = display_date;
            this.Created_at = created_at;
            this.tableName = "note";
            Database.GetInstance().Connect();
        }
        public NoteModel(string note, DateTime display_date, DateTime created_at)
        {
            this.Id = 0;
            this.Note = note;
            this.Display_date = display_date;
            this.Created_at = created_at;
            this.tableName = "note";
            Database.GetInstance().Connect();
        }
     
        public static List<NoteModel> SelectQuery(Dictionary<string, string[]> joinTableandFields = null, Dictionary<string, object> parameters = null, string whereClause = null)
        {
            Database.GetInstance().Connect();
            List<NoteModel> booksList = new List<NoteModel>();
            using (MySqlDataReader reader = Database.GetInstance().selectQuery("note", joinTableandFields, parameters, whereClause))
            {
                while (reader.Read())
                {
                    NoteModel model = new NoteModel(Convert.ToInt32(reader["id"]), reader["note"].ToString(), DateTime.Parse(reader["display_date"].ToString()), DateTime.Parse(reader["created_at"].ToString()));
                    booksList.Add(model);
                }
            }
            return booksList;
        }
        /*
        public string getAuthorName()
        {
            return authorName;
        }
        public void setAuthorName(string authorName)
        {
            this.authorName=authorName;
        }
        private static bool ColumnExists(DataTable schemaTable, string columnName)
        {
              foreach (DataRow row in schemaTable.Rows)
              {
                if(row["ColumnName"].ToString()==columnName)
                    return true;
              }
             return false;
        }
        */
    }
}
