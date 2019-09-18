using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Components.Classes.ClassesTable
{
    class VisitTable : TableModel
    {
        Dictionary<int, string> days = new Dictionary<int, string>
        {
            [0] = "Понедельник",
            [1] = "Вторник",
            [2] = "Среда",
            [3] = "Четверг",
            [4] = "Пятница",
            [5] = "Суббота"
        };
        public CheckedListBox CheckedListBox { get; set; }
        public DateTime DateVisit { get; set; }
        public Tuple<string,bool>[] VisitList { get; set; }
        public string Group { get; set; }
        public DateTime DateDelete { get; set; }
        public string Customer { get; set; }


        public VisitTable(DataGridView dataGridView) : base(dataGridView)
        {
            DataGridView = dataGridView;
        }
        public VisitTable()
        {

        }
        public VisitTable(CheckedListBox checkedListBox)
        {
            CheckedListBox = checkedListBox;
        }

        public override void AddRow()
        {
            var command = Connection.CreateCommand();
            
            for (int j = 0; j < CheckedListBox.Items.Count; j++)
            {
                if (CheckedListBox.GetItemChecked(j) && VisitList[j].Item2 == false)
                {
                    VisitList[j] = new Tuple<string, bool>(VisitList[j].Item1, true);
                    command.CommandText = $"call AddVisitTable('{Group}','{VisitList[j].Item1}')";
                    command.ExecuteNonQuery();
                }
            }
        }

        public override void DeleteRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call DeleteAddVisitTable('{DateDelete.Year}.{DateDelete.Month}.{DateDelete.Day}','{Group}','{Customer}')";
            command.ExecuteNonQuery();
        }

        public void SelectComboBox(ComboBox container, string room)
        {
            int index = (((int)DateTime.Now.DayOfWeek) - 1) < 0 ? 0 : ((int)DateTime.Now.DayOfWeek) - 1;
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы, Расписание.ДеньНедели from Группы " +
                                                $" inner join Расписание on Группы.НомерГруппы = Расписание.НомерГруппы " +
                                                $" where (Группы.ДатаНачала <= '{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day}') and " +
                                                $" (Группы.ДатаКонца >= '{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day}') and " +
                                                $" (Расписание.Зал = '{room}')  and " +
                                                $" (Расписание.ДеньНедели = '{days[index]}')", Connection);
            var table = new DataTable();
            adapter.Fill(table);

            for (int j = 0; j < table.Rows.Count; j++)
            {
                container.Items.Add(table.Rows[j].ItemArray[0].ToString());
            }
        }

        public void ShowTableCheckList()
        {
            var adapterVisit = new MySqlDataAdapter($"select Посетители.ФИО from Посещения " +
                                                    $"inner join ЗаписьГруппы on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи" +
                                                    $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы" +
                                                    $" inner join Услуги on Услуги.IDУслуги = Группы.IDУслуги" +
                                                    $" inner  join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                                    $" where (Группы.НомерГруппы = '{Group}') and " +
                                                    $" (Посещения.ДатаПосещения = '{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day}')", Connection);

            var adapterRecord = new MySqlDataAdapter($"select Посетители.ФИО  from ЗаписьГруппы " +
                                                     $"inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                                     $"inner  join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                                     $" where Группы.НомерГруппы = '{Group}' ", Connection);

            var visitTable = new DataTable();
            var recordTable = new DataTable();
            adapterRecord.Fill(recordTable);
            adapterVisit.Fill(visitTable);

            VisitList = new Tuple<string, bool>[recordTable.Rows.Count];
            for (int i = 0; i < recordTable.Rows.Count; i++)
            {
                CheckedListBox.Items.Add(recordTable.Rows[i].ItemArray[0].ToString());
                VisitList[i] = new Tuple<string, bool>(recordTable.Rows[i].ItemArray[0].ToString(), false);
            }

            for (int j = 0; j < CheckedListBox.Items.Count; j++)
            {
                for (int i = 0; i < visitTable.Rows.Count; i++)
                {
                    if (visitTable.Rows[i].ItemArray[0].ToString() == CheckedListBox.Items[j].ToString())
                    {
                        VisitList[j] = new Tuple<string, bool>(recordTable.Rows[i].ItemArray[0].ToString(), true);
                        CheckedListBox.SetItemChecked(j, true);
                    }
                }
            }
        }

        public override void ShowTable()
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеПосещения", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }

        public void ShowFilterTable(string text)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеПосещения where ФИО Like '{text}%'", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }
    }
}
