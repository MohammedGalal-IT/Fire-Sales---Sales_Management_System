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

namespace Fire_Sales___Sales_Management_System
{

    public partial class EnterExpensesView : Form
    {
        public EnterExpensesView()
        {
            InitializeComponent();
            new Guna.UI2.WinForms.Guna2ShadowForm(this);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void CostPriceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LogoPB_Click(object sender, EventArgs e)
        {

        }

        private void TitleLBL_Click(object sender, EventArgs e)
        {

        }

        private void SubtitleLBL_Click(object sender, EventArgs e)
        {

        }

        private void EnterExpensesView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_FireSalesDataSet.Expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.db_FireSalesDataSet.Expense);

        }
    }
}
