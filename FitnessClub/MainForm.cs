using FitnessClub.Components.Classes.ClassesTable;
using FitnessClub.Components.Forms;
using FitnessClub.Forms;
using Stimulsoft.Report;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessClub
{
    public partial class MainForm : Form
    {
        WorkerTable classTableWorker;
        ServiceTable classTableService;
        CustomerTable classTableCustomer;
        GroupTable groupTable;
        TimetableTable timetable;
        VisitTable visitTable;
        RecordGroupTable recordGroup;

        public MainForm()
        {
            InitializeComponent();
            classTableWorker = new WorkerTable(GridViewWorker);
            classTableService = new ServiceTable(GridViewService);
            classTableCustomer = new CustomerTable(GridViewСustomers);
            groupTable = new GroupTable(GridViewGroups);
            visitTable = new VisitTable(GridViewVisitGroup);
            timetable = new TimetableTable(GridViewTimeTable);
            recordGroup = new RecordGroupTable(GridViewRecordGroups);
            timetable.DateDay = SelectDate.Value;
            timetable.Room = cbRoom.Text;
        }

        private void bttAddRecordGroups_Click(object sender, EventArgs e)
        {
            RecordGroupAdd addRecordGroup = new RecordGroupAdd();
            addRecordGroup.Show();
        }
        private void bttAddCustomer_Click(object sender, EventArgs e)
        {
            CustomeAdd customeForm = new CustomeAdd();
            customeForm.Show();
        }
        private void bttAddWorker_Click(object sender, EventArgs e)
        {
            WorkerAdd workerForm = new WorkerAdd();
            workerForm.Show();
        }
        private void bttAddService_Click(object sender, EventArgs e)
        {
            ServiceAdd serviceForm = new ServiceAdd();
            serviceForm.Show();
        }
        private void bttAddGroups_Click(object sender, EventArgs e)
        {
            GroupAdd groupForm = new GroupAdd();
            groupForm.Show();
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {            
            classTableWorker.ShowTable();
            classTableService.ShowTable();
            classTableCustomer.ShowTable();
            groupTable.ShowTable();
            timetable.ShowTable();
            visitTable.ShowTable();
            recordGroup.ShowTable();
        }

        private void bttDeleteWorker_Click(object sender, EventArgs e)
        {
           
            if (!ValiadtionDelete(GridViewWorker))
            {
                return;
            }
            classTableWorker.NameWorker = GridViewWorker.CurrentRow.Cells[0].Value.ToString();
            classTableWorker.DeleteRow();
            classTableWorker.ShowTable();         
            
        }
        
        private bool ValiadtionDelete(DataGridView gridView)
        {
            if (gridView.CurrentRow == null)
            {
                MessageBox.Show("Ничего не выбрано",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены что не хотите удалить эту запись?",
                                "Внимание",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                return false;
            }
            return true;
        }

        private void bttDeleteService_Click(object sender, EventArgs e)
        {
            if (!ValiadtionDelete(GridViewService))
            {
                return;
            }
            classTableService.NameService = GridViewService.CurrentRow.Cells[0].Value.ToString();
            classTableService.DeleteRow();
            classTableService.ShowTable();
        }

        private void bttDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (!ValiadtionDelete(GridViewСustomers))
            {
                return;
            }
            classTableCustomer.NameCustomer = GridViewСustomers.CurrentRow.Cells[0].Value.ToString();
            classTableCustomer.DeleteRow();
            classTableCustomer.ShowTable();
        }

        private void SelectDate_ValueChanged(object sender, EventArgs e)
        {
            timetable.DateDay = SelectDate.Value;
            timetable.Room = cbRoom.Text;
            timetable.ShowTable();
        }

        private void cbRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbRoom.Text = cbRoom.Items[0].ToString();
        }

        private void bttAddVisit_Click(object sender, EventArgs e)
        {
            VisitAdd visitAdd = new VisitAdd();
            visitAdd.Room = cbRoom.Text;
            visitAdd.ShowDialog();
        }

        private void bttDeleteVisit_Click(object sender, EventArgs e)
        {
            if (!ValiadtionDelete(GridViewVisitGroup))
            {
                return;
            }
            visitTable.DateDelete = DateTime.Parse(GridViewVisitGroup.CurrentRow.Cells[2].Value.ToString());
            visitTable.Customer = GridViewVisitGroup.CurrentRow.Cells[1].Value.ToString();
            visitTable.Group = GridViewVisitGroup.CurrentRow.Cells[0].Value.ToString();
            visitTable.DeleteRow();
            visitTable.ShowTable();
        }

        private void bttDeleteRecord_Click(object sender, EventArgs e)
        {
            if (!ValiadtionDelete(GridViewRecordGroups))
            {
                return;
            }
            recordGroup.Customer = GridViewRecordGroups.CurrentRow.Cells[1].Value.ToString();
            recordGroup.Group = GridViewRecordGroups.CurrentRow.Cells[0].Value.ToString();
            recordGroup.DeleteRow();
            recordGroup.ShowTable();
        }


        private void GridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewGroups.CurrentRow == null)
            {
                MessageBox.Show("Ничего не выбрано",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            TimeDelete timeDelete = new TimeDelete();
            timeDelete.tbGroup.Text = GridViewGroups.CurrentRow.Cells[0].Value.ToString();
            timeDelete.tbWorker.Text = GridViewGroups.CurrentRow.Cells[1].Value.ToString();
            timeDelete.tbService.Text = GridViewGroups.CurrentRow.Cells[2].Value.ToString();
            timeDelete.tbDateStart.Value =  DateTime.Parse(GridViewGroups.CurrentRow.Cells[3].Value.ToString());
            timeDelete.tbDateFinish.Value = DateTime.Parse(GridViewGroups.CurrentRow.Cells[4].Value.ToString());
            timeDelete.lastDate = DateTime.Parse(GridViewGroups.CurrentRow.Cells[4].Value.ToString());
            timeDelete.ShowDialog();
        }

        private void GridViewСustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewСustomers.CurrentRow == null)
            {
                MessageBox.Show("Ничего не выбрано",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            
            CustomerInformation information = new CustomerInformation();
            information.tbName.Text = GridViewСustomers.CurrentRow.Cells[0].Value.ToString().Split(' ')[0] + " " + GridViewСustomers.CurrentRow.Cells[0].Value.ToString().Split(' ')[2];
            information.tbThirdName.Text = GridViewСustomers.CurrentRow.Cells[0].Value.ToString().Split(' ')[1];
            information.DateBirthday.Value = DateTime.Parse(GridViewСustomers.CurrentRow.Cells[1].Value.ToString());
            information.labelSex.Text = $"({GridViewСustomers.CurrentRow.Cells[2].Value.ToString()})";
            information.tbPhone.Text = GridViewСustomers.CurrentRow.Cells[3].Value.ToString();
            information.saveDate = DateTime.Parse(GridViewСustomers.CurrentRow.Cells[1].Value.ToString());
            information.oldCustomer = GridViewСustomers.CurrentRow.Cells[0].Value.ToString();
            information.ShowDialog();
        }

        private void GridViewWorker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewWorker.CurrentRow == null)
            {
                MessageBox.Show("Ничего не выбрано",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            WorkerInformation information = new WorkerInformation();
            information.tbName.Text = GridViewWorker.CurrentRow.Cells[0].Value.ToString().Split(' ')[0] + " " + GridViewWorker.CurrentRow.Cells[0].Value.ToString().Split(' ')[2];
            information.tbSurname.Text = GridViewWorker.CurrentRow.Cells[0].Value.ToString().Split(' ')[1];
            information.tbPhone.Text = GridViewWorker.CurrentRow.Cells[1].Value.ToString();
            information.tbExperience.Text = GridViewWorker.CurrentRow.Cells[2].Value.ToString();
            information.DateBirthday.Value = DateTime.Parse(GridViewWorker.CurrentRow.Cells[3].Value.ToString());
            information.labelSex.Text = $" ({GridViewWorker.CurrentRow.Cells[4].Value.ToString()})";
            information.tbStreet.Text = GridViewWorker.CurrentRow.Cells[5].Value.ToString().Split(',')[0];
            information.tbHome.Text = GridViewWorker.CurrentRow.Cells[5].Value.ToString().Split(',')[1];
            information.tbFlat.Text = GridViewWorker.CurrentRow.Cells[5].Value.ToString().Split(',')[2];
            information.lastDate = DateTime.Parse(GridViewWorker.CurrentRow.Cells[3].Value.ToString());
            information.oldWorker = GridViewWorker.CurrentRow.Cells[0].Value.ToString();
            information.ShowDialog();
        }

        private void tbCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            classTableCustomer.ShowFilterTable(tbCustomerSearch.Text);
        }

        private void tbWorkerSearch_TextChanged(object sender, EventArgs e)
        {
            classTableWorker.ShowFilterTable(tbWorkerSearch.Text);
        }

        private void tbGroupsSearch_TextChanged(object sender, EventArgs e)
        {
            groupTable.ShowFilterTable(tbGroupsSearch.Text);
        }

        private void tbRecordGroupsSearch_TextChanged(object sender, EventArgs e)
        {
            recordGroup.ShowFilterTable(tbRecordGroupsSearch.Text);
        }

        private void tbVisitGroupSearch_TextChanged(object sender, EventArgs e)
        {
            visitTable.ShowFilterTable(tbVisitGroupSearch.Text);
        }

        private void GridViewTimeTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GridViewRecordGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewRecordGroups.CurrentRow == null)
            {
                MessageBox.Show("Ничего не выбрано",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            SQLPrise qLPrise = new SQLPrise();
            qLPrise.Group = GridViewRecordGroups.CurrentRow.Cells[0].Value.ToString();
            qLPrise.Customer = GridViewRecordGroups.CurrentRow.Cells[1].Value.ToString();
            qLPrise.DateRecord = DateTime.Parse(GridViewRecordGroups.CurrentRow.Cells[2].Value.ToString());
            BuyForm buyForm = new BuyForm(qLPrise);
            buyForm.ShowDialog();
        }

        private void bttReportVisit_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"VisitReport.mrt");
            report.Show();
        }

        private void bttGroupReport_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"GroupReport.mrt");
            report.Show();
        }

        private void bttWorkerReport_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"WorkerReport.mrt");
            report.Show();
        }
    }
}
