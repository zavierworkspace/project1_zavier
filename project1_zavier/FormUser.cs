using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_zavier
{
    public partial class FormUser : Form
    {

        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            TampilData();
            IsiLevel();
        }

        private void TampilData()
        {
            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT id, nama_lengkap, username, password, level FROM users";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable data = new DataTable();

                    adapter.Fill(data);

                    dgvUser.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan user: " + ex.Message);
            }
        }

        private void IsiLevel()
        {
            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT nama_role FROM roles";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbLevel.Items.Clear();

                    while (reader.Read())
                    {
                        cmbLevel.Items.Add(reader["nama_role"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil role: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaLengkap.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                cmbLevel.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi!");
                return;
            }

            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO users
                (nama_lengkap, username, password, level)
                VALUES
                (@nama, @username, @password, @level)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@level", cmbLevel.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User berhasil disimpan!");

                    txtNamaLengkap.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    cmbLevel.SelectedIndex = -1;

                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan user: " + ex.Message);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNamaLengkap.Text = dgvUser.Rows[e.RowIndex].Cells["nama_lengkap"].Value.ToString();
                txtUsername.Text = dgvUser.Rows[e.RowIndex].Cells["username"].Value.ToString();
                txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells["password"].Value.ToString();
                cmbLevel.Text = dgvUser.Rows[e.RowIndex].Cells["level"].Value.ToString();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow == null)
            {
                MessageBox.Show("Pilih user yang ingin diubah!");
                return;
            }

            int id = Convert.ToInt32(dgvUser.CurrentRow.Cells["id"].Value);

            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE users SET
                nama_lengkap=@nama,
                username=@username,
                password=@password,
                level=@level
                WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@level", cmbLevel.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User berhasil diubah!");

                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah user: " + ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
