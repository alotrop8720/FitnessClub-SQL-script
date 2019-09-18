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
    class RecordGroupTable : TableModel
    {
        public string Group { get; set; }
        public string Customer { get; set; }
        public DateTime DateRecord { get; set; }
        public int CountClasses { get; set; }

        public RecordGroupTable()
        {
                
        }
        public RecordGroupTable(DataGridView dataGridView) : base(dataGridView)
        {
            DataGridView = dataGridView;
        }

        public bool CheckSimilarGroup()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call CheckRecords('{Group}','{Customer}')";
            if (Int32.Parse(command.ExecuteScalar().ToString()) == 0)
            {
                return false;
            }
            return true;
        }
        public void SelectGroup(ComboBox container)
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"select НомерГруппы from Группы";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    container.Items.Add(reader[0]);
                }
            }
        }
        public void SelectCustomer(ComboBox container)
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"select ФИО from Посетители";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    container.Items.Add(reader[0]);
                }
            }
        }

        public void UpdateCountPrice(int countClasses)
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call UpdateCountPrice('{countClasses}','{Group}','{Customer}')";
            command.ExecuteNonQuery();
        }

        public override void AddRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call AddRecordGroup('{DateRecord.Year}.{DateRecord.Month}.{DateRecord.Day}'," +
                                                $"'{CountClasses}'," +
                                                $"'{Group}','{Customer}')";
            command.ExecuteNonQuery();
        }

        public override void DeleteRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call DeleteRecordGroup('{Group}','{Customer}')";
            command.ExecuteNonQuery();
        }

        public override void ShowTable()
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеЗаписьГруппы", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }

        public void ShowFilterTable(string text)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеЗаписьГруппы where ФИО Like '{text}%'", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }

        public DateTime CheckDate()
        {
            var adapter = new MySqlDataAdapter($"select ДатаНачала from Группы where НомерГруппы = '{Group}'", Connection);
            var table = new DataTable();
            adapter.Fill(table);
            if (DateTime.Parse(table.Rows[0].ItemArray[0].ToString()) < DateRecord)
            {
                return DateTime.Parse(table.Rows[0].ItemArray[0].ToString());
            }
            return new DateTime(1000,1,1);
        }
    }
}
