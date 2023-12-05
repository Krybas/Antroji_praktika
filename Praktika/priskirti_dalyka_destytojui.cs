using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Praktika
{
    public partial class priskirti_dalyka_destytojui : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();
        public priskirti_dalyka_destytojui()
        {
            InitializeComponent();
            load_data_view();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void load_data_view()
        {
            dbConnection.OpenConnection();
            string createTable = "SELECT * FROM priskirtas_dalykas";
            MySqlCommand cmd = new MySqlCommand(createTable, dbConnection.GetConnection());
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void prideti_dest_Click(object sender, EventArgs e)
        {
            validDD();
            load_data_view();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            istrinti();
            load_data_view();
        }

        private void validDD()
        {
            if (txtPDID.Text == "")
                MessageBox.Show("Iveskite priskirto dalyko ID");
            else if (txtDID.Text == "")
                MessageBox.Show("Iveskite destytojo ID");
            else if (txtGID.Text == "")
                MessageBox.Show("Iveskite grupes ID");
            else if (txtDDID.Text == "")
                MessageBox.Show("Iveskite dalyko ID");
            else prideti();
        }

        private void priskirti_dalyka_destytojui_Load(object sender, EventArgs e)
        {
            Get_id();
        }

        private void Get_id()
        {
            {
                string PdID;
                string studQuery = "SELECT idPriskirtas_dalykas FROM priskirtas_dalykas ORDER BY idPriskirtas_dalykas desc;";
                dbConnection.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(studQuery, dbConnection.GetConnection());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int i = int.Parse(dr[0].ToString()) + 1;
                    PdID = i.ToString("0");
                }
                else if (Convert.IsDBNull(dr))
                {
                    PdID = ("1");
                }
                else
                {
                    PdID = ("1");
                }
                dbConnection.CloseConnection();
                string v = PdID.ToString();
                txtPDID.Text = v;
            }
        }
        private void prideti()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    dbConnection.OpenConnection();

                    cmd.Connection = dbConnection.GetConnection();
                    cmd.CommandText = "INSERT INTO priskirtas_dalykas (idPriskirtas_dalykas, idDestytojas, idGrupe, idDalykas) VALUES (@idPriskirtas_dalykas, @idDestytojas, @idGrupe, @idDalykas);";
                    cmd.Parameters.AddWithValue("@idPriskirtas_dalykas", txtPDID.Text);
                    cmd.Parameters.AddWithValue("@idDestytojas", txtDID.Text);
                    cmd.Parameters.AddWithValue("@idGrupe", txtGID.Text);
                    cmd.Parameters.AddWithValue("@idDalykas", txtDDID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sėkmingai pridėtas priskirtas dalykas");
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
        }
        private void istrinti()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    dbConnection.OpenConnection();

                    cmd.Connection = dbConnection.GetConnection();
                    cmd.CommandText = "DELETE FROM priskirtas_dalykas WHERE idPriskirtas_dalykas=@idPriskirtas_dalykas";
                    cmd.Parameters.AddWithValue("@idPriskirtas_dalykas", int.Parse(textBox1.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sėkmingai ištrintas priskirtas dalykas");
                    }
                    else
                    {
                        MessageBox.Show("Įrašas su nurodytu ID neegzistuoja");
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
        }
    }
}
