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
    public partial class FormApproval : Form
    {
        public FormApproval()
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

                    string query = @"
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

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable data = new DataTable();

                    adapter.Fill(data);

                    dgvApproval.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void UbahStatus(string status)
        {
            if (dgvApproval.CurrentRow == null)
            {
                MessageBox.Show("Pilih data peminjaman terlebih dahulu!");
                return;
            }

            int id = Convert.ToInt32(
                dgvApproval.CurrentRow.Cells["id_peminjaman"].Value
            );

            Koneksi koneksi = new Koneksi();

            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"
                UPDATE peminjaman
                SET status=@status, catatan=@catatan
                WHERE id_peminjaman=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@catatan", txtCatatan.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Status berhasil diubah menjadi " + status + "!");

                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah status: " + ex.Message);
            }
        }

        private void FormApproval_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void dgvApproval_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbStatus.Text = dgvApproval.Rows[e.RowIndex]
                    .Cells["status"].Value.ToString();

                txtCatatan.Text = dgvApproval.Rows[e.RowIndex]
                    .Cells["catatan"].Value.ToString();
            }
        }

        private void btnSetujui_Click(object sender, EventArgs e)
        {
            UbahStatus("Disetujui");
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            UbahStatus("Ditolak");
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
