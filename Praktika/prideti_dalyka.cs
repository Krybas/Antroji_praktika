using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Praktika
{
    public partial class prideti_dalyka : Form
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public prideti_dalyka()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtDP_TextChanged(object sender, EventArgs e)
        {
        }

        private void valid()
        {
            if (string.IsNullOrWhiteSpace(txtDID.Text))
                MessageBox.Show("Iveskite dalyko ID");
            if (string.IsNullOrWhiteSpace(txtDP.Text))
                MessageBox.Show("Iveskite dalyko pavadinimą");
        }

        private void prideti_dest_Click(object sender, EventArgs e)
        {
            valid();
            prideti();
            this.Close();
        }

        private void prideti()
        {
            using (MySqlConnection con = dbConnection.GetConnection())
            {
                con.Open();
                string add_D = "INSERT INTO dalykas (idDalykas, Dalyko_pavadinimas) VALUES (@idDalykas, @Dalyko_pavadinimas);";
                using (MySqlCommand cmd = new MySqlCommand(add_D, con))
                {
                    cmd.Parameters.AddWithValue("@idDalykas", txtDID.Text);
                    cmd.Parameters.AddWithValue("@Dalyko_pavadinimas", txtDP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sėkmingai pridėtas dalykas");
                }
            }
        }

        private void Get_Dest_id()
        {
            string destID;
            string studQuery = "SELECT idDalykas FROM dalykas ORDER BY idDalykas DESC LIMIT 1;";
            using (MySqlConnection con = dbConnection.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(studQuery, con))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            int i = int.Parse(dr[0].ToString()) + 1;
                            destID = i.ToString("0");
                        }
                        else if (Convert.IsDBNull(dr))
                        {
                            destID = "1";
                        }
                        else
                        {
                            destID = "1";
                        }
                    }
                }
            }

            string v = destID.ToString();
            txtDID.Text = v;
        }

        private void prideti_dalyka_Load(object sender, EventArgs e)
        {
            Get_Dest_id();
        }
    }
}