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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.db_FireSalesDataSet = new Fire_Sales___Sales_Management_System.db_FireSalesDataSet();
            this.purchaseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseItemTableAdapter = new Fire_Sales___Sales_Management_System.db_FireSalesDataSetTableAdapters.PurchaseItemTableAdapter();
            this.titleLBL = new System.Windows.Forms.Label();
            this.discountTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.saleButton = new Guna.UI2.WinForms.Guna2Button();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.noteLBL = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.productQuantityLBL = new System.Windows.Forms.Label();
            this.productNameLBL = new System.Windows.Forms.Label();
            this.metroGrid1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseInvoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // db_FireSalesDataSet
            // 
            this.db_FireSalesDataSet.DataSetName = "db_FireSalesDataSet";
            this.db_FireSalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseItemBindingSource
            // 
            this.purchaseItemBindingSource.DataMember = "PurchaseItem";
            this.purchaseItemBindingSource.DataSource = this.db_FireSalesDataSet;
            // 
            // purchaseItemTableAdapter
            // 
            this.purchaseItemTableAdapter.ClearBeforeFill = true;
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(346, 82);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(168, 45);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "Purchase Page";
            this.titleLBL.Click += new System.EventHandler(this.titleLBL_Click);
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
            this.discountTB.Location = new System.Drawing.Point(68, 540);
            this.discountTB.Margin = new System.Windows.Forms.Padding(7);
            this.discountTB.Name = "discountTB";
            this.discountTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.discountTB.PlaceholderText = "Purchased Items Num.";
            this.discountTB.SelectedText = "";
            this.discountTB.Size = new System.Drawing.Size(503, 44);
            this.discountTB.TabIndex = 12;
            this.discountTB.TextChanged += new System.EventHandler(this.DiscountTB_TextChanged);
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
            this.saleButton.Location = new System.Drawing.Point(598, 540);
            this.saleButton.Margin = new System.Windows.Forms.Padding(4);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(210, 44);
            this.saleButton.TabIndex = 14;
            this.saleButton.Text = "Add Items";
            this.saleButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::Fire_Sales___Sales_Management_System.Properties.Resources.box;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(400, 15);
            this.logoPB.Margin = new System.Windows.Forms.Padding(4);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(75, 80);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
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
            this.backButton.Location = new System.Drawing.Point(-16, 15);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(206, 36);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back to home Page";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // noteLBL
            // 
            this.noteLBL.AutoSize = true;
            this.noteLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLBL.ForeColor = System.Drawing.Color.White;
            this.noteLBL.Location = new System.Drawing.Point(306, 416);
            this.noteLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteLBL.Name = "noteLBL";
            this.noteLBL.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.noteLBL.Size = new System.Drawing.Size(291, 32);
            this.noteLBL.TabIndex = 29;
            this.noteLBL.Text = "Choose Product to Add More Items";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.productNameLBL);
            this.guna2Panel1.Controls.Add(this.productQuantityLBL);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Location = new System.Drawing.Point(68, 449);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(741, 50);
            this.guna2Panel1.TabIndex = 30;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // productQuantityLBL
            // 
            this.productQuantityLBL.AutoSize = true;
            this.productQuantityLBL.Location = new System.Drawing.Point(593, 11);
            this.productQuantityLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productQuantityLBL.Name = "productQuantityLBL";
            this.productQuantityLBL.Size = new System.Drawing.Size(136, 32);
            this.productQuantityLBL.TabIndex = 0;
            this.productQuantityLBL.Text = "Product Quantity";
            // 
            // productNameLBL
            // 
            this.productNameLBL.AutoSize = true;
            this.productNameLBL.Location = new System.Drawing.Point(20, 11);
            this.productNameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLBL.Name = "productNameLBL";
            this.productNameLBL.Size = new System.Drawing.Size(255, 32);
            this.productNameLBL.TabIndex = 1;
            this.productNameLBL.Text = "No Product Choose From The List";
            // 
            // metroGrid1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.ColumnHeadersHeight = 30;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseItemIDDataGridViewTextBoxColumn,
            this.purchaseInvoiceIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.purchaseItemBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(54, 141);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowTemplate.Height = 26;
            this.metroGrid1.Size = new System.Drawing.Size(754, 263);
            this.metroGrid1.TabIndex = 31;
            this.metroGrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.metroGrid1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.metroGrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.metroGrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.metroGrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.metroGrid1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.metroGrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.metroGrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.metroGrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.metroGrid1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.metroGrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.metroGrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.metroGrid1.ThemeStyle.HeaderStyle.Height = 30;
            this.metroGrid1.ThemeStyle.ReadOnly = false;
            this.metroGrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.metroGrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.metroGrid1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.metroGrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.metroGrid1.ThemeStyle.RowsStyle.Height = 26;
            this.metroGrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.metroGrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // purchaseInvoiceIDDataGridViewTextBoxColumn
            // 
            this.purchaseInvoiceIDDataGridViewTextBoxColumn.DataPropertyName = "PurchaseInvoiceID";
            this.purchaseInvoiceIDDataGridViewTextBoxColumn.HeaderText = "PurchaseInvoiceID";
            this.purchaseInvoiceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseInvoiceIDDataGridViewTextBoxColumn.Name = "purchaseInvoiceIDDataGridViewTextBoxColumn";
            // 
            // purchaseItemIDDataGridViewTextBoxColumn
            // 
            this.purchaseItemIDDataGridViewTextBoxColumn.DataPropertyName = "PurchaseItemID";
            this.purchaseItemIDDataGridViewTextBoxColumn.HeaderText = "PurchaseItemID";
            this.purchaseItemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseItemIDDataGridViewTextBoxColumn.Name = "purchaseItemIDDataGridViewTextBoxColumn";
            this.purchaseItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Tan;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.metroGrid1);
            this.mainPanel.Controls.Add(this.guna2Panel1);
            this.mainPanel.Controls.Add(this.noteLBL);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.logoPB);
            this.mainPanel.Controls.Add(this.saleButton);
            this.mainPanel.Controls.Add(this.discountTB);
            this.mainPanel.Controls.Add(this.titleLBL);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(875, 738);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 738);
            this.panel1.TabIndex = 32;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.guna2DataGridView1.DataSource = this.purchaseItemBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(54, 141);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 26;
            this.guna2DataGridView1.Size = new System.Drawing.Size(754, 263);
            this.guna2DataGridView1.TabIndex = 31;
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 26;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PurchaseItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PurchaseItemID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PurchaseInvoiceID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PurchaseInvoiceID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel2.FillColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.Location = new System.Drawing.Point(68, 449);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(741, 50);
            this.guna2Panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Product Choose From The List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(306, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Size = new System.Drawing.Size(291, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Choose Product to Add More Items";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Cairo Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(-16, 15);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(206, 36);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Back to home Page";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox1.Image = global::Fire_Sales___Sales_Management_System.Properties.Resources.box;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(400, 15);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Tan;
            this.guna2Button2.Location = new System.Drawing.Point(598, 540);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(210, 44);
            this.guna2Button2.TabIndex = 14;
            this.guna2Button2.Text = "Add Items";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(68, 540);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(7);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Purchased Items Num.";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(503, 44);
            this.guna2TextBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(346, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Purchase Page";
            // 
            // PurchasePageViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 738);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PurchasePageViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.PurchasePageViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private db_FireSalesDataSet db_FireSalesDataSet;
        private System.Windows.Forms.BindingSource purchaseItemBindingSource;
        private db_FireSalesDataSetTableAdapters.PurchaseItemTableAdapter purchaseItemTableAdapter;
        private System.Windows.Forms.Label titleLBL;
        private Guna.UI2.WinForms.Guna2TextBox discountTB;
        private Guna.UI2.WinForms.Guna2Button saleButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private System.Windows.Forms.Label noteLBL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label productNameLBL;
        private System.Windows.Forms.Label productQuantityLBL;
        private Guna.UI2.WinForms.Guna2DataGridView metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseInvoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label4;
    }
}

