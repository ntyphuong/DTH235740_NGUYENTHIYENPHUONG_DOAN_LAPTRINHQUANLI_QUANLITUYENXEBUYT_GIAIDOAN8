namespace quanLiXeBuyt.GiaoDien
{
    partial class ucPhanCong
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaPhanCong = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.dtpNgayTruc = new System.Windows.Forms.DateTimePicker();
            this.cboCaTruc = new System.Windows.Forms.ComboBox();
            this.cboTaiXe = new System.Windows.Forms.ComboBox();
            this.cboXeBus = new System.Windows.Forms.ComboBox();
            this.cboTuyenXe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaPhanCong);
            this.splitContainer1.Panel1.Controls.Add(this.btnPhanCong);
            this.splitContainer1.Panel1.Controls.Add(this.dtpNgayTruc);
            this.splitContainer1.Panel1.Controls.Add(this.cboCaTruc);
            this.splitContainer1.Panel1.Controls.Add(this.cboTaiXe);
            this.splitContainer1.Panel1.Controls.Add(this.cboXeBus);
            this.splitContainer1.Panel1.Controls.Add(this.cboTuyenXe);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPhanCong);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 1000);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 662);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày trực: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chọn ca trực: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chọn tài xế: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn xe bus: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn tuyến đường: ";
            // 
            // btnXoaPhanCong
            // 
            this.btnXoaPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanCong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXoaPhanCong.Location = new System.Drawing.Point(233, 870);
            this.btnXoaPhanCong.Name = "btnXoaPhanCong";
            this.btnXoaPhanCong.Size = new System.Drawing.Size(168, 49);
            this.btnXoaPhanCong.TabIndex = 7;
            this.btnXoaPhanCong.Text = "Xóa phân công";
            this.btnXoaPhanCong.UseVisualStyleBackColor = true;
            this.btnXoaPhanCong.Click += new System.EventHandler(this.btnXoaPhanCong_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCong.ForeColor = System.Drawing.Color.Red;
            this.btnPhanCong.Location = new System.Drawing.Point(28, 870);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(148, 49);
            this.btnPhanCong.TabIndex = 6;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // dtpNgayTruc
            // 
            this.dtpNgayTruc.Location = new System.Drawing.Point(201, 662);
            this.dtpNgayTruc.Name = "dtpNgayTruc";
            this.dtpNgayTruc.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayTruc.TabIndex = 5;
            // 
            // cboCaTruc
            // 
            this.cboCaTruc.FormattingEnabled = true;
            this.cboCaTruc.Items.AddRange(new object[] {
            "Ca sáng",
            "Ca chiều"});
            this.cboCaTruc.Location = new System.Drawing.Point(178, 527);
            this.cboCaTruc.Name = "cboCaTruc";
            this.cboCaTruc.Size = new System.Drawing.Size(223, 28);
            this.cboCaTruc.TabIndex = 4;
            // 
            // cboTaiXe
            // 
            this.cboTaiXe.FormattingEnabled = true;
            this.cboTaiXe.Location = new System.Drawing.Point(178, 404);
            this.cboTaiXe.Name = "cboTaiXe";
            this.cboTaiXe.Size = new System.Drawing.Size(223, 28);
            this.cboTaiXe.TabIndex = 3;
            // 
            // cboXeBus
            // 
            this.cboXeBus.FormattingEnabled = true;
            this.cboXeBus.Location = new System.Drawing.Point(178, 279);
            this.cboXeBus.Name = "cboXeBus";
            this.cboXeBus.Size = new System.Drawing.Size(223, 28);
            this.cboXeBus.TabIndex = 2;
            // 
            // cboTuyenXe
            // 
            this.cboTuyenXe.FormattingEnabled = true;
            this.cboTuyenXe.Location = new System.Drawing.Point(178, 159);
            this.cboTuyenXe.Name = "cboTuyenXe";
            this.cboTuyenXe.Size = new System.Drawing.Size(223, 28);
            this.cboTuyenXe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN CÔNG CA TRỰC";
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanCong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.RowHeadersWidth = 62;
            this.dgvPhanCong.RowTemplate.Height = 28;
            this.dgvPhanCong.Size = new System.Drawing.Size(744, 1000);
            this.dgvPhanCong.TabIndex = 0;
            this.dgvPhanCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellClick);
            // 
            // ucPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucPhanCong";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaPhanCong;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.DateTimePicker dtpNgayTruc;
        private System.Windows.Forms.ComboBox cboCaTruc;
        private System.Windows.Forms.ComboBox cboTaiXe;
        private System.Windows.Forms.ComboBox cboXeBus;
        private System.Windows.Forms.ComboBox cboTuyenXe;
    }
}
