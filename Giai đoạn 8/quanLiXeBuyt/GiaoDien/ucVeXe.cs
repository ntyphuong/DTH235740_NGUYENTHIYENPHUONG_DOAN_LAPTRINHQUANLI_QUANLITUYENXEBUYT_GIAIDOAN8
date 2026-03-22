using MySql.Data.MySqlClient;
using QRCoder;
using quanLiXeBuyt.DuLieu;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace quanLiXeBuyt.GiaoDien
{
    public partial class ucVeXe : UserControl
    {
        KetNoiCSDL db = new KetNoiCSDL();
        public ucVeXe()
        {
            InitializeComponent();
        }
        private void ucVeXe_Load(object sender, EventArgs e)
        {
            LoadLoaiVe();
            LoadDanhSachVe();
            dtpHanSuDung.Value = DateTime.Today.AddDays(30);
            dtpHanSuDung.MinDate = DateTime.Today;
        }

        private void LoadLoaiVe()
        {
            DataTable dt = db.LayDuLieu("SELECT * FROM TicketTypes");
            cboLoaiVe.DataSource = dt;
            cboLoaiVe.DisplayMember = "TypeName";
            cboLoaiVe.ValueMember = "TypeID";
        }

        private void LoadDanhSachVe()
        {
            string sql = @"SELECT t.TicketID, t.QRCode, tt.TypeName, u.FullName, t.UserID, t.ExpiryDate 
                           FROM Tickets t 
                           JOIN TicketTypes tt ON t.TypeID = tt.TypeID 
                           JOIN Users u ON t.UserID = u.UserID 
                           ORDER BY t.TicketID DESC";
            dgvDanhSachVe.DataSource = db.LayDuLieu(sql);
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            
            string hoTen = txtTenKhach.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và SĐT khách!");
                return;
            }

            if (cboLoaiVe.SelectedValue == null)
            {
                MessageBox.Show("Chưa có loại vé!");
                return;
            }

            try
            {
                int userID = 0;

                // ===== KIỂM TRA USER TỒN TẠI =====
                string sqlCheck = "SELECT UserID FROM Users WHERE Username = @sdt LIMIT 1";
                MySqlParameter[] pCheck = { new MySqlParameter("@sdt", sdt) };
                DataTable dtUser = db.LayDuLieuVoiThamSo(sqlCheck, pCheck);

                if (dtUser.Rows.Count > 0)
                {
                    userID = Convert.ToInt32(dtUser.Rows[0]["UserID"]);
                }
                else
                {
                    // ===== LẤY ROLEID PASSENGER =====
                    string sqlRole = "SELECT RoleID FROM Roles WHERE RoleName = 'Passenger' LIMIT 1";
                    DataTable dtRole = db.LayDuLieu(sqlRole);

                    if (dtRole.Rows.Count == 0)
                    {
                        MessageBox.Show("Chưa có Role Passenger trong CSDL!");
                        return;
                    }

                    int roleID = Convert.ToInt32(dtRole.Rows[0]["RoleID"]);

                    // ===== THÊM USER MỚI =====
                    string sqlInsertUser = @"INSERT INTO Users(Username, Password, FullName, RoleID) 
                                     VALUES (@sdt, '123', @name, @role)";
                    MySqlParameter[] pInsertUser = {
                        new MySqlParameter("@sdt", sdt),
                        new MySqlParameter("@name", hoTen),
                        new MySqlParameter("@role", roleID)
                    };

                    if (db.ThucThi(sqlInsertUser, pInsertUser) > 0)
                    {
                        // Lấy ID vừa thêm 
                        DataTable dtNewID = db.LayDuLieu("SELECT LAST_INSERT_ID()");
                        userID = Convert.ToInt32(dtNewID.Rows[0][0]);
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo khách hàng!");
                        return;
                    }
                }

                // ===== TẠO VÉ =====
                string maVe = "BUS" + sdt + DateTime.Now.ToString("yyyyMMddHHmmss");

                string sqlTicket = @"INSERT INTO Tickets(QRCode, TypeID, UserID, ExpiryDate, IsActive) 
                             VALUES (@qr, @type, @user, @date, 1)";
                MySqlParameter[] pTicket = {
                    new MySqlParameter("@qr", maVe),
                    new MySqlParameter("@type", Convert.ToInt32(cboLoaiVe.SelectedValue)),
                    new MySqlParameter("@user", userID),
                    new MySqlParameter("@date", dtpHanSuDung.Value)
                };

                if (db.ThucThi(sqlTicket, pTicket) > 0)
                {
                    // ===== TẠO QR =====
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrData = qrGenerator.CreateQrCode(maVe, QRCodeGenerator.ECCLevel.Q);
                    PngByteQRCode qrCode = new PngByteQRCode(qrData);
                    byte[] qrBytes = qrCode.GetGraphic(20);

                    using (MemoryStream ms = new MemoryStream(qrBytes))
                    {
                        picQR.Image = Image.FromStream(ms);
                    }
                    picQR.SizeMode = PictureBoxSizeMode.Zoom;

                    MessageBox.Show("Xuất vé thành công!");
                    LoadDanhSachVe();
                }
                else
                {
                    MessageBox.Show("Tạo vé thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnXoaVe_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachVe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần xóa!");
                return;
            }

            // Lấy TicketID của dòng đang chọn
            int ticketID = Convert.ToInt32(dgvDanhSachVe.CurrentRow.Cells["TicketID"].Value);

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa vé này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rs == DialogResult.No)
                return;

            try
            {
                string sql = "DELETE FROM Tickets WHERE TicketID = @id";
                MySqlParameter[] p = { new MySqlParameter("@id", ticketID) };

                if (db.ThucThi(sql, p) > 0)
                {
                    MessageBox.Show("Xóa vé thành công!");
                    LoadDanhSachVe(); // Load lại danh sách
                }
                else
                {
                    MessageBox.Show("Không thể xóa vé!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaVe_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachVe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần sửa!");
                return;
            }

            int ticketID = Convert.ToInt32(dgvDanhSachVe.CurrentRow.Cells["TicketID"].Value);
            int typeID = Convert.ToInt32(cboLoaiVe.SelectedValue);
            DateTime expiry = dtpHanSuDung.Value;

            DialogResult rs = MessageBox.Show(
                "Xác nhận cập nhật vé?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.No)
                return;

            try
            {
                string sql = @"UPDATE Tickets 
                       SET TypeID = @type, ExpiryDate = @date
                       WHERE TicketID = @id";

                MySqlParameter[] p = {
                    new MySqlParameter("@type", typeID),
                    new MySqlParameter("@date", expiry),
                    new MySqlParameter("@id", ticketID)
                };

                if (db.ThucThi(sql, p) > 0)
                {
                    MessageBox.Show("Cập nhật vé thành công!");
                    LoadDanhSachVe();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật vé!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void dgvDanhSachVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachVe.CurrentRow == null) return;

            if (dgvDanhSachVe.CurrentRow.Cells["ExpiryDate"].Value != DBNull.Value)
            {
                dtpHanSuDung.Value = Convert.ToDateTime(
                    dgvDanhSachVe.CurrentRow.Cells["ExpiryDate"].Value
                );
            }
        }

        private void btnTimVe_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.Trim();

            string sql = @"SELECT t.TicketID, t.QRCode, tt.TypeName, u.FullName, t.UserID, t.ExpiryDate
                   FROM Tickets t
                   JOIN TicketTypes tt ON t.TypeID = tt.TypeID
                   JOIN Users u ON t.UserID = u.UserID
                   WHERE u.FullName LIKE @kw
                      OR u.Username LIKE @kw
                      OR t.QRCode LIKE @kw
                   ORDER BY t.TicketID DESC";

            MySqlParameter[] p = {
                new MySqlParameter("@kw", "%" + tukhoa + "%")
            };

            dgvDanhSachVe.DataSource = db.LayDuLieuVoiThamSo(sql, p);
        }
    }
}


