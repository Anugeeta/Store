﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Model
{
    public partial class fromCategoryAdd : SampleAdd
    {
        public fromCategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
              
                qry = "Insert into category values(NULL,@Name)";

            }
            else
            {
                qry = "Update category Set catname = @Name where catid = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name",txtName.Text);

            if(MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
           
        }
      

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {

                qry = "Insert into category Values(NULL,@Name)";

            }
            else
            {
                qry = "Update category Set catname = @Name where catid = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
           
        }
    }
}
