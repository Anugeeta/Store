using Store.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void AddControls(Form f)
        {
            cpane.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
           cpane.Controls.Add(f);
            f.Show();
        }
       
        private void frmMain_Load(object sender, EventArgs e)
        {
           
            lbluser.Text = MainClass.USER;   

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategory());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddControls(new frmProduct());
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            AddControls(new frmBarcode());
        }
    }
}
