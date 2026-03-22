namespace quanLiXeBuyt.GiaoDien
{
    partial class ucTuyenXe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTuyenXe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTramCuoi = new System.Windows.Forms.ComboBox();
            this.cboTramDau = new System.Windows.Forms.ComboBox();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.btnSuaTram = new System.Windows.Forms.Button();
            this.btnXoaTram = new System.Windows.Forms.Button();
            this.btnThemTram = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mapTuyen = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapTuyen);
            this.splitContainer1.Size = new System.Drawing.Size(1500, 923);
            this.splitContainer1.SplitterDistance = 498;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTuyenXe);
            this.panel2.Location = new System.Drawing.Point(4, 435);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 483);
            this.panel2.TabIndex = 1;
            // 
            // dgvTuyenXe
            // 
            this.dgvTuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyenXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTuyenXe.Location = new System.Drawing.Point(0, 0);
            this.dgvTuyenXe.Name = "dgvTuyenXe";
            this.dgvTuyenXe.RowHeadersWidth = 62;
            this.dgvTuyenXe.RowTemplate.Height = 28;
            this.dgvTuyenXe.Size = new System.Drawing.Size(490, 483);
            this.dgvTuyenXe.TabIndex = 0;
            this.dgvTuyenXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenXe_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaTuyen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTramCuoi);
            this.panel1.Controls.Add(this.cboTramDau);
            this.panel1.Controls.Add(this.txtGiaVe);
            this.panel1.Controls.Add(this.txtTenTuyen);
            this.panel1.Controls.Add(this.btnSuaTram);
            this.panel1.Controls.Add(this.btnXoaTram);
            this.panel1.Controls.Add(this.btnThemTram);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 429);
            this.panel1.TabIndex = 0;
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Location = new System.Drawing.Point(158, 215);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(254, 26);
            this.txtMaTuyen.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã tuyến: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Chọn tuyến:";
            // 
            // cboTramCuoi
            // 
            this.cboTramCuoi.FormattingEnabled = true;
            this.cboTramCuoi.Location = new System.Drawing.Point(291, 256);
            this.cboTramCuoi.Name = "cboTramCuoi";
            this.cboTramCuoi.Size = new System.Drawing.Size(121, 28);
            this.cboTramCuoi.TabIndex = 21;
            // 
            // cboTramDau
            // 
            this.cboTramDau.FormattingEnabled = true;
            this.cboTramDau.Location = new System.Drawing.Point(158, 256);
            this.cboTramDau.Name = "cboTramDau";
            this.cboTramDau.Size = new System.Drawing.Size(121, 28);
            this.cboTramDau.TabIndex = 20;
            this.cboTramDau.SelectedIndexChanged += new System.EventHandler(this.cboTramDau_SelectedIndexChanged_1);
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(158, 165);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(254, 26);
            this.txtGiaVe.TabIndex = 19;
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(158, 117);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(254, 26);
            this.txtTenTuyen.TabIndex = 18;
            // 
            // btnSuaTram
            // 
            this.btnSuaTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTram.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaTram.Location = new System.Drawing.Point(338, 302);
            this.btnSuaTram.Name = "btnSuaTram";
            this.btnSuaTram.Size = new System.Drawing.Size(75, 69);
            this.btnSuaTram.TabIndex = 17;
            this.btnSuaTram.Text = "Sửa tuyến";
            this.btnSuaTram.UseVisualStyleBackColor = true;
            this.btnSuaTram.Click += new System.EventHandler(this.btnSuaTram_Click);
            // 
            // btnXoaTram
            // 
            this.btnXoaTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTram.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTram.Location = new System.Drawing.Point(212, 302);
            this.btnXoaTram.Name = "btnXoaTram";
            this.btnXoaTram.Size = new System.Drawing.Size(75, 69);
            this.btnXoaTram.TabIndex = 16;
            this.btnXoaTram.Text = "Xóa tuyến";
            this.btnXoaTram.UseVisualStyleBackColor = true;
            this.btnXoaTram.Click += new System.EventHandler(this.btnXoaTram_Click);
            // 
            // btnThemTram
            // 
            this.btnThemTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTram.Location = new System.Drawing.Point(92, 302);
            this.btnThemTram.Name = "btnThemTram";
            this.btnThemTram.Size = new System.Drawing.Size(75, 69);
            this.btnThemTram.TabIndex = 15;
            this.btnThemTram.Text = "Thêm tuyến";
            this.btnThemTram.UseVisualStyleBackColor = true;
            this.btnThemTram.Click += new System.EventHandler(this.btnThemTram_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giá vé: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên tuyến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(170, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "TUYẾN XE";
            // 
            // mapTuyen
            // 
            this.mapTuyen.Bearing = 0F;
            this.mapTuyen.CanDragMap = true;
            this.mapTuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapTuyen.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapTuyen.GrayScaleMode = false;
            this.mapTuyen.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapTuyen.LevelsKeepInMemory = 5;
            this.mapTuyen.Location = new System.Drawing.Point(0, 0);
            this.mapTuyen.MarkersEnabled = true;
            this.mapTuyen.MaxZoom = 2;
            this.mapTuyen.MinZoom = 2;
            this.mapTuyen.MouseWheelZoomEnabled = true;
            this.mapTuyen.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapTuyen.Name = "mapTuyen";
            this.mapTuyen.NegativeMode = false;
            this.mapTuyen.PolygonsEnabled = true;
            this.mapTuyen.RetryLoadTile = 0;
            this.mapTuyen.RoutesEnabled = true;
            this.mapTuyen.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapTuyen.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapTuyen.ShowTileGridLines = false;
            this.mapTuyen.Size = new System.Drawing.Size(996, 923);
            this.mapTuyen.TabIndex = 0;
            this.mapTuyen.Zoom = 0D;
            // 
            // ucTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTuyenXe";
            this.Size = new System.Drawing.Size(1500, 923);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTuyenXe;
        private System.Windows.Forms.ComboBox cboTramCuoi;
        private System.Windows.Forms.ComboBox cboTramDau;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.Button btnSuaTram;
        private System.Windows.Forms.Button btnXoaTram;
        private System.Windows.Forms.Button btnThemTram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private GMap.NET.WindowsForms.GMapControl mapTuyen;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label label5;
    }
}
