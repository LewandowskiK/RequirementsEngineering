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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void mnuAddItem_Click(object sender, EventArgs e)
        {
            frmAddMenuItem addItem = new frmAddMenuItem();
            addItem.Show();
        }

        private void mnuRemoveItem_Click(object sender, EventArgs e)
        {
            frmRemoveMenuItem removeItem = new frmRemoveMenuItem();
            removeItem.Show();
        }

        private void mnuChangeItem_Click(object sender, EventArgs e)
        {
            frmChangeMenuItem changeItem = new frmChangeMenuItem();
            changeItem.Show();
        }

        private void mnuViewMenu_Click(object sender, EventArgs e)
        {
            frmViewMenu viewMenu = new frmViewMenu();
            viewMenu.Show();
        }
    }
}
