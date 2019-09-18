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
    class ServiceTable : TableModel
    {
        public string NameService { get; set; }
        public int House { get; set; }
        public int Price { get; set; }

        public ServiceTable(DataGridView dataGridView) : base(dataGridView)
        {
            DataGridView = dataGridView;
        }

        public ServiceTable(string nameService, int house, int price)
        {
            NameService = nameService;
            House = house;
            Price = price;
        }

        public bool CheckSimilarName(string name)
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"select count(НазваниеУслуги) from Услуги where НазваниеУслуги = '{name}'";
            if (Int32.Parse(command.ExecuteScalar().ToString()) == 0)
            {
                return false;
            }
            return true;
        }

        public override void AddRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call AddService('{NameService}','{House}','{Price}')";
            command.ExecuteNonQuery();
        }

        public override void DeleteRow()
        {
            var command = Connection.CreateCommand();
            command.CommandText = $"call DeleteService('{NameService}')";
            command.ExecuteNonQuery();
        }

        public override void ShowTable()
        {
            var table = new DataTable();
            var adapter = new MySqlDataAdapter($"select * from ПредставлениеУслуги", Connection);
            adapter.Fill(table);
            DataGridView.DataSource = table.DefaultView;
        }
    }
}
