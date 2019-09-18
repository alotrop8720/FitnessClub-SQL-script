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
    class CustomerTable: TableModel
    {
        public string NameCustomer { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }

        public CustomerTable(DataGridView dataGridView) : base(dataGridView)
        {
        }
        public CustomerTable()
        {
                
        }

        public override void AddRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call AddCustomer('{NameCustomer}','{Birthday.Year}.{Birthday.Month}.{Birthday.Day}','{Sex}','{Phone}')";
            command.ExecuteNonQuery();
        }

        public override void DeleteRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call DeleteCustomer('{NameCustomer}')";
            command.ExecuteNonQuery();
        }

        public override void ShowTable()
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеПосетители", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }

        public void ShowFilterTable(string text)
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеПосетители where ФИО Like '{text}%'", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }
    }
}
