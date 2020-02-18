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
    public partial class add_new_user : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\InventoryApp1\InventoryApp\Database2.mdf;Integrated Security=True");
        public add_new_user()
        {
            InitializeComponent();
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtEmail.Text)) // preveri, če so zahtevani textboxi prazni
            {
                MessageBox.Show("Prosim, zapolnite vsa obvezna polja.");
            }
            else
            {
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from registration where username = '" + txtUserName.Text + "'";
                cmd.ExecuteNonQuery(); // vrne število spremenjenih vrstic v bazi z (DELETE;UPDATE;INSERT) tukaj pa za vsak slucaj
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into registration values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "')"; // SQL insert stavek
                    cmd1.ExecuteNonQuery();

                    txtFirstName.Text = ""; txtLastName.Text = ""; txtUserName.Text = "";
                    txtPassword.Text = ""; txtEmail.Text = ""; txtPhone.Text = "";
                    display(); // funkcija za prikaz podatkov v DataGridWiev

                    MessageBox.Show("Nov uporabik uspešno vstavljen."); // obvestilo ob primeru veljavnosti pogoja

                }
                else
                {
                    MessageBox.Show("To Uporabiško Ime že obstaja, prosim izberite drugega."); // obvestilo ob primeru neveljavnosti pogoja
                }
            }
        }

        private void add_new_user_Load(object sender, EventArgs e)
        {
            // na začetku je povezava vedko zaprta ampak se vseeno preveri, če je odprta

            if (con.State == ConnectionState.Open) // preveri ali je povezava vzpostavljena
            {
                con.Close(); // zapre povezavo
            }
            con.Open(); // odpre povezavo
            display(); // funkcija za prikaz podatkov v DataGridWiev
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void display() // funkcija za prikaz podatkov v DataGridWiev
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            try                                                                         
            {                                                                           
                id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()); //izpis podatkov v poizvedbi (DataGridView)
            }
            catch 
            {
                MessageBox.Show("Nemoreš Izbrisati neobsotječega uporabnika."); // Error Message, če izbrišemo NULL vrstico.
                throw;
            }
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;// shranim tekst v s tip ukaza
            cmd.CommandText = "delete from registration where id = "+ id +""; // SQL stavek za izbris podatkov določenega uporabnika iz baze podatkov
            cmd.ExecuteNonQuery();

            display(); // funkcija za prikaz podatkov
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
