using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceApplication.Database;

namespace FinanceApplication.AddEditForms
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        
        private void AcceptAddUserButton_Click(object sender, EventArgs e)
        {
            
 
                DialogResult = DialogResult.OK;
            
        }

        private void CancelAddUserButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
