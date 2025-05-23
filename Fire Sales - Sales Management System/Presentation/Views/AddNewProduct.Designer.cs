namespace LoginView
{
    partial class AddNewProductForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.StockQuantityTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellingPriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CostPriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BarcodeTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.addProdButton = new Guna.UI2.WinForms.Guna2Button();
            this.prodNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleLBL = new System.Windows.Forms.Label();
            this.subtitleLBL = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Tan;
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.StockQuantityTB);
            this.mainPanel.Controls.Add(this.SellingPriceTB);
            this.mainPanel.Controls.Add(this.CostPriceTB);
            this.mainPanel.Controls.Add(this.CategoryCB);
            this.mainPanel.Controls.Add(this.BarcodeTB);
            this.mainPanel.Controls.Add(this.logoPB);
            this.mainPanel.Controls.Add(this.addProdButton);
            this.mainPanel.Controls.Add(this.prodNameTB);
            this.mainPanel.Controls.Add(this.titleLBL);
            this.mainPanel.Controls.Add(this.subtitleLBL);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(750, 500);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this.backButton.Location = new System.Drawing.Point(-14, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(177, 29);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back to home Page";
            // 
            // StockQuantityTB
            // 
            this.StockQuantityTB.Animated = true;
            this.StockQuantityTB.BorderRadius = 10;
            this.StockQuantityTB.BorderThickness = 0;
            this.StockQuantityTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StockQuantityTB.DefaultText = "";
            this.StockQuantityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StockQuantityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StockQuantityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StockQuantityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StockQuantityTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StockQuantityTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StockQuantityTB.ForeColor = System.Drawing.Color.Black;
            this.StockQuantityTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StockQuantityTB.Location = new System.Drawing.Point(492, 279);
            this.StockQuantityTB.Margin = new System.Windows.Forms.Padding(6);
            this.StockQuantityTB.Name = "StockQuantityTB";
            this.StockQuantityTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.StockQuantityTB.PlaceholderText = "Stock  Quantity";
            this.StockQuantityTB.SelectedText = "";
            this.StockQuantityTB.Size = new System.Drawing.Size(160, 36);
            this.StockQuantityTB.TabIndex = 21;
            // 
            // SellingPriceTB
            // 
            this.SellingPriceTB.Animated = true;
            this.SellingPriceTB.BorderRadius = 10;
            this.SellingPriceTB.BorderThickness = 0;
            this.SellingPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellingPriceTB.DefaultText = "";
            this.SellingPriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellingPriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellingPriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellingPriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellingPriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellingPriceTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellingPriceTB.ForeColor = System.Drawing.Color.Black;
            this.SellingPriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellingPriceTB.Location = new System.Drawing.Point(317, 279);
            this.SellingPriceTB.Margin = new System.Windows.Forms.Padding(6);
            this.SellingPriceTB.Name = "SellingPriceTB";
            this.SellingPriceTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.SellingPriceTB.PlaceholderText = "Selling Price";
            this.SellingPriceTB.SelectedText = "";
            this.SellingPriceTB.Size = new System.Drawing.Size(160, 36);
            this.SellingPriceTB.TabIndex = 20;
            // 
            // CostPriceTB
            // 
            this.CostPriceTB.Animated = true;
            this.CostPriceTB.BorderRadius = 10;
            this.CostPriceTB.BorderThickness = 0;
            this.CostPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CostPriceTB.DefaultText = "";
            this.CostPriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CostPriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CostPriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostPriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostPriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostPriceTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CostPriceTB.ForeColor = System.Drawing.Color.Black;
            this.CostPriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostPriceTB.Location = new System.Drawing.Point(98, 279);
            this.CostPriceTB.Margin = new System.Windows.Forms.Padding(6);
            this.CostPriceTB.Name = "CostPriceTB";
            this.CostPriceTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.CostPriceTB.PlaceholderText = "Cost  Price";
            this.CostPriceTB.SelectedText = "";
            this.CostPriceTB.Size = new System.Drawing.Size(204, 36);
            this.CostPriceTB.TabIndex = 19;
            // 
            // CategoryCB
            // 
            this.CategoryCB.BackColor = System.Drawing.Color.Transparent;
            this.CategoryCB.BorderRadius = 10;
            this.CategoryCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryCB.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCB.ForeColor = System.Drawing.Color.Black;
            this.CategoryCB.ItemHeight = 30;
            this.CategoryCB.Items.AddRange(new object[] {
            "Category 1",
            "Category 2",
            "Category 3"});
            this.CategoryCB.Location = new System.Drawing.Point(98, 177);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(160, 36);
            this.CategoryCB.StartIndex = 0;
            this.CategoryCB.TabIndex = 18;
            // 
            // BarcodeTB
            // 
            this.BarcodeTB.Animated = true;
            this.BarcodeTB.BorderRadius = 10;
            this.BarcodeTB.BorderThickness = 0;
            this.BarcodeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BarcodeTB.DefaultText = "";
            this.BarcodeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BarcodeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BarcodeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BarcodeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BarcodeTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BarcodeTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BarcodeTB.ForeColor = System.Drawing.Color.Black;
            this.BarcodeTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BarcodeTB.Location = new System.Drawing.Point(273, 177);
            this.BarcodeTB.Margin = new System.Windows.Forms.Padding(6);
            this.BarcodeTB.Name = "BarcodeTB";
            this.BarcodeTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BarcodeTB.PlaceholderText = "Barcode";
            this.BarcodeTB.SelectedText = "";
            this.BarcodeTB.Size = new System.Drawing.Size(379, 36);
            this.BarcodeTB.TabIndex = 16;
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::LoginView.Properties.Resources.box;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(343, 29);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(64, 65);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
            // 
            // addProdButton
            // 
            this.addProdButton.Animated = true;
            this.addProdButton.BorderRadius = 10;
            this.addProdButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addProdButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addProdButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addProdButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addProdButton.FillColor = System.Drawing.Color.Black;
            this.addProdButton.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.addProdButton.ForeColor = System.Drawing.Color.Tan;
            this.addProdButton.Location = new System.Drawing.Point(273, 379);
            this.addProdButton.Name = "addProdButton";
            this.addProdButton.Size = new System.Drawing.Size(208, 30);
            this.addProdButton.TabIndex = 14;
            this.addProdButton.Text = "Add Product";
            this.addProdButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // prodNameTB
            // 
            this.prodNameTB.Animated = true;
            this.prodNameTB.BorderRadius = 10;
            this.prodNameTB.BorderThickness = 0;
            this.prodNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodNameTB.DefaultText = "";
            this.prodNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodNameTB.ForeColor = System.Drawing.Color.Black;
            this.prodNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodNameTB.Location = new System.Drawing.Point(98, 228);
            this.prodNameTB.Margin = new System.Windows.Forms.Padding(6);
            this.prodNameTB.Name = "prodNameTB";
            this.prodNameTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.prodNameTB.PlaceholderText = "Product Name";
            this.prodNameTB.SelectedText = "";
            this.prodNameTB.Size = new System.Drawing.Size(554, 36);
            this.prodNameTB.TabIndex = 12;
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(294, 87);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(162, 36);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "Add New Products";
            // 
            // subtitleLBL
            // 
            this.subtitleLBL.AutoSize = true;
            this.subtitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitleLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLBL.ForeColor = System.Drawing.Color.White;
            this.subtitleLBL.Location = new System.Drawing.Point(297, 116);
            this.subtitleLBL.Name = "subtitleLBL";
            this.subtitleLBL.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.subtitleLBL.Size = new System.Drawing.Size(157, 24);
            this.subtitleLBL.TabIndex = 3;
            this.subtitleLBL.Text = "Enter The Product info";
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddNewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Label subtitleLBL;
        private Guna.UI2.WinForms.Guna2TextBox prodNameTB;
        private Guna.UI2.WinForms.Guna2Button addProdButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2TextBox BarcodeTB;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryCB;
        private Guna.UI2.WinForms.Guna2TextBox StockQuantityTB;
        private Guna.UI2.WinForms.Guna2TextBox SellingPriceTB;
        private Guna.UI2.WinForms.Guna2TextBox CostPriceTB;
        private Guna.UI2.WinForms.Guna2Button backButton;
    }
}

