using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Grupes_lentele : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public Grupes_lentele()
        {
            InitializeComponent();
            LoadDataView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataView();
        }

        private void LoadDataView()
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "SELECT * FROM grupe";
                using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection()))
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

        private void Grupes_lentele_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}