using FitnessClub.Components.Classes.ClassesTable;
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
    public partial class BuyForm : Form
    {
        public Form mainForm;
        SQLPrise sqlPrise;
        public bool flagForm = false;

        public BuyForm(SQLPrise qLPrise)
        {
            InitializeComponent();
            sqlPrise = qLPrise;
            labelCountClassGroup.Text += $"   {qLPrise.CountClassesGroup()}";
            labelPriceOneClass.Text += $"   {qLPrise.PriceOneClasses()}";
            labelCountClassThisGroup.Text += $"   {qLPrise.CountClassesThisGroup()}";
            labelCountBuyAll.Text += $"   {qLPrise.CountBuyAll()}";
            labelCountBuyWillAll.Text += $"   {qLPrise.CountBuyWillAll()}";
            labelPriceWillAll.Text += $"   {qLPrise.PriceWillAll()}";
            labelGroup.Text += $"   {qLPrise.Group}";
            labelCustomer.Text += $"   {qLPrise.Customer}";
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        { 
            if (tbPrice.Text != string.Empty)
            {
                labelSum.Text = $"Сумма   {int.Parse(tbPrice.Text) * int.Parse(sqlPrise.PriceOneClasses())}";
            }
            return;
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Back)
                return;
            else
                e.Handled = true;
        }

        bool flag = false;

        private void bttSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Данные сохранятся. Вы уверенны что не хотите ничего изменить?",
                               "Внимание",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (flagForm)
            {
                (mainForm as RecordGroupAdd).tbCountClasses.Text = tbPrice.Text;
            }
            else
            {
                RecordGroupTable recordGroup = new RecordGroupTable();
                recordGroup.Group = sqlPrise.Group;
                recordGroup.Customer = sqlPrise.Customer;
                recordGroup.UpdateCountPrice(int.Parse(tbPrice.Text));
            }
            flag = true;
            this.Close();
        }

        private void BuyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Введенные данные не сохронятся. Занятия не будут считатся оплачены!",
                                "Внимание",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
