namespace Take_Away_System
{
    partial class frmAddMenuItem
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.MaskedTextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddItemCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(106, 15);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(104, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(106, 41);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(192, 20);
            this.txtItemDescription.TabIndex = 1;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(106, 67);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(49, 20);
            this.txtItemPrice.TabIndex = 2;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(15, 18);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(76, 13);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "Name of Item: ";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(15, 44);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(89, 13);
            this.lblItemDescription.TabIndex = 4;
            this.lblItemDescription.Text = "Item Description: ";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(15, 70);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(54, 13);
            this.lblItemPrice.TabIndex = 5;
            this.lblItemPrice.Text = "Item Price";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(29, 109);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnAddItemCancel
            // 
            this.btnAddItemCancel.Location = new System.Drawing.Point(206, 109);
            this.btnAddItemCancel.Name = "btnAddItemCancel";
            this.btnAddItemCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddItemCancel.TabIndex = 7;
            this.btnAddItemCancel.Text = "Cancel";
            this.btnAddItemCancel.UseVisualStyleBackColor = true;
            this.btnAddItemCancel.Click += new System.EventHandler(this.btnAddItemCancel_Click);
            // 
            // frmAddMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 153);
            this.Controls.Add(this.btnAddItemCancel);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.txtItemName);
            this.Name = "frmAddMenuItem";
            this.Text = "Add Menu Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.MaskedTextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddItemCancel;
    }
}