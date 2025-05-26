using Fire_Sales___Sales_Management_System.Business_Logic.Interfaces;
using Fire_Sales___Sales_Management_System.Business_Logic.Services;
using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Repositories;
using Fire_Sales___Sales_Management_System.Helpers.Database_Helpers;
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

    public partial class AddNewCategoryForm : Form
    {
        DatabaseManager db = new DatabaseManager(@"Data Source=DESKTOP-KL322NI\MOHAMMEDGALAL; DataBase=db_FireSales;integrated Security=true;");

        public AddNewCategoryForm()
        {
            InitializeComponent();
            guna2DataGridView1.BringToFront();

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
            ICategoryRepository categoryRepository = new CategoryRepository(db);
            ICategoryService categoryService = new CategoryService(categoryRepository);
            categoryService.CreateCategory(new Category
            {
                Name = txtCategoryName.Text,
                Description = txtDescription.Text,
            });

            // clear the input fields after adding the category
            txtCategoryName.Clear();
            txtDescription.Clear();
            MessageBox.Show("Category added successfully!");
            // refresh the grid view to show the new category
            this.categoryTableAdapter.Fill(this.db_FireSalesDataSet.Category);
            guna2DataGridView1.DataSource = this.db_FireSalesDataSet.Category;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_FireSalesDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.db_FireSalesDataSet.Category);

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
