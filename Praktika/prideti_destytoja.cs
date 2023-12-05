using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Praktika
{
    public partial class prideti_destytoja : Form
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public prideti_destytoja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void valid()
        {
            if (string.IsNullOrWhiteSpace(txtDID.Text))
                MessageBox.Show("Iveskite dėstytojo ID");
            if (string.IsNullOrWhiteSpace(txtDP.Text))
                MessageBox.Show("Iveskite dėstytojo pavardę");
        }

        private void prideti_destytoja_Load(object sender, EventArgs e)
        {
            Get_Dest_id();
        }

        private void prideti_stud_Click(object sender, EventArgs e)
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
                string add_D = "INSERT INTO destytojas (idDestytojas, Destytojo_vardas, Destytojo_pavarde) VALUES (@idDestytojas, @Destytojo_vardas, @Destytojo_pavarde);";
                using (MySqlCommand cmd = new MySqlCommand(add_D, con))
                {
                    cmd.Parameters.AddWithValue("@idDestytojas", txtDID.Text);
                    cmd.Parameters.AddWithValue("@Destytojo_vardas", txtDV.Text);
                    cmd.Parameters.AddWithValue("@Destytojo_pavarde", txtDP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sėkmingai pridėtas dėstytojas");
                }
            }
        }

        private void Get_Dest_id()
        {
            string destID;
            string studQuery = "SELECT idDestytojas FROM destytojas ORDER BY idDestytojas DESC LIMIT 1;";
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
    }
}
