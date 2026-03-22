namespace quanLiXeBuyt.GiaoDien
{
    partial class ucXeBus
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvXeBus = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaXe = new System.Windows.Forms.Button();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.cboTuyenXe = new System.Windows.Forms.ComboBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.picXeBus = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeBus)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXeBus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(537, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "XE BUÝT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvXeBus);
            this.panel1.Location = new System.Drawing.Point(567, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 665);
            this.panel1.TabIndex = 1;
            // 
            // dgvXeBus
            // 
            this.dgvXeBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXeBus.Location = new System.Drawing.Point(0, 0);
            this.dgvXeBus.Name = "dgvXeBus";
            this.dgvXeBus.RowHeadersWidth = 62;
            this.dgvXeBus.RowTemplate.Height = 28;
            this.dgvXeBus.Size = new System.Drawing.Size(569, 665);
            this.dgvXeBus.TabIndex = 0;
            this.dgvXeBus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXeBus_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.btnThemAnh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSuaXe);
            this.groupBox1.Controls.Add(this.btnXoaXe);
            this.groupBox1.Controls.Add(this.btnThemXe);
            this.groupBox1.Controls.Add(this.cboTuyenXe);
            this.groupBox1.Controls.Add(this.txtBienSo);
            this.groupBox1.Location = new System.Drawing.Point(51, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 386);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tuyến xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Biển số xe:";
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaXe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaXe.Location = new System.Drawing.Point(316, 253);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(75, 69);
            this.btnSuaXe.TabIndex = 20;
            this.btnSuaXe.Text = "Sửa xe";
            this.btnSuaXe.UseVisualStyleBackColor = true;
            this.btnSuaXe.Click += new System.EventHandler(this.btnSuaXe_Click);
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaXe.ForeColor = System.Drawing.Color.Red;
            this.btnXoaXe.Location = new System.Drawing.Point(182, 253);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(75, 69);
            this.btnXoaXe.TabIndex = 19;
            this.btnXoaXe.Text = "Xóa xe";
            this.btnXoaXe.UseVisualStyleBackColor = true;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXe.Location = new System.Drawing.Point(62, 253);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(75, 69);
            this.btnThemXe.TabIndex = 18;
            this.btnThemXe.Text = "Thêm xe";
            this.btnThemXe.UseVisualStyleBackColor = true;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // cboTuyenXe
            // 
            this.cboTuyenXe.FormattingEnabled = true;
            this.cboTuyenXe.Location = new System.Drawing.Point(231, 195);
            this.cboTuyenXe.Name = "cboTuyenXe";
            this.cboTuyenXe.Size = new System.Drawing.Size(160, 28);
            this.cboTuyenXe.TabIndex = 3;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(111, 71);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(280, 26);
            this.txtBienSo.TabIndex = 0;
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Location = new System.Drawing.Point(220, 344);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(160, 29);
            this.btnThemAnh.TabIndex = 24;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // picXeBus
            // 
            this.picXeBus.Location = new System.Drawing.Point(51, 567);
            this.picXeBus.Name = "picXeBus";
            this.picXeBus.Size = new System.Drawing.Size(427, 257);
            this.picXeBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXeBus.TabIndex = 3;
            this.picXeBus.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Đang chạy",
            "Bảo trì"});
            this.cboTrangThai.Location = new System.Drawing.Point(231, 130);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(160, 28);
            this.cboTrangThai.TabIndex = 25;
            // 
            // ucXeBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.picXeBus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ucXeBus";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeBus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXeBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvXeBus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTuyenXe;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Button btnSuaXe;
        private System.Windows.Forms.Button btnXoaXe;
        private System.Windows.Forms.Button btnThemXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.PictureBox picXeBus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTrangThai;
    }
}
