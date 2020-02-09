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
using System.Windows.Forms.DataVisualization.Charting;

namespace InventoryApp
{
    public partial class home : Form
    {

        public home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            /*Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();*/
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_new_user anu = new add_new_user(); //shranim v spremenljivko (add_new_user stran)
            anu.Show(); // odpre stran "add_new_user"
        }

        private void addNewUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit un = new Unit(); //shranim v spremenljivko (Unit stran)
            un.Show(); // odpre stran "Unit"
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_product_name apn = new add_product_name(); // iz index strani poveze na okno "Add New Product"
            
            apn.Show(); // prikaze okno
        }

        private void addNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier_info si = new supplier_info(); // iz index strani poveze na okno "Supplier Information"

            si.Show(); // prikaze okno
        }

        private void purchaseFromSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase_product pfs = new purchase_product(); // iz index strani poveze na okno "Purchase Product"            

            pfs.Show(); // prikaze okno
        }

        private void Load_Click(object sender, EventArgs e)
        {
                SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\InventoryApp1\InventoryApp\Database2.mdf;Integrated Security=True");

                string sqlStr = "SELECT product_quantity, product_name from stock ";

                SqlDataAdapter myCommand = new SqlDataAdapter(sqlStr, myConnection); 
                DataSet ds = new DataSet();
                myCommand.Fill(ds);

                DataView source = new DataView(ds.Tables[0]);

                chartStock.DataSource = source;

                chartStock.Series[0].XValueMember = "product_name";
                chartStock.Series[0].YValueMembers = "product_quantity";
                chartStock.DataBind();
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            add_new_user anu = new add_new_user(); //shranim v spremenljivko (add_new_user stran)
            anu.Show(); // odpre stran "add_new_user"
            this.Hide();
        }

        private void buttonAddNewUnit_Click(object sender, EventArgs e)
        {
            Unit un = new Unit(); //shranim v spremenljivko (Unit stran)
            un.Show(); // odpre stran "Unit"
            this.Hide();
        }

        private void buttonAddNewSupplier_Click(object sender, EventArgs e)
        {
            supplier_info si = new supplier_info(); // iz index strani poveze na okno "Supplier Information"
            si.Show(); // prikaze okno
            this.Hide();
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            add_product_name apn = new add_product_name(); // iz index strani poveze na okno "Add New Product"
            apn.Show(); // prikaze okno
            this.Hide();
        }

        private void buttonPurchaseProduct_Click(object sender, EventArgs e)
        {
            purchase_product pfs = new purchase_product(); // iz index strani poveze na okno "Purchase Product"            
            pfs.Show(); // prikaze okno
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {           
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help He = new Help();
            He.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vizitka v = new vizitka();
            v.Show();
            this.Hide();
        }
    }
}
