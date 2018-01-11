using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FinanceApplication
{
    class MyApplicationContext : ApplicationContext
    {
        public MyApplicationContext()
        {
            GreetingForm frm = new GreetingForm();
            frm.Show();
        }
        
    }
    public class UserContext : DbContext
    {
        //public DbSet<AddEditUserForm> Users { get; set; }
        //public DbSet<AddAccountForm> Products { get; set; }
    }


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
            //Application.Run(new GreetingForm());
            MyApplicationContext context = new MyApplicationContext();
            Application.Run(context);




            // MyApplicationContext context = new MyApplicationContext();
            //Application.Run(context);

        }
    }

    
}
