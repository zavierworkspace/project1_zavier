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
    public partial class FormPeminjam : Form
    {
        public FormPeminjam()
        {
            InitializeComponent();
        }

        private void FormPeminjam_Load(object sender, EventArgs e)
        {
            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM peminjam";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable data = new DataTable();

                    adapter.Fill(data);

                    dgvPeminjam.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtKelas.Text == "")
            {
                MessageBox.Show("Nama dan kelas wajib diisi!");
                return;
            }

            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO peminjam (nama_peminjam, kelas, no_hp) VALUES (@nama, @kelas, @no_hp)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@kelas", txtKelas.Text);
                    cmd.Parameters.AddWithValue("@no_hp", txtNoHp.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil disimpan!");

                    txtNama.Clear();
                    txtKelas.Clear();
                    txtNoHp.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeminjam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNama.Text = dgvPeminjam.Rows[e.RowIndex].Cells["nama_peminjam"].Value.ToString();
                txtKelas.Text = dgvPeminjam.Rows[e.RowIndex].Cells["kelas"].Value.ToString();
                txtKelas.Text = dgvPeminjam.Rows[e.RowIndex].Cells["no_hp"].Value.ToString();
            }
        }
    }
}
