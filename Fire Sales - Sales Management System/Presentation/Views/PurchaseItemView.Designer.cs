namespace Fire_Sales___Sales_Management_System.Presentation.Views
{
    partial class PurchasePageViewForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1", System.Drawing.Color.Gray, System.Drawing.Color.White, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1st Product", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.InactiveCaption, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Category1", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.InactiveCaption, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "3.4$", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.InactiveCaption, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "30", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.InactiveCaption, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "2nd Product",
            "Category2",
            "5$",
            "80"}, -1, System.Drawing.Color.Gray, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "3rd Product Name",
            "Category",
            "5.7$",
            "120"}, -1, System.Drawing.Color.Gray, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "4", System.Drawing.Color.Gray, System.Drawing.Color.White, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Enter Your Product Name Here", System.Drawing.Color.Silver, System.Drawing.Color.White, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Category3", System.Drawing.Color.Silver, System.Drawing.Color.White, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "2$", System.Drawing.Color.Silver, System.Drawing.Color.White, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "188", System.Drawing.Color.Silver, System.Drawing.Color.White, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.productNameLBL = new System.Windows.Forms.Label();
            this.productQuantityLBL = new System.Windows.Forms.Label();
            this.noteLBL = new System.Windows.Forms.Label();
            this.productListV = new System.Windows.Forms.ListView();
            this.product_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.catrgory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.saleButton = new Guna.UI2.WinForms.Guna2Button();
            this.discountTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleLBL = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.mainPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Tan;
            this.mainPanel.Controls.Add(this.guna2Panel2);
            this.mainPanel.Controls.Add(this.guna2Panel1);
            this.mainPanel.Controls.Add(this.noteLBL);
            this.mainPanel.Controls.Add(this.productListV);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.logoPB);
            this.mainPanel.Controls.Add(this.saleButton);
            this.mainPanel.Controls.Add(this.discountTB);
            this.mainPanel.Controls.Add(this.titleLBL);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1500, 1153);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.productNameLBL);
            this.guna2Panel1.Controls.Add(this.productQuantityLBL);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Location = new System.Drawing.Point(117, 702);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1270, 78);
            this.guna2Panel1.TabIndex = 30;
            // 
            // productNameLBL
            // 
            this.productNameLBL.AutoSize = true;
            this.productNameLBL.Location = new System.Drawing.Point(34, 17);
            this.productNameLBL.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.productNameLBL.Name = "productNameLBL";
            this.productNameLBL.Size = new System.Drawing.Size(389, 49);
            this.productNameLBL.TabIndex = 1;
            this.productNameLBL.Text = "No Product Choose From The List";
            // 
            // productQuantityLBL
            // 
            this.productQuantityLBL.AutoSize = true;
            this.productQuantityLBL.Location = new System.Drawing.Point(1017, 17);
            this.productQuantityLBL.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.productQuantityLBL.Name = "productQuantityLBL";
            this.productQuantityLBL.Size = new System.Drawing.Size(209, 49);
            this.productQuantityLBL.TabIndex = 0;
            this.productQuantityLBL.Text = "Product Quantity";
            // 
            // noteLBL
            // 
            this.noteLBL.AutoSize = true;
            this.noteLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLBL.ForeColor = System.Drawing.Color.White;
            this.noteLBL.Location = new System.Drawing.Point(525, 650);
            this.noteLBL.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.noteLBL.Name = "noteLBL";
            this.noteLBL.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.noteLBL.Size = new System.Drawing.Size(454, 49);
            this.noteLBL.TabIndex = 29;
            this.noteLBL.Text = "Choose Product to Add More Items";
            // 
            // productListV
            // 
            this.productListV.BackColor = System.Drawing.Color.White;
            this.productListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product_id,
            this.product_name,
            this.catrgory,
            this.price,
            this.stock_quantity});
            this.productListV.HideSelection = false;
            this.productListV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.productListV.Location = new System.Drawing.Point(131, 252);
            this.productListV.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.productListV.Name = "productListV";
            this.productListV.Size = new System.Drawing.Size(1233, 267);
            this.productListV.TabIndex = 24;
            this.productListV.UseCompatibleStateImageBehavior = false;
            this.productListV.View = System.Windows.Forms.View.Details;
            // 
            // product_id
            // 
            this.product_id.Text = "ID";
            this.product_id.Width = 30;
            // 
            // product_name
            // 
            this.product_name.Text = "Name";
            this.product_name.Width = 295;
            // 
            // catrgory
            // 
            this.catrgory.Text = "Category Name";
            this.catrgory.Width = 166;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 71;
            // 
            // stock_quantity
            // 
            this.stock_quantity.Text = "Quantity";
            this.stock_quantity.Width = 68;
            // 
            // backButton
            // 
            this.backButton.BorderRadius = 5;
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.FillColor = System.Drawing.Color.Black;
            this.backButton.Font = new System.Drawing.Font("Cairo Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(-27, 23);
            this.backButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(353, 56);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back to home Page";
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::Fire_Sales___Sales_Management_System.Properties.Resources.box;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(686, 56);
            this.logoPB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(129, 125);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
            // 
            // saleButton
            // 
            this.saleButton.Animated = true;
            this.saleButton.BorderRadius = 10;
            this.saleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleButton.FillColor = System.Drawing.Color.Black;
            this.saleButton.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.saleButton.ForeColor = System.Drawing.Color.Tan;
            this.saleButton.Location = new System.Drawing.Point(1025, 844);
            this.saleButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(360, 69);
            this.saleButton.TabIndex = 14;
            this.saleButton.Text = "Add Items";
            this.saleButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // discountTB
            // 
            this.discountTB.Animated = true;
            this.discountTB.BorderRadius = 10;
            this.discountTB.BorderThickness = 0;
            this.discountTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discountTB.DefaultText = "";
            this.discountTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.discountTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.discountTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discountTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discountTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discountTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discountTB.ForeColor = System.Drawing.Color.Black;
            this.discountTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discountTB.Location = new System.Drawing.Point(117, 844);
            this.discountTB.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.discountTB.Name = "discountTB";
            this.discountTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.discountTB.PlaceholderText = "Purchased Items Num.";
            this.discountTB.SelectedText = "";
            this.discountTB.Size = new System.Drawing.Size(862, 69);
            this.discountTB.TabIndex = 12;
            this.discountTB.TextChanged += new System.EventHandler(this.DiscountTB_TextChanged);
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(593, 161);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(265, 72);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "Purchase Page";
            this.titleLBL.Click += new System.EventHandler(this.titleLBL_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(117, 236);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1270, 313);
            this.guna2Panel2.TabIndex = 31;
            // 
            // PurchasePageViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1153);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "PurchasePageViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLBL;
        private Guna.UI2.WinForms.Guna2TextBox discountTB;
        private Guna.UI2.WinForms.Guna2Button saleButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private System.Windows.Forms.ListView productListV;
        private System.Windows.Forms.ColumnHeader product_id;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader catrgory;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader stock_quantity;
        private System.Windows.Forms.Label noteLBL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label productNameLBL;
        private System.Windows.Forms.Label productQuantityLBL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}

