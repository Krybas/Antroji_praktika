using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Destytojo_lentele : Form
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public Destytojo_lentele()
        {
            InitializeComponent();
            LoadDataView();
        }

        private void Destytojo_lentele_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadDataView()
        {
            try
            {
                dbConnection.OpenConnection();

                string query = "SELECT * FROM destytojas";
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            priskirti_dalyka_destytojui frm = new priskirti_dalyka_destytojui();
            frm.ShowDialog();
        }
    }
}