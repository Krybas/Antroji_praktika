using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Dalyko_lentele : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public Dalyko_lentele()
        {
            InitializeComponent();
            load_data_view();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void load_data_view()
        {
            try
            {
                dbConnection.OpenConnection();

                string createTable = "SELECT * FROM dalykas";
                using (MySqlCommand cmd = new MySqlCommand(createTable, dbConnection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data_view();
        }

        private void Dalyko_lentele_Load(object sender, EventArgs e)
        {

        }
    }
}