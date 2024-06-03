using Desktop.Classes;
using Kadry.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kadry
{
    public partial class OfertyAdmin : Form
    {
        public OfertyAdmin()
        {
            InitializeComponent();
        }

        SQLOferty c = new SQLOferty();

        private void InitializeComponent()
        {
            this.lblOddzial = new System.Windows.Forms.Label();
            this.NrOddzialuTxt = new System.Windows.Forms.TextBox();
            this.NazwaOfertyTxt = new System.Windows.Forms.TextBox();
            this.lblOferta = new System.Windows.Forms.Label();
            this.ObowiazkiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WymaganiaTxt = new System.Windows.Forms.TextBox();
            this.lblWymagania = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.OddzialCombo = new System.Windows.Forms.ComboBox();
            this.WynagrodzenieTxt = new System.Windows.Forms.TextBox();
            this.lblWynagrodzenie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.NrOfertyTxt = new System.Windows.Forms.TextBox();
            this.lblNrOferty = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOddzial
            // 
            this.lblOddzial.AutoSize = true;
            this.lblOddzial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOddzial.Location = new System.Drawing.Point(31, 168);
            this.lblOddzial.Name = "lblOddzial";
            this.lblOddzial.Size = new System.Drawing.Size(104, 19);
            this.lblOddzial.TabIndex = 2;
            this.lblOddzial.Text = "Nr Oddziału";
            // 
            // NrOddzialuTxt
            // 
            this.NrOddzialuTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NrOddzialuTxt.Location = new System.Drawing.Point(141, 165);
            this.NrOddzialuTxt.Name = "NrOddzialuTxt";
            this.NrOddzialuTxt.ReadOnly = true;
            this.NrOddzialuTxt.Size = new System.Drawing.Size(215, 27);
            this.NrOddzialuTxt.TabIndex = 3;
            // 
            // NazwaOfertyTxt
            // 
            this.NazwaOfertyTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaOfertyTxt.Location = new System.Drawing.Point(141, 210);
            this.NazwaOfertyTxt.Name = "NazwaOfertyTxt";
            this.NazwaOfertyTxt.Size = new System.Drawing.Size(215, 27);
            this.NazwaOfertyTxt.TabIndex = 1;
            // 
            // lblOferta
            // 
            this.lblOferta.AutoSize = true;
            this.lblOferta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOferta.Location = new System.Drawing.Point(15, 213);
            this.lblOferta.Name = "lblOferta";
            this.lblOferta.Size = new System.Drawing.Size(120, 19);
            this.lblOferta.TabIndex = 4;
            this.lblOferta.Text = "Nazwa Oferty";
            // 
            // ObowiazkiTxt
            // 
            this.ObowiazkiTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObowiazkiTxt.Location = new System.Drawing.Point(141, 297);
            this.ObowiazkiTxt.Name = "ObowiazkiTxt";
            this.ObowiazkiTxt.Size = new System.Drawing.Size(215, 27);
            this.ObowiazkiTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obowiazki";
            // 
            // WymaganiaTxt
            // 
            this.WymaganiaTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WymaganiaTxt.Location = new System.Drawing.Point(141, 253);
            this.WymaganiaTxt.Name = "WymaganiaTxt";
            this.WymaganiaTxt.Size = new System.Drawing.Size(215, 27);
            this.WymaganiaTxt.TabIndex = 2;
            // 
            // lblWymagania
            // 
            this.lblWymagania.AutoSize = true;
            this.lblWymagania.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWymagania.Location = new System.Drawing.Point(31, 256);
            this.lblWymagania.Name = "lblWymagania";
            this.lblWymagania.Size = new System.Drawing.Size(104, 19);
            this.lblWymagania.TabIndex = 6;
            this.lblWymagania.Text = "Wymagania";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 339);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(69, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(69, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 34);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // OddzialCombo
            // 
            this.OddzialCombo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OddzialCombo.FormattingEnabled = true;
            this.OddzialCombo.Items.AddRange(new object[] {
            "SerwisKomputerowy",
            "SerwisKablowy"});
            this.OddzialCombo.Location = new System.Drawing.Point(141, 382);
            this.OddzialCombo.Name = "OddzialCombo";
            this.OddzialCombo.Size = new System.Drawing.Size(215, 27);
            this.OddzialCombo.TabIndex = 5;
            // 
            // WynagrodzenieTxt
            // 
            this.WynagrodzenieTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WynagrodzenieTxt.Location = new System.Drawing.Point(141, 340);
            this.WynagrodzenieTxt.Name = "WynagrodzenieTxt";
            this.WynagrodzenieTxt.Size = new System.Drawing.Size(215, 27);
            this.WynagrodzenieTxt.TabIndex = 4;
            // 
            // lblWynagrodzenie
            // 
            this.lblWynagrodzenie.AutoSize = true;
            this.lblWynagrodzenie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynagrodzenie.Location = new System.Drawing.Point(0, 343);
            this.lblWynagrodzenie.Name = "lblWynagrodzenie";
            this.lblWynagrodzenie.Size = new System.Drawing.Size(135, 19);
            this.lblWynagrodzenie.TabIndex = 18;
            this.lblWynagrodzenie.Text = "Wynagrodzenie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(65, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Oddzial";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(226, 430);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // NrOfertyTxt
            // 
            this.NrOfertyTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NrOfertyTxt.Location = new System.Drawing.Point(141, 123);
            this.NrOfertyTxt.Name = "NrOfertyTxt";
            this.NrOfertyTxt.ReadOnly = true;
            this.NrOfertyTxt.Size = new System.Drawing.Size(215, 27);
            this.NrOfertyTxt.TabIndex = 24;
            // 
            // lblNrOferty
            // 
            this.lblNrOferty.AutoSize = true;
            this.lblNrOferty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrOferty.Location = new System.Drawing.Point(51, 131);
            this.lblNrOferty.Name = "lblNrOferty";
            this.lblNrOferty.Size = new System.Drawing.Size(84, 19);
            this.lblNrOferty.TabIndex = 23;
            this.lblNrOferty.Text = "Nr Oferty";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(226, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSzukaj.Location = new System.Drawing.Point(715, 121);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.Size = new System.Drawing.Size(385, 27);
            this.txtSzukaj.TabIndex = 11;
            this.txtSzukaj.TextChanged += new System.EventHandler(this.txtSzukaj_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.Location = new System.Drawing.Point(645, 124);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 19);
            this.lblSearch.TabIndex = 27;
            this.lblSearch.Text = "Szukaj";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(395, 121);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 28);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kadry.Properties.Resources.x;
            this.pictureBox3.Location = new System.Drawing.Point(1114, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kadry.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(458, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(-13, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblWer
            // 
            this.lblWer.AutoSize = true;
            this.lblWer.BackColor = System.Drawing.Color.Gray;
            this.lblWer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWer.Location = new System.Drawing.Point(1000, 578);
            this.lblWer.Name = "lblWer";
            this.lblWer.Size = new System.Drawing.Size(133, 13);
            this.lblWer.TabIndex = 98;
            this.lblWer.Text = "/////////////////////";
            // 
            // OfertyAdmin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 600);
            this.Controls.Add(this.lblWer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSzukaj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.NrOfertyTxt);
            this.Controls.Add(this.lblNrOferty);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WynagrodzenieTxt);
            this.Controls.Add(this.lblWynagrodzenie);
            this.Controls.Add(this.OddzialCombo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ObowiazkiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WymaganiaTxt);
            this.Controls.Add(this.lblWymagania);
            this.Controls.Add(this.NazwaOfertyTxt);
            this.Controls.Add(this.lblOferta);
            this.Controls.Add(this.NrOddzialuTxt);
            this.Controls.Add(this.lblOddzial);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OfertyAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Oferty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Oferty_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
            lblWer.Text = Wersja.WersjaAplikacji;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (OddzialCombo.Text == ("SerwisKomputerowy"))
            {
                NrOddzialuTxt.Text = "1";
            }
            else
            {
                NrOddzialuTxt.Text = "2";
            }
            c.NR_Oddzialu = int.Parse(NrOddzialuTxt.Text);
            c.NazwaOferty = NazwaOfertyTxt.Text;
            c.Wymagania = WymaganiaTxt.Text;
            c.Obowiazki = ObowiazkiTxt.Text;
            c.Wynagrodzenie = decimal.Parse(WynagrodzenieTxt.Text);
            c.Oddzial = OddzialCombo.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Nowa Oferta Dodana");
                Clear();
            }
            else
            {
                MessageBox.Show("Bład Dodawania Oferty");
            }
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.NR_Oferty = int.Parse(NrOfertyTxt.Text);
            c.NR_Oddzialu = int.Parse(NrOddzialuTxt.Text);
            c.NazwaOferty = NazwaOfertyTxt.Text;
            c.Wymagania = WymaganiaTxt.Text;
            c.Obowiazki = ObowiazkiTxt.Text;
            c.Wynagrodzenie = decimal.Parse(WynagrodzenieTxt.Text);
            c.Oddzial = OddzialCombo.Text;
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Aktualizacja danych udana");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;

        }

        public void Clear()
        {
            NrOfertyTxt.Text = "";
            NrOddzialuTxt.Text = "";
            NazwaOfertyTxt.Text = "";
            WymaganiaTxt.Text = "";
            ObowiazkiTxt.Text = "";
            WynagrodzenieTxt.Text = "";
            OddzialCombo.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            NrOfertyTxt.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            NrOddzialuTxt.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            NazwaOfertyTxt.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            WymaganiaTxt.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            ObowiazkiTxt.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            WynagrodzenieTxt.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            OddzialCombo.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.NR_Oferty = Convert.ToInt32(NrOfertyTxt.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Pomyslnie usunieto");
                Clear();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
