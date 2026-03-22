namespace quanLiXeBuyt.GiaoDien
{
    partial class ucVeXe
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
            this.btnXoaVe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnXuatVe = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiVe = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachVe = new System.Windows.Forms.DataGridView();
            this.btnTimVe = new System.Windows.Forms.Button();
            this.btnSuaVe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachVe)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.dtpHanSuDung);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimVe);
            this.splitContainer1.Panel1.Controls.Add(this.btnSuaVe);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaVe);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.picQR);
            this.splitContainer1.Panel1.Controls.Add(this.btnXuatVe);
            this.splitContainer1.Panel1.Controls.Add(this.txtSDT);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenKhach);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cboLoaiVe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDanhSachVe);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 800);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnXoaVe
            // 
            this.btnXoaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaVe.ForeColor = System.Drawing.Color.Maroon;
            this.btnXoaVe.Location = new System.Drawing.Point(186, 491);
            this.btnXoaVe.Name = "btnXoaVe";
            this.btnXoaVe.Size = new System.Drawing.Size(162, 40);
            this.btnXoaVe.TabIndex = 10;
            this.btnXoaVe.Text = "Xóa vé";
            this.btnXoaVe.UseVisualStyleBackColor = true;
            this.btnXoaVe.Click += new System.EventHandler(this.btnXoaVe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại vé:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khách hàng:";
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(90, 641);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(150, 150);
            this.picQR.TabIndex = 6;
            this.picQR.TabStop = false;
            // 
            // btnXuatVe
            // 
            this.btnXuatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatVe.ForeColor = System.Drawing.Color.Red;
            this.btnXuatVe.Location = new System.Drawing.Point(3, 491);
            this.btnXuatVe.Name = "btnXuatVe";
            this.btnXuatVe.Size = new System.Drawing.Size(162, 40);
            this.btnXuatVe.TabIndex = 5;
            this.btnXuatVe.Text = "Xuất vé";
            this.btnXuatVe.UseVisualStyleBackColor = true;
            this.btnXuatVe.Click += new System.EventHandler(this.btnXuatVe_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(126, 217);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 26);
            this.txtSDT.TabIndex = 4;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(124, 129);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(191, 26);
            this.txtTenKhach.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "VÉ XE";
            // 
            // cboLoaiVe
            // 
            this.cboLoaiVe.FormattingEnabled = true;
            this.cboLoaiVe.Location = new System.Drawing.Point(137, 379);
            this.cboLoaiVe.Name = "cboLoaiVe";
            this.cboLoaiVe.Size = new System.Drawing.Size(178, 28);
            this.cboLoaiVe.TabIndex = 0;
            // 
            // dgvDanhSachVe
            // 
            this.dgvDanhSachVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachVe.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachVe.Name = "dgvDanhSachVe";
            this.dgvDanhSachVe.RowHeadersWidth = 62;
            this.dgvDanhSachVe.RowTemplate.Height = 28;
            this.dgvDanhSachVe.Size = new System.Drawing.Size(645, 800);
            this.dgvDanhSachVe.TabIndex = 0;
            this.dgvDanhSachVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachVe_CellClick);
            // 
            // btnTimVe
            // 
            this.btnTimVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimVe.Location = new System.Drawing.Point(186, 549);
            this.btnTimVe.Name = "btnTimVe";
            this.btnTimVe.Size = new System.Drawing.Size(162, 40);
            this.btnTimVe.TabIndex = 12;
            this.btnTimVe.Text = "Tìm vé";
            this.btnTimVe.UseVisualStyleBackColor = true;
            this.btnTimVe.Click += new System.EventHandler(this.btnTimVe_Click);
            // 
            // btnSuaVe
            // 
            this.btnSuaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaVe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaVe.Location = new System.Drawing.Point(3, 549);
            this.btnSuaVe.Name = "btnSuaVe";
            this.btnSuaVe.Size = new System.Drawing.Size(162, 40);
            this.btnSuaVe.TabIndex = 11;
            this.btnSuaVe.Text = "Sửa vé";
            this.btnSuaVe.UseVisualStyleBackColor = true;
            this.btnSuaVe.Click += new System.EventHandler(this.btnSuaVe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hạn sử dụng:";
            // 
            // dtpHanSuDung
            // 
            this.dtpHanSuDung.CustomFormat = "dd/MM/yyyy";
            this.dtpHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanSuDung.Location = new System.Drawing.Point(126, 310);
            this.dtpHanSuDung.Name = "dtpHanSuDung";
            this.dtpHanSuDung.Size = new System.Drawing.Size(189, 26);
            this.dtpHanSuDung.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(137, 441);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(191, 26);
            this.txtTimKiem.TabIndex = 15;
            // 
            // ucVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucVeXe";
            this.Size = new System.Drawing.Size(1000, 800);
            this.Load += new System.EventHandler(this.ucVeXe_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboLoaiVe;
        private System.Windows.Forms.DataGridView dgvDanhSachVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Button btnXuatVe;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaVe;
        private System.Windows.Forms.Button btnTimVe;
        private System.Windows.Forms.Button btnSuaVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHanSuDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
