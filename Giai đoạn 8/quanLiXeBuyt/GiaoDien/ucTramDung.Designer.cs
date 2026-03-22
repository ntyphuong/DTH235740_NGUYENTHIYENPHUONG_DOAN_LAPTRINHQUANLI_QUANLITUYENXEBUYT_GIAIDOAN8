namespace quanLiXeBuyt.GiaoDien
{
    partial class ucTramDung
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
            this.txtKinhDo = new System.Windows.Forms.TextBox();
            this.txtViDo = new System.Windows.Forms.TextBox();
            this.txtTenTram = new System.Windows.Forms.TextBox();
            this.btnSuaTram = new System.Windows.Forms.Button();
            this.btnXoaTram = new System.Windows.Forms.Button();
            this.btnThemTram = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTramDung = new System.Windows.Forms.DataGridView();
            this.mapTram = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramDung)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtKinhDo);
            this.splitContainer1.Panel1.Controls.Add(this.txtViDo);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenTram);
            this.splitContainer1.Panel1.Controls.Add(this.btnSuaTram);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaTram);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemTram);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvTramDung);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapTram);
            this.splitContainer1.Size = new System.Drawing.Size(800, 520);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtKinhDo
            // 
            this.txtKinhDo.Location = new System.Drawing.Point(67, 118);
            this.txtKinhDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKinhDo.Name = "txtKinhDo";
            this.txtKinhDo.Size = new System.Drawing.Size(171, 20);
            this.txtKinhDo.TabIndex = 10;
            // 
            // txtViDo
            // 
            this.txtViDo.Location = new System.Drawing.Point(67, 84);
            this.txtViDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtViDo.Name = "txtViDo";
            this.txtViDo.Size = new System.Drawing.Size(171, 20);
            this.txtViDo.TabIndex = 9;
            // 
            // txtTenTram
            // 
            this.txtTenTram.Location = new System.Drawing.Point(67, 53);
            this.txtTenTram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTram.Name = "txtTenTram";
            this.txtTenTram.Size = new System.Drawing.Size(171, 20);
            this.txtTenTram.TabIndex = 8;
            // 
            // btnSuaTram
            // 
            this.btnSuaTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTram.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaTram.Location = new System.Drawing.Point(187, 173);
            this.btnSuaTram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaTram.Name = "btnSuaTram";
            this.btnSuaTram.Size = new System.Drawing.Size(50, 45);
            this.btnSuaTram.TabIndex = 7;
            this.btnSuaTram.Text = "Sửa trạm";
            this.btnSuaTram.UseVisualStyleBackColor = true;
            this.btnSuaTram.Click += new System.EventHandler(this.btnSuaTram_Click);
            // 
            // btnXoaTram
            // 
            this.btnXoaTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTram.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTram.Location = new System.Drawing.Point(103, 173);
            this.btnXoaTram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaTram.Name = "btnXoaTram";
            this.btnXoaTram.Size = new System.Drawing.Size(50, 45);
            this.btnXoaTram.TabIndex = 6;
            this.btnXoaTram.Text = "Xóa trạm";
            this.btnXoaTram.UseVisualStyleBackColor = true;
            this.btnXoaTram.Click += new System.EventHandler(this.btnXoaTram_Click);
            // 
            // btnThemTram
            // 
            this.btnThemTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTram.Location = new System.Drawing.Point(23, 173);
            this.btnThemTram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemTram.Name = "btnThemTram";
            this.btnThemTram.Size = new System.Drawing.Size(50, 45);
            this.btnThemTram.TabIndex = 5;
            this.btnThemTram.Text = "Thêm trạm";
            this.btnThemTram.UseVisualStyleBackColor = true;
            this.btnThemTram.Click += new System.EventHandler(this.btnThemTram_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kinh độ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vĩ độ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên trạm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRẠM DỪNG";
            // 
            // dgvTramDung
            // 
            this.dgvTramDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramDung.Location = new System.Drawing.Point(2, 239);
            this.dgvTramDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTramDung.Name = "dgvTramDung";
            this.dgvTramDung.RowHeadersWidth = 62;
            this.dgvTramDung.RowTemplate.Height = 28;
            this.dgvTramDung.Size = new System.Drawing.Size(265, 280);
            this.dgvTramDung.TabIndex = 0;
            this.dgvTramDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTramDung_CellContentClick);
            // 
            // mapTram
            // 
            this.mapTram.Bearing = 0F;
            this.mapTram.CanDragMap = true;
            this.mapTram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapTram.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapTram.GrayScaleMode = false;
            this.mapTram.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapTram.LevelsKeepInMemory = 5;
            this.mapTram.Location = new System.Drawing.Point(0, 0);
            this.mapTram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapTram.MarkersEnabled = true;
            this.mapTram.MaxZoom = 2;
            this.mapTram.MinZoom = 2;
            this.mapTram.MouseWheelZoomEnabled = true;
            this.mapTram.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapTram.Name = "mapTram";
            this.mapTram.NegativeMode = false;
            this.mapTram.PolygonsEnabled = true;
            this.mapTram.RetryLoadTile = 0;
            this.mapTram.RoutesEnabled = true;
            this.mapTram.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapTram.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapTram.ShowTileGridLines = false;
            this.mapTram.Size = new System.Drawing.Size(531, 520);
            this.mapTram.TabIndex = 0;
            this.mapTram.Zoom = 0D;
            // 
            // ucTramDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucTramDung";
            this.Size = new System.Drawing.Size(800, 520);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtKinhDo;
        private System.Windows.Forms.TextBox txtViDo;
        private System.Windows.Forms.TextBox txtTenTram;
        private System.Windows.Forms.Button btnSuaTram;
        private System.Windows.Forms.Button btnXoaTram;
        private System.Windows.Forms.Button btnThemTram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTramDung;
        private GMap.NET.WindowsForms.GMapControl mapTram;
    }
}
