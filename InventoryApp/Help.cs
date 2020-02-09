using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();           
        }
    }
}
