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
    public partial class Unit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\InventoryApp1\InventoryApp\Database2.mdf;Integrated Security=True");
        public Unit()
        {
            InitializeComponent();
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        //
        //ADD NEW UNIT - BUTTON
        //
        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnit.Text)) // preveri, če je textbox prazen
            {
                MessageBox.Show("Please enter unit.");
            }
            else
            {

                int count = 0; // števec, ki kasneje preveri če ta enota že obstaja v bazi
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from units where unit='" + txtUnit.Text + "'"; // za vse unite, kjer je ime = "vpis"
                cmd1.ExecuteNonQuery(); // vrne število spremenjenih vrstic v bazi z insert stavkom (če je nič pomeni, da ni nobenih updejtanih stavkov)
                DataTable dt1 = new DataTable(); // v "dt" shrani novo tabelo
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                count = Convert.ToInt32(dt1.Rows.Count.ToString()); // v count shrani število vrstic


                if (count == 0) //preveri če  enota že obstaja v bazi
                {
                   
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into units values('" + txtUnit.Text + "')"; // SQL insert stavek
                    cmd.ExecuteNonQuery(); // vrne število spremenjenih vrstic v bazi z insert stavkom (če je nič pomeni, da ni nobenih updejtanih stavkov)
                    display(); // prikaže podatke v DataGridWiev
                }
                else
                {
                    MessageBox.Show("This unit already exists."); // enota že obstaja
                }

            }

            display(); // funkcija za prikaz podatkov v DataGridWiev
        }


        private void Unit_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            display(); //vzpostavi povezavo že na začetku
        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from units"; // SQL insert stavek
            cmd.ExecuteNonQuery(); // vrne število spremenjenih vrstic v bazi z insert stavkom (če je nič pomeni, da ni nobenih updejtanih stavkov)
            DataTable dt = new DataTable(); // v "dt" shrani novo tabelo
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        //
        //DELETE UNIT - BUTTON
        //
        private void buttonDeleteSelectedUnit_Click(object sender, EventArgs e)
        {
            
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()); // Pridobi zbirko celic, ki jih izbere uporabnik.
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from units where id = " + id + ""; // SQL delete stavek
            cmd.ExecuteNonQuery(); // vrne število spremenjenih vrstic v bazi z delete stavkom (če je nič pomeni, da ni nobenih deletanih stavkov)
            display();
        }
    }
    
}
