using Kadry.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kadry
{
    public partial class UzytkownikPodania : Form
    {
        public UzytkownikPodania()
        {
            InitializeComponent();
        }
        SQLUzytkownik c = new SQLUzytkownik();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (NrOfertyTxt.Text == "" || ImieTxt.Text == "" || NazwiskoTxt.Text == "" || WiekTxt.Text == "" || MailTxt.Text == "" || NrTelefonuTxt.Text == "" || AdresZamieszkaniaTxt.Text == "")
            {
                MessageBox.Show("Wypełnij wymagane pola");
            }
            else
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
            }

            bool success = c.Insert6(c);
            if (success == true)
            {
                MessageBox.Show("Nowe Podanie Dodane");
                Clear();
            }
            else
            {
                MessageBox.Show("Bład Dodawania Podania");
            }
            DataTable dt = c.Select6();
            dataGridView1.DataSource = dt;
        }

        private void UzytkownikPodania_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select6();
            dataGridView1.DataSource = dt;
            lblWer.Text = Wersja.WersjaAplikacji;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            NrOfertyTxt.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();

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
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSzukaj.Text;

            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter srch = new SqlDataAdapter("SELECT * FROM OFERTY WHERE NR_OFERTY LIKE '%" + keyword + "%' OR NR_ODDZIAŁU LIKE '%" + keyword + "%' OR NAZWA_OFERTY LIKE '%" + keyword + "%' OR WYMAGANIA LIKE '%" + keyword + "%' OR OBOWIAZKI LIKE '%" + keyword + "%' OR WYNAGRODZENIE LIKE '%" + keyword + "%' OR ODDZIAŁ LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            srch.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Kontakt f9 = new Kontakt();
            f9.ShowDialog();
            Show();
        }
    }
}
