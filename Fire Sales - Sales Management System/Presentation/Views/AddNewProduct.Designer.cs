namespace Fire_Sales___Sales_Management_System.Presentation.Views

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddProduct = new System.Windows.Forms.Panel();
            this.metroGrid1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbFireSalesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_FireSalesDataSet = new Fire_Sales___Sales_Management_System.db_FireSalesDataSet();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSellingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCostPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.addProdButton = new Guna.UI2.WinForms.Guna2Button();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleLBL = new System.Windows.Forms.Label();
            this.subtitleLBL = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFireSalesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Fire_Sales___Sales_Management_System.db_FireSalesDataSetTableAdapters.ProductTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFireSalesDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFireSalesDataSetBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.Tan;
            this.AddProduct.Controls.Add(this.guna2Panel1);
            this.AddProduct.Controls.Add(this.backButton);
            this.AddProduct.Controls.Add(this.txtQuantity);
            this.AddProduct.Controls.Add(this.txtSellingPrice);
            this.AddProduct.Controls.Add(this.txtCostPrice);
            this.AddProduct.Controls.Add(this.cbxCategory);
            this.AddProduct.Controls.Add(this.txtBarcode);
            this.AddProduct.Controls.Add(this.logoPB);
            this.AddProduct.Controls.Add(this.addProdButton);
            this.AddProduct.Controls.Add(this.txtProductName);
            this.AddProduct.Controls.Add(this.titleLBL);
            this.AddProduct.Controls.Add(this.subtitleLBL);
            this.AddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProduct.Location = new System.Drawing.Point(0, 0);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(1500, 1359);
            this.AddProduct.TabIndex = 1;
            this.AddProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // metroGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.ColumnHeadersHeight = 19;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.metroGrid1.DataSource = this.productBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(14, 13);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowTemplate.Height = 26;
            this.metroGrid1.Size = new System.Drawing.Size(1391, 403);
            this.metroGrid1.TabIndex = 23;
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
            this.metroGrid1.ThemeStyle.HeaderStyle.Height = 19;
            this.metroGrid1.ThemeStyle.ReadOnly = false;
            this.metroGrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.metroGrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.metroGrid1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.metroGrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.metroGrid1.ThemeStyle.RowsStyle.Height = 26;
            this.metroGrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.metroGrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.HeaderText = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.dbFireSalesDataSetBindingSource1;
            // 
            // dbFireSalesDataSetBindingSource1
            // 
            this.dbFireSalesDataSetBindingSource1.DataSource = this.db_FireSalesDataSet;
            this.dbFireSalesDataSetBindingSource1.Position = 0;
            // 
            // db_FireSalesDataSet
            // 
            this.db_FireSalesDataSet.DataSetName = "db_FireSalesDataSet";
            this.db_FireSalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Animated = true;
            this.txtQuantity.BorderRadius = 10;
            this.txtQuantity.BorderThickness = 0;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(984, 536);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQuantity.PlaceholderText = "Stock  Quantity";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(321, 69);
            this.txtQuantity.TabIndex = 21;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Animated = true;
            this.txtSellingPrice.BorderRadius = 10;
            this.txtSellingPrice.BorderThickness = 0;
            this.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.DefaultText = "";
            this.txtSellingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSellingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSellingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellingPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSellingPrice.ForeColor = System.Drawing.Color.Black;
            this.txtSellingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellingPrice.Location = new System.Drawing.Point(634, 536);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSellingPrice.PlaceholderText = "Selling Price";
            this.txtSellingPrice.SelectedText = "";
            this.txtSellingPrice.Size = new System.Drawing.Size(321, 69);
            this.txtSellingPrice.TabIndex = 20;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Animated = true;
            this.txtCostPrice.BorderRadius = 10;
            this.txtCostPrice.BorderThickness = 0;
            this.txtCostPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostPrice.DefaultText = "";
            this.txtCostPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCostPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCostPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCostPrice.ForeColor = System.Drawing.Color.Black;
            this.txtCostPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostPrice.Location = new System.Drawing.Point(195, 536);
            this.txtCostPrice.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCostPrice.PlaceholderText = "Cost  Price";
            this.txtCostPrice.SelectedText = "";
            this.txtCostPrice.Size = new System.Drawing.Size(408, 69);
            this.txtCostPrice.TabIndex = 19;
            // 
            // cbxCategory
            // 
            this.cbxCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbxCategory.BorderRadius = 10;
            this.cbxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategory.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.cbxCategory.ForeColor = System.Drawing.Color.Black;
            this.cbxCategory.ItemHeight = 30;
            this.cbxCategory.Location = new System.Drawing.Point(195, 341);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(316, 36);
            this.cbxCategory.TabIndex = 18;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Animated = true;
            this.txtBarcode.BorderRadius = 10;
            this.txtBarcode.BorderThickness = 0;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.DefaultText = "";
            this.txtBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBarcode.ForeColor = System.Drawing.Color.Black;
            this.txtBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcode.Location = new System.Drawing.Point(545, 341);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBarcode.PlaceholderText = "Barcode";
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.Size = new System.Drawing.Size(758, 69);
            this.txtBarcode.TabIndex = 16;
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::Fire_Sales___Sales_Management_System.Properties.Resources.shopping;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(686, 56);
            this.logoPB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(129, 125);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
            // 
            // addProdButton
            // 
            this.addProdButton.Animated = true;
            this.addProdButton.BorderColor = System.Drawing.Color.DimGray;
            this.addProdButton.BorderRadius = 10;
            this.addProdButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addProdButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addProdButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addProdButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addProdButton.FillColor = System.Drawing.Color.Black;
            this.addProdButton.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.addProdButton.ForeColor = System.Drawing.Color.Tan;
            this.addProdButton.Location = new System.Drawing.Point(545, 728);
            this.addProdButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.addProdButton.Name = "addProdButton";
            this.addProdButton.Size = new System.Drawing.Size(417, 58);
            this.addProdButton.TabIndex = 14;
            this.addProdButton.Text = "Add Product";
            this.addProdButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Animated = true;
            this.txtProductName.BorderRadius = 10;
            this.txtProductName.BorderThickness = 0;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(195, 439);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductName.PlaceholderText = "Product Name";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(1107, 69);
            this.txtProductName.TabIndex = 12;
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(588, 167);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(324, 72);
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
            this.subtitleLBL.Location = new System.Drawing.Point(593, 223);
            this.subtitleLBL.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.subtitleLBL.Name = "subtitleLBL";
            this.subtitleLBL.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.subtitleLBL.Size = new System.Drawing.Size(315, 49);
            this.subtitleLBL.TabIndex = 3;
            this.subtitleLBL.Text = "Enter The Product info";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dbFireSalesDataSetBindingSource;
            // 
            // dbFireSalesDataSetBindingSource
            // 
            this.dbFireSalesDataSetBindingSource.DataSource = this.db_FireSalesDataSet;
            this.dbFireSalesDataSetBindingSource.Position = 0;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.metroGrid1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(34, 810);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1425, 435);
            this.guna2Panel1.TabIndex = 25;
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1359);
            this.Controls.Add(this.AddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "AddNewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.AddNewProductForm_Load);
            this.AddProduct.ResumeLayout(false);
            this.AddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFireSalesDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFireSalesDataSetBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddProduct;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Label subtitleLBL;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2Button addProdButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2TextBox txtBarcode;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtSellingPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtCostPrice;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private System.Windows.Forms.BindingSource dbFireSalesDataSetBindingSource;
        private db_FireSalesDataSet db_FireSalesDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private db_FireSalesDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource dbFireSalesDataSetBindingSource1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

