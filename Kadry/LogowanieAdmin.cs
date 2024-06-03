using Kadry.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kadry
{
    public partial class LogowanieAdmin : Form
    {
        public LogowanieAdmin()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogowanieAdmin_Load(object sender, EventArgs e)
        {
            lblWer.Text = Wersja.WersjaAplikacji;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            string login, hasło;

            login = txtBoxLogin.Text;
            hasło = txtHasło.Text;

            try
            {
                String querry = "SELECT * FROM ADMINI WHERE Login = '" + txtBoxLogin.Text + "' AND Hasło = '" + txtHasło.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0 )
                {
                    login = txtBoxLogin.Text;
                    hasło = txtHasło.Text;

                    MessageBox.Show("Witamy Admina");

                    this.Hide();
                    AdminPanel f2 = new AdminPanel();
                    f2.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Błąd danych logowania");
                }
            }
            catch
            {
                MessageBox.Show("Bład danych logowania");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
