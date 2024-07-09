namespace AplikasiPerpustakaan13
{
    partial class DataSiswa
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TextNisn = new TextBox();
            TextSiswa = new TextBox();
            TextAlamat = new TextBox();
            TextNo = new TextBox();
            BtnTambah = new Button();
            BtnSimpan = new Button();
            BtnUbah = new Button();
            BtnBack = new Button();
            Data_Siswa = new DataGridView();
            Nis = new DataGridViewTextBoxColumn();
            Siswa = new DataGridViewTextBoxColumn();
            Kelas = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            No = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            ComboKelas = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Siswa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
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
            label1.Size = new Size(104, 23);
            label1.TabIndex = 1;
            label1.Text = "Data Siswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "NISN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Nama Siswa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Nama Kelas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 197);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 5;
            label6.Text = "No Hp";
            // 
            // TextNisn
            // 
            TextNisn.Location = new Point(117, 60);
            TextNisn.Name = "TextNisn";
            TextNisn.Size = new Size(149, 28);
            TextNisn.TabIndex = 6;
            TextNisn.KeyPress += TextNisn_KeyPress;
            // 
            // TextSiswa
            // 
            TextSiswa.Location = new Point(117, 94);
            TextSiswa.Name = "TextSiswa";
            TextSiswa.Size = new Size(149, 28);
            TextSiswa.TabIndex = 7;
            TextSiswa.KeyPress += TextSiswa_KeyPress;
            // 
            // TextAlamat
            // 
            TextAlamat.Location = new Point(115, 162);
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(151, 28);
            TextAlamat.TabIndex = 9;
            TextAlamat.KeyPress += TextAlamat_KeyPress;
            // 
            // TextNo
            // 
            TextNo.Location = new Point(115, 196);
            TextNo.Name = "TextNo";
            TextNo.Size = new Size(151, 28);
            TextNo.TabIndex = 10;
            TextNo.KeyPress += TextNo_KeyPress;
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(12, 247);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 11;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(117, 247);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 12;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Location = new Point(227, 247);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(94, 29);
            BtnUbah.TabIndex = 13;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(336, 247);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 14;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // Data_Siswa
            // 
            Data_Siswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Siswa.Columns.AddRange(new DataGridViewColumn[] { Nis, Siswa, Kelas, Alamat, No, Hapus });
            Data_Siswa.Location = new Point(12, 301);
            Data_Siswa.Name = "Data_Siswa";
            Data_Siswa.RowHeadersWidth = 51;
            Data_Siswa.RowTemplate.Height = 29;
            Data_Siswa.Size = new Size(1900, 742);
            Data_Siswa.TabIndex = 15;
            // 
            // Nis
            // 
            Nis.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nis.HeaderText = "NISN";
            Nis.MinimumWidth = 6;
            Nis.Name = "Nis";
            // 
            // Siswa
            // 
            Siswa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Siswa.HeaderText = "Nama Siswa";
            Siswa.MinimumWidth = 6;
            Siswa.Name = "Siswa";
            // 
            // Kelas
            // 
            Kelas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kelas.HeaderText = "Nama Kelas";
            Kelas.MinimumWidth = 6;
            Kelas.Name = "Kelas";
            // 
            // Alamat
            // 
            Alamat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Alamat.HeaderText = "Alamat";
            Alamat.MinimumWidth = 6;
            Alamat.Name = "Alamat";
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            No.HeaderText = "No Hp";
            No.MinimumWidth = 6;
            No.Name = "No";
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
            // ComboKelas
            // 
            ComboKelas.FormattingEnabled = true;
            ComboKelas.Location = new Point(115, 128);
            ComboKelas.Name = "ComboKelas";
            ComboKelas.Size = new Size(151, 28);
            ComboKelas.TabIndex = 16;
            ComboKelas.SelectedIndexChanged += ComboKelas_SelectedIndexChanged;
            ComboKelas.KeyPress += ComboKelas_KeyPress;
            // 
            // DataSiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 127, 255);
            ClientSize = new Size(1924, 1055);
            Controls.Add(ComboKelas);
            Controls.Add(Data_Siswa);
            Controls.Add(BtnBack);
            Controls.Add(BtnUbah);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(TextNo);
            Controls.Add(TextAlamat);
            Controls.Add(TextSiswa);
            Controls.Add(TextNisn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "DataSiswa";
            Text = "DataSiswa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Siswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TextNisn;
        private TextBox TextSiswa;
        private TextBox TextAlamat;
        private TextBox TextNo;
        private Button BtnTambah;
        private Button BtnSimpan;
        private Button BtnUbah;
        private Button BtnBack;
        private DataGridView Data_Siswa;
        private ComboBox ComboKelas;
        private DataGridViewTextBoxColumn Nis;
        private DataGridViewTextBoxColumn Siswa;
        private DataGridViewTextBoxColumn Kelas;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn No;
        private DataGridViewButtonColumn Hapus;
    }
}