using Fire_Sales___Sales_Management_System.Helpers.Database_Helpers;
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
    public partial class LoginView: Form
    {
        public LoginView()
        {
            InitializeComponent();
            //    DatabaseManager db = new DatabaseManager(@"Data Source=DESKTOP-KL322NI\MOHAMMEDGALAL; DataBase=LibraryDataBase;integrated Security=true;");
            //    //int s = db.ExecuteNonQuery($"INSERT INTO Book([title],[author],[pages],[date]) values('sss','mmm',100,null)", null);
            //    DataTable dt = db.ExecuteDataTable($"select * from Book", null);
            //    this.dataGridView1.DataSource = dt;
            //    //MessageBox.Show(""+s);
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
