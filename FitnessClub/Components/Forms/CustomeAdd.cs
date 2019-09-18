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


namespace FitnessClub.Forms
{
    public partial class CustomeAdd : Form
    {
        Control[] controls;
        CustomerTable classTableCustomer;
        public CustomeAdd()
        {
            InitializeComponent();
            controls = new Control[3] { tbName, tbSecondName, tbThirdName };
            classTableCustomer = new CustomerTable();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | (Char.IsPunctuation(e.KeyChar)))
                e.Handled = true; 
            else
                return;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                if (controls[i].Text == String.Empty){
                    MessageBox.Show("Заполните поля",
                               "Внимание",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите сохранить клиента? В последстивии вы сможете изменить только фамилию и телефон.",
                                "Внимание",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            classTableCustomer.NameCustomer = tbName.Text+ " " + tbSecondName.Text + " " + tbThirdName.Text;
            classTableCustomer.Birthday = DateBirthday.Value;
            classTableCustomer.Sex = rbFemale.Checked ? rbFemale.Text : rbMale.Text;
            classTableCustomer.Phone = tbPhone.Text;
            classTableCustomer.AddRow();
            this.Close();
        }

        private void bttCanсel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что не хотите сохранить эту запись?",
                                "Внимание",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}
