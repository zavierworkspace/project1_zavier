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
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
        }

        private void TampilData()
        {
            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM roles";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable data = new DataTable();

                    adapter.Fill(data);

                    dgvRole.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaRole.Text == "")
            {
                MessageBox.Show("Nama role wajib diisi!");
                return;
            }

            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO roles (nama_role) VALUES (@nama_role)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_role", txtNamaRole.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Role berhasil disimpan!");

                    txtNamaRole.Clear();

                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan role: " + ex.Message);
            }
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvRole.CurrentRow == null || txtNamaRole.Text == "")
            {
                MessageBox.Show("Pilih data role dan isi nama role!");
                return;
            }

            int id = Convert.ToInt32(dgvRole.CurrentRow.Cells["id"].Value);

            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "UPDATE roles SET nama_role=@nama_role WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama_role", txtNamaRole.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Role berhasil diubah!");

                    txtNamaRole.Clear();
                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah role: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvRole.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            int id = Convert.ToInt32(dgvRole.CurrentRow.Cells["id"].Value);

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus role ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (hasil == DialogResult.No)
                return;

            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM roles WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Role berhasil dihapus!");

                    txtNamaRole.Clear();
                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus role: " + ex.Message);
            }
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNamaRole.Text = dgvRole.Rows[e.RowIndex]
                    .Cells["nama_role"].Value.ToString();
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
