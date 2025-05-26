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

    public partial class AddNewProductForm : Form
    {
        DatabaseManager db = new DatabaseManager(@"Data Source=DESKTOP-KL322NI\MOHAMMEDGALAL; DataBase=db_FireSales;integrated Security=true;");
        public AddNewProductForm()
        {
            InitializeComponent();

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
            IProductRepository productRepository = new ProductRepository(db);
            IProductService productService = new ProductService(productRepository);
            productService.CreateProduct(new Product
            {
                Name = txtProductName.Text,
                Barcode = txtBarcode.Text,
                CategoryID = cbxCategory.SelectedIndex + 1, // Assuming categories are indexed starting from 1
                CostPrice = decimal.Parse(txtCostPrice.Text),
                SellingPrice = decimal.Parse(txtSellingPrice.Text),
                StockQuantity = int.Parse(txtQuantity.Text),
                Unit = null,
                IsActive = 1


            });

            // clear the input fields after adding the product
            txtProductName.Clear();
            txtBarcode.Clear();
            txtCostPrice.Clear();
            txtSellingPrice.Clear();
            txtQuantity.Clear();
            MessageBox.Show("Product added successfully!");

            // refresh the grid view to show the new product
            this.productTableAdapter.Fill(this.db_FireSalesDataSet.Product);
            metroGrid1.DataSource = this.db_FireSalesDataSet.Product;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_FireSalesDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.db_FireSalesDataSet.Product);

            ICategoryRepository categoryRepository = new CategoryRepository(db);
            ICategoryService categoryService = new CategoryService(categoryRepository);

            List<Category> categories = categoryService.GetAllCategories();


            for (int i = 0; i < categories.Count; i++)
            {
                cbxCategory.Items.Add(categories[i].Name);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
