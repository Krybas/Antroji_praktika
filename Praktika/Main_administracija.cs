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
    public partial class Main_administracija : Form
    {
        public Main_administracija()
        {
            InitializeComponent();
            custom_design();
        }

        private void custom_design()
        {
            panelStudentas.Visible = false;
            panelDestytojas.Visible = false;
            panelGrupe.Visible = false;
            panelDalykas.Visible = false;
        }

        private void hide_panel()
        {
            if (panelStudentas.Visible == true) 
                panelStudentas.Visible = false;
            if (panelDestytojas.Visible == true)
                panelDestytojas.Visible = false;
            if (panelGrupe.Visible == true)
                panelGrupe.Visible = false;
            if (panelDalykas.Visible == true)
                panelDalykas.Visible = false;
        }
        
        private void show_panel (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hide_panel();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Studento_lentele());
            show_panel(panelStudentas);
        }

        private void buttonDėstytojai_Click(object sender, EventArgs e)
        {
            openChildForm(new Destytojo_lentele());
            show_panel(panelDestytojas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Grupes_lentele());
            show_panel(panelGrupe);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            prideti_studenta frm = new prideti_studenta();
            frm.ShowDialog();
            hide_panel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Istrinti_studenta frm = new Istrinti_studenta();
            frm.ShowDialog();
            hide_panel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prideti_destytoja frm = new prideti_destytoja();
            frm.ShowDialog();
            hide_panel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            istrinti_destytoja frm = new istrinti_destytoja();
            frm.ShowDialog();
            hide_panel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prideti_grupe frm = new prideti_grupe();
            frm.ShowDialog();
            hide_panel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            istrinti_grupe frm = new istrinti_grupe();
            frm.ShowDialog();
            hide_panel();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Main_administracija_Load(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Dalyko_lentele());
            show_panel(panelDalykas);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            prideti_dalyka frm = new prideti_dalyka();
            frm.ShowDialog();
            hide_panel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            istrinti_dalyka frm = new istrinti_dalyka();
            frm.ShowDialog();
            hide_panel();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            hide_panel();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hide_panel();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
