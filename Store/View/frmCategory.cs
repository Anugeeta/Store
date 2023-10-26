using Store.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.View
{
    public partial class frmCategory : Sample_View
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        public void getdata()
        {
            string qry = "Select * From category where catname like '%"+ txtsearch.Text +"%' ";
            ListBox lb=new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            MainClass.loadata(qry, gunaDataGridView1, lb);

        }
        public override void btnadd_Click(object sender, EventArgs e)
        {
            getdata();
            fromCategoryAdd frm = new fromCategoryAdd();
            frm.ShowDialog();      
        }
        public override void txtsearch_TextChanged(object sender, EventArgs e)
        {
            getdata();
        }
        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            getdata();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                fromCategoryAdd frm = new fromCategoryAdd();
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
               frm.txtName.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                getdata();
            }
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from category where catid=" + id+ "";
                Hashtable ht = new Hashtable();
                MainClass.SQL(qry, ht);

                MessageBox.Show("Deleted Succesfully");
                getdata();
            }


        }
    }
}
