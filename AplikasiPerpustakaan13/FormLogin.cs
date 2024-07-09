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
    public partial class FormLogin : Form
    {
        private string loggedInUsername;
        private string loggedInUserId;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextPassword.Focus();
                e.Handled = true;
            }
        }

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromLogin();
            }
        }

        private void BtnKlik_Click(object sender, EventArgs e)
        {
            PerfromLogin();
        }

        private void PerfromLogin()
        {
            string username = TextUser.Text;
            string password = TextPassword.Text;

            // Cek jika inputan user memiliki spasi di awal atau di akhir
            if (username != username.Trim() || password != password.Trim())
            {
                MessageBox.Show("Username atau password tidak boleh memiliki spasi di awal atau di akhir", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            username = username.Trim();
            password = password.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT * FROM tb_user WHERE username COLLATE Latin1_General_BIN = @username AND password COLLATE Latin1_General_BIN = @password";

            using (SqlCommand cmd = new SqlCommand(query, Connect.conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                Connect.conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        loggedInUsername = reader["username"].ToString();
                        loggedInUserId = reader["id_username"].ToString();
                        int roleId = int.Parse(reader["id_role"].ToString());

                        // Buka MenuUtama dengan roleId, logInUsername, dan logInUserId
                        MenuUtama menuUtama = new MenuUtama(roleId, loggedInUsername, loggedInUserId);
                        menuUtama.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextUser.Text = "";
                        TextPassword.Text = "";
                    }
                }

                Connect.conn.Close();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '*';
        }

        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassword.Checked)
            {
                TextPassword.PasswordChar = '\0'; // Menampilkan teks biasa (tanpa karakter tersembunyi)
            }
            else
            {
                TextPassword.PasswordChar = '*'; // Menggunakan karakter tersembunyi (bintang)
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
