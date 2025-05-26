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
        ISalesInvoiceRepository invoiceRepository;
        ISalesItemRepository salesItemRepository;
        ISalesService salesService;
        ITransactionLogRepository transactionLogRepository;
        ITransactionLogService transactionLogService;

        public SalePageViewForm()
        {
            InitializeComponent();
            new Guna.UI2.WinForms.Guna2ShadowForm(this);
            categoryRepository = new CategoryRepository(db);
            categoryService = new CategoryService(categoryRepository);
            productRepository = new ProductRepository(db);
            productService = new ProductService(productRepository);

            invoiceRepository = new SalesInvoiceRepository(db);
            salesItemRepository = new SalesItemRepository(db);
            salesService = new SalesService(invoiceRepository, salesItemRepository);

            transactionLogRepository = new TransactionLogRepository(db);
            transactionLogService = new TransactionLogService(transactionLogRepository);


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

        private string GenerateInvoiceNumber()
        {
            // Format: SAL-YYYYMMDDHHmmssff
            return "SAL-" + DateTime.Now.ToString("yyyyMMddHHmmssff");
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            string invoiceNumber = GenerateInvoiceNumber();
            lblInvoiceNunber.Text = invoiceNumber;

            SalesInvoice invoice = new SalesInvoice()
            {
                InvoiceNumber = invoiceNumber ,
                Date = DateTime.Now,
                TotalAmount = 0m,
                CreatedBy = signinForm.CurrentUser.UserID,

            };
            salesService.CreateInvoice(invoice);

            decimal totalAmount = 0m;
            decimal totalDiscount = 0m;


            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                // Skip the new row placeholder if AllowUserToAddRows is true
                if (row.IsNewRow) continue;

                // Access cell values by index or column name
                var productName = row.Cells[0].Value?.ToString();
                var categoryName = row.Cells[1].Value?.ToString();
                var quantity = row.Cells[2].Value != null ? Convert.ToInt32(row.Cells[2].Value) : 0;
                var price = row.Cells[3].Value != null ? Convert.ToDecimal(row.Cells[3].Value) : 0m;

                SalesItem item = new SalesItem()
                {
                    SalesInvoiceID = salesService.GetByInvoiceNumber(invoiceNumber).SalesInvoiceID,
                    ProductID = productService.GetProductByName(ltvProducts.SelectedItems[0].Text).ProductID,
                    Quantity = quantity,
                    CostPrice = price,
                    Discount = txtDiscount.Text == "" ? 0m : int.Parse(txtQaunity.Text),

                };
                totalAmount += price;
                totalDiscount += item.Discount;

                salesService.AddSalesItem(item);

                //------------------------
                // Get the product
                var product = productService.GetProductByName(productName);
                // Decrease stock
                product.StockQuantity -= quantity;
                // Update the product in the database
                productService.UpdateProduct(product);
            }

            // Update the invoice with total amount and discount
            invoice.TotalAmount = totalAmount - totalDiscount;


            //string query = @"
            //    UPDATE SalesInvoice SET 
            //        TotalAmount = @TotalAmount
            //    WHERE SalesInvoiceID = @ID";

            //var parameters = new Dictionary<string, object>
            //{
            //    { "@TotalAmount", invoice.TotalAmount },
            //    { "@ID", salesService.GetByInvoiceNumber(invoiceNumber).SalesInvoiceID }
            //};

            // db.ExecuteNonQuery(query, parameters);


            
            if (salesService.UpdateInvoice(new SalesInvoice()
            {
                SalesInvoiceID = salesService.GetByInvoiceNumber(invoiceNumber).SalesInvoiceID,
                InvoiceNumber = invoice.InvoiceNumber,
                Date = invoice.Date,
                TotalAmount = invoice.TotalAmount,
                CreatedBy = invoice.CreatedBy

            }))
            {
                MessageBox.Show($"Invoice {invoice.InvoiceNumber} created successfully!\nTotal Amount: {totalAmount:C}\nTotal Discount: {totalDiscount:C}", "Invoice Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // add Transation Log
            //transactionLogService.Add(new TransactionLog()
            //{
            //    TransactionType = TransactionType.Sale,
            //    ReferenceID = salesService.GetByInvoiceNumber(invoiceNumber).SalesInvoiceID,
            //    Amount = invoice.TotalAmount,
            //    Date = DateTime.Now,
            //    CreatedBy = signinForm.CurrentUser.UserID,
            //    Note = $"Sale Invoice {invoice.InvoiceNumber} created with total amount {invoice.TotalAmount:C}."

            //});


            // clear the graidview after adding the invoice
            guna2DataGridView1.Rows.Clear();

            // refrech the list view
            refrechListView();






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

        private void refrechListView()
        {
            var c = categoryService.GetCategoryByName(cbxCategory.SelectedItem.ToString());
            var products = productService.GetByCategoryId(c.CategoryID);


            ltvProducts.Items.Clear();

            foreach (var product in products)
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.SellingPrice.ToString("C")); // "C" for currency format
                item.SubItems.Add(product.StockQuantity.ToString());
                ltvProducts.Items.Add(item);
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrechListView();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // it shows an exception here way
                if (ltvProducts.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a product from the list.", "No Product Selected");
                    return;
                }
                var item = (ListViewItem) this.ltvProducts.SelectedItems[0];

                if (item != null)
                {
                    string productName = item.Text;
                    int quantity = txtQaunity.Text == "" ? 1 : int.Parse(txtQaunity.Text);

                    if(quantity > int.Parse(item.SubItems[2].Text)) {
                        MessageBox.Show("Insufficient stock available.", "Stock Error");
                        txtQaunity.Focus();
                        return;
                    }
                    decimal price = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency) * quantity;
                    
                    MessageBox.Show($"Product: {productName}\nPrice: {price:C}\nQuantity: {quantity}", "Sale Details");

                    guna2DataGridView1.Rows.Add(
                            productName,
                            cbxCategory.SelectedItem.ToString(),
                            quantity,
                            price,
                            txtDiscount.Text == "" ? 0 : int.Parse(txtDiscount.Text)
                        );


                }
                else
                {
                    MessageBox.Show("Please select a product from the list.", "No Product Selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex.StackTrace);
            }

            // clear fileds
            txtQaunity.Clear();
            txtDiscount.Clear();
            txtQaunity.Focus();



        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void noteLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
