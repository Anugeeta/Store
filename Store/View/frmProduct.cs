using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Xml.Linq;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;
using ZXing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ZXing.QrCode;
using ZXing.Common;

namespace Store.View
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        private void LoadProductsByCategory(string selectedCategory)
        {
            // Connect to the database using your connection string
            string str = "SERVER=localhost;DATABASE=STORE;UID=root;PASSWORD=";
        
            using (MySqlConnection connection = new MySqlConnection(str))
            {
                connection.Open();
                string query = "SELECT * FROM product WHERE cateogry = @Category";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Category", selectedCategory);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                  /*      Hashtable ht = new Hashtable();
                        ht.Add("@p_id", Product_id);
                        ht.Add("@pname",ProductName);
                        ht.Add("@cateogry",Category);
                        ht.Add("@price", Price);
                        ht.Add("@qty", Quantity);
                  */
                        DataTable productsTable = new DataTable();
                        adapter.Fill(productsTable);
                        gridviewproduct.DataSource = productsTable;
                    }
                }
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
           
                // Get the selected category from the ComboBox
                string selectedCategory = combocategory.SelectedItem.ToString();

                // Call a method to load products based on the selected category
                LoadProductsByCategory(selectedCategory);
            
        }


        public void UpdateBarcodeInDatabase(int productId, string barcodeValue)
        {
            string str = "SERVER=localhost;DATABASE=STORE;UID=root;PASSWORD=";

            using (MySqlConnection connection = new MySqlConnection(str))
            {
                connection.Open();

                // Define an SQL update query to set the barcode value for the specified product
                string updateQuery = "UPDATE product SET Barcode = @Barcode WHERE p_id = @ProductId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcodeValue);
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        // The update was successful
                    }
                    else
                    {
                        // Handle the case where the update did not affect exactly one row
                    }
                }
            }
        }


        public string GenerateBarcode(string uniqueIdentifier)
        {
            // Create a BarcodeWriter instance
            BarcodeWriter barcodeWriter = new BarcodeWriter();

            // Set the barcode format (e.g., QR Code, BarcodeFormat.QR_CODE)
            barcodeWriter.Format = BarcodeFormat.QR_CODE; // You can choose a different format as needed

            // Set other options, such as width and height of the barcode image
            barcodeWriter.Options = new ZXing.Common.EncodingOptions
            {
                Width = 200,  // Adjust the width as needed
                Height = 200, // Adjust the height as needed
            };

            // Generate the barcode
           // BitMatrix bitMatrix = barcodeWriter.Encode(uniqueIdentifier);
            BitMatrix bitMatrix = barcodeWriter.Encode(uniqueIdentifier);


            // Convert the BitMatrix to a Bitmap image
            Bitmap barcodeBitmap = barcodeWriter.Write(bitMatrix);

            // Convert the Bitmap to a base64-encoded string (or save to a file, database, etc.)
            string base64Barcode = ConvertBitmapToBase64(barcodeBitmap);

            return base64Barcode;
        }

        // Helper method to convert a Bitmap image to a base64-encoded string
        private string ConvertBitmapToBase64(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    

       
public class Product
    {
        public int p_id { get; set; }
        public string pname { get; set; }
        public string cateogry{ get; set; }
        public int price{ get; set; }
            public int qty { get; set; }
            public string Barcode { get; set; }
            // Add other product properties here
        }

   
       

        public List<Product> GetProductsFromDatabase()
        {
            List<Product> products = new List<Product>();
            string str = "SERVER=localhost;DATABASE=STORE;UID=root;PASSWORD=";

            using (MySqlConnection connection = new MySqlConnection(str))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT p_id,pname,cateogry,price,qty FROM product", connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                p_id = Convert.ToInt32(reader["p_id"]),
                               pname = reader["pname"].ToString(),
                               cateogry = reader["cateogry"].ToString(),
                                price = Convert.ToInt32(reader["price"]),
                                qty = Convert.ToInt32(reader["p_id"])


                            };

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }


    private void gunaButton1_Click(object sender, EventArgs e)
        {
            // Assuming you have a list of products

            List<Product> products = GetProductsFromDatabase();

            foreach (Product p in products)
            {
                string barcodeValue = GenerateBarcode(p.pname);
                p.Barcode = barcodeValue;

                // Update the database with the generated barcode value
                UpdateBarcodeInDatabase(p.p_id, barcodeValue);
            }
            string selectedCategory = combocategory.SelectedItem.ToString();

            LoadProductsByCategory(selectedCategory);

        }
    }
}
