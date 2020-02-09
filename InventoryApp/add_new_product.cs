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
    public partial class add_product_name : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\InventoryApp1\InventoryApp\Database2.mdf;Integrated Security=True");
        public add_product_name()
        {
            InitializeComponent();
        }

        private void add_product_name_Load(object sender, EventArgs e) 
        {
            // na začetku je povezava vedko zaprta ampak se vseeno preveri, če je odprta

            if (con.State == ConnectionState.Open) // preveri ali je povezava vzpostavljena
            {
                con.Close(); // zapre povezavo
            }
            con.Open(); // odpre povezavo

            fill_dd(); // doda vrstice v tabelo, tako da ustvari nove, če že ne obstajajo.
            fill_dg(); // doda vrstice v tabelo, tako da ustvari nove, če že ne obstajajo.
        }   // ko se vzpostavi povezava, fill funkcija zapolne DataGrid in DropDownMenu z podatki iz databaze


        //
        // POVEZAVA "UNITS" NA COMBO BOX
        //
            public void fill_dd() // fill drop down menu
            {
                comboBox1.Items.Clear(); //pošisti combo box
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from units"; // izbere vse podatke iz tabele units
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["unit"].ToString()); //v ComboBox doda podatke iz baze units
                }
            }


            public void fill_dg() // fill DataGridWiev
            {
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product_name";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        //
        //ADD NEW PRODUCT - BUTTON
        //
        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnterProductName.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please enter Product Name and select Unit.");

            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into product_name values('" + txtEnterProductName.Text + "','" + comboBox1.SelectedItem.ToString() + "')"; //SQL insert stavek
                cmd.ExecuteNonQuery();

                txtEnterProductName.Text = "";
                fill_dg(); //zapolni DataGridWiev z novimi podatki, ki jih vstavimo
                MessageBox.Show("Product inserted successfully.");
            }
        }


        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nedela vredu če je koda tu notr
   
        }


        //
        // IZPIS PODATKOV (SPODNJI DEL)
        //
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;

            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            comboBox2.Items.Clear(); // počisti comboBox2
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from units";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                comboBox2.Items.Add(dr2["unit"].ToString());
            }


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_name where id = "+ i +"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtProductName.Text = dr["product_name"].ToString(); // pošlje podatke iz tabele product_name v txtProductName
                comboBox2.Text = dr["units"].ToString(); // pošlje podatke iz tabele product_name v ComboBox2
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(comboBox2.Text) || (comboBox2.Text == txtProductName.Text)  )// preveri, če so textboxi prazni // NEDELA HELP!!!
            {
                MessageBox.Show("Please fill all of the required fields.");
            }
            else
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()); // dobi id iz baze

                MessageBox.Show("Product was successfully updated.");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update product_name set product_name = '" + txtProductName.Text + "',units ='" + comboBox2.SelectedItem.ToString() + "'where id = " + i + "";
                cmd.ExecuteNonQuery();
                panel1.Visible = false;
                fill_dg();
            }
        }

        private void buttonDeleteSelectedUser_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from product_name where id = " + id + "";
            cmd.ExecuteNonQuery();

            fill_dg();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
    }
}
