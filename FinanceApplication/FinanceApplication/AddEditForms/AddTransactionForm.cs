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
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();
        }


        private bool IsDataCorrect()
        {
            int cost;
            if (!int.TryParse(TransactionCostTextBox.Text, out cost))
            {
                MessageBox.Show("Стоимость не корректна");
                return false;
            }

            return true;
        }

        private void AddAccountToDB()
        {
            Repository.Insert(entity: new Post
            {
                Name = TransactionNameTextBox.Text,
                Date = Convert.ToDateTime(TransactionDateTimePicker.Text),
                AccountWhere = TransactionPlaceTextBox.Text,
                Total = Convert.ToInt32(TransactionCostTextBox.Text),
                AccountFrom = Convert.ToInt32(TransactionUserNameTextBox.Text)
            });
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                AddAccountToDB();
                DialogResult = DialogResult.OK;
                
               
    
            }
         }
         
             

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        

        private void TransactionCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (TransactionCostTextBox.Text.IndexOf(',') != -1)
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
                    AcceptButton.Focus();
                return;
            }

            // остальные символы запрещены
            e.Handled = true;
        }
    }
}
