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
    public partial class AddPlannedPurchaseForm : Form
    {

        private bool IsDataCorrect()
        {
            int cost;

            if (!int.TryParse(PPurchaseCostTextBox.Text, out cost))
            {
                MessageBox.Show("Стоимость не корректна");
                return false;
            }

            return true;

        }

        public AddPlannedPurchaseForm()
        {
            InitializeComponent();
        }


        private void AddPPToDB() => Repository.Insert(entity: new PlanedPurchases
        {

            Name = PPurchaseNameTextBox.Text,
            Status = false,
            Cost = Convert.ToInt32(PPurchaseCostTextBox.Text),
            AccountUID = Convert.ToInt32(PPUserTextBox.Text)
        });

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                AddPPToDB();
                DialogResult = DialogResult.OK;
                
            }
        }

        private void PPurchaseCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (PPurchaseCostTextBox.Text.IndexOf(',') != -1)
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

