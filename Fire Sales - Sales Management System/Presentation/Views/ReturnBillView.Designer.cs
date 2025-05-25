namespace Fire_Sales___Sales_Management_System
{
    partial class ReturnBillView
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
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1st Product ( 3 P )", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.InactiveCaption, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1205 $", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.InactiveCaption, new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "2nd Product ( 5p )",
            "21251 $"}, -1, System.Drawing.Color.Gray, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "3rd Product ( 2 p )",
            "500 $"}, -1, System.Drawing.Color.Gray, System.Drawing.Color.Empty, null);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ReturnAmountTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.returnBillButton = new Guna.UI2.WinForms.Guna2Button();
            this.titleLBL = new System.Windows.Forms.Label();
            this.subtitleLBL = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.productListV = new System.Windows.Forms.ListView();
            this.Bill_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalReturnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Tan;
            this.mainPanel.Controls.Add(this.guna2Panel1);
            this.mainPanel.Controls.Add(this.ReturnAmountTB);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.logoPB);
            this.mainPanel.Controls.Add(this.returnBillButton);
            this.mainPanel.Controls.Add(this.titleLBL);
            this.mainPanel.Controls.Add(this.subtitleLBL);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1500, 900);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this.ReturnAmountTB.Location = new System.Drawing.Point(196, 729);
            this.ReturnAmountTB.Margin = new System.Windows.Forms.Padding(12);
            this.ReturnAmountTB.Name = "ReturnAmountTB";
            this.ReturnAmountTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ReturnAmountTB.PlaceholderText = "Return  Amount";
            this.ReturnAmountTB.SelectedText = "";
            this.ReturnAmountTB.Size = new System.Drawing.Size(647, 69);
            this.ReturnAmountTB.TabIndex = 23;
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
            this.backButton.Margin = new System.Windows.Forms.Padding(6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(354, 56);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back to home Page";
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::LoginView.Properties.Resources.box;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(686, 56);
            this.logoPB.Margin = new System.Windows.Forms.Padding(6);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(128, 125);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
            this.logoPB.Click += new System.EventHandler(this.LogoPB_Click);
            // 
            // returnBillButton
            // 
            this.returnBillButton.Animated = true;
            this.returnBillButton.BorderRadius = 10;
            this.returnBillButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.returnBillButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.returnBillButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnBillButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.returnBillButton.FillColor = System.Drawing.Color.Black;
            this.returnBillButton.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.returnBillButton.ForeColor = System.Drawing.Color.Tan;
            this.returnBillButton.Location = new System.Drawing.Point(888, 729);
            this.returnBillButton.Margin = new System.Windows.Forms.Padding(6);
            this.returnBillButton.Name = "returnBillButton";
            this.returnBillButton.Size = new System.Drawing.Size(416, 69);
            this.returnBillButton.TabIndex = 14;
            this.returnBillButton.Text = "Return Bill";
            this.returnBillButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(610, 167);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(281, 72);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "Return Bill Page";
            this.titleLBL.Click += new System.EventHandler(this.TitleLBL_Click);
            // 
            // subtitleLBL
            // 
            this.subtitleLBL.AutoSize = true;
            this.subtitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitleLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLBL.ForeColor = System.Drawing.Color.White;
            this.subtitleLBL.Location = new System.Drawing.Point(576, 223);
            this.subtitleLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.subtitleLBL.Name = "subtitleLBL";
            this.subtitleLBL.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.subtitleLBL.Size = new System.Drawing.Size(348, 49);
            this.subtitleLBL.TabIndex = 3;
            this.subtitleLBL.Text = "Choose The Bill To Return";
            this.subtitleLBL.Click += new System.EventHandler(this.SubtitleLBL_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.productListV);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(196, 321);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1108, 368);
            this.guna2Panel1.TabIndex = 24;
            // 
            // productListV
            // 
            this.productListV.BackColor = System.Drawing.Color.White;
            this.productListV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bill_id,
            this.BillDetails,
            this.TotalReturnAmount});
            this.productListV.HideSelection = false;
            this.productListV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.productListV.Location = new System.Drawing.Point(23, 23);
            this.productListV.Margin = new System.Windows.Forms.Padding(6);
            this.productListV.Name = "productListV";
            this.productListV.Size = new System.Drawing.Size(1060, 317);
            this.productListV.TabIndex = 25;
            this.productListV.UseCompatibleStateImageBehavior = false;
            this.productListV.View = System.Windows.Forms.View.Details;
            // 
            // Bill_id
            // 
            this.Bill_id.Text = "Bill ID";
            this.Bill_id.Width = 77;
            // 
            // BillDetails
            // 
            this.BillDetails.Text = "Details";
            this.BillDetails.Width = 277;
            // 
            // TotalReturnAmount
            // 
            this.TotalReturnAmount.Text = "Total Amount";
            this.TotalReturnAmount.Width = 166;
            // 
            // ReturnBillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ReturnBillView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Label subtitleLBL;
        private Guna.UI2.WinForms.Guna2Button returnBillButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Guna.UI2.WinForms.Guna2TextBox ReturnAmountTB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ListView productListV;
        private System.Windows.Forms.ColumnHeader Bill_id;
        private System.Windows.Forms.ColumnHeader BillDetails;
        private System.Windows.Forms.ColumnHeader TotalReturnAmount;
    }
}

