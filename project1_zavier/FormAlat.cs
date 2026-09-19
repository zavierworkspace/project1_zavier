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
    public partial class FormAlat : Form
    {
        public FormAlat()
        {
            InitializeComponent();
        }

        private void FormAlat_Load(object sender, EventArgs e)
        {
            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM alat";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable data = new DataTable();

                    adapter.Fill(data);

                    dgvAlat.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtKodeAlat.Text == "" ||
                txtNamaAlat.Text == "" ||
                txtJumlah.Text == "" ||
                txtKondisi.Text == "" ||
                txtLokasi.Text == "")
            {
                MessageBox.Show("Semua data alat wajib diisi!");
                return;
            }

            if (!int.TryParse(txtJumlah.Text, out int jumlah))
            {
                MessageBox.Show("Jumlah harus berupa angka!");
                return;
            }

            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO alat
                            (kode_alat, nama_alat, jumlah, kondisi, lokasi)
                            VALUES
                            (@kode, @nama, @jumlah, @kondisi, @lokasi)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@kode", txtKodeAlat.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNamaAlat.Text);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@kondisi", txtKondisi.Text);
                    cmd.Parameters.AddWithValue("@lokasi", txtLokasi.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data alat berhasil disimpan!");

                    txtKodeAlat.Clear();
                    txtNamaAlat.Clear();
                    txtJumlah.Clear();
                    txtKondisi.Clear();
                    txtLokasi.Clear();

                    FormAlat_Load(null, null);
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

        private void dgvAlat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNamaAlat.Text = dgvAlat.Rows[e.RowIndex].Cells["nama_alat"].Value.ToString();
                txtJumlah.Text = dgvAlat.Rows[e.RowIndex].Cells["jumlah"].Value.ToString();
            }
        }
    }
}
