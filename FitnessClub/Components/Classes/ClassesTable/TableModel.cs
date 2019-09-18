using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Components.Classes.ClassesTable
{
    abstract class TableModel
    {
        public TableModel()
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
        protected TableModel(DataGridView dataGridView)
        {
            DataGridView = dataGridView;

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

        protected DataGridView DataGridView { get; set; }
        protected MySqlConnection Connection { get; set; }

        public abstract void AddRow();

        public abstract void DeleteRow();

        public abstract void ShowTable();
    }
}
