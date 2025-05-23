namespace LoginView
{
    partial class signupForm
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
            this.RoleGB = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CashierRB = new System.Windows.Forms.RadioButton();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.confirmPassTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.createaccountButton = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleLBL = new System.Windows.Forms.Label();
            this.subtitleLBL = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.RoleGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Tan;
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.RoleGB);
            this.mainPanel.Controls.Add(this.confirmPassTB);
            this.mainPanel.Controls.Add(this.logoPB);
            this.mainPanel.Controls.Add(this.createaccountButton);
            this.mainPanel.Controls.Add(this.passwordTB);
            this.mainPanel.Controls.Add(this.usernameTB);
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
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back to home Page";
            // 
            // RoleGB
            // 
            this.RoleGB.BorderRadius = 10;
            this.RoleGB.Controls.Add(this.CashierRB);
            this.RoleGB.Controls.Add(this.adminRB);
            this.RoleGB.CustomBorderColor = System.Drawing.Color.White;
            this.RoleGB.FillColor = System.Drawing.Color.Gainsboro;
            this.RoleGB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoleGB.ForeColor = System.Drawing.Color.Black;
            this.RoleGB.Location = new System.Drawing.Point(214, 291);
            this.RoleGB.Name = "RoleGB";
            this.RoleGB.Size = new System.Drawing.Size(322, 87);
            this.RoleGB.TabIndex = 17;
            this.RoleGB.Text = "User Role";
            // 
            // CashierRB
            // 
            this.CashierRB.AutoSize = true;
            this.CashierRB.BackColor = System.Drawing.Color.Transparent;
            this.CashierRB.Cursor = System.Windows.Forms.Cursors.Default;
            this.CashierRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierRB.Location = new System.Drawing.Point(115, 55);
            this.CashierRB.Name = "CashierRB";
            this.CashierRB.Size = new System.Drawing.Size(63, 19);
            this.CashierRB.TabIndex = 1;
            this.CashierRB.TabStop = true;
            this.CashierRB.Text = "Cashier";
            this.CashierRB.UseMnemonic = false;
            this.CashierRB.UseVisualStyleBackColor = false;
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.BackColor = System.Drawing.Color.Transparent;
            this.adminRB.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminRB.Location = new System.Drawing.Point(26, 55);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(60, 19);
            this.adminRB.TabIndex = 0;
            this.adminRB.TabStop = true;
            this.adminRB.Text = "Admin";
            this.adminRB.UseVisualStyleBackColor = false;
            // 
            // confirmPassTB
            // 
            this.confirmPassTB.Animated = true;
            this.confirmPassTB.BorderRadius = 10;
            this.confirmPassTB.BorderThickness = 0;
            this.confirmPassTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassTB.DefaultText = "";
            this.confirmPassTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPassTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPassTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPassTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmPassTB.ForeColor = System.Drawing.Color.Black;
            this.confirmPassTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPassTB.Location = new System.Drawing.Point(214, 233);
            this.confirmPassTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.confirmPassTB.Name = "confirmPassTB";
            this.confirmPassTB.PasswordChar = '.';
            this.confirmPassTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.confirmPassTB.PlaceholderText = "Confirm Password";
            this.confirmPassTB.SelectedText = "";
            this.confirmPassTB.Size = new System.Drawing.Size(322, 36);
            this.confirmPassTB.TabIndex = 16;
            // 
            // logoPB
            // 
            this.logoPB.FillColor = System.Drawing.Color.Black;
            this.logoPB.Image = global::LoginView.Properties.Resources.img;
            this.logoPB.ImageRotate = 0F;
            this.logoPB.Location = new System.Drawing.Point(350, 20);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(49, 45);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 15;
            this.logoPB.TabStop = false;
            // 
            // createaccountButton
            // 
            this.createaccountButton.Animated = true;
            this.createaccountButton.BorderRadius = 10;
            this.createaccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createaccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createaccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createaccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createaccountButton.FillColor = System.Drawing.Color.Black;
            this.createaccountButton.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold);
            this.createaccountButton.ForeColor = System.Drawing.Color.Tan;
            this.createaccountButton.Location = new System.Drawing.Point(271, 419);
            this.createaccountButton.Name = "createaccountButton";
            this.createaccountButton.Size = new System.Drawing.Size(208, 30);
            this.createaccountButton.TabIndex = 14;
            this.createaccountButton.Text = "Create Account";
            this.createaccountButton.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Animated = true;
            this.passwordTB.BorderRadius = 10;
            this.passwordTB.BorderThickness = 0;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTB.ForeColor = System.Drawing.Color.Black;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Location = new System.Drawing.Point(214, 183);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '.';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordTB.PlaceholderText = "Password";
            this.passwordTB.SelectedText = "";
            this.passwordTB.Size = new System.Drawing.Size(322, 36);
            this.passwordTB.TabIndex = 13;
            // 
            // usernameTB
            // 
            this.usernameTB.Animated = true;
            this.usernameTB.BorderRadius = 10;
            this.usernameTB.BorderThickness = 0;
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.DefaultText = "";
            this.usernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTB.ForeColor = System.Drawing.Color.Black;
            this.usernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Location = new System.Drawing.Point(214, 132);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.usernameTB.PlaceholderText = "UserName";
            this.usernameTB.SelectedText = "";
            this.usernameTB.Size = new System.Drawing.Size(322, 36);
            this.usernameTB.TabIndex = 12;
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLBL.Font = new System.Drawing.Font("Cairo Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(282, 59);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(186, 36);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "Create a new Account";
            // 
            // subtitleLBL
            // 
            this.subtitleLBL.AutoSize = true;
            this.subtitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitleLBL.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLBL.ForeColor = System.Drawing.Color.White;
            this.subtitleLBL.Location = new System.Drawing.Point(296, 88);
            this.subtitleLBL.Name = "subtitleLBL";
            this.subtitleLBL.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.subtitleLBL.Size = new System.Drawing.Size(158, 24);
            this.subtitleLBL.TabIndex = 3;
            this.subtitleLBL.Text = "Enter The Account info";
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "signupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.RoleGB.ResumeLayout(false);
            this.RoleGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Label subtitleLBL;
        private Guna.UI2.WinForms.Guna2TextBox usernameTB;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Guna.UI2.WinForms.Guna2Button createaccountButton;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2TextBox confirmPassTB;
        private Guna.UI2.WinForms.Guna2GroupBox RoleGB;
        private System.Windows.Forms.RadioButton CashierRB;
        private System.Windows.Forms.RadioButton adminRB;
        private Guna.UI2.WinForms.Guna2Button backButton;
    }
}

