using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Store
{
     class MainClass
    {
        
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
        //Method for CRUD operations
        public static int SQL(string qry,Hashtable ht)
        {
            int res = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry,cnn);
                cmd.CommandType= CommandType.Text;
                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (cnn.State == ConnectionState.Closed) { cnn.Open(); }
                res = cmd.ExecuteNonQuery();
                if(cnn.State == ConnectionState.Open) { cnn.Close(); }
            }
            catch(Exception e)
            {
               // MessageBox.Show(e.ToString());
                //cnn.Close();
            }
            return res;
        }

        // for loading data from db
        public static void loadata(string qry,DataGridView gv,ListBox lb)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry,cnn);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da=new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for(int i=0;i<lb.Items.Count;i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();

                }
                gv.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                cnn.Close();
            }
        }
    }
}
