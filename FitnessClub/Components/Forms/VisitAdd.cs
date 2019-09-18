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
    public partial class VisitAdd : Form
    {
        VisitTable visitTable;
        public string Room { get; set; }
        public VisitAdd()
        {
            InitializeComponent();
            visitTable = new VisitTable(cbLustCustomer);
        }

        private void cbGroup_DropDown(object sender, EventArgs e)
        {
            cbGroup.Items.Clear();
            visitTable.SelectComboBox(cbGroup, Room);   
        }

        private void cbGroup_TextChanged(object sender, EventArgs e)
        {
            cbLustCustomer.Items.Clear();
            visitTable.Group = cbGroup.Text;
            visitTable.ShowTableCheckList();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что не хотите сохранить изменения?",
                                  "Внимание",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            visitTable.Group = cbGroup.Text;
            visitTable.AddRow();
            this.Close();
        }
    }
}
