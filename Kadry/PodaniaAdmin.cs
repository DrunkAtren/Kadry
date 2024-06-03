using Kadry.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kadry
{
    public partial class PodaniaAdmin : Form
    {
        public PodaniaAdmin()
        {
            InitializeComponent();
        }

        SQLPodania c = new SQLPodania();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.NR_Oferty = int.Parse(NrOfertyTxt.Text);
            c.Imie = ImieTxt.Text;
            c.Nazwisko = NazwiskoTxt.Text;
            c.Wiek = int.Parse(WiekTxt.Text);
            c.Mail = MailTxt.Text;
            c.Wyksztalcenie = WyksztalcenieTxt.Text;
            c.Adres_Zamieszkania = AdresZamieszkaniaTxt.Text;
            c.Nr_Telefonu = int.Parse(NrTelefonuTxt.Text);
            c.Dodatkowe_Informacje = DodatkoweInfTxt.Text;

            bool success = c.Insert3(c);
            if (success == true)
            {
                MessageBox.Show("Nowe Podanie Dodane");
                Clear();
            }
            else
            {
                MessageBox.Show("Bład Dodawania Podania");
            }
            DataTable dt = c.Select3();
            dataGridView1.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.NR_Podania = int.Parse(PodaniaTxt.Text);
            c.NR_Oferty = int.Parse(NrOfertyTxt.Text);
            c.Imie = ImieTxt.Text;
            c.Nazwisko = NazwiskoTxt.Text;
            c.Wiek = int.Parse(WiekTxt.Text);
            c.Mail = MailTxt.Text;
            c.Wyksztalcenie = WyksztalcenieTxt.Text;
            c.Adres_Zamieszkania = AdresZamieszkaniaTxt.Text;
            c.Nr_Telefonu = int.Parse(NrTelefonuTxt.Text);
            c.Dodatkowe_Informacje = DodatkoweInfTxt.Text;
            bool success = c.Update3(c);
            if (success == true)
            {
                MessageBox.Show("Aktualizacja danych udana");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select3();
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.NR_Podania = Convert.ToInt32(PodaniaTxt.Text);
            bool success = c.Delete3(c);
            if (success == true)
            {
                MessageBox.Show("Pomyslnie usunieto");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select3();
            dataGridView1.DataSource = dt;
        }

        private void PodaniaAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select3();
            dataGridView1.DataSource = dt;
            lblWer.Text = Wersja.WersjaAplikacji;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSzukaj.Text;

            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter srch = new SqlDataAdapter("SELECT * FROM PODANIA WHERE NR_PODANIA LIKE '%" + keyword + "%' OR NR_OFERTY LIKE '%" + keyword + "%' OR IMIE LIKE '%" + keyword + "%' OR NAZWISKO LIKE '%" + keyword + "%' OR WIEK LIKE '%" + keyword + "%' OR MAIL LIKE '%" + keyword + "%' OR WYKSZTALCENIE LIKE '%" + keyword + "%' OR ADRES_ZAMIESZKANIA LIKE '%" + keyword + "%' OR NR_TELEFONU LIKE '%" + keyword + "%' OR DODATKOWE_INFORMACJE LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            srch.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Clear()
        {
            PodaniaTxt.Text = "";
            NrOfertyTxt.Text = "";
            ImieTxt.Text = "";
            NazwiskoTxt.Text = "";
            WiekTxt.Text = "";
            MailTxt.Text = "";
            WyksztalcenieTxt.Text = "";
            AdresZamieszkaniaTxt.Text = "";
            NrTelefonuTxt.Text = "";
            DodatkoweInfTxt.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            PodaniaTxt.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            NrOfertyTxt.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            ImieTxt.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            NazwiskoTxt.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            WiekTxt.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            MailTxt.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            WyksztalcenieTxt.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            AdresZamieszkaniaTxt.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            NrTelefonuTxt.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            DodatkoweInfTxt.Text = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
        }
    }
}
//c.NR_Podania = int.Parse(PodaniaTxt.Text);
//c.NR_Oferty = int.Parse(NrOfertyTxt.Text);