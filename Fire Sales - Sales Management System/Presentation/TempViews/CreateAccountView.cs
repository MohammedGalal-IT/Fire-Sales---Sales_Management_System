using Fire_Sales___Sales_Management_System.Business_Logic.Controllers;
using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Sales___Sales_Management_System.Presentation.TempViews
{

    public partial class CreateAccountView : Form
    {
        private CreateAccountController _controller;
        public Action<string, string, string, bool, UserRole> OnCreateAccountAttempt;

        public CreateAccountView()
        {
            InitializeComponent();
            _controller = new CreateAccountController(new Views.signupForm());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserRole selectedRole = rbtnAdmin.Checked ? UserRole.Admin : UserRole.Cashier;

            OnCreateAccountAttempt?.Invoke(
                txtUsername.Text,
                txtPassword.Text,
                txtConfirmPassword.Text,
                chkIsActive.Checked,
                selectedRole
            );
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CreateAccountView_Load(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
