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
    public class GroupSQL
    {
        public MySqlConnection Connection { get; set; }
        public string Group { get; set; }
        public string Worker { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }

        public GroupSQL()
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

        public string CountPeopleGroup()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"select count(*) from ЗаписьГруппы " +
                                    $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы" +
                                    $" where Группы.НомерГруппы = '{Group}'";
            return command.ExecuteScalar().ToString();
        }

        public string AgeGroup()
        {
            try
            {
                var adapterMin = new MySqlDataAdapter($"select min(Посетители.ДатаРождения) from Посетители " +
                                    $" inner join ЗаписьГруппы on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя" +
                                    $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы" +
                                    $" where (Группы.НомерГруппы = '{Group}')", Connection);

                var adapterMax = new MySqlDataAdapter($"select max(Посетители.ДатаРождения) from Посетители " +
                                        $" inner join ЗаписьГруппы on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя" +
                                        $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы" +
                                        $" where (Группы.НомерГруппы = '{Group}')", Connection);

                var tableMin = new DataTable();
                var tableMax = new DataTable();
                adapterMin.Fill(tableMin);
                adapterMax.Fill(tableMax);

                DateTime max = DateTime.Parse(tableMax.Rows[0].ItemArray[0].ToString());
                DateTime min = DateTime.Parse(tableMin.Rows[0].ItemArray[0].ToString());
                return (DateTime.Now.Year - min.Year) == (DateTime.Now.Year - max.Year) ? $"  ~{DateTime.Now.Year - max.Year}" : $"  {DateTime.Now.Year - min.Year} - {DateTime.Now.Year - max.Year}";
            }
            catch (Exception)
            {
                return "";
            }
            
        }

        public void SelectCustomer(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Посетители.ФИО, Посетители.ДатаРождения, Посетители.Пол, Посетители.НомерТелефона from Посетители " +
                                               $" inner join ЗаписьГруппы on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" where (Группы.НомерГруппы = '{Group}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void SelectVisit(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Посетители.ФИО, Посещения.ДатаПосещения from Посещения " +
                                               $" inner join ЗаписьГруппы on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                               $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" where (Группы.НомерГруппы = '{Group}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void SelectVisitDate(DataGridView dataGridView, DateTime date)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Посетители.ФИО, Посещения.ДатаПосещения from Посещения " +
                                               $" inner join ЗаписьГруппы on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                               $" inner join Группы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" where (Группы.НомерГруппы = '{Group}')" +
                                               $" and (Посещения.ДатаПосещения = '{date.Year}.{date.Month}.{date.Day}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public string[][] DayGroup()
        {
            var adapter = new MySqlDataAdapter($"select Расписание.ДеньНедели, Расписание.ВремяНачала from Расписание " +
                                       $" inner join Группы on Группы.НомерГруппы = Расписание.НомерГруппы" +
                                       $" where (Группы.НомерГруппы = '{Group}')", Connection);

            var table = new DataTable();
            adapter.Fill(table);

            string[][] informatin = new string[2][];
            informatin[0] = new string[table.Rows.Count];
            informatin[1] = new string[table.Rows.Count];

            for (int j = 0; j < table.Rows.Count; j++)
            {
                informatin[0][j] = table.Rows[j].ItemArray[0].ToString();
                informatin[1][j] = table.Rows[j].ItemArray[1].ToString();               
            }
            return informatin;
        }

        public void UpdateGroup()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call UpdateGroup('{DateFinish.Year}.{DateFinish.Month}.{DateFinish.Day}','{Group}')";
            command.ExecuteNonQuery();
        }
        
    }
}
