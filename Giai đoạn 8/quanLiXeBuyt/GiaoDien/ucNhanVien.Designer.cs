namespace quanLiXeBuyt.GiaoDien
{
    partial class ucNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnSuaNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.cboVaiTro);
            this.splitContainer1.Panel1.Controls.Add(this.txtMatKhau);
            this.splitContainer1.Panel1.Controls.Add(this.txtTaiKhoan);
            this.splitContainer1.Panel1.Controls.Add(this.txtHoTen);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvNhanVien);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 1000);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(796, 1000);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(107, 176);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(272, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(107, 309);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(272, 26);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(107, 424);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(272, 26);
            this.txtMatKhau.TabIndex = 3;
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(180, 526);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(191, 28);
            this.cboVaiTro.TabIndex = 4;
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhanVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaNhanVien.Location = new System.Drawing.Point(293, 794);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(75, 69);
            this.btnSuaNhanVien.TabIndex = 10;
            this.btnSuaNhanVien.Text = "Sửa nhân viên";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhanVien.ForeColor = System.Drawing.Color.Red;
            this.btnXoaNhanVien.Location = new System.Drawing.Point(167, 794);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(75, 69);
            this.btnXoaNhanVien.TabIndex = 9;
            this.btnXoaNhanVien.Text = "Xóa nhân viên";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.Location = new System.Drawing.Point(47, 794);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(75, 69);
            this.btnThemNhanVien.TabIndex = 8;
            this.btnThemNhanVien.Text = "Thêm nhân viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vai trò:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mật khẩu:";
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
