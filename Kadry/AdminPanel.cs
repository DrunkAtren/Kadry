using Kadry.Classes;
using System;
using System.Windows.Forms;

namespace Kadry
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOferty_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfertyAdmin f3 = new OfertyAdmin();
            f3.ShowDialog();
            Show();
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            this.Hide();
            PracownicyAdmin f4 = new PracownicyAdmin();
            f4.ShowDialog();
            Show();
        }

        private void btnPodania_Click(object sender, EventArgs e)
        {
            this.Hide();
            PodaniaAdmin f5 = new PodaniaAdmin();
            f5.ShowDialog();
            Show();
        }

        private void btnStanowiska_Click(object sender, EventArgs e)
        {
            this.Hide();
            StanowiskaAdmin f6 = new StanowiskaAdmin();
            f6.ShowDialog();
            Show();
        }

        private void btnOddzialy_Click(object sender, EventArgs e)
        {
            this.Hide();
            OddzialAdmin f7 = new OddzialAdmin();
            f7.ShowDialog();
            Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            lblWer.Text = Wersja.WersjaAplikacji;
        }
    }
}
