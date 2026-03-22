using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using quanLiXeBuyt.DuLieu;
using System.IO;

namespace quanLiXeBuyt.GiaoDien
{
    public partial class ucXeBus : UserControl
    {
        KetNoiCSDL db = new KetNoiCSDL();
        int xeID_DangChon = -1;
        string duongDanAnh = "";
        public ucXeBus()
        {
            InitializeComponent();
            LoadComboTuyen();
            LoadDataXe();
        }
        private void LoadComboTuyen()
        {
            string sql = "SELECT RouteID, RouteName FROM routes";
            cboTuyenXe.DataSource = db.LayDuLieu(sql);
            cboTuyenXe.DisplayMember = "RouteName";
            cboTuyenXe.ValueMember = "RouteID";
        }

        private void LoadDataXe()
        {
            string sql = @"SELECT b.BusID, b.LicensePlate, b.Status, r.RouteName, b.ImagePath, b.RouteID 
                   FROM buses b 
                   LEFT JOIN routes r ON b.RouteID = r.RouteID";

            DataTable dt = db.LayDuLieu(sql);
            dgvXeBus.DataSource = dt;

            if (dgvXeBus.Columns.Contains("ImagePath")) dgvXeBus.Columns["ImagePath"].Visible = false;
            if (dgvXeBus.Columns.Contains("RouteID")) dgvXeBus.Columns["RouteID"].Visible = false;
            if (dgvXeBus.Columns.Contains("BusID")) dgvXeBus.Columns["BusID"].Visible = false;

            dgvXeBus.Columns["LicensePlate"].HeaderText = "Biển số xe";
            dgvXeBus.Columns["Status"].HeaderText = "Trạng thái";
            dgvXeBus.Columns["RouteName"].HeaderText = "Tuyến đang chạy";
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBienSo.Text))
            {
                MessageBox.Show("Bà nhập biển số xe giúp tui nha!");
                return;
            }

            string sql = "INSERT INTO buses (LicensePlate, Status, RouteID, ImagePath) " +
                         "VALUES (@plate, @status, @route, @img)";

            MySqlParameter[] p = {
                new MySqlParameter("@plate", txtBienSo.Text.Trim()),
                new MySqlParameter("@status", cboTrangThai.Text),
                new MySqlParameter("@route", cboTuyenXe.SelectedValue),
                new MySqlParameter("@img", duongDanAnh)
            };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Thêm xe thành công!");
                LoadDataXe();
            }
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            if (xeID_DangChon == -1) return;

            if (MessageBox.Show("Xác nhận xóa xe này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM buses WHERE BusID = @id";
                MySqlParameter[] p = { new MySqlParameter("@id", xeID_DangChon) };

                if (db.ThucThi(sql, p) > 0)
                {
                    LoadDataXe();
                    xeID_DangChon = -1;
                    MessageBox.Show("Xóa xong rồi nè!");
                }
            }
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            if (xeID_DangChon == -1)
            {
                MessageBox.Show("Bạn chọn con xe cần sửa trong bảng trước nhen!");
                return;
            }

            string sql = "UPDATE buses SET LicensePlate=@plate, Status=@status, " +
                         "RouteID=@route, ImagePath=@img WHERE BusID=@id";

            MySqlParameter[] p = {
                new MySqlParameter("@plate", txtBienSo.Text.Trim()),
                new MySqlParameter("@status", cboTrangThai.Text),
                new MySqlParameter("@route", cboTuyenXe.SelectedValue),
                new MySqlParameter("@img", duongDanAnh),
                new MySqlParameter("@id", xeID_DangChon)
            };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Đã cập nhật thông tin xe!");
                LoadDataXe();
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ảnh xe|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                duongDanAnh = ofd.FileName;
                picXeBus.Image = Image.FromFile(duongDanAnh);
                picXeBus.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dgvXeBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXeBus.Rows[e.RowIndex];           
                xeID_DangChon = Convert.ToInt32(row.Cells["BusID"].Value);

                txtBienSo.Text = row.Cells["LicensePlate"].Value.ToString();
                cboTrangThai.Text = row.Cells["Status"].Value.ToString();
                cboTuyenXe.Text = row.Cells["RouteName"].Value.ToString();
                duongDanAnh = row.Cells["ImagePath"].Value.ToString();

                if (File.Exists(duongDanAnh))
                {
                    picXeBus.Image = Image.FromFile(duongDanAnh);
                }
                else
                {
                    picXeBus.Image = null;
                }
            }
        }
    }
}
