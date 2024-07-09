namespace AplikasiPerpustakaan13
{
    partial class MenuUtama
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
            Menu = new MenuStrip();
            DataMaster = new ToolStripMenuItem();
            DataPegawai = new ToolStripMenuItem();
            DataSiswa = new ToolStripMenuItem();
            DataUser = new ToolStripMenuItem();
            DataPenulis = new ToolStripMenuItem();
            DataPenerbit = new ToolStripMenuItem();
            DataBuku1 = new ToolStripMenuItem();
            DataBuku2 = new ToolStripMenuItem();
            DataTransaksi = new ToolStripMenuItem();
            DataPinjam = new ToolStripMenuItem();
            Peminjaman = new ToolStripMenuItem();
            DataPengembalian = new ToolStripMenuItem();
            Pengembalian = new ToolStripMenuItem();
            DataPengirim = new ToolStripMenuItem();
            DataMasuk = new ToolStripMenuItem();
            TransaksiMasuk = new ToolStripMenuItem();
            RiwayatPinjam = new ToolStripMenuItem();
            Keranjang = new ToolStripMenuItem();
            Back = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            StokIpa = new Label();
            StokMtk = new Label();
            StokBi = new Label();
            StokPkn = new Label();
            User = new Label();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.Gray;
            Menu.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { DataMaster, DataBuku2, DataTransaksi, RiwayatPinjam, Keranjang, Back });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(703, 28);
            Menu.TabIndex = 0;
            Menu.Text = "menuStrip1";
            // 
            // DataMaster
            // 
            DataMaster.DropDownItems.AddRange(new ToolStripItem[] { DataPegawai, DataSiswa, DataUser, DataPenulis, DataPenerbit, DataBuku1 });
            DataMaster.Name = "DataMaster";
            DataMaster.Size = new Size(112, 24);
            DataMaster.Text = "Data Master";
            // 
            // DataPegawai
            // 
            DataPegawai.Name = "DataPegawai";
            DataPegawai.Size = new Size(191, 26);
            DataPegawai.Text = "Data Pegawai";
            DataPegawai.Click += DataPegawai_Click;
            // 
            // DataSiswa
            // 
            DataSiswa.Name = "DataSiswa";
            DataSiswa.Size = new Size(191, 26);
            DataSiswa.Text = "Data Siswa";
            // 
            // DataUser
            // 
            DataUser.Name = "DataUser";
            DataUser.Size = new Size(191, 26);
            DataUser.Text = "Data User";
            // 
            // DataPenulis
            // 
            DataPenulis.Name = "DataPenulis";
            DataPenulis.Size = new Size(191, 26);
            DataPenulis.Text = "Data Penulis";
            // 
            // DataPenerbit
            // 
            DataPenerbit.Name = "DataPenerbit";
            DataPenerbit.Size = new Size(191, 26);
            DataPenerbit.Text = "Data Penerbit";
            // 
            // DataBuku1
            // 
            DataBuku1.Name = "DataBuku1";
            DataBuku1.Size = new Size(191, 26);
            DataBuku1.Text = "Data Buku";
            // 
            // DataBuku2
            // 
            DataBuku2.Name = "DataBuku2";
            DataBuku2.Size = new Size(101, 24);
            DataBuku2.Text = "Data Buku";
            // 
            // DataTransaksi
            // 
            DataTransaksi.DropDownItems.AddRange(new ToolStripItem[] { DataPinjam, Peminjaman, DataPengembalian, Pengembalian, DataPengirim, DataMasuk, TransaksiMasuk });
            DataTransaksi.Name = "DataTransaksi";
            DataTransaksi.Size = new Size(131, 24);
            DataTransaksi.Text = "Data Transaksi";
            // 
            // DataPinjam
            // 
            DataPinjam.Name = "DataPinjam";
            DataPinjam.Size = new Size(259, 26);
            DataPinjam.Text = "Data Pinjam";
            DataPinjam.Click += DataPinjam_Click;
            // 
            // Peminjaman
            // 
            Peminjaman.Name = "Peminjaman";
            Peminjaman.Size = new Size(259, 26);
            Peminjaman.Text = "Peminjaman";
            Peminjaman.Click += Peminjaman_Click;
            // 
            // DataPengembalian
            // 
            DataPengembalian.Name = "DataPengembalian";
            DataPengembalian.Size = new Size(259, 26);
            DataPengembalian.Text = "Data Pengembalian";
            // 
            // Pengembalian
            // 
            Pengembalian.Name = "Pengembalian";
            Pengembalian.Size = new Size(259, 26);
            Pengembalian.Text = "Pengembalian";
            // 
            // DataPengirim
            // 
            DataPengirim.Name = "DataPengirim";
            DataPengirim.Size = new Size(259, 26);
            DataPengirim.Text = "Data Pengirim";
            // 
            // DataMasuk
            // 
            DataMasuk.Name = "DataMasuk";
            DataMasuk.Size = new Size(259, 26);
            DataMasuk.Text = "Data Masuk Buku";
            // 
            // TransaksiMasuk
            // 
            TransaksiMasuk.Name = "TransaksiMasuk";
            TransaksiMasuk.Size = new Size(259, 26);
            TransaksiMasuk.Text = "Transaksi Masuk Buku";
            // 
            // RiwayatPinjam
            // 
            RiwayatPinjam.Name = "RiwayatPinjam";
            RiwayatPinjam.Size = new Size(177, 24);
            RiwayatPinjam.Text = "Riwayat Peminjaman";
            // 
            // Keranjang
            // 
            Keranjang.Name = "Keranjang";
            Keranjang.Size = new Size(97, 24);
            Keranjang.Text = "Keranjang";
            // 
            // Back
            // 
            Back.Name = "Back";
            Back.Size = new Size(60, 24);
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(269, 135);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 1;
            label1.Text = "Menu Utama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(199, 227);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 2;
            label2.Text = "IPA                              :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(199, 257);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 3;
            label3.Text = "MATEMATIKA            :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(199, 287);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 4;
            label4.Text = "BAHASA INDONESIA :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(199, 320);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 5;
            label5.Text = "PKN                            :";
            // 
            // StokIpa
            // 
            StokIpa.AutoSize = true;
            StokIpa.ForeColor = Color.Cornsilk;
            StokIpa.Location = new Point(394, 227);
            StokIpa.Name = "StokIpa";
            StokIpa.Size = new Size(57, 20);
            StokIpa.TabIndex = 6;
            StokIpa.Text = "STOK";
            // 
            // StokMtk
            // 
            StokMtk.AutoSize = true;
            StokMtk.ForeColor = Color.Cornsilk;
            StokMtk.Location = new Point(394, 257);
            StokMtk.Name = "StokMtk";
            StokMtk.Size = new Size(57, 20);
            StokMtk.TabIndex = 7;
            StokMtk.Text = "STOK";
            // 
            // StokBi
            // 
            StokBi.AutoSize = true;
            StokBi.ForeColor = Color.Cornsilk;
            StokBi.Location = new Point(394, 287);
            StokBi.Name = "StokBi";
            StokBi.Size = new Size(57, 20);
            StokBi.TabIndex = 8;
            StokBi.Text = "STOK";
            // 
            // StokPkn
            // 
            StokPkn.AutoSize = true;
            StokPkn.ForeColor = Color.Cornsilk;
            StokPkn.Location = new Point(394, 320);
            StokPkn.Name = "StokPkn";
            StokPkn.Size = new Size(57, 20);
            StokPkn.TabIndex = 9;
            StokPkn.Text = "STOK";
            // 
            // User
            // 
            User.AutoSize = true;
            User.ForeColor = Color.Cornsilk;
            User.Location = new Point(306, 371);
            User.Name = "User";
            User.Size = new Size(43, 20);
            User.TabIndex = 10;
            User.Text = "User";
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 127, 255);
            ClientSize = new Size(703, 563);
            Controls.Add(User);
            Controls.Add(StokPkn);
            Controls.Add(StokBi);
            Controls.Add(StokMtk);
            Controls.Add(StokIpa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Menu);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuUtama";
            Text = "MenuUtama";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem DataMaster;
        private ToolStripMenuItem DataPegawai;
        private ToolStripMenuItem DataSiswa;
        private ToolStripMenuItem DataUser;
        private ToolStripMenuItem DataPenerbit;
        private ToolStripMenuItem DataBuku1;
        private ToolStripMenuItem DataPenulis;
        private ToolStripMenuItem DataBuku2;
        private ToolStripMenuItem DataTransaksi;
        private ToolStripMenuItem DataPinjam;
        private ToolStripMenuItem Peminjaman;
        private ToolStripMenuItem DataPengembalian;
        private ToolStripMenuItem Pengembalian;
        private ToolStripMenuItem DataPengirim;
        private ToolStripMenuItem DataMasuk;
        private ToolStripMenuItem TransaksiMasuk;
        private ToolStripMenuItem RiwayatPinjam;
        private ToolStripMenuItem Back;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label StokIpa;
        private Label StokMtk;
        private Label StokBi;
        private Label StokPkn;
        private ToolStripMenuItem Keranjang;
        private Label User;
    }
}