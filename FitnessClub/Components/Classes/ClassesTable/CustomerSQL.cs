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
    class CustomerSQL
    {

        public MySqlConnection Connection { get; set; }
        public string Customer { get; set; }

        public string oldCustomer { get; set; }
        public string Phone { get; set; }


        public DateTime DateVisit { get; set; }

        public CustomerSQL()
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

        public void GroupCustomer(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы from Группы " +
                                               $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" where (Посетители.ФИО = '{Customer}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void VisitCustomer(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы, Посещения.ДатаПосещения  from Группы " +
                                               $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" inner join Посещения on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                               $" where (Посетители.ФИО = '{Customer}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void VisitDateCustomer(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы, Посещения.ДатаПосещения  from Группы " +
                                              $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                              $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                              $" inner join Посещения on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                              $" where (Посетители.ФИО = '{Customer}')" +
                                              $" and  (Посещения.ДатаПосещения = '{DateVisit.Year}.{DateVisit.Month}.{DateVisit.Day}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void UpdateCustomer()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call UpdateCustomer('{oldCustomer}','{Customer}','{Phone}')";
            command.ExecuteNonQuery();
        }
    }
}
