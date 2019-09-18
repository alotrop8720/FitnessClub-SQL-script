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
    public partial class BuyClasses : Form
    {
        RecordGroupTable recordGroup;
        public BuyClasses()
        {
            InitializeComponent();
            recordGroup = new RecordGroupTable();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (tbCount.Text != string.Empty)
            {
                recordGroup.Group = labelGroup.Text;
                recordGroup.Customer = labelName.Text;
                recordGroup.UpdateCountPrice(int.Parse(tbCount.Text));
            }
            this.Close();
        }

        private void tbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || Keys.Back == (Keys)e.KeyChar)
                return;
            else
                e.Handled = true;
        }
    }
}
