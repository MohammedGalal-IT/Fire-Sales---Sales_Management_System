namespace Fire_Sales___Sales_Management_System.Presentation.Views
{
    partial class MainView2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_FireSalesDataSet = new Fire_Sales___Sales_Management_System.db_FireSalesDataSet();
            this.userTableAdapter = new Fire_Sales___Sales_Management_System.db_FireSalesDataSetTableAdapters.UserTableAdapter();
            this.purchaseInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseInvoiceTableAdapter = new Fire_Sales___Sales_Management_System.db_FireSalesDataSetTableAdapters.PurchaseInvoiceTableAdapter();
            this.db_FireSalesDataSet1 = new Fire_Sales___Sales_Management_System.db_FireSalesDataSet1();
            this.vwTransactionLogWithUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_TransactionLogWithUserTableAdapter = new Fire_Sales___Sales_Management_System.db_FireSalesDataSet1TableAdapters.vw_TransactionLogWithUserTableAdapter();
            this.pnlNavBar = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.btnCraeteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.subtitleLBL = new System.Windows.Forms.Label();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.transactionLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeArabicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpLBL = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.OrdersNumLBL = new System.Windows.Forms.Label();
            this.ordersLBL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLBL = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTransactionLogWithUserBindingSource)).BeginInit();
            this.pnlNavBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.closePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.db_FireSalesDataSet;
            // 
            // db_FireSalesDataSet
            // 
            this.db_FireSalesDataSet.DataSetName = "db_FireSalesDataSet";
            this.db_FireSalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseInvoiceBindingSource
            // 
            this.purchaseInvoiceBindingSource.DataMember = "PurchaseInvoice";
            this.purchaseInvoiceBindingSource.DataSource = this.db_FireSalesDataSet;
            // 
            // purchaseInvoiceTableAdapter
            // 
            this.purchaseInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // db_FireSalesDataSet1
            // 
            this.db_FireSalesDataSet1.DataSetName = "db_FireSalesDataSet1";
            this.db_FireSalesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwTransactionLogWithUserBindingSource
            // 
            this.vwTransactionLogWithUserBindingSource.DataMember = "vw_TransactionLogWithUser";
            this.vwTransactionLogWithUserBindingSource.DataSource = this.db_FireSalesDataSet1;
            // 
            // vw_TransactionLogWithUserTableAdapter
            // 
            this.vw_TransactionLogWithUserTableAdapter.ClearBeforeFill = true;
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.Tan;
            this.pnlNavBar.Controls.Add(this.flowLayoutPanel1);
            this.pnlNavBar.Controls.Add(this.guna2Panel3);
            this.pnlNavBar.Controls.Add(this.subtitleLBL);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(237, 657);
            this.pnlNavBar.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDashBoard);
            this.flowLayoutPanel1.Controls.Add(this.btnCraeteCategory);
            this.flowLayoutPanel1.Controls.Add(this.txtAddProduct);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 208);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 449);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Animated = true;
            this.btnDashBoard.BorderRadius = 5;
            this.btnDashBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashBoard.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashBoard.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnDashBoard.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoard.Location = new System.Drawing.Point(8, 4);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(220, 37);
            this.btnDashBoard.TabIndex = 14;
            this.btnDashBoard.Text = "Dash Board";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnCraeteCategory
            // 
            this.btnCraeteCategory.Animated = true;
            this.btnCraeteCategory.BorderRadius = 5;
            this.btnCraeteCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCraeteCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCraeteCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCraeteCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCraeteCategory.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCraeteCategory.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnCraeteCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCraeteCategory.Location = new System.Drawing.Point(8, 49);
            this.btnCraeteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnCraeteCategory.Name = "btnCraeteCategory";
            this.btnCraeteCategory.Size = new System.Drawing.Size(218, 37);
            this.btnCraeteCategory.TabIndex = 14;
            this.btnCraeteCategory.Text = "Categories";
            this.btnCraeteCategory.Click += new System.EventHandler(this.btnCraeteCategory_Click);
            // 
            // txtAddProduct
            // 
            this.txtAddProduct.Animated = true;
            this.txtAddProduct.BorderRadius = 5;
            this.txtAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtAddProduct.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddProduct.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtAddProduct.ForeColor = System.Drawing.Color.Black;
            this.txtAddProduct.Location = new System.Drawing.Point(8, 94);
            this.txtAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddProduct.Name = "txtAddProduct";
            this.txtAddProduct.Size = new System.Drawing.Size(220, 37);
            this.txtAddProduct.TabIndex = 14;
            this.txtAddProduct.Text = "Products";
            this.txtAddProduct.Click += new System.EventHandler(this.txtAddProduct_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.logoPB);
            this.guna2Panel3.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel3.Location = new System.Drawing.Point(33, 22);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(155, 125);
            this.guna2Panel3.TabIndex = 18;
            // 
            // logoPB
            // 
            this.logoPB.BackColor = System.Drawing.Color.Transparent;
            this.logoPB.BorderRadius = 20;
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::Fire_Sales___Sales_Management_System.Properties.Resources.img;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(29, 27);
            this.logoPB.Margin = new System.Windows.Forms.Padding(4);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(99, 82);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 16;
            this.logoPB.TabStop = false;
            this.logoPB.UseTransparentBackground = true;
            this.logoPB.Click += new System.EventHandler(this.logoPB_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(30, 22);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(97, 93);
            this.guna2CircleButton1.TabIndex = 16;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            // 
            // subtitleLBL
            // 
            this.subtitleLBL.AutoSize = true;
            this.subtitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitleLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLBL.ForeColor = System.Drawing.Color.White;
            this.subtitleLBL.Location = new System.Drawing.Point(56, 150);
            this.subtitleLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLBL.Name = "subtitleLBL";
            this.subtitleLBL.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.subtitleLBL.Size = new System.Drawing.Size(120, 32);
            this.subtitleLBL.TabIndex = 17;
            this.subtitleLBL.Text = "User Name";
            this.subtitleLBL.Click += new System.EventHandler(this.subtitleLBL_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Animated = true;
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(17, 63);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 37);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Snow;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.pnlNavBar);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1254, 657);
            this.mainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closePanel);
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Controls.Add(this.guna2Panel4);
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.titleLBL);
            this.panel1.Location = new System.Drawing.Point(237, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 657);
            this.panel1.TabIndex = 18;
            // 
            // closePanel
            // 
            this.closePanel.BorderRadius = 10;
            this.closePanel.BorderThickness = 5;
            this.closePanel.Controls.Add(this.label6);
            this.closePanel.CustomBorderColor = System.Drawing.Color.White;
            this.closePanel.FillColor = System.Drawing.Color.Maroon;
            this.closePanel.Location = new System.Drawing.Point(879, 18);
            this.closePanel.Margin = new System.Windows.Forms.Padding(2);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(114, 36);
            this.closePanel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "CLOSE";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 34;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionLogIDDataGridViewTextBoxColumn,
            this.transactionTypeArabicDataGridViewTextBoxColumn,
            this.referenceIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.createdByUsernameDataGridViewTextBoxColumn,
            this.userRoleDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.vwTransactionLogWithUserBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 308);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 26;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1017, 349);
            this.guna2DataGridView1.TabIndex = 16;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 34;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 26;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // transactionLogIDDataGridViewTextBoxColumn
            // 
            this.transactionLogIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionLogID";
            this.transactionLogIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionLogIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionLogIDDataGridViewTextBoxColumn.Name = "transactionLogIDDataGridViewTextBoxColumn";
            // 
            // transactionTypeArabicDataGridViewTextBoxColumn
            // 
            this.transactionTypeArabicDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeArabic";
            this.transactionTypeArabicDataGridViewTextBoxColumn.HeaderText = "Type";
            this.transactionTypeArabicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionTypeArabicDataGridViewTextBoxColumn.Name = "transactionTypeArabicDataGridViewTextBoxColumn";
            this.transactionTypeArabicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceIDDataGridViewTextBoxColumn
            // 
            this.referenceIDDataGridViewTextBoxColumn.DataPropertyName = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn.HeaderText = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.referenceIDDataGridViewTextBoxColumn.Name = "referenceIDDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // createdByUsernameDataGridViewTextBoxColumn
            // 
            this.createdByUsernameDataGridViewTextBoxColumn.DataPropertyName = "CreatedByUsername";
            this.createdByUsernameDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByUsernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdByUsernameDataGridViewTextBoxColumn.Name = "createdByUsernameDataGridViewTextBoxColumn";
            // 
            // userRoleDataGridViewTextBoxColumn
            // 
            this.userRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.HeaderText = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userRoleDataGridViewTextBoxColumn.Name = "userRoleDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.Controls.Add(this.label5);
            this.guna2Panel4.Controls.Add(this.btnCreate);
            this.guna2Panel4.FillColor = System.Drawing.Color.Tan;
            this.guna2Panel4.Location = new System.Drawing.Point(723, 123);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(210, 115);
            this.guna2Panel4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Create New Account";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.EmpLBL);
            this.guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Location = new System.Drawing.Point(387, 123);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(210, 115);
            this.guna2Panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "4";
            // 
            // EmpLBL
            // 
            this.EmpLBL.AutoSize = true;
            this.EmpLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLBL.Location = new System.Drawing.Point(30, 11);
            this.EmpLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpLBL.Name = "EmpLBL";
            this.EmpLBL.Size = new System.Drawing.Size(168, 32);
            this.EmpLBL.TabIndex = 0;
            this.EmpLBL.Text = "Number Of Employes";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.OrdersNumLBL);
            this.guna2Panel1.Controls.Add(this.ordersLBL);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(83, 123);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(210, 115);
            this.guna2Panel1.TabIndex = 7;
            // 
            // OrdersNumLBL
            // 
            this.OrdersNumLBL.AutoSize = true;
            this.OrdersNumLBL.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersNumLBL.Location = new System.Drawing.Point(72, 40);
            this.OrdersNumLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrdersNumLBL.Name = "OrdersNumLBL";
            this.OrdersNumLBL.Size = new System.Drawing.Size(72, 70);
            this.OrdersNumLBL.TabIndex = 1;
            this.OrdersNumLBL.Text = "52";
            // 
            // ordersLBL
            // 
            this.ordersLBL.AutoSize = true;
            this.ordersLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLBL.Location = new System.Drawing.Point(43, 11);
            this.ordersLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ordersLBL.Name = "ordersLBL";
            this.ordersLBL.Size = new System.Drawing.Size(138, 32);
            this.ordersLBL.TabIndex = 0;
            this.ordersLBL.Text = "Orders For Today";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Location = new System.Drawing.Point(422, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 1);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cairo SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Somthing To Do";
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.Tan;
            this.titleLBL.Location = new System.Drawing.Point(23, 22);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(125, 45);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "Main Page";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(8, 139);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(220, 37);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Products";
            this.guna2Button1.Click += new System.EventHandler(this.txtAddProduct_Click);
            // 
            // MainView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 657);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTransactionLogWithUserBindingSource)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.closePanel.ResumeLayout(false);
            this.closePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private db_FireSalesDataSet db_FireSalesDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private db_FireSalesDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource purchaseInvoiceBindingSource;
        private db_FireSalesDataSetTableAdapters.PurchaseInvoiceTableAdapter purchaseInvoiceTableAdapter;
        private db_FireSalesDataSet1 db_FireSalesDataSet1;
        private System.Windows.Forms.BindingSource vwTransactionLogWithUserBindingSource;
        private db_FireSalesDataSet1TableAdapters.vw_TransactionLogWithUserTableAdapter vw_TransactionLogWithUserTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel pnlNavBar;
        private System.Windows.Forms.Label subtitleLBL;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button btnCraeteCategory;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private Guna.UI2.WinForms.Guna2Button txtAddProduct;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel closePanel;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionLogIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeArabicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EmpLBL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label OrdersNumLBL;
        private System.Windows.Forms.Label ordersLBL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLBL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}