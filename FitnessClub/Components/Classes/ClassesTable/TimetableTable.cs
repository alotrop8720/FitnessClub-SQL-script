using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Components.Classes.ClassesTable
{
    class TimetableTable : TableModel
    {
        public int TimeStart { get; set; }
        public string Room { get; set; }
        public string DayWeek { get; set; }
        public string NumberGroup { get; set; }

        public DateTime DateDay { get; set; }

        public TimetableTable()
        {
                
        }
        public TimetableTable(DataGridView dataGridView) : base(dataGridView)
        {
            DataGridView = dataGridView;
        }        

        public override void AddRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call AddTimeTable('{TimeStart}'," +
                                                $"'{Room}'," +
                                                $"'{DayWeek}'," +
                                                $"'{NumberGroup}')";
            command.ExecuteNonQuery();
        }

        public override void DeleteRow()
        {
            throw new NotImplementedException();
        }

        

        public override void ShowTable()
        {
            DataGridView.Rows.Clear();

            DateTime startWeek = StartOfWeek();
            DateTime finishWeek = startWeek.AddDays(6);


            var adapter = new MySqlDataAdapter($"select Расписание.ВремяНачала, Услуги.ДлительностьЗанятия, Расписание.ДеньНедели," +
                                    $"Группы.НомерГруппы, Тренера.ФИО from Расписание" +
                                    $" inner join Группы on Группы.НомерГруппы = Расписание.НомерГруппы" +
                                    $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                    $" inner join Услуги on Услуги.IDУслуги = Группы.IDУслуги" +
                                    $" where((Расписание.Зал = '{Room}') and" +
                                    $" (Группы.ДатаНачала <= '{DateDay.Year}.{DateDay.Month}.{DateDay.Day}') and" +
                                    $" (Группы.ДатаКонца >= '{DateDay.Year}.{DateDay.Month}.{DateDay.Day}'))", Connection);

            var table = new DataTable();
            adapter.Fill(table);
            Tuple<int, bool, string, string>[][] time = CreateTuple(table);
        }
        private Tuple<int, bool, string, string>[][] CreateTuple(DataTable table)
        {
            Tuple<int, bool, string, string>[][] time = new Tuple<int, bool, string, string>[6][];
            for (int i = 0; i < time.Length; i++)
            {
                time[i] = FillInTime(time[i]);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i].ItemArray[2].ToString() == "Понедельник")
                {
                    time[0] = FillFreel(time[0], table.Rows[i].ItemArray[0].ToString(), int.Parse(table.Rows[i].ItemArray[1].ToString()),
                                        table.Rows[i].ItemArray[3].ToString(), table.Rows[i].ItemArray[4].ToString());
                }
                if (table.Rows[i].ItemArray[2].ToString() == "Вторник")
                {
                    time[1] = FillFreel(time[1], table.Rows[i].ItemArray[0].ToString(), int.Parse(table.Rows[i].ItemArray[1].ToString()),
                        table.Rows[i].ItemArray[3].ToString(), table.Rows[i].ItemArray[4].ToString());
                }
                if (table.Rows[i].ItemArray[2].ToString() == "Среда")
                {
                    time[2] = FillFreel(time[2], table.Rows[i].ItemArray[0].ToString(), int.Parse(table.Rows[i].ItemArray[1].ToString()),
                              table.Rows[i].ItemArray[3].ToString(), table.Rows[i].ItemArray[4].ToString());
                }
                if (table.Rows[i].ItemArray[2].ToString() == "Четверг")
                {
                    time[3] = FillFreel(time[3], table.Rows[i].ItemArray[0].ToString(), int.Parse(table.Rows[i].ItemArray[1].ToString()),
                              table.Rows[i].ItemArray[3].ToString(), table.Rows[i].ItemArray[4].ToString());
                }
                if (table.Rows[i].ItemArray[2].ToString() == "Пятница")
                {
                    time[4] = FillFreel(time[4], table.Rows[i].ItemArray[0].ToString(), int.Parse(table.Rows[i].ItemArray[1].ToString()),
                              table.Rows[i].ItemArray[3].ToString(), table.Rows[i].ItemArray[4].ToString());
                }
                if (table.Rows[i].ItemArray[2].ToString() == "Суббота")
                {
                    time[5] = FillFreel(time[5], table.Rows[i].ItemArray[0].ToString(), int.Parse(table.Rows[i].ItemArray[1].ToString()),
                              table.Rows[i].ItemArray[3].ToString(), table.Rows[i].ItemArray[4].ToString());
                }
            }

            DataGridView.Rows.Add(15);
            for (int i = 0; i < DataGridView.RowCount; i++)
            {
                DataGridView.Rows[i].Cells[0].Value = $"{i + 9}:00";
            }

            for (int i = 0; i < time.Length; i++)
            {
                for (int j = 0; j < time[i].Length; j++)
                {
                    if (!time[i][j].Item2)
                    {
                        DataGridView.Rows[j].Cells[i + 1].Style.BackColor = Color.FromArgb(240, 121, 108);
                    }
                    DataGridView.Rows[j].Cells[i + 1].Value = FormatTimetable(time[i][j]);
                }
            }
            return time;
        }
        private string FormatTimetable(Tuple<int, bool, string, string> tuple)
        {
            if (tuple.Item3 == string.Empty)
            {
                return "";
            }

            var name = tuple.Item4;
            string nameResult = "";
            nameResult = nameResult.Insert(nameResult.Length, $"{name.Split(' ').ToArray()[1]} " +
                                            $"{name.Split(' ').ToArray()[0][0]}. " +
                                            $"{name.Split(' ').ToArray()[2][0]}.");
            return $"{tuple.Item3} \n {nameResult}";
        }
        private Tuple<int, bool, string, string>[] FillInTime(Tuple<int, bool, string, string>[] tuples)
        {
            int index = 0;
            tuples = new Tuple<int, bool, string, string>[16];

            for (int j = 9; j <= 24; j++)
            {
                tuples[index] = new Tuple<int, bool, string, string>(j,true,"","");
                index++;
            }
            return tuples;
        }
        private Tuple<int, bool, string, string>[] FillFreel(Tuple<int, bool, string, string>[] tuples, string timeStart, int countHour, string group, string worker)
        {
            for (int k = 0; k < tuples.Length; k++)
            {
                if (tuples[k].Item1.ToString() == timeStart)
                {
                    tuples[k] = new Tuple<int, bool, string, string>(tuples[k].Item1, false, group, worker);
                    for (int j = 1; j < countHour; j++)
                    {
                        tuples[k+j] = new Tuple<int, bool, string, string>(tuples[k+j].Item1, false, "", "");                        
                    }
                    
                }
            }
            return tuples;
        }

        private DateTime StartOfWeek()
        {
            int diff = (7 + (DateDay.DayOfWeek - DayOfWeek.Monday)) % 7;
            return DateDay.AddDays(-1 * diff).Date;
        }
    }
}
