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

namespace FinanceApplication
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        public string DeltaAccountName { get; set; }

        public int DeltaAccountBalance
        {
            get { return int.Parse(AccountBalanceTextBox.Text); }
            set
            {
                if (value > 0)
                {
                    AccountBalanceTextBox.Text = value.ToString();

                }
            }
        }

        private bool IsDataCorrect()
        {
            int balance;
            if (!int.TryParse(AccountBalanceTextBox.Text, out balance))
            {
                MessageBox.Show("Баланс не корректен");
                return false;
            }

            return true;

        }

        private void AddAccountToDB() => Repository.Insert(entity: new Account
        {

            Name = AccountNameTextBox.Text,
            Status = true,
            Balance = Convert.ToInt32(AccountBalanceTextBox.Text)
        });

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                AddAccountToDB();
                DialogResult = DialogResult.OK;
              
            }
        }

        private void AccountBalanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }

            if (e.KeyChar == '.')
            {
                // точку заменим запятой
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (AccountBalanceTextBox.Text.IndexOf(',') != -1)
                {
                    // запятая уже есть в поле редактирования
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // нажата клавиша <Enter>
                    // установить курсор на кнопку OK
                    AcceptAddAccountButton.Focus();
                return;
            }

            // остальные символы запрещены
            e.Handled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
