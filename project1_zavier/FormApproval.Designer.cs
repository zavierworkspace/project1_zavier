
namespace project1_zavier
{
    partial class FormApproval
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.btnSetujui = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.dgvApproval = new System.Windows.Forms.DataGridView();
            this.btnKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(324, 54);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Location = new System.Drawing.Point(324, 100);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(66, 20);
            this.lblCatatan.TabIndex = 1;
            this.lblCatatan.Text = "Catatan";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(407, 46);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(205, 28);
            this.cmbStatus.TabIndex = 2;
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(407, 100);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(205, 26);
            this.txtCatatan.TabIndex = 3;
            // 
            // btnSetujui
            // 
            this.btnSetujui.Location = new System.Drawing.Point(326, 175);
            this.btnSetujui.Name = "btnSetujui";
            this.btnSetujui.Size = new System.Drawing.Size(130, 35);
            this.btnSetujui.TabIndex = 4;
            this.btnSetujui.Text = "Setujui";
            this.btnSetujui.UseVisualStyleBackColor = true;
            this.btnSetujui.Click += new System.EventHandler(this.btnSetujui_Click);
            // 
            // btnTolak
            // 
            this.btnTolak.Location = new System.Drawing.Point(522, 175);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(130, 35);
            this.btnTolak.TabIndex = 5;
            this.btnTolak.Text = "Tolak";
            this.btnTolak.UseVisualStyleBackColor = true;
            this.btnTolak.Click += new System.EventHandler(this.btnTolak_Click);
            // 
            // dgvApproval
            // 
            this.dgvApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApproval.Location = new System.Drawing.Point(-8, 255);
            this.dgvApproval.Name = "dgvApproval";
            this.dgvApproval.RowHeadersWidth = 62;
            this.dgvApproval.RowTemplate.Height = 28;
            this.dgvApproval.Size = new System.Drawing.Size(1009, 254);
            this.dgvApproval.TabIndex = 6;
            this.dgvApproval.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApproval_CellClick);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(811, 175);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(129, 43);
            this.btnKeluar.TabIndex = 11;
            this.btnKeluar.Text = "Kembali";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FormApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 510);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.dgvApproval);
            this.Controls.Add(this.btnTolak);
            this.Controls.Add(this.btnSetujui);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.lblStatus);
            this.Name = "FormApproval";
            this.Text = "FormApproval";
            this.Load += new System.EventHandler(this.FormApproval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Button btnSetujui;
        private System.Windows.Forms.Button btnTolak;
        private System.Windows.Forms.DataGridView dgvApproval;
        private System.Windows.Forms.Button btnKeluar;
    }
}