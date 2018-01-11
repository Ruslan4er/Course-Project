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
    public partial class AddEditAmortisationPurchaseForm : Form
    {
        public AddEditAmortisationPurchaseForm()
        {
            InitializeComponent();
        }
        
        private bool IsDataCorrect()
        {
            int cost;
        
            if (!int.TryParse(AmortisationCostTextBox.Text, out cost))
            {
                MessageBox.Show("Стоимость не корректна");
                return false;
            }

            return true;

        }

        private void AddAmortisationToDB() => Repository.Insert(entity: new Amortisation
        {

            Name = AmortisastionNameTextBox.Text,
            Status = false,
            AccountUID = Convert.ToInt32(AmortisationUserTextBox.Text),
            Cost = Convert.ToInt32(AmortisationCostTextBox.Text)
        });

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                AddAmortisationToDB();
                DialogResult = DialogResult.OK;
             

            }
        
        }

        private void AmortisationCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (AmortisationCostTextBox.Text.IndexOf(',') != -1)
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
