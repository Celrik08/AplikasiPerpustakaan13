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
    public partial class DataSiswa : Form
    {
        private int roleId;
        private int selectedRowIndex = -1;
        private bool isTambahMode = true;
        public DataSiswa(int roleId)
        {
            InitializeComponent();
            //this.FormClosing += DataSiswa_FormClosing;
            this.roleId = roleId;
        }

        private void TextNisn_KeyPress(object sender, KeyPressEventArgs e)
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
                ComboKelas.Focus();
            }
        }

        private void ComboKelas_KeyPress(object sender, KeyPressEventArgs e)
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
                //PerfromSiswa();
            }
        }

        private void PerformKelas()
        {
            Connect.conn.Open();
            ComboKelas.Items.Clear();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_kelas", Connect.conn);
            Connect.reader = Connect.cmd.ExecuteReader();
            while (Connect.reader.Read())
            {
                ComboKelas.Items.Add(Connect.reader[0]);
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void ComboKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menampilkan data kelas
            Connect.conn.Open();
            Connect.cmd = new SqlCommand("SELECT * FROM tb_kelas WHERE id_kelas = @id_kelas", Connect.conn);
            Connect.cmd.Parameters.AddWithValue("@id_kelas", ComboKelas.Text);

            Connect.reader = Connect.cmd.ExecuteReader();
            if (Connect.reader.Read())
            {
                //TextMapel.Text = Connect.reader["nama_mapel"].ToString();
            }
            Connect.reader.Close();
            Connect.conn.Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            //PerfromSiswa();
        }
    }
}
