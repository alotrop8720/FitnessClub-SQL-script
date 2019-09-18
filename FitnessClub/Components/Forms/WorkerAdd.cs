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
    public partial class WorkerAdd : Form
    {
        WorkerTable classTableWorker;

        public WorkerAdd()
        {
            InitializeComponent();
        }


        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | (Char.IsPunctuation(e.KeyChar)) | (e.KeyChar == (char)Keys.Space))
                e.Handled = true;
            else
                return;
        }

        private void tbExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | (e.KeyChar == (char)Keys.Back))
                return;
            else
                e.Handled = true;            
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                MessageBox.Show("Заполните поля",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
            
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите сохранить этого сотрудника? В последстивии вы сможете изменить только фамилию, телефон и адрес.",
                                "Внимание",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            classTableWorker = new WorkerTable($"{tbName.Text} {tbSecondName.Text} {tbThirdName.Text}",
                                                       tbPhone.Text,Int32.Parse(tbExperience.Text), DateBirthday.Value, 
                                                       rbFemale.Checked? rbFemale.Text: rbMale.Text,
                                                       $"{tbStreet.Text},{tbNumberHome.Text},{tbNumberFlat.Text}");
            classTableWorker.AddRow();
            this.Close();
        }
        private bool CheckEmpty()
        { 
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i].Tag?.ToString() == "record")
                {
                    if ((Controls[i] as TextBox).Text == String.Empty)
                    {
                        return true;
                    }                    
                }
            }
            return false;
        }

        private void tbStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsPunctuation(e.KeyChar)) | (e.KeyChar == (char)Keys.Space))
                e.Handled = true;
            else
                return;
        }

        private void bttCenсel_Click(object sender, EventArgs e)
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
