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
    public partial class PlannedPurchaseForm : Form
    {
        public PlannedPurchaseForm()
        {
            InitializeComponent();
          
        }

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            AddPlannedPurchaseForm frm = new AddPlannedPurchaseForm();
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

        private void UpdDb()
        {
            this.planedPurchasesTableAdapter.Fill(this.financeApplicationDBDataSet2.PlanedPurchases);
        }

        private void PlannedPurchaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeApplicationDBDataSet2.PlanedPurchases' table. You can move, or remove it, as needed.
            this.planedPurchasesTableAdapter.Fill(this.financeApplicationDBDataSet2.PlanedPurchases);

        }

        private void CheckPPurchase()
        {
            int id;
            int.TryParse(PPDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out id);

            var context = new FinanceApplicationDBEntities3();
            
            var ppurchase = Repository.Select<PlanedPurchases>(context)
                .Where(a => a.PPUID == id)
                .FirstOrDefault();

            ppurchase.Status = true;
             
            Repository.Update(ppurchase, context);
        }


        private void EditPurchaseButton_Click(object sender, EventArgs e)
        {
            
                CheckPPurchase();
                UpdDb();
                MessageBox.Show("Успешно");

        }
    }
}
