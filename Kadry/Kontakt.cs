using Kadry.Classes;
using System;
using System.Windows.Forms;

namespace Kadry
{
    public partial class Kontakt : Form
    {
        public Kontakt()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kontakt_Load(object sender, EventArgs e)
        {
            lblWer.Text = Wersja.WersjaAplikacji;
        }
    }
}
