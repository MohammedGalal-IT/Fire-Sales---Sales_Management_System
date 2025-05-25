using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fire_Sales___Sales_Management_System.Presentation.Views;


namespace Fire_Sales___Sales_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            signinForm s = new signinForm();
            //AddNewProductForm a = new AddNewProductForm();
            //AddNewCategoryForm b = new AddNewCategoryForm();
            Application.Run(s);

            //Application.Run(new signupForm());
            //Application.Run(new frMainView(s.user));
            s.Close();
            //Application.Run(new CreateAccountView());
        }
    }
}
