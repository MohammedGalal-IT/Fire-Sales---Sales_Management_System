using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Sales___Sales_Management_System.Presentation.Views
{
    public partial class Users: Form
    {
        public Users()
        {
            InitializeComponent();
            new Guna.UI2.WinForms.Guna2ShadowForm(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_FireSalesDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.db_FireSalesDataSet.User);

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
