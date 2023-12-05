using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Praktika
{
    public partial class prideti_grupe : Form
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public prideti_grupe()
        {
            InitializeComponent();
        }

        private void valid()
        {
            if (string.IsNullOrWhiteSpace(txtGID.Text))
                MessageBox.Show("Iveskite grupės ID");
            if (string.IsNullOrWhiteSpace(txtGP.Text))
                MessageBox.Show("Iveskite grupės vardą");
        }

        private void prideti_grupe_Load(object sender, EventArgs e)
        {
            Get_Grupe_id();
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
                string add_G = "INSERT INTO grupe (idGrupe, Grupes_pavadinimas) VALUES (@idGrupe, @Grupes_pavadinimas);";
                using (MySqlCommand cmd = new MySqlCommand(add_G, con))
                {
                    cmd.Parameters.AddWithValue("@idGrupe", txtGID.Text);
                    cmd.Parameters.AddWithValue("@Grupes_pavadinimas", txtGP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sėkmingai pridėta grupė");
                }
            }
        }

        private void Get_Grupe_id()
        {
            string gID;
            string studQuery = "SELECT idGrupe FROM grupe ORDER BY idGrupe DESC LIMIT 1;";
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
                            gID = i.ToString("0");
                        }
                        else if (Convert.IsDBNull(dr))
                        {
                            gID = "1";
                        }
                        else
                        {
                            gID = "1";
                        }
                    }
                }
            }

            string v = gID.ToString();
            txtGID.Text = v;
        }
    }
}
