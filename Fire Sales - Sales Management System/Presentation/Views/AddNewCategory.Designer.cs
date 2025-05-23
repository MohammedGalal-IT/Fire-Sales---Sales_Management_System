namespace LoginView
{
    partial class AddNewCategoryForm
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
            this.categoryNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.addCategoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.descriptionTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleLBL = new System.Windows.Forms.Label();
            this.subtitleLBL = new System.Windows.Forms.Label();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Tan;
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.categoryNameTB);
            this.mainPanel.Controls.Add(this.logoPB);
            this.mainPanel.Controls.Add(this.addCategoryButton);
            this.mainPanel.Controls.Add(this.descriptionTB);
            this.mainPanel.Controls.Add(this.titleLBL);
            this.mainPanel.Controls.Add(this.subtitleLBL);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(750, 400);
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
            // categoryNameTB
            // 
            this.categoryNameTB.Animated = true;
            this.categoryNameTB.BorderRadius = 10;
            this.categoryNameTB.BorderThickness = 0;
            this.categoryNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryNameTB.DefaultText = "";
            this.categoryNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryNameTB.ForeColor = System.Drawing.Color.Black;
            this.categoryNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameTB.Location = new System.Drawing.Point(98, 177);
            this.categoryNameTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.categoryNameTB.Name = "categoryNameTB";
            this.categoryNameTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.categoryNameTB.PlaceholderText = "Category Name";
            this.categoryNameTB.SelectedText = "";
            this.categoryNameTB.Size = new System.Drawing.Size(554, 36);
            this.categoryNameTB.TabIndex = 16;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Animated = true;
            this.addCategoryButton.BorderRadius = 10;
            this.addCategoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addCategoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addCategoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addCategoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addCategoryButton.FillColor = System.Drawing.Color.Black;
            this.addCategoryButton.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.addCategoryButton.ForeColor = System.Drawing.Color.Tan;
            this.addCategoryButton.Location = new System.Drawing.Point(271, 283);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(208, 30);
            this.addCategoryButton.TabIndex = 14;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // descriptionTB
            // 
            this.descriptionTB.Animated = true;
            this.descriptionTB.BorderRadius = 10;
            this.descriptionTB.BorderThickness = 0;
            this.descriptionTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTB.DefaultText = "";
            this.descriptionTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionTB.ForeColor = System.Drawing.Color.Black;
            this.descriptionTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTB.Location = new System.Drawing.Point(98, 228);
            this.descriptionTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.descriptionTB.PlaceholderText = "Description";
            this.descriptionTB.SelectedText = "";
            this.descriptionTB.Size = new System.Drawing.Size(554, 36);
            this.descriptionTB.TabIndex = 12;
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
            this.titleLBL.Text = "Add New Category";
            // 
            // subtitleLBL
            // 
            this.subtitleLBL.AutoSize = true;
            this.subtitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitleLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLBL.ForeColor = System.Drawing.Color.White;
            this.subtitleLBL.Location = new System.Drawing.Point(293, 116);
            this.subtitleLBL.Name = "subtitleLBL";
            this.subtitleLBL.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.subtitleLBL.Size = new System.Drawing.Size(164, 24);
            this.subtitleLBL.TabIndex = 3;
            this.subtitleLBL.Text = "Enter The Category info";
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::LoginView.Properties.Resources.category;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(343, 29);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(64, 65);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
            // 
            // AddNewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddNewCategoryForm";
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
        private Guna.UI2.WinForms.Guna2TextBox descriptionTB;
        private Guna.UI2.WinForms.Guna2Button addCategoryButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2TextBox categoryNameTB;
        private Guna.UI2.WinForms.Guna2Button backButton;
    }
}

