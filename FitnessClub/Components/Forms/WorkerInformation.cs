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
    public partial class WorkerInformation : Form
    {
        public string oldWorker;
        public DateTime lastDate;
        WorkerSQL workerSQL;

        public WorkerInformation()
        {
            InitializeComponent();
            workerSQL = new WorkerSQL();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( char.IsDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Back )
                return;
            else
                e.Handled = true;
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            workerSQL.olbWorker = oldWorker;
            workerSQL.AllCustomer(GridViewSelect);
        }

        private void rbGroup_CheckedChanged(object sender, EventArgs e)
        {
                workerSQL.olbWorker = oldWorker;
                workerSQL.AllGroup(GridViewSelect);
        }

        private void WorkerInformation_Activated(object sender, EventArgs e)
        {
            workerSQL.olbWorker = oldWorker;
            workerSQL.FillComboBoxGroup(cbGroup);
            workerSQL.FillComboBoxGroup(cbGroupVisit);
        }

        private void cbChoseGroup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbChoseGroup.Checked)
                {
                    workerSQL.Group = cbGroup.Text;
                    workerSQL.olbWorker = oldWorker;
                    workerSQL.AllCustomerGroup(GridViewSelect);
                }
                else
                {
                    workerSQL.olbWorker = oldWorker;
                    workerSQL.AllCustomer(GridViewSelect);
                }
            }
            catch (Exception)
            {
                return;
            }
        }



        private void chChoseDate_CheckStateChanged(object sender, EventArgs e)
        {
            if (chChoseDate.Checked && !cbChoseGroupVisit.Checked)
            {
                workerSQL.olbWorker = oldWorker;
                workerSQL.DateVisit = DateChose.Value;
                workerSQL.AllVisitDate(GridViewSelect);
            }
            else if (!chChoseDate.Checked && cbChoseGroupVisit.Checked)
            {
                workerSQL.olbWorker = oldWorker;
                workerSQL.Group = cbGroupVisit.Text;
                workerSQL.AllVisitGroup(GridViewSelect);
            }
            else if (chChoseDate.Checked && cbChoseGroupVisit.Checked)
            {
                workerSQL.DateVisit = DateChose.Value;
                workerSQL.olbWorker = oldWorker;
                workerSQL.Group = cbChoseGroup.Text;
                workerSQL.AllVisitDateGroup(GridViewSelect);
            }
            else if (!chChoseDate.Checked && !cbChoseGroupVisit.Checked)
            {
                workerSQL.olbWorker = oldWorker;
                workerSQL.AllVisit(GridViewSelect);
            }
        }

        private void GridViewSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
