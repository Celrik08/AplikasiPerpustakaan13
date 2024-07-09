namespace AplikasiPerpustakaan13
{
    partial class Peminjaman
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextTanggal = new TextBox();
            TextId = new TextBox();
            TextSiswa = new TextBox();
            label7 = new Label();
            label8 = new Label();
            TextBuku = new TextBox();
            TextJumlah = new TextBox();
            label9 = new Label();
            BtnKlik = new Button();
            DataPeminjaman = new DataGridView();
            ISBN = new DataGridViewTextBoxColumn();
            Banyak = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            BtnBack = new Button();
            label4 = new Label();
            label10 = new Label();
            ComboNisn = new ComboBox();
            ComboIsbn = new ComboBox();
            TextUser = new TextBox();
            label11 = new Label();
            TextJam = new TextBox();
            TextBanyak = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataPeminjaman).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1923, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 1;
            label1.Text = "Peminjaman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Id Pinjam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 100);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 2;
            label3.Text = "Tanggal Transaksi";
            // 
            // TextTanggal
            // 
            TextTanggal.Location = new Point(168, 97);
            TextTanggal.Name = "TextTanggal";
            TextTanggal.Size = new Size(151, 28);
            TextTanggal.TabIndex = 3;
            // 
            // TextId
            // 
            TextId.Location = new Point(168, 59);
            TextId.Name = "TextId";
            TextId.Size = new Size(151, 28);
            TextId.TabIndex = 7;
            // 
            // TextSiswa
            // 
            TextSiswa.Location = new Point(486, 92);
            TextSiswa.Name = "TextSiswa";
            TextSiswa.Size = new Size(151, 28);
            TextSiswa.TabIndex = 8;
            TextSiswa.KeyPress += TextSiswa_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 170);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 12;
            label7.Text = "ISBN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(270, 170);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 13;
            label8.Text = "Nama Buku";
            // 
            // TextBuku
            // 
            TextBuku.Location = new Point(372, 167);
            TextBuku.Name = "TextBuku";
            TextBuku.Size = new Size(151, 28);
            TextBuku.TabIndex = 14;
            // 
            // TextJumlah
            // 
            TextJumlah.Location = new Point(653, 167);
            TextJumlah.Name = "TextJumlah";
            TextJumlah.Size = new Size(151, 28);
            TextJumlah.TabIndex = 16;
            TextJumlah.KeyPress += TextJumlah_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(543, 170);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 15;
            label9.Text = "Jumlah Buku";
            // 
            // BtnKlik
            // 
            BtnKlik.Location = new Point(817, 166);
            BtnKlik.Name = "BtnKlik";
            BtnKlik.Size = new Size(94, 29);
            BtnKlik.TabIndex = 17;
            BtnKlik.Text = "Klik";
            BtnKlik.UseVisualStyleBackColor = true;
            BtnKlik.Click += BtnKlik_Click;
            // 
            // DataPeminjaman
            // 
            DataPeminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataPeminjaman.Columns.AddRange(new DataGridViewColumn[] { ISBN, Banyak, Hapus });
            DataPeminjaman.Location = new Point(23, 226);
            DataPeminjaman.Name = "DataPeminjaman";
            DataPeminjaman.RowHeadersWidth = 51;
            DataPeminjaman.RowTemplate.Height = 29;
            DataPeminjaman.Size = new Size(1889, 716);
            DataPeminjaman.TabIndex = 18;
            DataPeminjaman.RowsAdded += DataPeminjaman_RowsAdded;
            DataPeminjaman.RowsRemoved += DataPeminjaman_RowsRemoved;
            // 
            // ISBN
            // 
            ISBN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ISBN.HeaderText = "Nama Buku";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            // 
            // Banyak
            // 
            Banyak.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Banyak.HeaderText = "Banyak Buku";
            Banyak.MinimumWidth = 6;
            Banyak.Name = "Banyak";
            // 
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hapus.HeaderText = "";
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Text = "Hapus";
            Hapus.UseColumnTextForButtonValue = true;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(956, 167);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 19;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 100);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 4;
            label4.Text = "Nama Siswa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(381, 62);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 21;
            label10.Text = "NISN";
            // 
            // ComboNisn
            // 
            ComboNisn.FormattingEnabled = true;
            ComboNisn.Location = new Point(486, 59);
            ComboNisn.Name = "ComboNisn";
            ComboNisn.Size = new Size(151, 28);
            ComboNisn.TabIndex = 22;
            ComboNisn.SelectedIndexChanged += ComboNisn_SelectedIndexChanged;
            ComboNisn.KeyPress += ComboNisn_KeyPress;
            // 
            // ComboIsbn
            // 
            ComboIsbn.FormattingEnabled = true;
            ComboIsbn.Location = new Point(79, 168);
            ComboIsbn.Name = "ComboIsbn";
            ComboIsbn.Size = new Size(151, 28);
            ComboIsbn.TabIndex = 23;
            ComboIsbn.SelectedIndexChanged += ComboIsbn_SelectedIndexChanged;
            ComboIsbn.KeyPress += ComboIsbn_KeyPress;
            // 
            // TextUser
            // 
            TextUser.Location = new Point(760, 97);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(151, 28);
            TextUser.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(694, 57);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 26;
            label11.Text = "Jam";
            // 
            // TextJam
            // 
            TextJam.Location = new Point(760, 54);
            TextJam.Name = "TextJam";
            TextJam.Size = new Size(151, 28);
            TextJam.TabIndex = 27;
            // 
            // TextBanyak
            // 
            TextBanyak.Location = new Point(1698, 981);
            TextBanyak.Name = "TextBanyak";
            TextBanyak.Size = new Size(151, 28);
            TextBanyak.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1565, 984);
            label12.Name = "label12";
            label12.Size = new Size(104, 20);
            label12.TabIndex = 29;
            label12.Text = "Jumlah Buku";
            // 
            // Peminjaman
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label12);
            Controls.Add(TextBanyak);
            Controls.Add(TextJam);
            Controls.Add(label11);
            Controls.Add(TextUser);
            Controls.Add(ComboIsbn);
            Controls.Add(ComboNisn);
            Controls.Add(label10);
            Controls.Add(BtnBack);
            Controls.Add(DataPeminjaman);
            Controls.Add(BtnKlik);
            Controls.Add(TextJumlah);
            Controls.Add(label9);
            Controls.Add(TextBuku);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TextSiswa);
            Controls.Add(TextId);
            Controls.Add(label4);
            Controls.Add(TextTanggal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Peminjaman";
            Text = "Peminjaman";
            Load += Peminjaman_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataPeminjaman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextTanggal;
        private Label label5;
        private Label label6;
        private TextBox TextId;
        private TextBox TextSiswa;
        private TextBox textBox4;
        private TextBox TextUser;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private TextBox TextBuku;
        private TextBox TextJumlah;
        private Label label9;
        private Button BtnKlik;
        private DataGridView DataPeminjaman;
        private Button BtnBack;
        private Label label4;
        private Label label10;
        private ComboBox ComboNisn;
        private ComboBox ComboIsbn;
        private TextBox textBox1;
        private Label label11;
        private TextBox TextJam;
        private TextBox TextBanyak;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Banyak;
        private DataGridViewButtonColumn Hapus;
        private Label label12;
    }
}