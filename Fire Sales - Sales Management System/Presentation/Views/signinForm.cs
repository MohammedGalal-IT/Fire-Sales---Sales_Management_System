using Fire_Sales___Sales_Management_System.Business_Logic.Controllers;
using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Sales___Sales_Management_System.Presentation.Views
{

    public partial class signinForm : Form
    {
        private LoginController _controller; // ---------------------
        public Action<string, string> OnLoginAttempt; //------------------
        public User user { get; set; }
        public signinForm()
        {
            InitializeComponent();
            _controller = new LoginController(this); // ---------------------
        }

        private void btnLogin_Click(object sender, EventArgs e) // ---------------------
        {
            OnLoginAttempt?.Invoke(this.txtUsername.Text, this.txtPassword.Text);
        }

        public void ShowError(string message) //--------------------------
        {
            MessageBox.Show(message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoginSuccess(string message)//---------------------
        {
            MessageBox.Show(message, "Done Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        
    }
}
