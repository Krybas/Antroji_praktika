using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Praktika
{
    public partial class Form1 : Form
    {
        string cs = "Server=localhost; Database=new_schema; Uid=root; Password=1234; Port=3306;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Prisijungti_Click(object sender, EventArgs e)
        {
            string value = Pasirinkimas.Text;
            if (value == "Studentas")
            {
                studento_prisijungimas();
            }
            else if (value == "Dėstytojas")
            {
                destytojo_prisijungimas();
            }
            else
            {
                administratoriuas_prisijungimas();
            }   
        }

        private void main_studentas_form()
        {
            this.Hide();
            Main_studentas frm = new Main_studentas();
            frm.sVardas = txtUsername.Text;
            frm.sPavarde = txtPassword.Text;
            frm.ShowDialog();
            this.Close();
        }

        private void studento_prisijungimas()
        {
            string query = "SELECT * FROM studentas WHERE Studento_vardas=@Studento_vardas AND Studento_pavarde=@Studento_pavarde";
            MySqlConnection con = new MySqlConnection(cs);

            MySqlCommand cdbS = new MySqlCommand(query, con);

            cdbS.Parameters.AddWithValue("Studento_vardas", txtUsername.Text);
            cdbS.Parameters.AddWithValue("Studento_pavarde", txtPassword.Text);

            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cdbS.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        main_studentas_form();
                    }
                }
                else 
                {
                    MessageBox.Show("Neteisingi prisijungimai");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Klaida");
                con.Close();
            }
            
        }
        private void main_destytojas_form()
        {
            this.Hide();
            Main_destytojas frm = new Main_destytojas();
            frm.dVardas = txtUsername.Text;
            frm.dPavarde = txtPassword.Text;
            frm.ShowDialog();
            this.Close();
        }

        private void destytojo_prisijungimas()
        {
            string query = "SELECT * FROM destytojas WHERE Destytojo_vardas=@Destytojo_vardas AND Destytojo_pavarde=@Destytojo_pavarde";
            MySqlConnection con = new MySqlConnection(cs);

            MySqlCommand cdbS = new MySqlCommand(query, con);

            cdbS.Parameters.AddWithValue("Destytojo_vardas", txtUsername.Text);
            cdbS.Parameters.AddWithValue("Destytojo_pavarde", txtPassword.Text);

            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cdbS.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        main_destytojas_form();
                    }
                }
                else
                {
                    MessageBox.Show("Neteisingi prisijungimai");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Klaida");
                con.Close();
            }
            
        }
        private void main_administracija_form()
        {
            this.Hide();
            Main_administracija frm = new Main_administracija();
            frm.ShowDialog();
            this.Close();
        }

        private void administratoriuas_prisijungimas()
        {
            string query = "SELECT * FROM administracija WHERE Administratoriaus_vardas=@Administratoriaus_vardas AND Administratoriaus_pavarde=@Administratoriaus_pavarde";
            MySqlConnection con = new MySqlConnection(cs);

            MySqlCommand cdbS = new MySqlCommand(query, con);

            cdbS.Parameters.AddWithValue("Administratoriaus_vardas", txtUsername.Text);
            cdbS.Parameters.AddWithValue("Administratoriaus_pavarde", txtPassword.Text);

            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cdbS.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        main_administracija_form();
                    }
                }
                else
                {
                    MessageBox.Show("Neteisingi prisijungimai");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Klaida");
                con.Close();
            }
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Pasirinkimas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pasirinkimas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
