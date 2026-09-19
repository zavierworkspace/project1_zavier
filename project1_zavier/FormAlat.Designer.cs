
namespace project1_zavier
{
    partial class FormAlat
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
            this.lblNamaAlat = new System.Windows.Forms.Label();
            this.txtNamaAlat = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dgvAlat = new System.Windows.Forms.DataGridView();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblKodeAlat = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblKondisi = new System.Windows.Forms.Label();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.txtKodeAlat = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtKondisi = new System.Windows.Forms.TextBox();
            this.txtLokasi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamaAlat
            // 
            this.lblNamaAlat.AutoSize = true;
            this.lblNamaAlat.Location = new System.Drawing.Point(55, 85);
            this.lblNamaAlat.Name = "lblNamaAlat";
            this.lblNamaAlat.Size = new System.Drawing.Size(83, 20);
            this.lblNamaAlat.TabIndex = 0;
            this.lblNamaAlat.Text = "Nama Alat";
            // 
            // txtNamaAlat
            // 
            this.txtNamaAlat.Location = new System.Drawing.Point(185, 78);
            this.txtNamaAlat.Name = "txtNamaAlat";
            this.txtNamaAlat.Size = new System.Drawing.Size(208, 26);
            this.txtNamaAlat.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(94, 320);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 36);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(226, 320);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(110, 36);
            this.btnUbah.TabIndex = 5;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(363, 321);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 36);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(505, 320);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(110, 36);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // dgvAlat
            // 
            this.dgvAlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlat.Location = new System.Drawing.Point(-5, 385);
            this.dgvAlat.Name = "dgvAlat";
            this.dgvAlat.RowHeadersWidth = 62;
            this.dgvAlat.RowTemplate.Height = 28;
            this.dgvAlat.Size = new System.Drawing.Size(1080, 236);
            this.dgvAlat.TabIndex = 1;
            this.dgvAlat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlat_CellClick);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(768, 314);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(129, 43);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "Kembali";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lblKodeAlat
            // 
            this.lblKodeAlat.AutoSize = true;
            this.lblKodeAlat.Location = new System.Drawing.Point(55, 43);
            this.lblKodeAlat.Name = "lblKodeAlat";
            this.lblKodeAlat.Size = new System.Drawing.Size(78, 20);
            this.lblKodeAlat.TabIndex = 11;
            this.lblKodeAlat.Text = "Kode Alat";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(55, 132);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(60, 20);
            this.lblJumlah.TabIndex = 12;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblKondisi
            // 
            this.lblKondisi.AutoSize = true;
            this.lblKondisi.Location = new System.Drawing.Point(55, 179);
            this.lblKondisi.Name = "lblKondisi";
            this.lblKondisi.Size = new System.Drawing.Size(60, 20);
            this.lblKondisi.TabIndex = 13;
            this.lblKondisi.Text = "Kondisi";
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Location = new System.Drawing.Point(55, 229);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(55, 20);
            this.lblLokasi.TabIndex = 14;
            this.lblLokasi.Text = "Lokasi";
            // 
            // txtKodeAlat
            // 
            this.txtKodeAlat.Location = new System.Drawing.Point(185, 40);
            this.txtKodeAlat.Name = "txtKodeAlat";
            this.txtKodeAlat.Size = new System.Drawing.Size(208, 26);
            this.txtKodeAlat.TabIndex = 15;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(185, 126);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(208, 26);
            this.txtJumlah.TabIndex = 2;
            // 
            // txtKondisi
            // 
            this.txtKondisi.Location = new System.Drawing.Point(185, 176);
            this.txtKondisi.Name = "txtKondisi";
            this.txtKondisi.Size = new System.Drawing.Size(208, 26);
            this.txtKondisi.TabIndex = 17;
            // 
            // txtLokasi
            // 
            this.txtLokasi.Location = new System.Drawing.Point(185, 226);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.Size = new System.Drawing.Size(208, 26);
            this.txtLokasi.TabIndex = 18;
            // 
            // FormAlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 573);
            this.Controls.Add(this.txtLokasi);
            this.Controls.Add(this.txtKondisi);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtKodeAlat);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.lblKondisi);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.lblKodeAlat);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.dgvAlat);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNamaAlat);
            this.Controls.Add(this.lblNamaAlat);
            this.Name = "FormAlat";
            this.Text = "FormAlat";
            this.Load += new System.EventHandler(this.FormAlat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamaAlat;
        private System.Windows.Forms.TextBox txtNamaAlat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dgvAlat;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblKodeAlat;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblKondisi;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.TextBox txtKodeAlat;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtKondisi;
        private System.Windows.Forms.TextBox txtLokasi;
    }
}