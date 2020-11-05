namespace Take_Away_System
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyItemAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.lblOpeningTime = new System.Windows.Forms.Label();
            this.lblClosingTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.mnuOrders,
            this.mnuAdmin,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddItem,
            this.mnuRemoveItem,
            this.mnuChangeItem,
            this.mnuViewMenu});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            // 
            // mnuAddItem
            // 
            this.mnuAddItem.Name = "mnuAddItem";
            this.mnuAddItem.Size = new System.Drawing.Size(178, 22);
            this.mnuAddItem.Text = "Add Menu Item";
            this.mnuAddItem.Click += new System.EventHandler(this.mnuAddItem_Click);
            // 
            // mnuRemoveItem
            // 
            this.mnuRemoveItem.Name = "mnuRemoveItem";
            this.mnuRemoveItem.Size = new System.Drawing.Size(178, 22);
            this.mnuRemoveItem.Text = "Remove Menu Item";
            this.mnuRemoveItem.Click += new System.EventHandler(this.mnuRemoveItem_Click);
            // 
            // mnuChangeItem
            // 
            this.mnuChangeItem.Name = "mnuChangeItem";
            this.mnuChangeItem.Size = new System.Drawing.Size(178, 22);
            this.mnuChangeItem.Text = "Change Menu Item";
            this.mnuChangeItem.Click += new System.EventHandler(this.mnuChangeItem_Click);
            // 
            // mnuViewMenu
            // 
            this.mnuViewMenu.Name = "mnuViewMenu";
            this.mnuViewMenu.Size = new System.Drawing.Size(178, 22);
            this.mnuViewMenu.Text = "View Menu";
            this.mnuViewMenu.Click += new System.EventHandler(this.mnuViewMenu_Click);
            // 
            // mnuOrders
            // 
            this.mnuOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddOrder,
            this.mnuRemoveOrder,
            this.mnuChangeOrder});
            this.mnuOrders.Name = "mnuOrders";
            this.mnuOrders.Size = new System.Drawing.Size(54, 20);
            this.mnuOrders.Text = "Orders";
            // 
            // mnuAddOrder
            // 
            this.mnuAddOrder.Name = "mnuAddOrder";
            this.mnuAddOrder.Size = new System.Drawing.Size(150, 22);
            this.mnuAddOrder.Text = "Add Order";
            // 
            // mnuRemoveOrder
            // 
            this.mnuRemoveOrder.Name = "mnuRemoveOrder";
            this.mnuRemoveOrder.Size = new System.Drawing.Size(150, 22);
            this.mnuRemoveOrder.Text = "Remove Order";
            // 
            // mnuChangeOrder
            // 
            this.mnuChangeOrder.Name = "mnuChangeOrder";
            this.mnuChangeOrder.Size = new System.Drawing.Size(150, 22);
            this.mnuChangeOrder.Text = "Change Order";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetTimes,
            this.mnuYearlyItemAnalysis,
            this.mnuYearlyRevenueAnalysis});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuSetTimes
            // 
            this.mnuSetTimes.Name = "mnuSetTimes";
            this.mnuSetTimes.Size = new System.Drawing.Size(199, 22);
            this.mnuSetTimes.Text = "Set Opening Times";
            // 
            // mnuYearlyItemAnalysis
            // 
            this.mnuYearlyItemAnalysis.Name = "mnuYearlyItemAnalysis";
            this.mnuYearlyItemAnalysis.Size = new System.Drawing.Size(199, 22);
            this.mnuYearlyItemAnalysis.Text = "Yearly Item Analysis";
            this.mnuYearlyItemAnalysis.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // mnuYearlyRevenueAnalysis
            // 
            this.mnuYearlyRevenueAnalysis.Name = "mnuYearlyRevenueAnalysis";
            this.mnuYearlyRevenueAnalysis.Size = new System.Drawing.Size(199, 22);
            this.mnuYearlyRevenueAnalysis.Text = "Yearly Revenue Analysis";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // picMainMenu
            // 
            this.picMainMenu.Image = global::Take_Away_System.Properties.Resources.restaurant;
            this.picMainMenu.Location = new System.Drawing.Point(0, 27);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(506, 355);
            this.picMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainMenu.TabIndex = 1;
            this.picMainMenu.TabStop = false;
            // 
            // lblOpeningTime
            // 
            this.lblOpeningTime.AutoSize = true;
            this.lblOpeningTime.Location = new System.Drawing.Point(144, 38);
            this.lblOpeningTime.Name = "lblOpeningTime";
            this.lblOpeningTime.Size = new System.Drawing.Size(106, 13);
            this.lblOpeningTime.TabIndex = 2;
            this.lblOpeningTime.Text = "Opening Time: 13:00";
            // 
            // lblClosingTime
            // 
            this.lblClosingTime.AutoSize = true;
            this.lblClosingTime.Location = new System.Drawing.Point(144, 63);
            this.lblClosingTime.Name = "lblClosingTime";
            this.lblClosingTime.Size = new System.Drawing.Size(100, 13);
            this.lblClosingTime.TabIndex = 3;
            this.lblClosingTime.Text = "Closing Time: 22:00";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 380);
            this.Controls.Add(this.lblClosingTime);
            this.Controls.Add(this.lblOpeningTime);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAddItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeItem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOrders;
        private System.Windows.Forms.ToolStripMenuItem mnuAddOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuSetTimes;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyItemAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevenueAnalysis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.Label lblOpeningTime;
        private System.Windows.Forms.Label lblClosingTime;
    }
}

