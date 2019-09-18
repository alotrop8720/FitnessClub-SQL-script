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
    class GroupTable : TableModel
    {
        public GroupTable(DataGridView dataGridView) : base(dataGridView)
        {
            DataGridView = dataGridView;
        }
        public GroupTable()
        {

        }

        public string NumberGroup { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public int MaxPeopleGroup { get; set; }
        public string Worker { get; set; }
        public string Service { get; set; }

        public bool CheckSimilarName()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"select count(НомерГруппы) from Группы where НомерГруппы = '{NumberGroup}'";
            if (Int32.Parse(command.ExecuteScalar().ToString()) == 0)
            {
                return false;
            }
            return true;
        }

        public void SelectService(ComboBox container)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select НазваниеУслуги from Услуги", Connection);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                container.Items.Add(table.Rows[i].ItemArray[0].ToString());
            }
        }
        public void SelectWorker(ComboBox container)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select ФИО from Тренера", Connection);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                container.Items.Add(table.Rows[i].ItemArray[0].ToString());
            }
        }
    
        public void SelectComboBox(ComboBox container, string room, string dayWeek)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Расписание.ВремяНачала, Услуги.ДлительностьЗанятия  from Расписание" +
                                                $" inner join Группы on Группы.НомерГруппы = Расписание.НомерГруппы" +
                                                $" inner join Услуги on Услуги.IDУслуги = Группы.IDУслуги" +
                                                $" where((Расписание.Зал = '{room}') and" +
                                                $" (Расписание.ДеньНедели = '{dayWeek}') and" +
                                                $" (Группы.ДатаКонца >= '{DateStart.Year}.{DateStart.Month}.{DateStart.Day}'))", Connection);
          
            adapter.Fill(table);



            Tuple<int, bool>[] time = new Tuple<int, bool>[16];
            int j = 0;
            for (int i = 9; i <= 24; i++)
            {
                time[j] = new Tuple<int, bool> (i,true);
                j++;
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (j = 0; j < time.Length; j++)
                {
                    if (time[j].Item1.ToString() == table.Rows[i].ItemArray[0].ToString())
                    {
                        for (int k = 0; k < int.Parse(table.Rows[i].ItemArray[1].ToString()); k++)
                        {
                            time[j+k] = new Tuple<int, bool>(time[j+k].Item1, false);
                        }
                    }
                }
            }

            var command = Connection.CreateCommand();            
            command.CommandText = $"select ДлительностьЗанятия from Услуги where НазваниеУслуги = '{Service}'";
            int duration = Int32.Parse(command.ExecuteScalar().ToString());
            for (int i = 0; i < time.Length - duration; i++)
            {
                if (time[i].Item2)
                {
                    for (j = 0; j < duration; j++)
                    {
                        if (!time[i+j].Item2)
                        {
                            time[i] = new Tuple<int, bool>(time[i].Item1, false);
                        }
                    }
                }                
            }

            for (int i = 0; i < duration; i++)
            {
                time[(time.Length-1)-i] = new Tuple<int, bool>(time[(time.Length - 1) - i].Item1, false);
            }

            for (int i = 0; i < time.Length; i++)
            {
                if (time[i].Item2)
                {
                    container.Items.Add(time[i].Item1+":00");
                }
            }
        }

        public override void AddRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call AddGroup('{NumberGroup}'," +
                                                $"'{MaxPeopleGroup}'," +
                                                $"'{DateStart.Year}.{DateStart.Month}.{DateStart.Day}'," +
                                                $"'{DateFinish.Year}.{DateFinish.Month}.{DateFinish.Day}'," +
                                                $"'{Worker}','{Service}')";
            command.ExecuteNonQuery();
        }

        public override void DeleteRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call DeleteGroup('{NumberGroup}')";
            command.ExecuteNonQuery();
        }

        public override void ShowTable()
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеГруппы", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }

        public void ShowFilterTable(string text)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеГруппы where № Like '{text}%'", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }
    }
}
