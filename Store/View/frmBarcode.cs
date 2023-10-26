using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using Google.Protobuf.WellKnownTypes;
using K4os.Compression.LZ4.Internal;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using ZXing;
using ZXing.Aztec;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Store.View
{
    public partial class frmBarcode : Form
    {
        public int total=0;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public frmBarcode()
        {
            InitializeComponent();
        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                gunaComboBox1.Items.Add(Device.Name);
            }
            gunaComboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[gunaComboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            gunaPictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)gunaPictureBox1.Image);
            try
            {

                string decoded = result.ToString().Trim();
               
                if (decoded != "")
                {
                    timer1.Stop();
                    MessageBox.Show(decoded);
                      fetchdata(decoded);
                 

                }
                else
                {
                    MessageBox.Show("Scan properly");
                }

            }
            catch (Exception ex) { }
        }

        private void frmBarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

     //   public static readonly string str = "SERVER=localhost;DATABASE=STORE;UID=root;PASSWORD=";
       // public static MySqlConnection cnn = new MySqlConnection(str);

        DataTable productsTable = new DataTable();
        public void fetchdata(string decoded)
        {

            string str = "SERVER=localhost;DATABASE=STORE;UID=root;PASSWORD=";

            using (MySqlConnection connection = new MySqlConnection(str))
            {
                connection.Open();
                string query = @"select p_id,pname,cateogry,price from product where pname='" + decoded + "' and qty>0 ";


                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                   
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {


                        adapter.Fill(productsTable);
                        gunaDataGridView2.DataSource = productsTable;

                    }
                }
            }
            using (MySqlConnection connection = new MySqlConnection(str))
            {
                connection.Open();
                string qry2 = @"Update product Set qty = qty-1 where pname ='" + decoded + "' ";
                using (MySqlCommand command = new MySqlCommand(qry2, connection))
                {
                 
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Rows affected: {rowsAffected}");
                }
            }

            using (MySqlConnection connection = new MySqlConnection(str))
            {
                connection.Open();

                string query3 = @"select price from product where pname='" + decoded + "' ";

                using (MySqlCommand command = new MySqlCommand(query3, connection))
                {
                    
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                          
                           total+= reader.GetInt32(0);
                            
                        }

                    }
                }
            }
        }

        Bitmap bitmap;
        private void generatebill_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Total:" + total);
            textBox1.Text += total;
            int height = gunaDataGridView2.Height;
            gunaDataGridView2.Height=gunaDataGridView2.RowCount*gunaDataGridView2.RowTemplate.Height*2;
            bitmap=new Bitmap(gunaDataGridView2.Width, gunaDataGridView2.Height);
            gunaDataGridView2.DrawToBitmap(bitmap,new Rectangle(0,0,gunaDataGridView2.Width,gunaDataGridView2.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            gunaDataGridView2.Height = height;
          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            e.Graphics.DrawImage(bitmap, 0, 0);

        }
    }
}
