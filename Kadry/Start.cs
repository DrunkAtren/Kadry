using Kadry.Classes;
using System;
using System.Windows.Forms;

namespace Kadry
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogowanieAdmin f2 = new LogowanieAdmin();
            f2.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UzytkownikPodania f6 = new UzytkownikPodania();
            f6.ShowDialog();
            Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            lblWer.Text = Wersja.WersjaAplikacji;
        }
    }
}
