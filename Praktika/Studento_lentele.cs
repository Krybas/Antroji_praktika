using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktika
{
    public partial class Studento_lentele : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();
        public Studento_lentele()
        {
            InitializeComponent();
            load_data_view();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Studento_lentele_Load(object sender, EventArgs e)
        {

        }
        public void load_data_view()
        {
            dbConnection.OpenConnection();
            string createTable = "SELECT studentas.* , grupe.Grupes_pavadinimas FROM studentas INNER JOIN grupe ON studentas.idGrupe = grupe.idGrupe";
            MySqlCommand cmd = new MySqlCommand(createTable, dbConnection.GetConnection());
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data_view();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Priskirti_dalyka_studentui frm = new Priskirti_dalyka_studentui();
            frm.ShowDialog();

        }
    }
}
