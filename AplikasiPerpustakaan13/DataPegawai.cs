using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPerpustakaan13
{
    public partial class DataPegawai : Form
    {
        private int roleId;
        private string loggedInUsername;
        private string loggedInUserId;
        private int selectedRowIndex = -1;
        private bool isTambahMode = true;
        public DataPegawai(int roleId)
        {
            InitializeComponent();
            this.FormClosing += DataPegawai_FormClosing;
            this.roleId = roleId;
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                RadioLaki.Focus();
            }
        }

        private void RadioLaki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                RadioPerempuan.Focus();
            }
        }

        private void RadioPerempuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextAlamat.Focus();
            }
        }

        private void TextAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextNo.Focus();
            }
        }

        private void TextNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextTempat.Focus();
            }
        }

        private void TextTempat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                Date.Focus();
            }
        }

        private void Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromPegawai();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerfromPegawai();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(TextNama.Text) ||
                (RadioLaki.Checked == false && RadioPerempuan.Checked == false) ||
                string.IsNullOrWhiteSpace(TextAlamat.Text) ||
                string.IsNullOrWhiteSpace(TextNo.Text) ||
                string.IsNullOrWhiteSpace(TextTempat.Text) ||
                Date.Value == DateTime.Today) // Cek apakah tanggal lahir sama dengan hari ini
            {
                MessageBox.Show("Semua kolom harus diisi dan tanggal lahir harus valid", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void PerfromPegawai()
        {
            if (!IsFormValid())
            {
                return;
            }

            string nama = TextNama.Text;
            string jenis = RadioLaki.Checked ? "Laki-Laki" : "Perempuan";
            string alamat = TextAlamat.Text;
            string nomor = TextNo.Text;
            string tempat = TextTempat.Text;
            DateTime tanggal = Date.Value; // Ambil nilai dari DateTimePicker

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_pegawai (nama_pegawai, jenis_kelamin, alamat, no_hp, tempat_lahir, tanggal_lahir) VALUES (@nama_pegawai, @jenis_kelamin, @alamat, @no_hp, @tempat_lahir, @tanggal_lahir)";
                cmd.Parameters.AddWithValue("nama_pegawai", nama);
                cmd.Parameters.AddWithValue("@jenis_kelamin", jenis);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@no_hp", nomor);
                cmd.Parameters.AddWithValue("@tempat_lahir", tempat);
                cmd.Parameters.AddWithValue("@tanggal_lahir", tanggal);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Set nilai kontrol kembali ke nilai default
            TextNama.Clear();
            RadioLaki.Checked = false;
            RadioPerempuan.Checked = false;
            TextAlamat.Clear();
            TextNo.Clear();
            TextTempat.Clear();
            Date.Value = DateTime.Today;

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();
        }

        private void DataPegawai_Load(object sender, EventArgs e)
        {
            // Menetapkan format untuk kolom tanggal_lahir
            if (Data_Pegawai.Columns["tanggal"] != null)
            {
                Data_Pegawai.Columns["tanggal"].DefaultCellStyle.Format = "dd-MM-yyyy";
            }
            LoadDataToDataGridView();
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
        {
            Data_Pegawai.Rows.Clear();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id_pegawai, nama_pegawai, jenis_kelamin, alamat, no_hp, tempat_lahir, tanggal_lahir FROM tb_pegawai";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id_pegawai"].ToString();
                        string nama = reader["nama_pegawai"].ToString();
                        string jenis = reader["jenis_kelamin"].ToString();
                        string alamat = reader["alamat"].ToString();
                        string nomor = reader["no_hp"].ToString();
                        string tempat = reader["tempat_lahir"].ToString();
                        // Memastikan tanggal diambil sebagai DateTime
                        DateTime tanggal = reader.GetDateTime(reader.GetOrdinal("tanggal_lahir"));

                        // Format tanggal sesuai kebutuhan, misalnya "dd-MM-yyyy"
                        string formattedTanggal = tanggal.ToString("dd-MM-yyyy");

                        Data_Pegawai.Rows.Add(id, nama, jenis, alamat, nomor, tempat, tanggal);
                    }
                }
            }
            Connect.conn.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (isTambahMode)
            {
                EnableInputControls();
                BtnTambah.Text = "Clear";
            }
        }

        private void DataPegawai_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset ke mode "Tambah" saat form ditutup
            BtnTambah.Text = "Tambah";
            isTambahMode = true;
        }

        private void Data_Pegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik null sebelum mengambil nilai
                if (Data_Pegawai.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextPegawai.Text = Data_Pegawai.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextPegawai.Text = string.Empty;
                }

                if (Data_Pegawai.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextNama.Text = Data_Pegawai.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextNama.Text = string.Empty;
                }

                if (Data_Pegawai.Rows[selectedRowIndex].Cells[2].Value != null &&
                    Data_Pegawai.Rows[selectedRowIndex].Cells[2].Value != DBNull.Value)
                {
                    string jenisKelamin = Data_Pegawai.Rows[selectedRowIndex].Cells[2].Value.ToString();
                    if (jenisKelamin.Equals("Laki-Laki", StringComparison.OrdinalIgnoreCase))
                    {
                        RadioLaki.Checked = true;
                        RadioPerempuan.Checked = false;
                    }
                    else if (jenisKelamin.Equals("Perempuan", StringComparison.OrdinalIgnoreCase))
                    {
                        RadioLaki.Checked = false;
                        RadioPerempuan.Checked = true;
                    }
                    else
                    {
                        RadioLaki.Checked = false;
                        RadioPerempuan.Checked = false;
                    }
                }
                else
                {
                    RadioLaki.Checked = false;
                    RadioPerempuan.Checked = false;
                }

                if (Data_Pegawai.Rows[selectedRowIndex].Cells[3].Value != null)
                {
                    TextAlamat.Text = Data_Pegawai.Rows[selectedRowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    TextAlamat.Text = string.Empty;
                }

                if (Data_Pegawai.Rows[selectedRowIndex].Cells[4].Value != null)
                {
                    TextNo.Text = Data_Pegawai.Rows[selectedRowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    TextNo.Text = string.Empty;
                }

                if (Data_Pegawai.Rows[selectedRowIndex].Cells[5].Value != null)
                {
                    TextTempat.Text = Data_Pegawai.Rows[selectedRowIndex].Cells[5].Value.ToString();
                }
                else
                {
                    TextTempat.Text = string.Empty;
                }

                // Ambil nilai tanggal dari kolom "tanggal_lahir"
                if (Data_Pegawai.Rows[selectedRowIndex].Cells[6].Value != null)
                {
                    DateTime tanggalLahir;
                    if (DateTime.TryParse(Data_Pegawai.Rows[selectedRowIndex].Cells[6].Value.ToString(), out tanggalLahir))
                    {
                        Date.Value = tanggalLahir;
                    }
                }
                else
                {
                    // Set tanggal default jika nilai tanggal kosong
                    Date.Value = DateTime.Today;
                }

                BtnSimpan.Enabled = false;
                BtnUbah.Enabled = true;

                // Mengatifkan kolom "Hapus"
                EnableDeleteColumn(true);
            }
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Pilih baris yang ingin diubah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = TextPegawai.Text;
            string nama = TextNama.Text;
            string jenis = RadioLaki.Checked ? "Laki-Laki" : (RadioPerempuan.Checked ? "Perempuan" : "");
            string alamat = TextAlamat.Text;
            string nomor = TextNo.Text;
            string tempat = TextTempat.Text;
            DateTime tanggal = Date.Value; // Ambil nilai dari DateTimePicker

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(jenis) || string.IsNullOrWhiteSpace(alamat) || string.IsNullOrWhiteSpace(nomor) || string.IsNullOrWhiteSpace(tempat) || Date.Value == DateTime.Today)
            {
                MessageBox.Show("Semua kolom harus diisi, termasuk memilih jenis kelamin, dan memilih tanggal lahir", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_pegawai SET nama_pegawai = @nama_pegawai, jenis_kelamin = @jenis_kelamin, alamat = @alamat, no_hp = @no_hp, tempat_lahir = @tempat_lahir, tanggal_lahir = @tanggal_lahir WHERE id_pegawai = @id_pegawai";
                cmd.Parameters.AddWithValue("@id_pegawai", id);
                cmd.Parameters.AddWithValue("@nama_pegawai", nama);
                cmd.Parameters.AddWithValue("@jenis_kelamin", jenis);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@no_hp", nomor);
                cmd.Parameters.AddWithValue("@tempat_lahir", tempat);
                cmd.Parameters.AddWithValue("@tanggal_lahir", tanggal);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextPegawai.Clear();
            TextNama.Clear();
            RadioLaki.Checked = false;
            RadioPerempuan.Checked = false;
            TextAlamat.Clear();
            TextNo.Clear();
            TextTempat.Clear();
            Date.Value = DateTime.Today;

            // Enable tombol Simpan dan Disable tombol Ubah, Hapus
            selectedRowIndex = -1;
            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = false;
            EnableDeleteColumn(false);

            LoadDataToDataGridView();
        }

        private void Data_Pegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Pegawai.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Periksa apakah nilai di kolom "id_pegawai" tidak null sebelum mengakses propertinya
                    string id = Data_Pegawai.Rows[e.RowIndex].Cells["Pegawai"]?.Value?.ToString();

                    if (id != null)
                    {
                        Connect.conn.Open();
                        using (SqlCommand cmd = Connect.conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tb_pegawai WHERE id_pegawai = @id_pegawai";
                            cmd.Parameters.AddWithValue("@id_pegawai", id);
                            cmd.ExecuteNonQuery();
                        }
                        Connect.conn.Close();

                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TextPegawai.Clear();
                        TextNama.Clear();
                        RadioLaki.Checked = false;
                        RadioPerempuan.Checked = false;
                        TextAlamat.Clear();
                        TextNo.Clear();
                        TextTempat.Clear();
                        Date.Value = DateTime.Today;

                        selectedRowIndex = -1;

                        LoadDataToDataGridView();
                    }
                    else
                    {
                        // Pengguna memilih No, tidak melakukan apa-apa
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MenuUtama MU = new MenuUtama(roleId, loggedInUsername, loggedInUserId);
            MU.Show();
            Hide();
        }

        private void EnableDeleteColumn(bool enable)
        {
            // Mendapatkan indeks kolom "Hapus"
            int deleteColumnIndex = Data_Pegawai.Columns["Hapus"].Index;

            // Mengatur properti ReadOnly untuk setiap sel di kolom "Hapus"
            foreach (DataGridViewRow row in Data_Pegawai.Rows)
            {
                if (row.Cells[deleteColumnIndex].Value != null)
                {
                    // Mengatur properti ReadOnly sesuai kebutuhan
                    row.Cells[deleteColumnIndex].ReadOnly = !enable;
                }
            }
        }

        private void EnableInputControls()
        {
            TextPegawai.Clear();
            TextNama.Clear();
            RadioLaki.Checked = false;
            RadioPerempuan.Checked = false;
            TextAlamat.Clear();
            TextNo.Clear();
            TextTempat.Clear();

            TextNama.Enabled = true;
            RadioLaki.Enabled = true;
            RadioPerempuan.Enabled = true;
            TextAlamat.Enabled = true;
            TextNo.Enabled = true;
            TextTempat.Enabled = true;
            Date.Enabled = true;

            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = true;
            EnableDeleteColumn(true);
        }

        private void DisableInputControls()
        {
            TextPegawai.Enabled = false;
            TextNama.Enabled = false;
            RadioLaki.Enabled = false;
            RadioPerempuan.Enabled = false;
            TextAlamat.Enabled = false;
            TextNo.Enabled = false;
            TextTempat.Enabled = false;
            Date.Enabled = false;

            BtnSimpan.Enabled = false;
            BtnUbah.Enabled = false;
            EnableDeleteColumn(false);
        }
    }
}
