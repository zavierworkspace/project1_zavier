
namespace project1_zavier
{
    partial class FormPeminjaman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNamaPeminjam = new System.Windows.Forms.Label();
            this.labellblNamaAlat2 = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.cmbPeminjam = new System.Windows.Forms.ComboBox();
            this.cmbAlat = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.dgvPeminjaman = new System.Windows.Forms.DataGridView();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.dtpTanggalKembali = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalPinjam = new System.Windows.Forms.DateTimePicker();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.lblTanggalKembali = new System.Windows.Forms.Label();
            this.lblTanggalPinjam = new System.Windows.Forms.Label();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamaPeminjam
            // 
            this.lblNamaPeminjam.AutoSize = true;
            this.lblNamaPeminjam.Location = new System.Drawing.Point(45, 45);
            this.lblNamaPeminjam.Name = "lblNamaPeminjam";
            this.lblNamaPeminjam.Size = new System.Drawing.Size(124, 20);
            this.lblNamaPeminjam.TabIndex = 0;
            this.lblNamaPeminjam.Text = "Nama Peminjam";
            // 
            // labellblNamaAlat2
            // 
            this.labellblNamaAlat2.AutoSize = true;
            this.labellblNamaAlat2.Location = new System.Drawing.Point(45, 94);
            this.labellblNamaAlat2.Name = "labellblNamaAlat2";
            this.labellblNamaAlat2.Size = new System.Drawing.Size(83, 20);
            this.labellblNamaAlat2.TabIndex = 1;
            this.labellblNamaAlat2.Text = "Nama Alat";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(45, 145);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(60, 20);
            this.lblJumlah.TabIndex = 2;
            this.lblJumlah.Text = "Jumlah";
            // 
            // cmbPeminjam
            // 
            this.cmbPeminjam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPeminjam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPeminjam.FormattingEnabled = true;
            this.cmbPeminjam.Location = new System.Drawing.Point(187, 42);
            this.cmbPeminjam.Name = "cmbPeminjam";
            this.cmbPeminjam.Size = new System.Drawing.Size(209, 28);
            this.cmbPeminjam.TabIndex = 3;
            // 
            // cmbAlat
            // 
            this.cmbAlat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAlat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlat.FormattingEnabled = true;
            this.cmbAlat.Location = new System.Drawing.Point(187, 91);
            this.cmbAlat.Name = "cmbAlat";
            this.cmbAlat.Size = new System.Drawing.Size(209, 28);
            this.cmbAlat.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(143, 272);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(112, 35);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(284, 272);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(112, 35);
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(187, 142);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(209, 26);
            this.txtJumlah.TabIndex = 0;
            // 
            // dgvPeminjaman
            // 
            this.dgvPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeminjaman.Location = new System.Drawing.Point(-7, 336);
            this.dgvPeminjaman.Name = "dgvPeminjaman";
            this.dgvPeminjaman.RowHeadersWidth = 62;
            this.dgvPeminjaman.RowTemplate.Height = 28;
            this.dgvPeminjaman.Size = new System.Drawing.Size(1152, 391);
            this.dgvPeminjaman.TabIndex = 8;
            this.dgvPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjaman_CellClick);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(775, 268);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(129, 43);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "Kembali";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // dtpTanggalKembali
            // 
            this.dtpTanggalKembali.Location = new System.Drawing.Point(605, 93);
            this.dtpTanggalKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTanggalKembali.Name = "dtpTanggalKembali";
            this.dtpTanggalKembali.Size = new System.Drawing.Size(260, 26);
            this.dtpTanggalKembali.TabIndex = 17;
            // 
            // dtpTanggalPinjam
            // 
            this.dtpTanggalPinjam.Location = new System.Drawing.Point(605, 44);
            this.dtpTanggalPinjam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTanggalPinjam.Name = "dtpTanggalPinjam";
            this.dtpTanggalPinjam.Size = new System.Drawing.Size(260, 26);
            this.dtpTanggalPinjam.TabIndex = 16;
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Location = new System.Drawing.Point(436, 142);
            this.lblCatatan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(66, 20);
            this.lblCatatan.TabIndex = 15;
            this.lblCatatan.Text = "Catatan";
            // 
            // lblTanggalKembali
            // 
            this.lblTanggalKembali.AutoSize = true;
            this.lblTanggalKembali.Location = new System.Drawing.Point(436, 91);
            this.lblTanggalKembali.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanggalKembali.Name = "lblTanggalKembali";
            this.lblTanggalKembali.Size = new System.Drawing.Size(135, 20);
            this.lblTanggalKembali.TabIndex = 14;
            this.lblTanggalKembali.Text = "Tagnggal Kembali";
            // 
            // lblTanggalPinjam
            // 
            this.lblTanggalPinjam.AutoSize = true;
            this.lblTanggalPinjam.Location = new System.Drawing.Point(436, 45);
            this.lblTanggalPinjam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanggalPinjam.Name = "lblTanggalPinjam";
            this.lblTanggalPinjam.Size = new System.Drawing.Size(117, 20);
            this.lblTanggalPinjam.TabIndex = 13;
            this.lblTanggalPinjam.Text = "Tanggal Pinjam";
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(605, 142);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(260, 26);
            this.txtCatatan.TabIndex = 18;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(420, 272);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(112, 35);
            this.btnUbah.TabIndex = 19;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(559, 272);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(112, 35);
            this.btnHapus.TabIndex = 20;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(45, 201);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(187, 198);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(209, 28);
            this.cmbStatus.TabIndex = 22;
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 601);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.dtpTanggalKembali);
            this.Controls.Add(this.dtpTanggalPinjam);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.lblTanggalKembali);
            this.Controls.Add(this.lblTanggalPinjam);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.dgvPeminjaman);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbAlat);
            this.Controls.Add(this.cmbPeminjam);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.labellblNamaAlat2);
            this.Controls.Add(this.lblNamaPeminjam);
            this.Name = "FormPeminjaman";
            this.Text = "FormPeminjaman";
            this.Load += new System.EventHandler(this.FormPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamaPeminjam;
        private System.Windows.Forms.Label labellblNamaAlat2;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.ComboBox cmbPeminjam;
        private System.Windows.Forms.ComboBox cmbAlat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.DataGridView dgvPeminjaman;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DateTimePicker dtpTanggalKembali;
        private System.Windows.Forms.DateTimePicker dtpTanggalPinjam;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.Label lblTanggalKembali;
        private System.Windows.Forms.Label lblTanggalPinjam;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}