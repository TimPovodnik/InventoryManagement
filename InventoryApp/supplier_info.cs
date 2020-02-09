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
    public partial class supplier_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\InventoryApp1\InventoryApp\Database2.mdf;Integrated Security=True");

        public supplier_info()
        {
            InitializeComponent();
        }


        //
        // ADD NEW SUPPLIER - BUTTON
        //
        private void buttonAddNewSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text) || string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrEmpty(txtAdress.Text) || string.IsNullOrEmpty(txtCity.Text)) // preveri, če so textboxi prazni
            {
                MessageBox.Show("Please fill all of the required fields.");
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into supplier_info values('" + txtSupplierName.Text + "','" + txtCompanyName.Text + "','" + txtPhone.Text + "','" + txtAdress.Text + "','" + txtCity.Text + "')";
                cmd.ExecuteNonQuery();

                txtSupplierName.Text = "";
                txtCompanyName.Text = "";
                txtPhone.Text = "";
                txtAdress.Text = "";
                txtCity.Text = "";

                dg();
                MessageBox.Show("New supplier inserted successfully.");
            }
        }

        private void supplier_info_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dg(); // funkcija za prikaz podatkov v DataGridWiev
        }

        public void dg() // DataGridWiev
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from supplier_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        //
        // DELETE - BUTTON
        //
        private void buttonDeleteSelecedSupplier_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from supplier_info where id = "+ id +"";
            cmd.ExecuteNonQuery();

            dg();
        }

        private void gradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }


        //
        // UPDATE SELECTED ROW - BUTTON 
        //
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; // gumb prikaze panel

            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from supplier_info where id="+ id +"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                textBox5.Text = dr["supplier_name"].ToString();
                textBox4.Text = dr["supplier_company_name"].ToString();
                textBox3.Text = dr["phone"].ToString();
                textBox2.Text = dr["adress"].ToString();
                textBox1.Text = dr["city"].ToString();
            }
        }

        private void buttonUpdateSelectedSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text)) // preveri, če so textboxi prazni
            {
                MessageBox.Show("Please fill all of the required fields.");
            }
            else
            {
                int id;
                id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update supplier_info set supplier_name ='" + textBox5.Text + "',supplier_company_name ='" + textBox4.Text + "',phone ='" + textBox3.Text + "',adress ='" + textBox2.Text + "', city ='" + textBox1.Text + "'  where id=" + id + "";
                cmd.ExecuteNonQuery();

                panel1.Visible = false;
                dg();
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
