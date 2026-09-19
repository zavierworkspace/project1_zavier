
namespace project1_zavier
{
    partial class FormMain
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnPeminjam = new System.Windows.Forms.Button();
            this.btnAlat = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnApproval = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(54, 54);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(237, 20);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "PEMINJAMAN ALAT SEKOLAH";
            // 
            // btnPeminjam
            // 
            this.btnPeminjam.Location = new System.Drawing.Point(58, 98);
            this.btnPeminjam.Name = "btnPeminjam";
            this.btnPeminjam.Size = new System.Drawing.Size(173, 37);
            this.btnPeminjam.TabIndex = 1;
            this.btnPeminjam.Text = "Data Peminjam";
            this.btnPeminjam.UseVisualStyleBackColor = true;
            this.btnPeminjam.Click += new System.EventHandler(this.btnPeminjam_Click);
            // 
            // btnAlat
            // 
            this.btnAlat.Location = new System.Drawing.Point(58, 169);
            this.btnAlat.Name = "btnAlat";
            this.btnAlat.Size = new System.Drawing.Size(173, 37);
            this.btnAlat.TabIndex = 2;
            this.btnAlat.Text = "Data Alat";
            this.btnAlat.UseVisualStyleBackColor = true;
            this.btnAlat.Click += new System.EventHandler(this.btnAlat_Click);
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.Location = new System.Drawing.Point(58, 240);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(173, 37);
            this.btnPeminjaman.TabIndex = 3;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.UseVisualStyleBackColor = true;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(614, 349);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(129, 43);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(281, 169);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(173, 37);
            this.btnRole.TabIndex = 5;
            this.btnRole.Text = "Data Role";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnApproval
            // 
            this.btnApproval.Location = new System.Drawing.Point(281, 240);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(173, 37);
            this.btnApproval.TabIndex = 6;
            this.btnApproval.Text = "Approval";
            this.btnApproval.UseVisualStyleBackColor = true;
            this.btnApproval.Click += new System.EventHandler(this.btnApproval_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(281, 98);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(173, 37);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "Data User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnApproval);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnPeminjaman);
            this.Controls.Add(this.btnAlat);
            this.Controls.Add(this.btnPeminjam);
            this.Controls.Add(this.lblJudul);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnPeminjam;
        private System.Windows.Forms.Button btnAlat;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.Button btnUser;
    }
}