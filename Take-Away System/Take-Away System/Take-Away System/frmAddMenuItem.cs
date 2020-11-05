using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Away_System
{
    public partial class frmAddMenuItem : Form
    {
        public frmAddMenuItem()
        {
            InitializeComponent();
            txtItemPrice.Text = "0.00";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItemCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelling item addition");
            //Application.Exit();
        }
    }
}
