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
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void btnsave_Click(object sender, EventArgs e)
        {
           

        }

        public virtual void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
