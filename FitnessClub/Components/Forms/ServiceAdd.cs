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
    public partial class ServiceAdd : Form
    {
        ServiceTable classTableService;
         
        public ServiceAdd()
        {
            InitializeComponent();
        }

        private void cbHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;          
        }


        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | (Char.IsPunctuation(e.KeyChar)))
                e.Handled = true;
            else
                return;           
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) | (e.KeyChar == (char)Keys.Back)))
                return;
            else
                e.Handled = true;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == String.Empty || tbPrice.Text == String.Empty || cbHouse.Text == String.Empty)
            {
                MessageBox.Show("Заполните поля",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            classTableService = new ServiceTable(tbName.Text, Int32.Parse(cbHouse.Text), Int32.Parse(tbPrice.Text));
            if (classTableService.CheckSimilarName(tbName.Text))
            {
                MessageBox.Show("Такая услуга существует",
                               "Внимание",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите сохранить услугу?",
                                "Внимание",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            


            classTableService.AddRow();
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
