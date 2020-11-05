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
    public partial class frmRemoveMenuItem : Form
    {
        public frmRemoveMenuItem()
        {
            InitializeComponent();
        }

        private void btnMenuItem1Remove_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem2Remove_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem3Remove_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem4Remove_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem5Remove_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem6Remove_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void showMessage()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Removing Item from menu!", "Confirmation");
                //Application.Exit();
            }
        }
    }
}
