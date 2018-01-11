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
    public partial class AmortisationManagementForm : Form
    {
        public AmortisationManagementForm()
        {
            InitializeComponent();
            
        }

        private void AddAmortisationPurchaseButton_Click(object sender, EventArgs e)
        {
            AddEditAmortisationPurchaseForm frm = new AddEditAmortisationPurchaseForm();
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

        private void CheckAmortisation()
        {
            int id;
            int.TryParse(AmortisationDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out id);

            var context = new FinanceApplicationDBEntities3();

            var amortisation = Repository.Select<Amortisation>(context)
                .Where(a => a.AmortisationUID == id)
                .FirstOrDefault();

                amortisation.Status = true;

            Repository.Update(amortisation, context);
        }

        private void UpdDb()
        {
            this.amortisationTableAdapter.Fill(this.financeApplicationDBDataSet1.Amortisation);

        }
        private void AmortisationManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeApplicationDBDataSet1.Amortisation' table. You can move, or remove it, as needed.
            this.amortisationTableAdapter.Fill(this.financeApplicationDBDataSet1.Amortisation);

        }

        private void EditAmortisationPurchaseButton_Click(object sender, EventArgs e)
        {
           

                CheckAmortisation();
                UpdDb();
                MessageBox.Show("Успешно");
           
        }
    }
}
