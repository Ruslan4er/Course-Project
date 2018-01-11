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

namespace FinanceApplication
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void UserFormButton_Click(object sender, EventArgs e)
        {
            UserManagementForm frm = new UserManagementForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void AccountFormButton_Click(object sender, EventArgs e)
        {
            AccountManagementForm frm = new AccountManagementForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void PPurchaseButton_Click(object sender, EventArgs e)
        {
            PlannedPurchaseForm frm = new PlannedPurchaseForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void AmortisationFormButton_Click(object sender, EventArgs e)
        {
            AmortisationManagementForm frm = new AmortisationManagementForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void AddTransactionFormButton_Click(object sender, EventArgs e)
        {
            AddTransactionForm frm = new AddTransactionForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdDb();
            }
            else
            {
                MessageBox.Show("Операция отменена");
            }
        }

        private void UpdDb()
        {
            this.postTableAdapter.Fill(this.financeApplicationDBDataSet4.Post);

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeApplicationDBDataSet4.Post' table. You can move, or remove it, as needed.
            this.postTableAdapter.Fill(this.financeApplicationDBDataSet4.Post);

        }

        
       
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void YearReportButton_Click(object sender, EventArgs e)
        {
            ReportManager.ExporttoExcel(dataGridView1);
        }
    }
}
