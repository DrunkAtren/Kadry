namespace Kadry
{
    partial class PracownicyAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.WynagrodzenieTxt = new System.Windows.Forms.TextBox();
            this.lblWynagrodzenie = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.NrTelefonuTxt = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.NazwiskoTxt = new System.Windows.Forms.TextBox();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.ImieTxt = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.IdPracownikaTxt = new System.Windows.Forms.TextBox();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.AdresTxt = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.MailTxt = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 336);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(474, 123);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 28);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.Location = new System.Drawing.Point(644, 129);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 19);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Szukaj";
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSzukaj.Location = new System.Drawing.Point(714, 124);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.Size = new System.Drawing.Size(342, 27);
            this.txtSzukaj.TabIndex = 12;
            this.txtSzukaj.TextChanged += new System.EventHandler(this.txtSzukaj_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(291, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(291, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // WynagrodzenieTxt
            // 
            this.WynagrodzenieTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WynagrodzenieTxt.Location = new System.Drawing.Point(206, 337);
            this.WynagrodzenieTxt.Name = "WynagrodzenieTxt";
            this.WynagrodzenieTxt.Size = new System.Drawing.Size(215, 27);
            this.WynagrodzenieTxt.TabIndex = 5;
            // 
            // lblWynagrodzenie
            // 
            this.lblWynagrodzenie.AutoSize = true;
            this.lblWynagrodzenie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynagrodzenie.Location = new System.Drawing.Point(65, 340);
            this.lblWynagrodzenie.Name = "lblWynagrodzenie";
            this.lblWynagrodzenie.Size = new System.Drawing.Size(135, 19);
            this.lblWynagrodzenie.TabIndex = 45;
            this.lblWynagrodzenie.Text = "Wynagrodzenie";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(134, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 34);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(134, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NrTelefonuTxt
            // 
            this.NrTelefonuTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NrTelefonuTxt.Location = new System.Drawing.Point(206, 255);
            this.NrTelefonuTxt.Name = "NrTelefonuTxt";
            this.NrTelefonuTxt.Size = new System.Drawing.Size(215, 27);
            this.NrTelefonuTxt.TabIndex = 3;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTelefon.Location = new System.Drawing.Point(100, 258);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(100, 19);
            this.lblTelefon.TabIndex = 40;
            this.lblTelefon.Text = "NrTelefonu";
            // 
            // NazwiskoTxt
            // 
            this.NazwiskoTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwiskoTxt.Location = new System.Drawing.Point(206, 211);
            this.NazwiskoTxt.Name = "NazwiskoTxt";
            this.NazwiskoTxt.Size = new System.Drawing.Size(215, 27);
            this.NazwiskoTxt.TabIndex = 2;
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwisko.Location = new System.Drawing.Point(113, 214);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(87, 19);
            this.lblNazwisko.TabIndex = 38;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // ImieTxt
            // 
            this.ImieTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImieTxt.Location = new System.Drawing.Point(206, 168);
            this.ImieTxt.Name = "ImieTxt";
            this.ImieTxt.Size = new System.Drawing.Size(215, 27);
            this.ImieTxt.TabIndex = 1;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(154, 171);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(46, 19);
            this.lblImie.TabIndex = 36;
            this.lblImie.Text = "Imie";
            // 
            // IdPracownikaTxt
            // 
            this.IdPracownikaTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IdPracownikaTxt.Location = new System.Drawing.Point(206, 123);
            this.IdPracownikaTxt.Name = "IdPracownikaTxt";
            this.IdPracownikaTxt.ReadOnly = true;
            this.IdPracownikaTxt.Size = new System.Drawing.Size(215, 27);
            this.IdPracownikaTxt.TabIndex = 35;
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPracownik.Location = new System.Drawing.Point(72, 127);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(128, 19);
            this.lblPracownik.TabIndex = 34;
            this.lblPracownik.Text = "ID Pracownika";
            // 
            // AdresTxt
            // 
            this.AdresTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdresTxt.Location = new System.Drawing.Point(206, 295);
            this.AdresTxt.Name = "AdresTxt";
            this.AdresTxt.Size = new System.Drawing.Size(215, 27);
            this.AdresTxt.TabIndex = 4;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdres.Location = new System.Drawing.Point(27, 298);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(173, 19);
            this.lblAdres.TabIndex = 52;
            this.lblAdres.Text = "Adres Zamieszkania";
            // 
            // MailTxt
            // 
            this.MailTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MailTxt.Location = new System.Drawing.Point(206, 378);
            this.MailTxt.Name = "MailTxt";
            this.MailTxt.Size = new System.Drawing.Size(215, 27);
            this.MailTxt.TabIndex = 6;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMail.Location = new System.Drawing.Point(154, 381);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(43, 19);
            this.lblMail.TabIndex = 54;
            this.lblMail.Text = "Mail";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kadry.Properties.Resources.x;
            this.pictureBox3.Location = new System.Drawing.Point(1063, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kadry.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(432, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(-58, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1140, 75);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblWer
            // 
            this.lblWer.AutoSize = true;
            this.lblWer.BackColor = System.Drawing.Color.Gray;
            this.lblWer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWer.Location = new System.Drawing.Point(949, 578);
            this.lblWer.Name = "lblWer";
            this.lblWer.Size = new System.Drawing.Size(133, 13);
            this.lblWer.TabIndex = 98;
            this.lblWer.Text = "/////////////////////";
            // 
            // PracownicyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.lblWer);
            this.Controls.Add(this.MailTxt);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.AdresTxt);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.WynagrodzenieTxt);
            this.Controls.Add(this.lblWynagrodzenie);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.NrTelefonuTxt);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.NazwiskoTxt);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.ImieTxt);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.IdPracownikaTxt);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSzukaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PracownicyAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PracownicyAdmin";
            this.Load += new System.EventHandler(this.PracownicyAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSzukaj;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox WynagrodzenieTxt;
        private System.Windows.Forms.Label lblWynagrodzenie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox NrTelefonuTxt;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox NazwiskoTxt;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox ImieTxt;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox IdPracownikaTxt;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.TextBox AdresTxt;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox MailTxt;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblWer;
    }
}