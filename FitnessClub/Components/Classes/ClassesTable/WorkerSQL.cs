using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FitnessClub.Components.Classes.ClassesTable
{
    class WorkerSQL
    {
        public MySqlConnection Connection { get; set; }
        public string olbWorker { get; set; }
        public string Group { get; set; }
        public DateTime DateVisit { get; set; }

        public WorkerSQL()
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

        public void FillComboBoxGroup(ComboBox container)
        {
            
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы from Группы  " +
                                               $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                               $" where (Тренера.ФИО = '{olbWorker}')", Connection);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                container.Items.Add(table.Rows[i].ItemArray[0]);
            }
        }

        public void AllGroup(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы, Группы.ДатаНачала from Группы  " +
                                               $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                               $" where (Тренера.ФИО = '{olbWorker}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void AllCustomer(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Посетители.ФИО, Посетители.ДатаРождения, Посетители.НомерТелефона from Группы  " +
                                               $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                               $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" where (Тренера.ФИО = '{olbWorker}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void AllCustomerGroup(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Посетители.ФИО, Посетители.ДатаРождения, Посетители.НомерТелефона from Группы  " +
                                               $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                               $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" where (Тренера.ФИО = '{olbWorker}')" +
                                               $" and (Группы.НомерГруппы = '{Group}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void AllVisit(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы, Посетители.ФИО, Посещения.ДатаПосещения from Группы  " +
                                               $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                               $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" inner join Посещения on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                               $" where (Тренера.ФИО = '{olbWorker}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void AllVisitDate(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы, Посетители.ФИО from Группы  " +
                                               $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                               $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" inner join Посещения on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                               $" where (Тренера.ФИО = '{olbWorker}')" +
                                               $" and (Посещения.ДатаПосещения = '{DateVisit.Year}.{DateVisit.Month}.{DateVisit.Day}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void AllVisitDateGroup(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы, Посетители.ФИО from Группы  " +
                                               $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                               $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" inner join Посещения on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                               $" where (Тренера.ФИО = '{olbWorker}')" +
                                               $" and (Группы.НомерГруппы = '{Group}')" +
                                               $" and (Посещения.ДатаПосещения = '{DateVisit.Year}.{DateVisit.Month}.{DateVisit.Day}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }

        public void AllVisitGroup(DataGridView dataGridView)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select Группы.НомерГруппы, Посетители.ФИО, Посещения.ДатаПосещения from Группы  " +
                                               $" inner join Тренера on Тренера.IDТренера = Группы.IDТренера " +
                                               $" inner join ЗаписьГруппы on Группы.НомерГруппы = ЗаписьГруппы.НомерГруппы " +
                                               $" inner join Посетители on Посетители.IDПосетителя = ЗаписьГруппы.IDПосетителя " +
                                               $" inner join Посещения on Посещения.НомерЗаписи = ЗаписьГруппы.НомерЗаписи " +
                                               $" where (Тренера.ФИО = '{olbWorker}')" +
                                               $" and (Группы.НомерГруппы = '{Group}')", Connection);
            adapter.Fill(table);
            dataGridView.DataSource = table.DefaultView;
        }
    }
}
