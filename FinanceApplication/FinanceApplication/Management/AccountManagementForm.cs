using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceApplication.AddEditForms;
using FinanceApplication.Database;

namespace FinanceApplication
{
    public partial class AccountManagementForm : Form
    {
        public AccountManagementForm()
        {
            InitializeComponent();
          
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountForm frm = new AddAccountForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdDb();
                MessageBox.Show("Счет добавлен");
                
            }
            else
            {
                MessageBox.Show("Операция отменена");
            }
        }

        private void DeleteAccount()
        {
            int id;
            int.TryParse(AccountDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out id);

            var account = new Account
            {
                AccountUID = id
            };

            Repository.Delete(account);
        }

        private void CloseAccountButton_Click(object sender, EventArgs e)
        {
            CloseAccountForm frm = new CloseAccountForm();

            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DeleteAccount();
                UpdDb();               
            }

            else
            {
                MessageBox.Show("Операция отменена");
            }
        }




        private void ToMainMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void UpdDb()
        {
            this.accountTableAdapter.Fill(this.financeApplicationDBDataSet.Account);

        }


        private void AccountManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeApplicationDBDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.financeApplicationDBDataSet.Account);

        }

        
    }
}
