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
    public partial class UserManagementForm : Form
    {
        
        public UserManagementForm()
        {
            InitializeComponent();

       
        }

        

    private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddEditUserForm frm = new AddEditUserForm();        
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdDb();
                MessageBox.Show("Добавлено");
        
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

        private void DeleteAccount()
        {
            int id;
            int.TryParse(UserManagementGridView.SelectedRows[0].Cells[0].Value.ToString(), out id);

            var user = new User
            {
                UserUID = id
            };

            Repository.Delete(user);
        }

        private void UpdDb()
        {
            this.userTableAdapter.Fill(this.financeApplicationDBDataSet3.User);
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeApplicationDBDataSet3.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.financeApplicationDBDataSet3.User);
                 

        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            DeleteUserForm frm = new DeleteUserForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DeleteAccount();
                UpdDb();
                MessageBox.Show("Удалено");

            }
            else
            {
                MessageBox.Show("Операция отменена");
            }

        }
    }
}
