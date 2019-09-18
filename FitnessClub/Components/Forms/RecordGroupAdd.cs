using FitnessClub.Components.Classes.ClassesTable;
using FitnessClub.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Components.Forms
{
    public partial class RecordGroupAdd : Form
    {
        RecordGroupTable recordGroup;
        public RecordGroupAdd()
        {
            InitializeComponent();
            recordGroup = new RecordGroupTable();
            
        }

        private void bttAddGroup_Click(object sender, EventArgs e)
        {
            GroupAdd groupAdd = new GroupAdd();
            groupAdd.ShowDialog();
        }

        private void tbCountClasses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bttBuyClasses_Click(object sender, EventArgs e)
        {
            if (cbCustomer.Text == string.Empty || cbGroups.Text == string.Empty)
            {
                MessageBox.Show("Заполните поля",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            SQLPrise qLPrise = new SQLPrise();
            qLPrise.Group = cbGroups.Text;
            qLPrise.Customer = cbCustomer.Text;
            qLPrise.DateRecord = DateRecord.Value;
            BuyForm buyForm = new BuyForm(qLPrise);
            buyForm.mainForm = this;
            buyForm.flagForm = true;
            buyForm.ShowDialog();
        }

        private void bttCustomer_Click(object sender, EventArgs e)
        {
            CustomeAdd customeAdd = new CustomeAdd();
            customeAdd.ShowDialog();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if (cbGroups.Text == String.Empty || cbCustomer.Text == String.Empty || tbCountClasses.Text == String.Empty)
            {
                MessageBox.Show("Заполните поля",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
            
            recordGroup.Customer = cbCustomer.Text;
            recordGroup.Group = cbGroups.Text;
            if (recordGroup.CheckSimilarGroup())
            {
                MessageBox.Show("Такая запись существует",
                               "Внимание",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите сохранить запись?",
                                "Внимание",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
 
            recordGroup.CountClasses = int.Parse(tbCountClasses.Text);
            recordGroup.DateRecord = DateRecord.Value;            
            recordGroup.AddRow();
            this.Close();
        }

        private void cbGroups_DropDown(object sender, EventArgs e)
        {
            cbGroups.Items.Clear();
            recordGroup.SelectGroup(cbGroups);
        }

        private void cbCustomer_DropDown(object sender, EventArgs e)
        {
            cbCustomer.Items.Clear();
            recordGroup.SelectCustomer(cbCustomer);
        }

        private void tbCountClasses_TextChanged(object sender, EventArgs e)
        {
            recordGroup.Customer = cbCustomer.Text;
            recordGroup.Group = cbGroups.Text;
            recordGroup.UpdateCountPrice(int.Parse(tbCountClasses.Text));
        }

        private void DateRecord_ValueChanged(object sender, EventArgs e)
        {
            recordGroup.Group = cbGroups.Text;
            if (recordGroup.CheckDate() == new DateTime(1000, 1, 1))
            {
                MessageBox.Show("Вы не можете записаться раньше чем была создана группа.",
                               "Внимание",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                DateRecord.Value = DateTime.Now;
                return;
            }
        }

    }
}
