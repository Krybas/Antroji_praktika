using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Praktika
{
    public partial class Main_studentas : Form
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();
        public string sVardas { get; set; }
        public string sPavarde { get; set; }

        public Main_studentas()
        {
            InitializeComponent();
        }

        private void Main_studentas_Load(object sender, EventArgs e)
        {
            label1.Text = $"{sVardas} {sPavarde} pažymiai:";
            Pazymiai();
        }

        private void Pazymiai()
        {
            using (MySqlConnection con = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                string pazymiaiQuery = "SELECT Dalyko_pavadinimas, pazymys FROM studento_dalykas " +
                    "INNER JOIN studentas ON studento_dalykas.idStudentas = studentas.idStudentas " +
                    "INNER JOIN dalykas ON studento_dalykas.idDalykas = dalykas.idDalykas " +
                    "WHERE Studento_vardas = @Studento_vardas AND Studento_pavarde = @Studento_pavarde";

                using (MySqlCommand cmd = new MySqlCommand(pazymiaiQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Studento_vardas", sVardas);
                    cmd.Parameters.AddWithValue("@Studento_pavarde", sPavarde);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
