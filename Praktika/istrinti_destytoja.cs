using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace Praktika
{
    public partial class istrinti_destytoja : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public istrinti_destytoja()
        {
            InitializeComponent();
        }

        private void buttonIstrinti_Click(object sender, EventArgs e)
        {
            valid();
            this.Close();
        }

        private void valid()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Iveskite dėstytojo ID");
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
                string delete = "DELETE FROM destytojas WHERE idDestytojas=@idDestytojas";
                MySqlCommand cmd = new MySqlCommand(delete, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@idDestytojas", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sėkmingai ištrintas destytojas");
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

        private void istrinti_destytoja_Load(object sender, EventArgs e)
        {

        }
    }
}