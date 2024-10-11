using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDApp
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=LAB116-24\\MSSQLSERVER01;Initial Catalog=РемесленныеНавыки;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Добавление новой записи в таблицу
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Обновление выбранной записи в таблице
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Удаление выбранной записи из таблицы
        }
    }
}