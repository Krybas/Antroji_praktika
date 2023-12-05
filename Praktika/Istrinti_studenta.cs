using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace Praktika
{
    public partial class Istrinti_studenta : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public Istrinti_studenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valid();
            this.Close();
        }

        private void valid()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Iveskite studento ID");
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
                string delete = "DELETE FROM studentas WHERE idStudentas=@idStudentas";
                MySqlCommand cmd = new MySqlCommand(delete, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@idStudentas", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sėkmingai ištrintas studentas");
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

        private void Istrinti_studenta_Load(object sender, EventArgs e)
        {

        }
    }
}