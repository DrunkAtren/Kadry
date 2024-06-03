namespace Kadry
{
    partial class StanowiskaAdmin
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StanowiskoTxt = new System.Windows.Forms.TextBox();
            this.lblDzial = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazwaStanowiskaTxt = new System.Windows.Forms.TextBox();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.OddzialTxt = new System.Windows.Forms.TextBox();
            this.lblOddział = new System.Windows.Forms.Label();
            this.PracownikTxt = new System.Windows.Forms.TextBox();
            this.lblOddzial = new System.Windows.Forms.Label();
            this.lblWer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kadry.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(484, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kadry.Properties.Resources.x;
            this.pictureBox3.Location = new System.Drawing.Point(1059, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(-124, 468);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1202, 75);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // StanowiskoTxt
            // 
            this.StanowiskoTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StanowiskoTxt.Location = new System.Drawing.Point(226, 75);
            this.StanowiskoTxt.Name = "StanowiskoTxt";
            this.StanowiskoTxt.ReadOnly = true;
            this.StanowiskoTxt.Size = new System.Drawing.Size(215, 27);
            this.StanowiskoTxt.TabIndex = 94;
            // 
            // lblDzial
            // 
            this.lblDzial.AutoSize = true;
            this.lblDzial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDzial.Location = new System.Drawing.Point(93, 78);
            this.lblDzial.Name = "lblDzial";
            this.lblDzial.Size = new System.Drawing.Size(127, 19);
            this.lblDzial.TabIndex = 93;
            this.lblDzial.Text = "Nr Stanowiska";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(484, 75);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.Location = new System.Drawing.Point(656, 78);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 19);
            this.lblSearch.TabIndex = 91;
            this.lblSearch.Text = "Szukaj";
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSzukaj.Location = new System.Drawing.Point(726, 75);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.Size = new System.Drawing.Size(296, 27);
            this.txtSzukaj.TabIndex = 9;
            this.txtSzukaj.TextChanged += new System.EventHandler(this.txtSzukaj_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(324, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(324, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(167, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 34);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(167, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(484, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 294);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // NazwaStanowiskaTxt
            // 
            this.NazwaStanowiskaTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaStanowiskaTxt.Location = new System.Drawing.Point(226, 214);
            this.NazwaStanowiskaTxt.Name = "NazwaStanowiskaTxt";
            this.NazwaStanowiskaTxt.Size = new System.Drawing.Size(215, 27);
            this.NazwaStanowiskaTxt.TabIndex = 3;
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanowisko.Location = new System.Drawing.Point(57, 217);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(163, 19);
            this.lblStanowisko.TabIndex = 83;
            this.lblStanowisko.Text = "Nazwa Stanowiska";
            // 
            // OddzialTxt
            // 
            this.OddzialTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OddzialTxt.Location = new System.Drawing.Point(226, 167);
            this.OddzialTxt.Name = "OddzialTxt";
            this.OddzialTxt.Size = new System.Drawing.Size(215, 27);
            this.OddzialTxt.TabIndex = 2;
            // 
            // lblOddział
            // 
            this.lblOddział.AutoSize = true;
            this.lblOddział.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOddział.Location = new System.Drawing.Point(111, 170);
            this.lblOddział.Name = "lblOddział";
            this.lblOddział.Size = new System.Drawing.Size(104, 19);
            this.lblOddział.TabIndex = 81;
            this.lblOddział.Text = "Nr Oddziału";
            // 
            // PracownikTxt
            // 
            this.PracownikTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PracownikTxt.Location = new System.Drawing.Point(226, 119);
            this.PracownikTxt.Name = "PracownikTxt";
            this.PracownikTxt.Size = new System.Drawing.Size(215, 27);
            this.PracownikTxt.TabIndex = 1;
            // 
            // lblOddzial
            // 
            this.lblOddzial.AutoSize = true;
            this.lblOddzial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOddzial.Location = new System.Drawing.Point(93, 122);
            this.lblOddzial.Name = "lblOddzial";
            this.lblOddzial.Size = new System.Drawing.Size(128, 19);
            this.lblOddzial.TabIndex = 79;
            this.lblOddzial.Text = "ID Pracownika";
            // 
            // lblWer
            // 
            this.lblWer.AutoSize = true;
            this.lblWer.BackColor = System.Drawing.Color.Gray;
            this.lblWer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWer.Location = new System.Drawing.Point(945, 518);
            this.lblWer.Name = "lblWer";
            this.lblWer.Size = new System.Drawing.Size(133, 13);
            this.lblWer.TabIndex = 98;
            this.lblWer.Text = "/////////////////////";
            // 
            // StanowiskaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 540);
            this.Controls.Add(this.lblWer);
            this.Controls.Add(this.StanowiskoTxt);
            this.Controls.Add(this.lblDzial);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSzukaj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NazwaStanowiskaTxt);
            this.Controls.Add(this.lblStanowisko);
            this.Controls.Add(this.OddzialTxt);
            this.Controls.Add(this.lblOddział);
            this.Controls.Add(this.PracownikTxt);
            this.Controls.Add(this.lblOddzial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StanowiskaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StanowiskaAdmin";
            this.Load += new System.EventHandler(this.StanowiskaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox StanowiskoTxt;
        private System.Windows.Forms.Label lblDzial;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSzukaj;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NazwaStanowiskaTxt;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.TextBox OddzialTxt;
        private System.Windows.Forms.Label lblOddział;
        private System.Windows.Forms.TextBox PracownikTxt;
        private System.Windows.Forms.Label lblOddzial;
        private System.Windows.Forms.Label lblWer;
    }
}