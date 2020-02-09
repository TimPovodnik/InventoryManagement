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
    public partial class login : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\InventoryApp1\InventoryApp\Database2.mdf;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }
  
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where username = '" + txtUsername.Text + "' and password = '" + txtPsw.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0) // če ne vrne ničesar (podatek ne obstaja)
            {
                MessageBox.Show("This Username and Password does not match");
                txtUsername.Text = ""; // resetira polje v prazno
                txtPsw.Text = ""; // resetira polje v prazno
                txtUsername.Focus(); // focus na Username
            }
            else
            {
                this.Hide();
                home h = new home(); // v mdi shrani index stran (home)         
                h.labelUser.Text = this.txtUsername.Text; // vzame text iz txtUsername v formu "login" in ga vpiše v labelUser v formu "home"
                h.Show(); // prikaže index stran (Home) 

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
