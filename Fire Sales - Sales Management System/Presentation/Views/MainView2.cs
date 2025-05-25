using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fire_Sales___Sales_Management_System.Model;
using Fire_Sales___Sales_Management_System.Presentation.Views;
using Fire_Sales___Sales_Management_System.Presentation.Views;

namespace Fire_Sales___Sales_Management_System.Presentation.Views
{
    public partial class MainView2: Form
    {
        private User _user;
        public MainView2(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void logoPB_Click(object sender, EventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_FireSalesDataSet.PurchaseInvoice' table. You can move, or remove it, as needed.
            this.purchaseInvoiceTableAdapter.Fill(this.db_FireSalesDataSet.PurchaseInvoice);
            // TODO: This line of code loads data into the 'db_FireSalesDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.db_FireSalesDataSet.User);

            subtitleLBL.Text = _user.Username;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new signupForm().ShowDialog();
        }

        private void subtitleLBL_Click(object sender, EventArgs e)
        {

        }

        private void txtAddProduct_Click(object sender, EventArgs e)
        {
            new AddNewProductForm().ShowDialog();
        }

        private void btnCraeteCategory_Click(object sender, EventArgs e)
        {
            new AddNewCategoryForm().ShowDialog();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            new mainForm().ShowDialog(this);
        }
    }
}
