using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1_zavier
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnPeminjam_Click(object sender, EventArgs e)
        {
            FormPeminjam form = new FormPeminjam();
            form.ShowDialog();
        }

        private void btnAlat_Click(object sender, EventArgs e)
        {
            FormAlat form = new FormAlat();
            form.ShowDialog();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            FormPeminjaman form = new FormPeminjaman();
            form.ShowDialog();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            FormRole form = new FormRole();
            form.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser();
            form.ShowDialog();
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            FormApproval form = new FormApproval();
            form.ShowDialog();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
