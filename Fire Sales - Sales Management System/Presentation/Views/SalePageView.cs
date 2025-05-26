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

    public partial class SalePageViewForm : Form
    {
       readonly DatabaseManager  db = new DatabaseManager(@"Data Source=DESKTOP-KL322NI\MOHAMMEDGALAL; DataBase=db_FireSales;integrated Security=true;");
        ICategoryRepository categoryRepository;
        ICategoryService categoryService;
        IProductRepository productRepository;
        IProductService productService;

        public SalePageViewForm()
        {
            InitializeComponent();
            categoryRepository = new CategoryRepository(db);
            categoryService = new CategoryService(categoryRepository);
            productRepository = new ProductRepository(db);
            productService = new ProductService(productRepository);

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

        private void MetroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SalePageViewForm_Load(object sender, EventArgs e)
        {
            

            List<Category> categories = categoryService.GetAllCategories();


            for (int i = 0; i < categories.Count; i++)
            {
                cbxCategory.Items.Add(categories[i].Name);
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = categoryService.GetCategoryByName(cbxCategory.SelectedItem.ToString());
            var products = productService.GetByCategoryId(c.CategoryID);
            // how to fill the listView ?

            ltvProducts.Items.Clear();

            foreach (var product in products)
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.SellingPrice.ToString("C")); // "C" for currency format
                item.SubItems.Add(product.StockQuantity.ToString());
                ltvProducts.Items.Add(item);
            }

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var item = (ListViewItem)this.ltvProducts.SelectedItems[0];

                if (item != null)
                {
                    string productName = item.Text;
                    decimal price = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency);
                    int quantity = int.Parse(item.SubItems[2].Text);
                    // Here you can add the logic to handle the sale, e.g., adding to a cart or processing the sale
                    MessageBox.Show($"Product: {productName}\nPrice: {price:C}\nQuantity: {quantity}", "Sale Details");
                }
                else
                {
                    MessageBox.Show("Please select a product from the list.", "No Product Selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select an Items from the list","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
