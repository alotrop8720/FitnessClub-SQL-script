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
    class WorkerTable: TableModel
    {
        public string NameWorker { get; set; }
        public string Phone { get; set; }
        public int Experience { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }

        public WorkerTable(DataGridView dataGridView) : base(dataGridView)
        {
            DataGridView = dataGridView;
        }

        public WorkerTable(string nameWorker, string phone, int experience,
            DateTime birthday, string sex, string address)
        {
            NameWorker = nameWorker;
            Phone = phone;
            Experience = experience;
            Birthday = birthday;
            Sex = sex;
            Address = address;
        }

        public override void AddRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call AddWorker('{NameWorker}','{Phone}',{Experience}," +
                                  $"'{Birthday.Year}.{Birthday.Month}.{Birthday.Day}','{Sex}','{Address}')";
            command.ExecuteNonQuery();
        }

        public override void DeleteRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call DeleteWorker('{NameWorker}')";
            command.ExecuteNonQuery();
        }

        public override void ShowTable()
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеТренера", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }

        public void ShowFilterTable(string text)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеТренера where ФИО Like '{text}%'", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }
    }
}
