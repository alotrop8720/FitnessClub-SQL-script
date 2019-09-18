using FastReport;
using FitnessClub.Components.Classes.ClassesTable;
using System;
using System.Windows.Forms;

namespace FitnessClub.Components.Forms
{
    public partial class CustomerInformation : Form
    {
        public DateTime saveDate;
        CustomerSQL customerSQL;
        public string oldCustomer;

        public CustomerInformation()
        {
            InitializeComponent();
            customerSQL = new CustomerSQL();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DateBirthday_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateBirthday.Value = new DateTime(saveDate.Year, saveDate.Month, saveDate.Day);
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void rbGroupVisit_CheckedChanged(object sender, EventArgs e)
        {
            string name = tbName.Text;
            customerSQL.Customer = $"{name.Split(' ')[0]} {tbThirdName.Text} {name.Split(' ')[1]}";
            customerSQL.GroupCustomer(GridViewSelect);
        }

        private void rbVisit_CheckedChanged(object sender, EventArgs e)
        {
            customerSQL.VisitCustomer(GridViewSelect);
        }

        private void CustomerInformation_Activated(object sender, EventArgs e)
        {
            rbGroupVisit.Checked = true;
        }

        private void cbChoseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChoseDate.Checked)
            {
                customerSQL.DateVisit = DateChose.Value;
                customerSQL.VisitDateCustomer(GridViewSelect);
            }
            else
            {
                customerSQL.VisitCustomer(GridViewSelect);
            }
        }

        private void CustomerInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Все изменения будут сохранены",
                                "Внимание",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            string name = tbName.Text;
            customerSQL.Phone = tbPhone.Text;
            customerSQL.Customer = $"{name.Split(' ')[0]} {tbThirdName.Text} {name.Split(' ')[1]}";
            customerSQL.oldCustomer = oldCustomer;
            customerSQL.UpdateCustomer();
        }

        private void GridViewSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
