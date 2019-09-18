using FitnessClub.Components.Classes.ClassesTable;
using Stimulsoft.Report;
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
    public partial class TimeDelete : Form
    {
        Control[][] arrControl;
        public GroupSQL groupSQL;
        public DateTime lastDate;
        public TimeDelete()
        {
            InitializeComponent();
            groupSQL = new GroupSQL();
            arrControl = new Control[2][];
            

        }

        private void bttDays_Click(object sender, EventArgs e)
        {
            timerPanel.Enabled = true;
        }

        bool isVisisble = false;
        private void timerPanel_Tick(object sender, EventArgs e)
        {
            
            if (!isVisisble)
            {
                PanelDays.Top += 25;
                if (PanelDays.Top == 0)
                {
                    isVisisble = !isVisisble;
                    timerPanel.Enabled = false;
                }
            }
            else
            {
                PanelDays.Top -= 25;
                if (PanelDays.Top == -375)
                {
                    isVisisble = !isVisisble;
                    timerPanel.Enabled = false;
                }
            }
        }

        private void tbGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TimeDelete_Activated(object sender, EventArgs e)
        {
            groupSQL.Group = tbGroup.Text;
            tbCountPeople.Text = groupSQL.CountPeopleGroup();
            labelAvgAge.Text += $" {groupSQL.AgeGroup()}";
            rbCustomers.Checked = true;
            

            string[][] information = groupSQL.DayGroup();
            arrControl[0] = new Control[information[0].Length];
            arrControl[1] = new Control[information[0].Length];

            int shift = 51;
            for (int i = 0; i < information[0].Length; i++)
            {

                arrControl[0][i] = new TextBox();
                (arrControl[0][i] as TextBox).KeyPress += tbGroup_KeyPress;
                arrControl[0][i].Parent = this.PanelDays;
                arrControl[0][i].Location = new Point(133, shift);
                arrControl[0][i].Size = new Size(166, 29);
                (arrControl[0][i] as TextBox).Text = information[0][i];
                (arrControl[0][i] as TextBox).Font = new Font("Microsoft Tai Le", 12);

                arrControl[1][i] = new TextBox();
                (arrControl[1][i] as TextBox).KeyPress += tbGroup_KeyPress;
                arrControl[1][i].Parent = this.PanelDays;
                arrControl[1][i].Location = new Point(23, shift);
                arrControl[1][i].Size = new Size(102, 29);
                (arrControl[1][i] as TextBox).Text = information[1][i]+ ":00";
                (arrControl[1][i] as TextBox).Font = new Font("Microsoft Tai Le", 12);

                shift += 37;
            }
        }

        private void rbCustomers_CheckedChanged(object sender, EventArgs e)
        {
            groupSQL.Group = tbGroup.Text;
            groupSQL.SelectCustomer(GridViewSelect);
        }

        private void rbVisit_CheckedChanged(object sender, EventArgs e)
        {
            groupSQL.Group = tbGroup.Text;
            if (cbChoseDate.Checked)
            {
                groupSQL.SelectVisitDate(GridViewSelect, ChoseDate.Value);
                return; 
            }            
            groupSQL.SelectVisit(GridViewSelect);
        }

        private void cbChoseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChoseDate.Checked)
            {
                groupSQL.Group = tbGroup.Text;
                groupSQL.SelectVisitDate(GridViewSelect, ChoseDate.Value);
            }
            else
            {
                groupSQL.Group = tbGroup.Text;
                groupSQL.SelectVisit(GridViewSelect);
            }
        }

        private void tbDateStart_ValueChanged(object sender, EventArgs e)
        {
            tbDateStart.Value = new DateTime(tbDateStart.Value.Year, tbDateStart.Value.Month, tbDateStart.Value.Day);
            if (tbDateFinish.Value < lastDate)
            {
                MessageBox.Show("Вы не можете задать дату меньше чем дата последнего существования группы",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                tbDateFinish.Value = lastDate;
                return;
            }
        }

        private void TimeDelete_FormClosing(object sender, FormClosingEventArgs e)
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
            groupSQL.Group = tbGroup.Text;
            groupSQL.DateFinish = tbDateFinish.Value;
            groupSQL.UpdateGroup();
        }

        private void GridViewSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
