using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Praktika
{
    public partial class istrinti_dalyka : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public istrinti_dalyka()
        {
            InitializeComponent();
        }

        private void istrinti_dalyka_Load(object sender, EventArgs e)
        {

        }

        private void buttonIstrinti_Click(object sender, EventArgs e)
        {
            valid();
            this.Close();
        }

        private void valid()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Iveskite dalyko ID");
            }
            else
            {
                istrinti();
            }
        }

        private void istrinti()
        {
            try
            {
                dbConnection.OpenConnection();
                string deleteQuery = "DELETE FROM dalykas WHERE idDalykas=@idDalykas";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@idDalykas", int.Parse(textBox1.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sėkmingai ištrintas dalykas");
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