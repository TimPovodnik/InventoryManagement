using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryApp
{
    public partial class purchase_product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\InventoryApp1\InventoryApp\Database2.mdf;Integrated Security=True");
        public purchase_product()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void purchase_product_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            fill_product_name(); // ob vzpostavitvi povezave z bazo, ukaz zapolni comboBoxProductName s podadki iz tabele "product_name"
            fill_supplier_name(); // ob vzpostavitvi povezave z bazo, ukaz zapolni comboBoxSupplierName s podadki iz tabele "supplier_info"
        }


        //
        // COMBO BOX - PRODUCT NAME
        //
        public void fill_product_name() // zapolni comboBoxProductName s podadki iz tabele "product_name"
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_name";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxProductName.Items.Add(dr["product_name"].ToString());
            }
        }


        //
        // COMBO BOX - SUPPLIER NAME
        //
        public void fill_supplier_name() // zapolni comboBoxSupplierName s podadki iz tabele "supplier_info"
        { 
           SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from supplier_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxSupplierName.Items.Add(dr["supplier_name"].ToString());
            }
        }


        //
        // LABEL UNIT
        //
        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_name where product_name = '" + comboBoxProductName.Text + "'"; // stavek ki prikaze vse podatke iz produktov in kasneje prikaze to v label "Unit"
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                labelUnit.Text = (dr["units"].ToString()); // to v label prikaze enoto katera pripada izbanemu izdelku v ComboBoxuProductName (tabela product_name)
            }
        }


        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtTotal.Text = Convert.ToString(Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text)); // skupni znesek je količina * cena
        }

        private void comboBoxSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
         // ni v uporabi (pomota)
        }


        //
        // INSERT SQL STAVEK
        //
        private void buttonPurchaseProduct_Click(object sender, EventArgs e)
        {
            int i;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from stock where product_name = '"+ comboBoxProductName.Text + "'"; // stavek ki prikaze vse podatke iz produktov
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            i = Convert.ToInt32(dt1.Rows.Count.ToString());

            if(i==0) // če je record 0 ( ni na voljo v "stock") insertamo v zalogo v "purchase_product", če pa izdelek že obstaja potem pa posodobimo količino "product_quantity"
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into purchase_product values('"+comboBoxProductName.Text + "','" + txtQuantity.Text + "','" + labelUnit.Text + "','" + txtPrice.Text + "','" + txtTotal.Text + "','" + dateTimePickerPurchase.Value.ToString("dd-MM-yyyy") + "','" + comboBoxSupplierName.Text + "','" + comboBoxPuchaseType.Text + "','" + dateTimePickerExpiration.Value.ToString("dd-MM-yyyy") + "','" + txtProfit.Text + "')"; // stavek ki prikaze vse podatke iz produktov in kasneje prikaze to v label "Unit"
                cmd.ExecuteNonQuery();

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into stock values('"+comboBoxProductName.Text + "','" + txtQuantity.Text + "','" + labelUnit.Text + "')"; // stavek ki prikaze vse podatke iz produktov in kasneje prikaze to v label "Unit"
                cmd3.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "insert into purchase_product values('"+comboBoxProductName.Text + "','" + txtQuantity.Text + "','" + labelUnit.Text + "','" + txtPrice.Text + "','" + txtTotal.Text + "','" + dateTimePickerPurchase.Value.ToString("dd-MM-yyyy") + "','" + comboBoxSupplierName.Text + "','" + comboBoxPuchaseType.Text + "','" + dateTimePickerExpiration.Value.ToString("dd-MM-yyyy") + "','" + txtProfit.Text + "')"; // stavek ki prikaze vse podatke iz produktov in kasneje prikaze to v label "Unit"
                cmd2.ExecuteNonQuery();

                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "update stock set product_quantity = product_quantity + " + txtQuantity.Text +" where product_name = '"+comboBoxProductName.Text + "' "; // stavek ki posodobi količino v "stock" in "comboBoxProductName"
                cmd5.ExecuteNonQuery();
                
            }
            MessageBox.Show("Product was purhased successfully.");
        }

        
    }
}
