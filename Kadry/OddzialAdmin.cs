using Kadry.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kadry
{
    public partial class OddzialAdmin : Form
    {
        public OddzialAdmin()
        {
            InitializeComponent();
        }

        SQLOddzial c = new SQLOddzial();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOddzial_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.NR_Działu = int.Parse(DzialTxt.Text);
            c.Nazwa = NazwaTxt.Text;
            c.Kierownik = KierownikTxt.Text;

            bool success = c.Insert4(c);
            if (success == true)
            {
                MessageBox.Show("Nowy Oddział Dodany");
                Clear();
            }
            else
            {
                MessageBox.Show("Bład Dodawania Oddziału");
            }
            DataTable dt = c.Select4();
            dataGridView1.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.NR_Oddziału = int.Parse(NrOddzialuTxt.Text);
            c.NR_Działu = int.Parse(DzialTxt.Text);
            c.Nazwa = NazwaTxt.Text;
            c.Kierownik = KierownikTxt.Text;

            bool success = c.Update4(c);
            if (success == true)
            {
                MessageBox.Show("Aktualizacja danych udana");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select4();
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.NR_Oddziału = Convert.ToInt32(NrOddzialuTxt.Text);
            bool success = c.Delete4(c);
            if (success == true)
            {
                MessageBox.Show("Pomyslnie usunieto");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select4();
            dataGridView1.DataSource = dt;
        }

        private void OddzialAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select4();
            dataGridView1.DataSource = dt;
            lblWer.Text = Wersja.WersjaAplikacji;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            NrOddzialuTxt.Text = "";
            DzialTxt.Text = "";
            NazwaTxt.Text = "";
            KierownikTxt.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            NrOddzialuTxt.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            DzialTxt.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            NazwaTxt.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            KierownikTxt.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
        }
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSzukaj.Text;

            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter srch = new SqlDataAdapter("SELECT * FROM ODDZIAŁ WHERE NR_ODDZIAŁU LIKE '%" + keyword + "%' OR NR_DZIAŁU LIKE '%" + keyword + "%' OR NAZWA LIKE '%" + keyword + "%' OR KIEROWNIK LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            srch.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
