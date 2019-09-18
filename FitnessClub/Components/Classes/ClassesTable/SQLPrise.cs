using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Components.Classes.ClassesTable
{
    public class SQLPrise
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
        protected MySqlConnection Connection { get; set; }
        public string Group { get; set; }
        public string Customer { get; set; }
        public DateTime DateRecord { get; set; }

        public SQLPrise()
        {
            try
            {
                Connection = new MySqlConnection("database=ФитнесКлуб;server=localhost;port=3306;userid=root;password=12345678");
                Connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string CountClassesGroup()
        {
            try
            {
                var adapter = new MySqlDataAdapter($"select Группы.ДатаНачала, Группы.ДатаКонца, Расписание.ДеньНедели from Группы " +
                                    $" inner join Расписание on Группы.НомерГруппы = Расписание.НомерГруппы " +
                                    $" where Группы.НомерГруппы = '{Group}'", Connection);
                var table = new DataTable();
                adapter.Fill(table);

                DateTime finishDate = DateTime.Parse(table.Rows[0].ItemArray[1].ToString());
                DateTime startDate = DateTime.Parse(table.Rows[0].ItemArray[0].ToString());
                List<int> daysWeek = DaysList(table, 2);

                int count = 0;
                for (int i = 0; i < daysWeek.Count; i++)
                {
                    for (DateTime start = startDate; start.Equals(finishDate) != true; start = start.AddDays(1))
                    {
                        if (start.DayOfWeek == (DayOfWeek)daysWeek[i])
                            count++;
                    }
                }

                return count.ToString();
            }
            catch (Exception)
            {
                return "0";
            }
            
        }
        private List<int> DaysList(DataTable table, int index)
        {
            List<int> daysWeek = new List<int>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                daysWeek.Add(days.FirstOrDefault(x => x.Value == table.Rows[i].ItemArray[index].ToString()).Key);
            }
            return daysWeek;
        }

        public string PriceOneClasses()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"select Услуги.ЦенаЗаЗанятие from Группы " +
                                    $" inner join Услуги on Услуги.IDУслуги = Группы.IDУслуги" +
                                    $" where Группы.НомерГруппы = '{Group}'";
            return command.ExecuteScalar().ToString();
        }

        public string CountClassesThisGroup()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"select count(*) from Посещения " +
                                    $" inner join ЗаписьГруппы on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                    $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                    $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                    $" where (Посетители.ФИО = '{Customer}') " +
                                    $" and (Посещения.ДатаПосещения >= '{DateRecord.Year}.{DateRecord.Month}.{DateRecord.Day}')" +
                                    $" and (Группы.НомерГруппы = '{Group}')";

            return command.ExecuteScalar().ToString();
        }

        public string CountBuyAll()
        {
            try
            {
                var adapter = new MySqlDataAdapter($"select ЗаписьГруппы.КоличествоОплаченыхЗанятий from ЗаписьГруппы " +
                                    $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                    $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                    $" where (Посетители.ФИО = '{Customer}')" +
                                    $" and (Группы.НомерГруппы = '{Group}')", Connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table.Rows[0].ItemArray[0].ToString();
            }
            catch (Exception)
            {
                return "0";
            }
            
        }

        public string CountBuyWillAll()
        {
            try
            {
                var adapter = new MySqlDataAdapter($"select  Группы.ДатаКонца, Расписание.ДеньНедели from Группы " +
                                     $" inner join Расписание on Группы.НомерГруппы = Расписание.НомерГруппы " +
                                     $" where (Группы.НомерГруппы = '{Group}')", Connection);
                var table = new DataTable();
                adapter.Fill(table);

                DateTime finishDate = DateTime.Parse(table.Rows[0].ItemArray[0].ToString());
                DateTime startDate = new DateTime(DateRecord.Year, DateRecord.Month, DateRecord.Day);
                List<int> daysWeek = DaysList(table, 1);

                int count = 0;
                for (int i = 0; i < daysWeek.Count; i++)
                {
                    for (DateTime start = startDate; start.Equals(finishDate) != true; start = start.AddDays(1))
                    {
                        if (start.DayOfWeek == (DayOfWeek)daysWeek[i])
                            count++;
                    }
                }
                return (count - int.Parse(CountBuyAll())) < 0 ? "0" : (count - int.Parse(CountBuyAll())).ToString();
            }
            catch (Exception)
            {
                return "0";
                throw;
            }
            
        }

        public string PriceWillAll()
        {
            return (int.Parse(CountBuyWillAll()) * int.Parse(PriceOneClasses())).ToString();
        }
    }
}
   