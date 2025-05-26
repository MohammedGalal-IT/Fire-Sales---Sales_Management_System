namespace Fire_Sales___Sales_Management_System
{
    partial class EnterExpensesView
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ExpensesDescTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ExpensesTypeTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ExpensesAmountTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AddExpensesButton = new Guna.UI2.WinForms.Guna2Button();
            this.titleLBL = new System.Windows.Forms.Label();
            this.subtitleLBL = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.db_FireSalesDataSet = new Fire_Sales___Sales_Management_System.db_FireSalesDataSet();
            this.dbFireSalesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTableAdapter = new Fire_Sales___Sales_Management_System.db_FireSalesDataSetTableAdapters.ExpenseTableAdapter();
            this.expenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFireSalesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Tan;
            this.mainPanel.Controls.Add(this.ExpensesDescTB);
            this.mainPanel.Controls.Add(this.ExpensesTypeTB);
            this.mainPanel.Controls.Add(this.guna2Panel1);
            this.mainPanel.Controls.Add(this.ExpensesAmountTB);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.logoPB);
            this.mainPanel.Controls.Add(this.AddExpensesButton);
            this.mainPanel.Controls.Add(this.titleLBL);
            this.mainPanel.Controls.Add(this.subtitleLBL);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(875, 705);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // ExpensesDescTB
            // 
            this.ExpensesDescTB.Animated = true;
            this.ExpensesDescTB.BorderRadius = 10;
            this.ExpensesDescTB.BorderThickness = 0;
            this.ExpensesDescTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExpensesDescTB.DefaultText = "";
            this.ExpensesDescTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ExpensesDescTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExpensesDescTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExpensesDescTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExpensesDescTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExpensesDescTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpensesDescTB.ForeColor = System.Drawing.Color.Black;
            this.ExpensesDescTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExpensesDescTB.Location = new System.Drawing.Point(114, 268);
            this.ExpensesDescTB.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ExpensesDescTB.Name = "ExpensesDescTB";
            this.ExpensesDescTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ExpensesDescTB.PlaceholderText = "Enter Expenses Description";
            this.ExpensesDescTB.SelectedText = "";
            this.ExpensesDescTB.Size = new System.Drawing.Size(646, 44);
            this.ExpensesDescTB.TabIndex = 26;
            // 
            // ExpensesTypeTB
            // 
            this.ExpensesTypeTB.Animated = true;
            this.ExpensesTypeTB.BorderRadius = 10;
            this.ExpensesTypeTB.BorderThickness = 0;
            this.ExpensesTypeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExpensesTypeTB.DefaultText = "";
            this.ExpensesTypeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ExpensesTypeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExpensesTypeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExpensesTypeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExpensesTypeTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExpensesTypeTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpensesTypeTB.ForeColor = System.Drawing.Color.Black;
            this.ExpensesTypeTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExpensesTypeTB.Location = new System.Drawing.Point(114, 207);
            this.ExpensesTypeTB.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ExpensesTypeTB.Name = "ExpensesTypeTB";
            this.ExpensesTypeTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ExpensesTypeTB.PlaceholderText = "Enter Expenses Type";
            this.ExpensesTypeTB.SelectedText = "";
            this.ExpensesTypeTB.Size = new System.Drawing.Size(646, 44);
            this.ExpensesTypeTB.TabIndex = 25;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(56, 435);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(704, 245);
            this.guna2Panel1.TabIndex = 24;
            // 
            // ExpensesAmountTB
            // 
            this.ExpensesAmountTB.Animated = true;
            this.ExpensesAmountTB.BorderRadius = 10;
            this.ExpensesAmountTB.BorderThickness = 0;
            this.ExpensesAmountTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExpensesAmountTB.DefaultText = "";
            this.ExpensesAmountTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ExpensesAmountTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExpensesAmountTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExpensesAmountTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExpensesAmountTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExpensesAmountTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpensesAmountTB.ForeColor = System.Drawing.Color.Black;
            this.ExpensesAmountTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExpensesAmountTB.Location = new System.Drawing.Point(114, 332);
            this.ExpensesAmountTB.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ExpensesAmountTB.Name = "ExpensesAmountTB";
            this.ExpensesAmountTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ExpensesAmountTB.PlaceholderText = "Expenses Amount";
            this.ExpensesAmountTB.SelectedText = "";
            this.ExpensesAmountTB.Size = new System.Drawing.Size(377, 44);
            this.ExpensesAmountTB.TabIndex = 23;
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
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::Fire_Sales___Sales_Management_System.Properties.Resources.category;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(400, 36);
            this.logoPB.Margin = new System.Windows.Forms.Padding(4);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(75, 80);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
            this.logoPB.Click += new System.EventHandler(this.LogoPB_Click);
            // 
            // AddExpensesButton
            // 
            this.AddExpensesButton.Animated = true;
            this.AddExpensesButton.BorderRadius = 10;
            this.AddExpensesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddExpensesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddExpensesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddExpensesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddExpensesButton.FillColor = System.Drawing.Color.Black;
            this.AddExpensesButton.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.AddExpensesButton.ForeColor = System.Drawing.Color.Tan;
            this.AddExpensesButton.Location = new System.Drawing.Point(518, 332);
            this.AddExpensesButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddExpensesButton.Name = "AddExpensesButton";
            this.AddExpensesButton.Size = new System.Drawing.Size(243, 44);
            this.AddExpensesButton.TabIndex = 14;
            this.AddExpensesButton.Text = "Add Expenses";
            this.AddExpensesButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(359, 107);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(170, 45);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "Expenses Page";
            this.titleLBL.Click += new System.EventHandler(this.TitleLBL_Click);
            // 
            // subtitleLBL
            // 
            this.subtitleLBL.AutoSize = true;
            this.subtitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitleLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLBL.ForeColor = System.Drawing.Color.White;
            this.subtitleLBL.Location = new System.Drawing.Point(366, 143);
            this.subtitleLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLBL.Name = "subtitleLBL";
            this.subtitleLBL.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.subtitleLBL.Size = new System.Drawing.Size(158, 32);
            this.subtitleLBL.TabIndex = 3;
            this.subtitleLBL.Text = "Please inter Info";
            this.subtitleLBL.Click += new System.EventHandler(this.SubtitleLBL_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expenseIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.expenseTypeDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.expenseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(19, 6);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 26;
            this.guna2DataGridView1.Size = new System.Drawing.Size(669, 228);
            this.guna2DataGridView1.TabIndex = 24;
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 26;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // db_FireSalesDataSet
            // 
            this.db_FireSalesDataSet.DataSetName = "db_FireSalesDataSet";
            this.db_FireSalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbFireSalesDataSetBindingSource
            // 
            this.dbFireSalesDataSetBindingSource.DataSource = this.db_FireSalesDataSet;
            this.dbFireSalesDataSetBindingSource.Position = 0;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "Expense";
            this.expenseBindingSource.DataSource = this.db_FireSalesDataSet;
            // 
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // expenseIDDataGridViewTextBoxColumn
            // 
            this.expenseIDDataGridViewTextBoxColumn.DataPropertyName = "ExpenseID";
            this.expenseIDDataGridViewTextBoxColumn.HeaderText = "ExpenseID";
            this.expenseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenseIDDataGridViewTextBoxColumn.Name = "expenseIDDataGridViewTextBoxColumn";
            this.expenseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseTypeDataGridViewTextBoxColumn
            // 
            this.expenseTypeDataGridViewTextBoxColumn.DataPropertyName = "ExpenseType";
            this.expenseTypeDataGridViewTextBoxColumn.HeaderText = "ExpenseType";
            this.expenseTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenseTypeDataGridViewTextBoxColumn.Name = "expenseTypeDataGridViewTextBoxColumn";
            this.expenseTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EnterExpensesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 705);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EnterExpensesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.EnterExpensesView_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FireSalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFireSalesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Label subtitleLBL;
        private Guna.UI2.WinForms.Guna2Button AddExpensesButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Guna.UI2.WinForms.Guna2TextBox ExpensesAmountTB;
        private Guna.UI2.WinForms.Guna2TextBox ExpensesDescTB;
        private Guna.UI2.WinForms.Guna2TextBox ExpensesTypeTB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource dbFireSalesDataSetBindingSource;
        private db_FireSalesDataSet db_FireSalesDataSet;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private db_FireSalesDataSetTableAdapters.ExpenseTableAdapter expenseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
    }
}

