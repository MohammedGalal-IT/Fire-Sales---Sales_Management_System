namespace Fire_Sales___Sales_Management_System
{
    partial class ReturnProduct
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
            this.QuantityTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.productsCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.returnProdButton = new Guna.UI2.WinForms.Guna2Button();
            this.titleLBL = new System.Windows.Forms.Label();
            this.subtitleLBL = new System.Windows.Forms.Label();
            this.ReturnAmountTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Tan;
            this.mainPanel.Controls.Add(this.ReturnAmountTB);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.QuantityTB);
            this.mainPanel.Controls.Add(this.productsCB);
            this.mainPanel.Controls.Add(this.logoPB);
            this.mainPanel.Controls.Add(this.returnProdButton);
            this.mainPanel.Controls.Add(this.titleLBL);
            this.mainPanel.Controls.Add(this.subtitleLBL);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1500, 750);
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
            this.backButton.Location = new System.Drawing.Point(-28, 23);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(354, 56);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back to home Page";
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // QuantityTB
            // 
            this.QuantityTB.Animated = true;
            this.QuantityTB.BorderRadius = 10;
            this.QuantityTB.BorderThickness = 0;
            this.QuantityTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTB.DefaultText = "";
            this.QuantityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityTB.ForeColor = System.Drawing.Color.Black;
            this.QuantityTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTB.Location = new System.Drawing.Point(196, 407);
            this.QuantityTB.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.QuantityTB.PlaceholderText = "Quantity";
            this.QuantityTB.SelectedText = "";
            this.QuantityTB.Size = new System.Drawing.Size(418, 69);
            this.QuantityTB.TabIndex = 19;
            this.QuantityTB.TextChanged += new System.EventHandler(this.CostPriceTB_TextChanged);
            // 
            // productsCB
            // 
            this.productsCB.BackColor = System.Drawing.Color.Transparent;
            this.productsCB.BorderRadius = 10;
            this.productsCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.productsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productsCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productsCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productsCB.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.productsCB.ForeColor = System.Drawing.Color.Black;
            this.productsCB.ItemHeight = 30;
            this.productsCB.Items.AddRange(new object[] {
            "Product 1",
            "Product 2",
            "Product 3"});
            this.productsCB.Location = new System.Drawing.Point(196, 308);
            this.productsCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productsCB.Name = "productsCB";
            this.productsCB.Size = new System.Drawing.Size(1108, 36);
            this.productsCB.StartIndex = 0;
            this.productsCB.TabIndex = 18;
            this.productsCB.SelectedIndexChanged += new System.EventHandler(this.ProductsCB_SelectedIndexChanged);
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::LoginView.Properties.Resources.box;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(686, 56);
            this.logoPB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(128, 125);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
            this.logoPB.Click += new System.EventHandler(this.LogoPB_Click);
            // 
            // returnProdButton
            // 
            this.returnProdButton.Animated = true;
            this.returnProdButton.BorderRadius = 10;
            this.returnProdButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.returnProdButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.returnProdButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnProdButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.returnProdButton.FillColor = System.Drawing.Color.Black;
            this.returnProdButton.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.returnProdButton.ForeColor = System.Drawing.Color.Tan;
            this.returnProdButton.Location = new System.Drawing.Point(542, 551);
            this.returnProdButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.returnProdButton.Name = "returnProdButton";
            this.returnProdButton.Size = new System.Drawing.Size(416, 69);
            this.returnProdButton.TabIndex = 14;
            this.returnProdButton.Text = "Return Product";
            this.returnProdButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(571, 167);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(358, 72);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "Return Product Page";
            this.titleLBL.Click += new System.EventHandler(this.TitleLBL_Click);
            // 
            // subtitleLBL
            // 
            this.subtitleLBL.AutoSize = true;
            this.subtitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitleLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLBL.ForeColor = System.Drawing.Color.White;
            this.subtitleLBL.Location = new System.Drawing.Point(550, 223);
            this.subtitleLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.subtitleLBL.Name = "subtitleLBL";
            this.subtitleLBL.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.subtitleLBL.Size = new System.Drawing.Size(400, 49);
            this.subtitleLBL.TabIndex = 3;
            this.subtitleLBL.Text = "Choose The Product To Return";
            this.subtitleLBL.Click += new System.EventHandler(this.SubtitleLBL_Click);
            // 
            // ReturnAmountTB
            // 
            this.ReturnAmountTB.Animated = true;
            this.ReturnAmountTB.BorderRadius = 10;
            this.ReturnAmountTB.BorderThickness = 0;
            this.ReturnAmountTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReturnAmountTB.DefaultText = "";
            this.ReturnAmountTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReturnAmountTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReturnAmountTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReturnAmountTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReturnAmountTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReturnAmountTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReturnAmountTB.ForeColor = System.Drawing.Color.Black;
            this.ReturnAmountTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReturnAmountTB.Location = new System.Drawing.Point(657, 407);
            this.ReturnAmountTB.Margin = new System.Windows.Forms.Padding(12);
            this.ReturnAmountTB.Name = "ReturnAmountTB";
            this.ReturnAmountTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ReturnAmountTB.PlaceholderText = "Return  Amount";
            this.ReturnAmountTB.SelectedText = "";
            this.ReturnAmountTB.Size = new System.Drawing.Size(647, 69);
            this.ReturnAmountTB.TabIndex = 23;
            // 
            // ReturnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "ReturnProduct";
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
        private Guna.UI2.WinForms.Guna2Button returnProdButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2ComboBox productsCB;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTB;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Guna.UI2.WinForms.Guna2TextBox ReturnAmountTB;
    }
}

