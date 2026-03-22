using MySql.Data.MySqlClient;
using quanLiXeBuyt.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLiXeBuyt.GiaoDien
{
    public partial class ucNhanVien : UserControl
    {
        KetNoiCSDL db = new KetNoiCSDL();
        int nhanVienID_DangChon = -1;
        public ucNhanVien()
        {
            InitializeComponent();
            LoadChucVu();
            LoadDataNhanVien();
        }
        private void LoadChucVu()
        {
            string sql = "SELECT RoleID, RoleName FROM Roles";
            cboVaiTro.DataSource = db.LayDuLieu(sql);
            cboVaiTro.DisplayMember = "RoleName";
            cboVaiTro.ValueMember = "RoleID";
        }

        private void LoadDataNhanVien()
        {
            string sql = @"SELECT u.UserID, u.Username, u.Password, u.FullName, r.RoleName, u.RoleID 
                           FROM Users u 
                           INNER JOIN Roles r ON u.RoleID = r.RoleID";
            DataTable dt = db.LayDuLieu(sql);
            dgvNhanVien.DataSource = dt;

            if (dgvNhanVien.Columns.Contains("UserID")) dgvNhanVien.Columns["UserID"].Visible = false;
            if (dgvNhanVien.Columns.Contains("RoleID")) dgvNhanVien.Columns["RoleID"].Visible = false;

            dgvNhanVien.Columns["Username"].HeaderText = "Tài khoản";
            dgvNhanVien.Columns["Password"].HeaderText = "Mật khẩu";
            dgvNhanVien.Columns["FullName"].HeaderText = "Họ và Tên";
            dgvNhanVien.Columns["RoleName"].HeaderText = "Chức vụ";
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Bạn nhập đủ thông tin giùm tui nhen!");
                return;
            }

            string sql = "INSERT INTO Users (Username, Password, FullName, RoleID) VALUES (@user, @pass, @name, @role)";
            MySqlParameter[] p = {
                new MySqlParameter("@user", txtTaiKhoan.Text.Trim()),
                new MySqlParameter("@pass", txtMatKhau.Text),
                new MySqlParameter("@name", txtHoTen.Text.Trim()),
                new MySqlParameter("@role", cboVaiTro.SelectedValue)
            };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Thêm thành công rồi nè!");
                LoadDataNhanVien();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                nhanVienID_DangChon = Convert.ToInt32(row.Cells["UserID"].Value);
                txtTaiKhoan.Text = row.Cells["Username"].Value.ToString();
                txtMatKhau.Text = row.Cells["Password"].Value.ToString();
                txtHoTen.Text = row.Cells["FullName"].Value.ToString();
                cboVaiTro.SelectedValue = row.Cells["RoleID"].Value;
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVienID_DangChon == -1)
            {
                MessageBox.Show("Bạn chọn nhân viên cần xóa đi đã nhen!");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = "DELETE FROM Users WHERE UserID = @id";
                MySqlParameter[] p = {
                    new MySqlParameter("@id", nhanVienID_DangChon)
                };
                if (db.ThucThi(sql, p) > 0)
                {
                    MessageBox.Show("Xóa thành công rồi nè!");
                    LoadDataNhanVien();
                    nhanVienID_DangChon = -1;
                }
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVienID_DangChon == -1)
            {
                MessageBox.Show("Bạn chọn nhân viên cần sửa đi đã nhen!");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa thông tin nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = "UPDATE Users SET Username = @user, Password = @pass, FullName = @name, RoleID = @role WHERE UserID = @id";
                MySqlParameter[] p = {
                    new MySqlParameter("@user", txtTaiKhoan.Text.Trim()),
                    new MySqlParameter("@pass", txtMatKhau.Text),
                    new MySqlParameter("@name", txtHoTen.Text.Trim()),
                    new MySqlParameter("@role", cboVaiTro.SelectedValue),
                    new MySqlParameter("@id", nhanVienID_DangChon)
                };
                if (db.ThucThi(sql, p) > 0)
                {
                    MessageBox.Show("Sửa thành công rồi nè!");
                    LoadDataNhanVien();
                }
            }
        }
    }
}