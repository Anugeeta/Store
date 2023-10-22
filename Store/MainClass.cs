using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace Store
{
    internal class MainClass
    {
        string connetionString;
      
        public static readonly string str = "SERVER=localhost;DATABASE=STORE;UID=root;PASSWORD=";
        public static MySqlConnection cnn = new MySqlConnection(str);
        // cnn.Open();
        // MessageBox.Show("Connection Open  !");
        // cnn.Close();
        public static bool isvaliduser(string user, string pass)
        {
            bool isvalid = false;
            string qry = @"select * from login where UNAME='" + user + "' and PASSWORD='" + pass + "' ";
            MySqlCommand cmd = new MySqlCommand(qry,cnn);
            DataTable dt = new DataTable();
            MySqlDataAdapter da= new MySqlDataAdapter(cmd);
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                isvalid = true;
                USER = dt.Rows[0]["UNAME"].ToString();
            }
            return isvalid;
        }
        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
    }
}
