using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Praktika
{
    public partial class prideti_studenta : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public prideti_studenta()
        {
            InitializeComponent();
        }

        private void prideti_stud_Click(object sender, EventArgs e)
        {
            valid();
            prideti();
            this.Close();
        }

        private void valid()
        {
            if (string.IsNullOrWhiteSpace(txtSID.Text))
                MessageBox.Show("Iveskite studento ID");
            if (string.IsNullOrWhiteSpace(txtSV.Text))
                MessageBox.Show("Iveskite studento vardą");
            if (string.IsNullOrWhiteSpace(txtSP.Text))
                MessageBox.Show("Iveskite studento pavardę");
            if (string.IsNullOrWhiteSpace(txtGID.Text))
                MessageBox.Show("Iveskite studento grupę");
        }

        private void prideti()
        {
            using (MySqlConnection con = dbConnection.GetConnection())
            {
                con.Open();
                string add_S = "INSERT INTO studentas (idStudentas, Studento_vardas, Studento_pavarde, idGrupe) VALUES (@idStudentas, @Studento_vardas, @Studento_pavarde, @idGrupe);";
                using (MySqlCommand cmd = new MySqlCommand(add_S, con))
                {
                    cmd.Parameters.AddWithValue("@idStudentas", txtSID.Text);
                    cmd.Parameters.AddWithValue("@Studento_vardas", txtSV.Text);
                    cmd.Parameters.AddWithValue("@Studento_pavarde", txtSP.Text);
                    cmd.Parameters.AddWithValue("@idGrupe", txtGID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sėkmingai pridėtas studentas");
                }
            }
        }

        private void prideti_studenta_Load(object sender, EventArgs e)
        {
            Get_Stud_id();
        }

        private void Get_Stud_id()
        {
            string studID;
            string studQuery = "SELECT idStudentas FROM studentas ORDER BY idStudentas DESC LIMIT 1;";
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
                            studID = i.ToString("0");
                        }
                        else if (Convert.IsDBNull(dr))
                        {
                            studID = "1";
                        }
                        else
                        {
                            studID = "1";
                        }
                    }
                }
            }

            string v = studID.ToString();
            txtSID.Text = v;
        }

        private void txtSID_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
