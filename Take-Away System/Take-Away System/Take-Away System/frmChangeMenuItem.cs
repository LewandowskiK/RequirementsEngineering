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
    public partial class frmChangeMenuItem : Form
    {
        public frmChangeMenuItem()
        {
            InitializeComponent();
        }

        private void btnMenuItem1Change_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem2Change_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem3Change_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem4Change_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem5Change_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem6Change_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void showMessage()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change this Item?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Please enter changes", "Enter Changes");
                //Application.Exit();
            }
        }
    }
}
