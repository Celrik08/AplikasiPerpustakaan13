using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPerpustakaan13
{
    public partial class Peminjaman : Form
    {
        private int roleId;
        private string loggedInUsername;
        private string loggedInUserId;
        private int selectedRowIndex = -1;
        private System.Windows.Forms.Timer timer; // Gunakan System.Windows.Forms.Timer secara eksplisit
        public Peminjaman(int roleId, string loggedInUsername, string loggedInUserId)
        {
            InitializeComponent();
            this.roleId = roleId;
            this.loggedInUsername = loggedInUsername;
            this.loggedInUserId = loggedInUserId;
        }

        private void noOtomatis()
        {
            string query = "SELECT * FROM tb_pinjam WHERE id_pinjam IN (SELECT MAX (id_pinjam) FROM tb_pinjam)";
            string urutanKode;
            long hitung;

            using (SqlCommand cmd = new SqlCommand(query, Connect.conn))
            {
                Connect.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() && dr.HasRows)
                {
                    hitung = long.Parse(dr.GetString(0).Substring(dr.GetString(0).Length - 9)) + 1;
                    urutanKode = "PJM" + DateTime.Now.ToString("ddMMyy") + hitung.ToString("D3");
                }
                else
                {
                    urutanKode = "PJM" + DateTime.Now.ToString("ddMMyy") + "001";
                }
                dr.Close();
                Connect.conn.Close();
            }

            TextId.Text = urutanKode;
        }


        private void PerformSiswa()
        {
            ComboNisn.Items.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT nisn, nama_siswa FROM tb_siswa", Connect.conn))
            {
                Connect.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Siswa siswa = new Siswa
                    {
                        NISN = reader["nisn"].ToString(),
                        NamaSiswa = reader["nama_siswa"].ToString()
                    };
                    ComboNisn.Items.Add(siswa);

                }
                reader.Close();
                Connect.conn.Close();
            }
        }

        private void ComboNisn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboNisn.SelectedItem is Siswa selectedSiswa)
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tb_siswa WHERE nisn = @nisn", Connect.conn))
                {
                    cmd.Parameters.AddWithValue("@nisn", selectedSiswa.NISN);
                    Connect.conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextSiswa.Text = reader["nama_siswa"].ToString();
                        // Isi kolom data lain seperlunya
                    }
                    reader.Close();
                    Connect.conn.Close();
                }
            }
        }

        private void PerformBuku()
        {
            ComboIsbn.Items.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT isbn, judul_buku FROM tb_buku", Connect.conn))
            {
                Connect.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Buku buku = new Buku
                    {
                        ISBN = reader["isbn"].ToString(),
                        JudulBuku = reader["judul_buku"].ToString()
                    };
                    ComboIsbn.Items.Add(buku);

                }
                reader.Close();
                Connect.conn.Close();
            }
        }

        private void ComboIsbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboIsbn.SelectedItem is Buku selectedBuku)
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tb_buku WHERE isbn = @isbn", Connect.conn))
                {
                    cmd.Parameters.AddWithValue("@isbn", selectedBuku.ISBN);
                    Connect.conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBuku.Text = reader["judul_buku"].ToString();
                        // Isi kolom data lain seperlunya
                    }
                    reader.Close();
                    Connect.conn.Close();
                }
            }
        }

        private void UpdateTextJam(object sender, EventArgs e)
        {
            TextJam.Text = DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer(); // Gunakan System.Windows.Forms.Timer secara eksplisit
            timer.Interval = 1000; // Setel interval ke 1 detik (1000 ms)
            timer.Tick += new EventHandler(UpdateTextJam);
            timer.Start();
        }

        private void ComboNisn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextSiswa.Focus();
            }
        }

        private void TextSiswa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                ComboIsbn.Focus();
            }
        }

        private void ComboIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextJumlah.Focus();
            }
        }

        private void TextJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromPeminjaman();
            }
        }

        private void BtnKlik_Click(object sender, EventArgs e)
        {
            PerfromPeminjaman();
        }

        private void PerfromPeminjaman()
        {
            if (ComboNisn.SelectedItem != null && ComboIsbn.SelectedItem != null && !String.IsNullOrEmpty(TextJumlah.Text))
            {
                Siswa selectedSiswa = ComboNisn.SelectedItem as Siswa;
                Buku selectedBuku = ComboIsbn.SelectedItem as Buku;

                if (selectedSiswa != null && selectedBuku != null)
                {
                    using (SqlCommand checkPinjamCmd = new SqlCommand("SELECT COUNT(*) FROM tb_pinjam WHERE id_pinjam = @id_pinjam", Connect.conn))
                    {
                        checkPinjamCmd.Parameters.AddWithValue("@id_pinjam", TextId.Text);
                        Connect.conn.Open();
                        int count = (int)checkPinjamCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            using (SqlCommand insertPinjamCmd = new SqlCommand("INSERT INTO tb_pinjam (id_pinjam, tanggal_pinjam, nisn, banyak_buku, id_status, id_username) VALUES (@id_pinjam, @tanggal_pinjam, @nisn, @banyak_buku, @id_status, @id_username)", Connect.conn))
                            {
                                insertPinjamCmd.Parameters.AddWithValue("@id_pinjam", TextId.Text);
                                DateTime tanggalPinjam = DateTime.ParseExact(TextTanggal.Text + " " + TextJam.Text, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                                insertPinjamCmd.Parameters.AddWithValue("@tanggal_pinjam", tanggalPinjam);
                                insertPinjamCmd.Parameters.AddWithValue("@nisn", selectedSiswa.NISN);
                                insertPinjamCmd.Parameters.AddWithValue("@banyak_buku", 0); // Inisialisasi banyak_buku dengan nilai 0
                                insertPinjamCmd.Parameters.AddWithValue("@id_status", 1);
                                insertPinjamCmd.Parameters.AddWithValue("@id_username", loggedInUserId);
                                insertPinjamCmd.ExecuteNonQuery();
                            }
                        }

                        // Masukkan ke detail_pinjam
                        using (SqlCommand insertDetailCmd = new SqlCommand("INSERT INTO tb_detail_pinjam (id_pinjam, isbn, qty) VALUES (@id_pinjam, @isbn, @qty)", Connect.conn))
                        {
                            insertDetailCmd.Parameters.AddWithValue("@id_pinjam", TextId.Text);
                            insertDetailCmd.Parameters.AddWithValue("@isbn", selectedBuku.ISBN);
                            insertDetailCmd.Parameters.AddWithValue("@qty", int.Parse(TextJumlah.Text));
                            insertDetailCmd.ExecuteNonQuery();
                        }

                        // Update stok di tb_buku
                        using (SqlCommand updateCmd = new SqlCommand("UPDATE tb_buku SET stok = stok - @qty WHERE isbn = @isbn", Connect.conn))
                        {
                            updateCmd.Parameters.AddWithValue("@qty", int.Parse(TextJumlah.Text));
                            updateCmd.Parameters.AddWithValue("@isbn", selectedBuku.ISBN);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Load data ke DataGridView dan perbarui jumlah total
                        LoadDataToDataGridView();

                        Connect.conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mohon lengkapi semua data.");
                }
            }
        }

        private bool autoGenerated = false; // Menyimpan status apakah nomor otomatis sudah dihasilkan atau belum

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            if (!autoGenerated)
            {
                noOtomatis();
                autoGenerated = true; // Set status menjadi true setelah nomor otomatis dihasilkan
            }

            TextTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            PerformSiswa();
            InitializeTimer(); // Inisialisasi Timer
            TextUser.Text = $"{loggedInUserId} - {loggedInUsername}";
            PerformBuku();
            TextBanyak.Text = "0";
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            // Kosongkan DataGridView terlebih dahulu
            DataPeminjaman.Rows.Clear();

            // Tulis kueri SQL Anda untuk mengambil data dari nilai
            string query = "SELECT tb_buku.judul_buku, tb_detail_pinjam.qty " +
                            "FROM tb_detail_pinjam " +
                            "JOIN tb_buku ON tb_detail_pinjam.isbn = tb_buku.isbn";

            // Buat SqlCommand untuk menjalankan kueri
            using (SqlCommand cmd = new SqlCommand(query, Connect.conn))
            {
                Connect.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string judul = reader["judul_buku"].ToString();
                    string qty = reader["qty"].ToString();
                    DataPeminjaman.Rows.Add(judul, qty);
                }
                reader.Close();
                Connect.conn.Close();

            }

            // Perbarui jumlah total di kolom TextBanyak
            UpdateTextBanyak();
        }

        private void UpdateTextBanyak()
        {
            int totalQty = 0;

            // Ulangi setiap baris di DataPeminjaman dan jumlahkan nilai qty
            foreach (DataGridViewRow row in DataPeminjaman.Rows)
            {
                if (row.Cells["Banyak"] != null && row.Cells["Banyak"].Value != null)
                {
                    totalQty += Convert.ToInt32(row.Cells["Banyak"].Value);
                }
            }

            // Perbarui kotak teks TextBanyak dengan jumlah total
            TextBanyak.Text = totalQty.ToString();
        }

        // Pastikan UpdateTextBanyak dipanggil setiap kali DataPeminjaman berubah
        private void DataPeminjaman_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateTextBanyak();
        }

        private void DataPeminjaman_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTextBanyak();
        }
    }
}
