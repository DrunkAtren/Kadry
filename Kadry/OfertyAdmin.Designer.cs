using System.Drawing;
using System.Windows.Forms;

namespace Kadry
{
    partial class OfertyAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblOddzial;
        private TextBox NrOddzialuTxt;
        private TextBox NazwaOfertyTxt;
        private Label lblOferta;
        private TextBox ObowiazkiTxt;
        private Label label2;
        private TextBox WymaganiaTxt;
        private Label lblWymagania;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnUpdate;
        private ComboBox OddzialCombo;
        private TextBox WynagrodzenieTxt;
        private Label lblWynagrodzenie;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btnClear;
        private TextBox NrOfertyTxt;
        private Label lblNrOferty;
        private Button btnDelete;
        private TextBox txtSzukaj;
        private Label lblSearch;
        private Button btnBack;
        private Label lblWer;
    }
}

