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
    public partial class FormPeminjaman : Form
    {

        public FormPeminjaman()
        {
            InitializeComponent();
        }

        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    // ComboBox Peminjam
                    string queryPeminjam = "SELECT id_peminjam, nama_peminjam FROM peminjam";

                    MySqlDataAdapter adapterPeminjam =
                        new MySqlDataAdapter(queryPeminjam, conn);

                    DataTable dataPeminjam = new DataTable();
                    adapterPeminjam.Fill(dataPeminjam);

                    cmbPeminjam.DataSource = dataPeminjam;
                    cmbPeminjam.DisplayMember = "nama_peminjam";
                    cmbPeminjam.ValueMember = "id_peminjam";


                    // ComboBox Alat
                    string queryAlat = "SELECT id_alat, nama_alat FROM alat";

                    MySqlDataAdapter adapterAlat =
                        new MySqlDataAdapter(queryAlat, conn);

                    DataTable dataAlat = new DataTable();
                    adapterAlat.Fill(dataAlat);

                    cmbAlat.DataSource = dataAlat;
                    cmbAlat.DisplayMember = "nama_alat";
                    cmbAlat.ValueMember = "id_alat";




                    // Status
                    cmbStatus.Items.Clear();
                    cmbStatus.Items.Add("Pending");
                    cmbStatus.Items.Add("Disetujui");
                    cmbStatus.Items.Add("Ditolak");
                    cmbStatus.Items.Add("Dipinjam");
                    cmbStatus.Items.Add("Dikembalikan");
                    cmbStatus.Items.Add("Terlambat");

                    cmbStatus.SelectedIndex = 0;

                    // TAMPILKAN DATA TRANSAKSI
                    string queryPeminjaman = @"
                     SELECT 
                         p.id_peminjaman,
                         pm.nama_peminjam,
                         a.nama_alat,
                         p.jumlah,
                         p.tanggal_pinjam,
                         p.tanggal_kembali,
                         p.status,
                         p.catatan
                     FROM peminjaman p
                     INNER JOIN peminjam pm 
                         ON p.id_peminjam = pm.id_peminjam
                     INNER JOIN alat a 
                         ON p.id_alat = a.id_alat";

                    MySqlDataAdapter adapterPeminjaman =
                        new MySqlDataAdapter(queryPeminjaman, conn);

                    DataTable dataPeminjaman = new DataTable();

                    adapterPeminjaman.Fill(dataPeminjaman);

                    dgvPeminjaman.DataSource = dataPeminjaman;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbPeminjam.SelectedValue == null ||
                cmbAlat.SelectedValue == null ||
                txtJumlah.Text == "")
            {
                MessageBox.Show("Peminjam, alat, dan jumlah wajib diisi!");
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

                    string query = @"INSERT INTO peminjaman
                            (id_peminjam, id_alat, jumlah,
                             tanggal_pinjam, tanggal_kembali,
                             status, catatan)
                            VALUES
                            (@peminjam, @alat, @jumlah,
                             @tgl_pinjam, @tgl_kembali,
                             @status, @catatan)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@peminjam", cmbPeminjam.SelectedValue);
                    cmd.Parameters.AddWithValue("@alat", cmbAlat.SelectedValue);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@tgl_pinjam", dtpTanggalPinjam.Value.Date);
                    cmd.Parameters.AddWithValue("@tgl_kembali", dtpTanggalKembali.Value.Date);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@catatan", txtCatatan.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data peminjaman berhasil disimpan!");

                    txtJumlah.Clear();
                    txtCatatan.Clear();

                    FormPeminjaman_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan peminjaman: " + ex.Message);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbPeminjam.Text = dgvPeminjaman.Rows[e.RowIndex]
                    .Cells["nama_peminjam"].Value.ToString();

                cmbAlat.Text = dgvPeminjaman.Rows[e.RowIndex]
                    .Cells["nama_alat"].Value.ToString();

                txtJumlah.Text = dgvPeminjaman.Rows[e.RowIndex]
                    .Cells["jumlah"].Value.ToString();
            }
        }

        private void cmbPeminjam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
