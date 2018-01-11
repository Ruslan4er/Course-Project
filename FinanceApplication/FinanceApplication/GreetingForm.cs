using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceApplication
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MainMenuForm frm = new MainMenuForm();
            this.Close();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
            
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
