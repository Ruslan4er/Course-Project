using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceApplication.Database;

namespace FinanceApplication
{
    public partial class AddEditUserForm : Form
    {
        public AddEditUserForm()
        {
            InitializeComponent();
        }
        

        private bool IsDataCorrect()
        {
            int age;
            if (!int.TryParse(UserAgeTextBox.Text, out age))
            {
                MessageBox.Show("Возраст не корректен");
                return false;
            }

            return true;

        }


        private void AddUserToDB() => Repository.Insert(entity: new User
            {
               
                Name = UserNameTextBox.Text,
                Surname = UserSurnameTextBox.Text,
                Age = Convert.ToInt32(UserAgeTextBox.Text)  
            });


        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
           
        }
        

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                AddUserToDB();
              
                DialogResult = DialogResult.OK;
                

                
            }
            
        }

     

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }




        private void UserAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (UserAgeTextBox.Text.IndexOf(',') != -1)
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
                    AcceptAddUserButton.Focus();
                return;
            }

            // остальные символы запрещены
            e.Handled = true;
        }
    }
    }

