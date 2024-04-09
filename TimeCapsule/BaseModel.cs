using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCapsule
{
    public class BaseModel
    {
        protected int Id;
        protected string tableName;
        
        public void Save()
        {
            
            if (this.Id == 0)
            {
                Database.GetInstance().insert(this.tableName, Database.ObjectToDictionary(this));
            }
            else
            {
                Database.GetInstance().update(this.tableName, Database.ObjectToDictionary(this));
            }
        }
        
        public void Delete()
        {
            if (this.Id != 0)
            {
                Database.GetInstance().delete(this.tableName, this.Id);
            }
        }

        public static void Delete(string tableName,int id)
        {
            if (id!=0)
            {
                Database.GetInstance().delete(tableName, id);
            }
        }
    }
}
