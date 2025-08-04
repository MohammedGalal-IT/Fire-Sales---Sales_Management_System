using Fire_Sales___Sales_Management_System.Business_Logic.Services;
using Fire_Sales___Sales_Management_System.Data_Access.Repositories;
using Fire_Sales___Sales_Management_System.Helpers.Database_Helpers;
using Fire_Sales___Sales_Management_System.Model;
using Fire_Sales___Sales_Management_System.Presentation.Views;
using Guna.UI2.WinForms.Suite;
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
        readonly DatabaseManager db = new DatabaseManager(@"Data Source=DESKTOP-KL322NI\MOHAMMEDGALAL; DataBase=db_FireSales;integrated Security=true;");
        ExpenseRepository expenseRepository;
        ExpenseService expenseService;

        public EnterExpensesView()
        {
            InitializeComponent();
            new Guna.UI2.WinForms.Guna2ShadowForm(this);
            expenseRepository = new ExpenseRepository(db);
            expenseService = new ExpenseService(expenseRepository);



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
            //if (!(txtAmount.Text.Trim() == "" || cbxExpenses.SelectedIndex == -1))
            {
                expenseService.Add(new Expense()
                {
                    Description = txtDescription.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                    Date = DateTime.Now,
                    ExpenseType = ExpenseType.أكل,
                    CreatedBy = signinForm.CurrentUser.UserID
                });

                MessageBox.Show("add successfully");

                // refresh the grid view to show the new category
                
                //guna2DataGridView1.
            }

            
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

            //var expense = expenseService.GetAll();

            //foreach (var item in expense)
            //{
            //    cbxExpenses.Items.Add(item.);
            //}

            cbxExpenses.Items.Add(ExpenseType.أكل.ToString());
            cbxExpenses.Items.Add(ExpenseType.قات.ToString());
            cbxExpenses.Items.Add(ExpenseType.كهرباء.ToString());
            cbxExpenses.Items.Add(ExpenseType.شيء_آخر.ToString());



        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
