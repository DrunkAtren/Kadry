using Kadry.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kadry
{
    public partial class PracownicyAdmin : Form
    {

        public PracownicyAdmin()
        {
            InitializeComponent();
        }
        SQLPracownicy c = new SQLPracownicy();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PracownicyAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select2();
            dataGridView1.DataSource = dt;
            lblWer.Text = Wersja.WersjaAplikacji;
        }
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSzukaj.Text;

            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter srch = new SqlDataAdapter("SELECT * FROM PRACOWNICY WHERE ID_PRACOWNIKA LIKE '%" + keyword + "%' OR IMIE LIKE '%" + keyword + "%' OR NAZWISKO LIKE '%" + keyword + "%' OR NR_TELEFONU LIKE '%" + keyword + "%' OR ADRES_ZAMIESZKANIA LIKE '%" + keyword + "%' OR MAIL LIKE '%" + keyword + "%' OR WYNAGRODZENIE LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            srch.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear()
        {
            IdPracownikaTxt.Text = "";
            ImieTxt.Text = "";
            NazwiskoTxt.Text = "";
            NrTelefonuTxt.Text = "";
            AdresTxt.Text = "";
            WynagrodzenieTxt.Text = "";
            MailTxt.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            c.Imie = ImieTxt.Text;
            c.Nazwisko = NazwiskoTxt.Text;
            c.Nr_Telefonu = int.Parse(NrTelefonuTxt.Text);
            c.Adres_Zamieszkania = AdresTxt.Text;
            c.Wynagrodzenie = decimal.Parse(WynagrodzenieTxt.Text);
            c.Mail = MailTxt.Text;

            bool success = c.Insert2(c);
            if (success == true)
            {
                MessageBox.Show("Nowy Pracownik Dodany");
                Clear();
            }
            else
            {
                MessageBox.Show("Bład Dodawania Pracownika");
            }
            DataTable dt = c.Select2();
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.ID_Pracownika = int.Parse(IdPracownikaTxt.Text);
            c.Imie = ImieTxt.Text;
            c.Nazwisko = NazwiskoTxt.Text;
            c.Nr_Telefonu = int.Parse(NrTelefonuTxt.Text);
            c.Adres_Zamieszkania = AdresTxt.Text;
            c.Wynagrodzenie = decimal.Parse(WynagrodzenieTxt.Text);
            c.Mail = MailTxt.Text;
            bool success = c.Update2(c);
            if (success == true)
            {
                MessageBox.Show("Aktualizacja danych udana");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select2();
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            IdPracownikaTxt.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            ImieTxt.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            NazwiskoTxt.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            NrTelefonuTxt.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            AdresTxt.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            WynagrodzenieTxt.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            MailTxt.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.ID_Pracownika = Convert.ToInt32(IdPracownikaTxt.Text);
            bool success = c.Delete2(c);
            if (success == true)
            {
                MessageBox.Show("Pomyslnie usunieto");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select2();
            dataGridView1.DataSource = dt;
        }
    }
}
