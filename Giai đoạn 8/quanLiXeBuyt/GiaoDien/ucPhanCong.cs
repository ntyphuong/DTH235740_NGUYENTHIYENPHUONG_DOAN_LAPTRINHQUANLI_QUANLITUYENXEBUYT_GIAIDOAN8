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
    public partial class ucPhanCong : UserControl
    {
        KetNoiCSDL db = new KetNoiCSDL();
        int assignmentID_DangChon = -1; 
        public ucPhanCong()
        {
            InitializeComponent();
            LoadDataTuyen();
            LoadDataXe();
            LoadDataTaiXe();
            LoadLichPhanCong();
        }
        private void LoadDataTuyen()
        {
            cboTuyenXe.DataSource = db.LayDuLieu("SELECT RouteID, RouteName FROM Routes");
            cboTuyenXe.DisplayMember = "RouteName";
            cboTuyenXe.ValueMember = "RouteID";
        }

        private void LoadDataXe()
        {
            cboXeBus.DataSource = db.LayDuLieu("SELECT BusID, LicensePlate FROM Buses WHERE Status = N'Sẵn sàng'");
            cboXeBus.DisplayMember = "LicensePlate";
            cboXeBus.ValueMember = "BusID";
        }

        private void LoadDataTaiXe()
        {
            cboTaiXe.DataSource = db.LayDuLieu("SELECT UserID, FullName FROM Users WHERE RoleID = 3");
            cboTaiXe.DisplayMember = "FullName";
            cboTaiXe.ValueMember = "UserID";
        }

        private void LoadLichPhanCong()
        {
            string sql = @"SELECT a.AssignmentID, r.RouteName, b.LicensePlate, u.FullName, a.AssignedDate, a.Shift 
                           FROM Assignments a
                           JOIN Routes r ON a.RouteID = r.RouteID
                           JOIN Buses b ON a.BusID = b.BusID
                           JOIN Users u ON u.UserID = a.DriverID";
            dgvPhanCong.DataSource = db.LayDuLieu(sql);
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO Assignments (RouteID, BusID, DriverID, AssignedDate, Shift) 
                           VALUES (@route, @bus, @driver, @date, @shift)";

            MySqlParameter[] p = {
                new MySqlParameter("@route", cboTuyenXe.SelectedValue),
                new MySqlParameter("@bus", cboXeBus.SelectedValue),
                new MySqlParameter("@driver", cboTaiXe.SelectedValue),
                new MySqlParameter("@date", dtpNgayTruc.Value.ToString("yyyy-MM-dd")),
                new MySqlParameter("@shift", cboCaTruc.SelectedIndex + 1) // 1: Sáng, 2: Chiều
            };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Đã phân công lịch trực thành công!");
                LoadLichPhanCong();
            }
        }
        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvPhanCong.Rows[e.RowIndex];
                    assignmentID_DangChon = Convert.ToInt32(row.Cells["AssignmentID"].Value);
                }
            }    
        }

        private void btnXoaPhanCong_Click(object sender, EventArgs e)
        {
            if (assignmentID_DangChon == -1)
            {
                MessageBox.Show("Bạn chọn một lịch phân công trong bảng để xóa nhen!");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy lịch phân công này không?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string sql = "DELETE FROM Assignments WHERE AssignmentID = @id";
                MySqlParameter[] p = { new MySqlParameter("@id", assignmentID_DangChon) };

                if (db.ThucThi(sql, p) > 0)
                {
                    MessageBox.Show("Đã xóa lịch phân công thành công!");

                    assignmentID_DangChon = -1;
                    LoadLichPhanCong();
                }
                else
                {
                    MessageBox.Show("Có lỗi gì đó, xóa không được!");
                }
            }
        }    
    }
}
