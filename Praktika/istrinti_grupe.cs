using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Praktika
{
    public partial class istrinti_grupe : Form
    {

        DatabaseConnection dbConnection = new DatabaseConnection();

        public istrinti_grupe()
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
                MessageBox.Show("Iveskite grupės ID");
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
                string delete = "DELETE FROM grupe WHERE idGrupe=@idGrupe";
                MySqlCommand cmd = new MySqlCommand(delete, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@idGrupe", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sėkmingai ištrinta grupė");
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

        private void istrinti_grupe_Load(object sender, EventArgs e)
        {

        }
    }
}