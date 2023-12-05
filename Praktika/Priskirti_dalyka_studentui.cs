using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Priskirti_dalyka_studentui : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();
        public Priskirti_dalyka_studentui()
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

                string selectQuery = "SELECT * FROM studento_dalykas";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, dbConnection.GetConnection()))
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prideti_dest_Click(object sender, EventArgs e)
        {
            validP();
            load_data_view();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void validP()
        {
            if (txtSDID.Text == "")
                MessageBox.Show("Iveskite studento dalyko ID");
            else if (txtDID.Text == "")
                MessageBox.Show("Iveskite dalyko ID");
            else if (txtSID.Text == "")
                MessageBox.Show("Iveskite studento ID");
            else prideti();
        }

        private void Get_id()
        {
            {
                string SdID;

                string studQuery = "SELECT idStudento_dalykas FROM studento_dalykas ORDER BY idStudento_dalykas desc;";
                dbConnection.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(studQuery, dbConnection.GetConnection());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int i = int.Parse(dr[0].ToString()) + 1;
                    SdID = i.ToString("0");
                }
                else if (Convert.IsDBNull(dr))
                {
                    SdID = ("1");
                }
                else
                {
                    SdID = ("1");
                }
                dbConnection.CloseConnection();
                string v = SdID.ToString();
                txtSDID.Text = v;
            }
        }
        private void prideti()
        {
            try
            {
                dbConnection.OpenConnection();

                string add_D = "INSERT INTO studento_dalykas (idStudento_dalykas, idDalykas, idStudentas) VALUES (@idStudento_dalykas, @idDalykas, @idStudentas);";

                using (MySqlCommand cmd = new MySqlCommand(add_D, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@idStudento_dalykas", txtSDID.Text);
                    cmd.Parameters.AddWithValue("@idDalykas", txtDID.Text);
                    cmd.Parameters.AddWithValue("@idStudentas", txtSID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Sėkmingai pridėtas studento dalykas");
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

        private void Priskirti_dalyka_studentui_Load(object sender, EventArgs e)
        {
            Get_id();
        }
        private void istrinti()
        {
            try
            {
                dbConnection.OpenConnection();

                string deleteQuery = "DELETE FROM studento_dalykas WHERE idStudento_dalykas=@idStudento_dalykas";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@idStudento_dalykas", int.Parse(textBox1.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sėkmingai ištrintas studento dalykas");
                    }
                    else
                    {
                        MessageBox.Show("Įrašas su nurodytu ID neegzistuoja");
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

        private void button2_Click(object sender, EventArgs e)
        {
            istrinti();
            load_data_view();
        }
    }
}
