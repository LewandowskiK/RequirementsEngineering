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
    public partial class frmViewMenu : Form
    {
        public frmViewMenu()
        {
            InitializeComponent();
        }

        private void btnMenuItem1Select_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem2Select_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem3Select_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem4Select_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem5Select_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void btnMenuItem6Select_Click(object sender, EventArgs e)
        {
            showMessage();
        }


        private void showMessage()
        {
            
            MessageBox.Show("Adding item to cart!", "Confirmation");
           
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to order?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Order Placed!", "Confirmation");
                //Application.Exit();
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelling Order!", "Confirmation");
            //Application.Exit();
        }
    }
}
