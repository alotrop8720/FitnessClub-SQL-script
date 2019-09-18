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
    public partial class GroupAdd : Form
    {
        Control[] controls;
        Control[][] arrControl;
        GroupTable groupTable;
        Dictionary<int, string> days = new Dictionary<int, string>
        {
            [0] = "Понедельник",
            [1] = "Вторник",
            [2] = "Среда",
            [3] = "Четверг",
            [4] = "Пятница",
            [5] = "Суббота"
        };
        
        

        public GroupAdd()
        {
            InitializeComponent();

            arrControl = new Control[3][];
            arrControl[0] = new Control[0];
            arrControl[1] = new Control[0];
            arrControl[2] = new Control[0];

            controls = new Control[] { tbNumberGroup, cbWorker, cbService, tbMaxPeople, tbRoom };
            groupTable = new GroupTable();

            cbService.TextChanged += ClearTime;
            tbRoom.TextChanged += ClearTime;
            DateFinish.TextChanged += ClearTime;
        }
        

        private void tbCountTime_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                if (controls[i].Text == String.Empty)
                {
                    MessageBox.Show("Заполните поля",
                               "Внимание",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    return;
                }
            }
            for (int i = 0; i < arrControl.Length; i++)
            {
               ClearForm(arrControl[i]);                    
            }
            
            if (tbCountTime.Text == String.Empty)
            {
                return;
            }
            ValidationDate();
            try
            {           
                if (Int32.Parse(tbCountTime.Text) <= 0 | Int32.Parse(tbCountTime.Text) > 6)
                {
                    MessageBox.Show("В неделе всего шесть рабочих дней! Введите количество дней когда будет заниматся эта группа.",
                                    "Внимание",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < arrControl.Length; i++)
                {
                    Array.Resize(ref arrControl[i], Int32.Parse(tbCountTime.Text));
                }

                int shift = 331;
                for (int i = 0; i < Int32.Parse(tbCountTime.Text); i++)
                {
                   arrControl[0][i] = new ComboBox();
                   arrControl[0][i].Parent = this;
                   arrControl[0][i].Location = new Point(170, shift);
                   arrControl[0][i].Size = new Size(121, 29);
                   arrControl[0][i].Tag = i+"1"; 
                   (arrControl[0][i] as ComboBox).DropDown += SelectComboBox;
                   (arrControl[0][i] as ComboBox).Font = new Font("Microsoft Tai Le", 12);                    

                   arrControl[1][i] = new ComboBox();
                   arrControl[1][i].Parent = this;
                   arrControl[1][i].Location = new Point(300, shift);
                   arrControl[1][i].Size = new Size(150, 29);
                   arrControl[1][i].Tag = i + "2";
                   (arrControl[1][i] as ComboBox).DropDown += CheckItemsComboBox;
                   (arrControl[1][i] as ComboBox).Click += ClearNeigbhour;
                   (arrControl[1][i] as ComboBox).Font = new Font("Microsoft YaHei", 12);               

                   arrControl[2][i] = new Label();
                   arrControl[2][i].Parent = this;
                   arrControl[2][i].Text = "Время/день:";
                   arrControl[2][i].Location = new Point(50, shift+3);
                   arrControl[2][i].Size = new Size(123, 31);
                   arrControl[2][i].Font = new Font("Microsoft Tai Le", 12);
                   shift += 53;

                    bttAdd.Location = new Point(bttAdd.Location.X, bttAdd.Location.Y + 50);
                    bttCancel.Location = new Point(bttCancel.Location.X, bttCancel.Location.Y + 50);
                    Height += 45;
                }
            }
            catch (Exception)
            {
                return;
            }

        }
        private void ClearForm(Control[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Dispose();
            }
            bttAdd.Location = new Point(79,334);
            bttCancel.Location = new Point(255,334);
            Height = 452;
        }
        private void ValidationDate()
        {
            if ((tbCountTime.Text != String.Empty) &&(DateFinish.Value - DateStart.Value).Days < Int32.Parse(tbCountTime.Text))
            {
                MessageBox.Show("Вы не можете задать количество дней больше чем в промежутке существования группы или столько же",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                tbCountTime.Text = "";
                return;
            }
        }
        private void DateFinish_ValueChanged(object sender, EventArgs e)
        {            
            ValidationDate();
            if ((DateFinish.Value - DateStart.Value).Days <= 0)
            {
                MessageBox.Show("Дата конца существования группы не может быть раньше дыты создания или заканчиватся в тот же день",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                DateFinish.Value = DateStart.Value.AddDays(1);
                return;
            }
            if (DateStart.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("В воскресение нет занятий",
                               "Внимание",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                DateStart.Value.AddDays(1);
                DateFinish.Value.AddDays(2);
                tbCountTime.Text = "";
                return;
            }
            tbCountTime.Text = "";
        }

        private void CheckItemsComboBox(object sender, EventArgs e)
        {
            List<string> dayWeek = new List<string>();

            int[] emptyList = new int[0];
            for (int i = (int)DateStart.Value.DayOfWeek; i < (int)DateFinish.Value.DayOfWeek; i++)
            {
                Array.Resize(ref emptyList, emptyList.Length+1);
                var t =((DayOfWeek)i);
                emptyList[emptyList.Length - 1] = (int)t;
            }
            for (int i = 0; i < emptyList.Length; i++)
            {
                dayWeek.Add(days[emptyList[i]]);
            }

            if (emptyList.Length == 0 || DateStart.Value.Month != DateFinish.Value.Month || (DateFinish.Value - DateStart.Value).Days > 6)
                dayWeek = new List<string> { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };

            for (int i = 0; i < arrControl[1].Length; i++)
            {
                dayWeek.RemoveAll(x => x == (arrControl[1][i] as ComboBox).Text);
            }

            (sender as ComboBox).Items.Clear();
            (sender as ComboBox).Items.AddRange(dayWeek.ToArray());
        }
        private void SelectComboBox(object sender, EventArgs e)
        {
            groupTable.DateStart = DateStart.Value;
            groupTable.DateFinish = DateFinish.Value;
            groupTable.Service = cbService.Text;
            ComboBox cb = new ComboBox();
            for (int i = 0; i < arrControl[1].Length; i++)
            {
                if ((arrControl[1][i] as ComboBox)?.Tag?.ToString()[0] == (sender as ComboBox).Tag?.ToString()[0])
                {
                    cb = (arrControl[1][i] as ComboBox);
                    break;
                }
            }

            if (cb.Text == string.Empty)
            {
                MessageBox.Show("Вберите сначала день недели!",
                              "Внимание",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);        
                return;
            }
            (sender as ComboBox).Items.Clear();
            groupTable.SelectComboBox((sender as ComboBox), tbRoom.Text, cb.Text);
        }
        private void ClearTime(object sender, EventArgs e)
        {
            for (int i = 0; i < arrControl[0].Length; i++)
            {
                (arrControl[0][i] as ComboBox).Text = "";
            }
        }
        private void ClearNeigbhour(object sender, EventArgs e)
        {
            for (int i = 0; i < arrControl[0].Length; i++)
            {
                if ((arrControl[0][i] as ComboBox)?.Tag?.ToString()[0] == (sender as ComboBox).Tag?.ToString()[0])
                {
                    (arrControl[0][i] as ComboBox).Text = "";
                    break;
                }
            }
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            DateFinish.Value = DateStart.Value.AddDays(1);
        }

        private void cbService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void tbMaxPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) | (e.KeyChar == (char)Keys.Back)))
                return;
            else
                e.Handled = true;
        }
        private void bttAddService_Click(object sender, EventArgs e)
        {
            ServiceAdd addService = new ServiceAdd();
            addService.Show();
        }
        private void bttAddCustomer_Click(object sender, EventArgs e)
        {
            WorkerAdd addCustome = new WorkerAdd();
            addCustome.Show();
        }

        
        private void bttAdd_Click(object sender, EventArgs e)
        {
            if (tbCountTime.Text == String.Empty)
            {
                MessageBox.Show("Заполните поля",
                              "Внимание",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                tbCountTime.Text = "";
                return;
            }
            groupTable.NumberGroup = tbNumberGroup.Text;
            if (groupTable.CheckSimilarName())
            {
                MessageBox.Show("Группа с таким названием существует",
                                 "Внимание",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                tbCountTime.Text = "";
                return;
            }

            groupTable.DateFinish = DateFinish.Value;
            groupTable.DateStart = DateStart.Value;           
            groupTable.MaxPeopleGroup = int.Parse(tbMaxPeople.Text);
            groupTable.Service = cbService.Text;
            groupTable.Worker = cbWorker.Text;
            groupTable.AddRow();

            for (int i = 0; i < arrControl[0].Length; i++)
            {
                TimetableTable timetable = new TimetableTable();
                timetable.NumberGroup = tbNumberGroup.Text;
                timetable.Room = tbRoom.Text;
                timetable.TimeStart = int.Parse($"{(arrControl[0][i] as ComboBox).Text[0]}{(arrControl[0][i] as ComboBox).Text[1]}");
                timetable.DayWeek = (arrControl[1][i] as ComboBox).Text;
                timetable.AddRow();
            }
            this.Close();
        }

        private void cbService_DropDown(object sender, EventArgs e)
        {
            cbService.Items.Clear();
            groupTable.SelectService(cbService);
        }

        private void cbCustomer_DropDown(object sender, EventArgs e)
        {
            cbWorker.Items.Clear();
            groupTable.SelectWorker(cbWorker);
        }

        private void tbRoom_DropDown(object sender, EventArgs e)
        {
            tbCountTime.Text = "";
        }

        private void cbService_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bttCancel_Click(object sender, EventArgs e)
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
