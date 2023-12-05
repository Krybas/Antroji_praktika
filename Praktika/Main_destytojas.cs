using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Main_destytojas : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        public string dVardas { get; set; }
        public string dPavarde { get; set; }
        public Main_destytojas()
        {
            InitializeComponent();
            
        }

        private void Main_destytojas_Load(object sender, EventArgs e)
        {
            label1.Text = dVardas + " " + dPavarde;
            dalykas_drop_box();
            grupe_drop_box();
           
            grid_view();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void grupe_drop_box ()
        {
            dbConnection.OpenConnection();

            string str = "SELECT Grupes_pavadinimas FROM priskirtas_dalykas " +
                             "INNER JOIN destytojas ON priskirtas_dalykas.idDestytojas = destytojas.idDestytojas " +
                             "INNER JOIN grupe ON priskirtas_dalykas.idGrupe = grupe.idGrupe " +
                             $"WHERE Destytojo_vardas = '{dVardas}' AND Destytojo_pavarde = '{dPavarde}'";

                using (MySqlCommand cmd = new MySqlCommand(str, dbConnection.GetConnection()))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        comboBox1.DisplayMember = "Grupes_pavadinimas";
                        comboBox1.ValueMember = "Grupes_pavadinimas";
                        comboBox1.DataSource = ds.Tables[0];
                    }
                }

                comboBox1.Enabled = true;
        }
        private void dalykas_drop_box ()
        {
            dbConnection.OpenConnection();

            string str = "SELECT Dalyko_pavadinimas " +
                             "FROM priskirtas_dalykas " +
                             "INNER JOIN destytojas ON priskirtas_dalykas.idDestytojas = destytojas.idDestytojas " +
                             "INNER JOIN dalykas ON priskirtas_dalykas.idDalykas = dalykas.idDalykas " +
                             $"WHERE Destytojo_vardas = '{dVardas}' AND Destytojo_pavarde = '{dPavarde}'";

                using (MySqlCommand cmd = new MySqlCommand(str, dbConnection.GetConnection()))
                {
                    using (MySqlDataAdapter daa = new MySqlDataAdapter(cmd))
                    {
                        DataSet dss = new DataSet();
                        daa.Fill(dss);

                        comboBox2.DisplayMember = "Dalyko_pavadinimas";
                        comboBox2.ValueMember = "Dalyko_pavadinimas";
                        comboBox2.DataSource = dss.Tables[0];
                    }
                }

                comboBox1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_view ()
        {
            dbConnection.OpenConnection();

            string createTable = "SELECT studentas.*, pazymys, Grupes_pavadinimas " +
                                     "FROM priskirtas_dalykas " +
                                     "INNER JOIN destytojas ON priskirtas_dalykas.idDestytojas = destytojas.idDestytojas " +
                                     "INNER JOIN grupe ON priskirtas_dalykas.idGrupe = grupe.idGrupe " +
                                     "JOIN studento_dalykas " +
                                     "INNER JOIN studentas ON studento_dalykas.idStudentas = studentas.idStudentas " +
                                     $"WHERE grupes_pavadinimas = '{comboBox1.Text}' " +
                                     $"AND Destytojo_vardas = '{dVardas}' " +
                                     $"AND Destytojo_pavarde = '{dPavarde}' " +
                                     "AND priskirtas_dalykas.idDalykas = studento_dalykas.idDalykas;";

                using (MySqlCommand cmd = new MySqlCommand(createTable, dbConnection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
        }
        private void prideti_pazymi()
        {
            dbConnection.OpenConnection();

            string prideti = "UPDATE studento_dalykas SET pazymys = @pazymys " +
                                 "WHERE idDalykas = @idDalykas AND idStudentas = @idStudentas;";

                using (MySqlCommand cmd = new MySqlCommand(prideti, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@pazymys", txtP.Text);
                    cmd.Parameters.AddWithValue("@idDalykas", dalykas());
                    cmd.Parameters.AddWithValue("@idStudentas", txtSID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sėkmingai pridėtas pažymys");
                }

            grid_view();
        }

        private int dalykas()
        {
            dbConnection.OpenConnection();

            string dal = "SELECT idDalykas FROM dalykas WHERE dalyko_pavadinimas = @dalykoPavadinimas;";
                using (MySqlCommand cmd = new MySqlCommand(dal, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@dalykoPavadinimas", comboBox2.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count > 0)
                        {
                            return Convert.ToInt32(dt.Rows[0]["idDalykas"]);
                        }
                    }
                }
            return -1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prideti_dest_Click(object sender, EventArgs e)
        {
            prideti_pazymi();
        }
        
        private void istrinti ()
        {
            try
            {
                dbConnection.OpenConnection();
                string delete = "UPDATE studento_dalykas SET pazymys = NULL WHERE idDalykas = @idDalykas AND idStudentas = @idStudentas;";
                    using (MySqlCommand cmd = new MySqlCommand(delete, dbConnection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@idStudentas", textBox2.Text);
                        cmd.Parameters.AddWithValue("@idDalykas", dalykas());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sėkmingai ištrintas pazymys");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                grid_view();
            }
        }

        private void buttonIstrinti_Click(object sender, EventArgs e)
        {
            istrinti();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
