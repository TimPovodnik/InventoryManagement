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
    public partial class sales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\InventoryApp1\InventoryApp\Database2.mdf;Integrated Security=True");
        DataTable dt = new DataTable(); //začasna tabela (ustvarim tukaj)
        int tot = 0;
        public sales()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sales_Load(object sender, EventArgs e)
        {
            // na začetku je povezava vedko zaprta ampak se vseeno preveri, če je odprta

            if (con.State == ConnectionState.Open) // preveri ali je povezava vzpostavljena
            {
                con.Close(); // zapre povezavo
            }
            con.Open(); // odpre povezav

            dt.Clear(); // začasna tabela 
            dt.Columns.Add("product");
            dt.Columns.Add("price");
            dt.Columns.Add("quantity");
            dt.Columns.Add("total_product_price");
        }


        //
        // IZ BAZE V LIST BOX IN NATO TEXT BOX
        //
        private void txtProduct_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Visible = true;

            listBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock where product_name like ('"+ txtProduct.Text +"%')"; // v bazi poisce vse kar vnesem v text box
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["product_name"].ToString()); // v listBox doda stvari, ki jih napisem in izberem
            }

        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;
                }

                if (e.KeyCode == Keys.Up)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    txtProduct.Text = listBox1.SelectedItem.ToString(); //tisto kar izberem in ko pritisnem enter, se pojavi v txtProduct
                    listBox1.Visible = false;
                    txtPrice.Focus(); // ko kliknem enter se focus preusmeri na txtPrice
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from purchase_product where product_name = '" + txtProduct.Text + "' order by id"; // v bazi poisce ceno, ki pripada izbranemu izdelku iz listboxa ("pozneje jo v foreach zanki izpise v txtPrice")
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtPrice.Text = dr["product_price"].ToString(); // v txtPrice doda ceno izdelka , ki ga izberem v listBox1
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            try 
            {
                txtTotalProductPrice.Text = Convert.ToString(Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text)); // v txtTotalProductPrice se zapise zmnozek vrednosti iz txtPrice in txtQuantity
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int stock = 0;
            SqlCommand cmd1 = con.CreateCommand();                                                   
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = " select * from stock where product_name = '"+ txtProduct.Text +"'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                stock = Convert.ToInt32(dr1["product_quantity"].ToString()); // v stock shrani količino izbranega produkta
            }

            if(Convert.ToInt32(txtQuantity.Text) > stock)
            {
                MessageBox.Show("This much stock value is not available");
            }
            else 
            {
                DataRow dr = dt.NewRow(); // če stock ni available, naredi novo tabelo
                dr["product"] = txtProduct.Text;
                dr["price"] = txtPrice.Text;
                dr["quantity"] = txtQuantity.Text;
                dr["total_product_price"] = txtTotalProductPrice.Text;


                // tabelo dodamo v dataGridView1
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;


                tot = tot + Convert.ToInt32(dr["total_product_price"].ToString()); // "tot" je enako "tot" + "total_product_price" (iz tabele)

                label10.Text = tot.ToString();
            }
            txtProduct.Text = " ";
            txtPrice.Text = " ";
            txtQuantity.Text = " ";
            txtTotalProductPrice.Text = " ";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString())); // izbriše row (vrstico) iz DataGridView
                foreach ( DataRow dr1 in dt.Rows)
                {
                    tot = tot + Convert.ToInt32(dr1["total_product_price"].ToString());

                    label10.Text = tot.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonSaveAndPrintBill_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into order_user values('"+ txtFirstName.Text +"','"+ txtLastName.Text +"','"+ comboBoxBillType.Text +"','"+ dateTimePicker1.Value.ToString( "dd-MM-yyyy") +"')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from order_user order by id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            foreach ( DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into order_product values('" + orderid.ToString() + "','" + dr["product"].ToString() + "','" + dr["price"].ToString() + "','" + dr["quantity"].ToString() + "','" + dr["total_product_price"].ToString() + "')";
                cmd3.ExecuteNonQuery();

                txtFirstName.Text = " ";
                txtLastName.Text = " ";
                txtProduct.Text = " ";
                txtPrice.Text = " ";
                txtQuantity.Text = " ";
                txtTotalProductPrice.Text = " ";
                label10.Text = " ";

                dt.Clear(); // začasna tabela 
                dataGridView1.DataSource = dt;
                MessageBox.Show("Product inserted successfully.");
            }
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
    }
}
