using Kadry.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kadry
{
    public partial class StanowiskaAdmin : Form
    {
        public StanowiskaAdmin()
        {
            InitializeComponent();
        }

        SQLStanowiska c = new SQLStanowiska();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            c.ID_Pracownika = int.Parse(PracownikTxt.Text);
            c.NR_Oddziału = int.Parse(OddzialTxt.Text);
            c.Nazwa_Stanowiska = NazwaStanowiskaTxt.Text;

            bool success = c.Insert5(c);
            if (success == true)
            {
                MessageBox.Show("Nowe Stanowisko Dodane");
                Clear();
            }
            else
            {
                MessageBox.Show("Bład Dodawania Stanowiska");
            }
            DataTable dt = c.Select5();
            dataGridView1.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.NR_Stanowiska = int.Parse(StanowiskoTxt.Text);
            c.ID_Pracownika = int.Parse(PracownikTxt.Text);
            c.NR_Oddziału = int.Parse(OddzialTxt.Text);
            c.Nazwa_Stanowiska = NazwaStanowiskaTxt.Text;
            bool success = c.Update5(c);
            if (success == true)
            {
                MessageBox.Show("Aktualizacja danych udana");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select5();
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.NR_Stanowiska = Convert.ToInt32(StanowiskoTxt.Text);
            bool success = c.Delete5(c);
            if (success == true)
            {
                MessageBox.Show("Pomyslnie usunieto");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select5();
            dataGridView1.DataSource = dt;
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
            SqlDataAdapter srch = new SqlDataAdapter("SELECT * FROM STANOWISKA WHERE NR_Stanowiska LIKE '%" + keyword + "%' OR ID_Pracownika LIKE '%" + keyword + "%' OR NR_Oddziału LIKE '%" + keyword + "%' OR NAZWA_STANOWISKA LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            srch.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void StanowiskaAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select5();
            dataGridView1.DataSource = dt;
            lblWer.Text = Wersja.WersjaAplikacji;
        }
        public void Clear()
        {
            StanowiskoTxt.Text = "";
            PracownikTxt.Text = "";
            OddzialTxt.Text = "";
            NazwaStanowiskaTxt.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            StanowiskoTxt.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            PracownikTxt.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            OddzialTxt.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            NazwaStanowiskaTxt.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
