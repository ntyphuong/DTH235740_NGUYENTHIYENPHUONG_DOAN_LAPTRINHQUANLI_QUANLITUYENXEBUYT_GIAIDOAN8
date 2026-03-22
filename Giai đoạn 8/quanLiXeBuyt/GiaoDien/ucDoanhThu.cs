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
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace quanLiXeBuyt.GiaoDien
{
    public partial class ucDoanhThu : UserControl
    {
        KetNoiCSDL db = new KetNoiCSDL();
        DataTable dtThongKe = new DataTable();
        public ucDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            string sql = @"SELECT t.TicketID, tt.TypeName, tt.Price, t.CreatedAt
                   FROM Tickets t
                   JOIN TicketTypes tt ON t.TypeID = tt.TypeID
                   WHERE t.CreatedAt BETWEEN @from AND @to
                   ORDER BY t.CreatedAt DESC";

            MySqlParameter[] p = {
                new MySqlParameter("@from", tuNgay),
                new MySqlParameter("@to", denNgay)
            };

            dtThongKe = db.LayDuLieuVoiThamSo(sql, p);
            dgvDoanhThu.DataSource = dtThongKe;

            int soVe = dtThongKe.Rows.Count;
            double tongTien = 0;

            foreach (DataRow row in dtThongKe.Rows)
                tongTien += Convert.ToDouble(row["Price"]);

            lblSoVe.Text = "Số vé bán: " + soVe;
            lblDoanhThu.Text = "Doanh thu: " + tongTien.ToString("N0") + " VNĐ";
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

            if (dtThongKe == null || dtThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.Title = "Lưu báo cáo doanh thu";
            sfd.FileName = "BaoCaoDoanhThu.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.License.SetNonCommercialPersonal("Đồ án cá nhân"); // Thiết lập giấy phép cho EPPlus
                FileInfo file = new FileInfo(sfd.FileName);


                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet ws = package.Workbook.Worksheets.Add("DoanhThu");

                    // ===== TIÊU ĐỀ =====
                    ws.Cells["A1"].Value = "BÁO CÁO DOANH THU";
                    ws.Cells["A1:D1"].Merge = true;
                    ws.Cells["A1"].Style.Font.Size = 16;
                    ws.Cells["A1"].Style.Font.Bold = true;
                    ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    // ===== THỜI GIAN =====
                    ws.Cells["A2"].Value = "Từ ngày:";
                    ws.Cells["B2"].Value = dtpTuNgay.Value.ToString("dd/MM/yyyy");
                    ws.Cells["C2"].Value = "Đến ngày:";
                    ws.Cells["D2"].Value = dtpDenNgay.Value.ToString("dd/MM/yyyy");

                    // ===== HEADER TABLE =====
                    ws.Cells["A4"].Value = "Mã vé";
                    ws.Cells["B4"].Value = "Loại vé";
                    ws.Cells["C4"].Value = "Giá vé";
                    ws.Cells["D4"].Value = "Ngày bán";

                    using (var range = ws.Cells["A4:D4"])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    // ===== GHI DỮ LIỆU =====
                    int row = 5;
                    foreach (DataRow dr in dtThongKe.Rows)
                    {
                        ws.Cells[row, 1].Value = dr["TicketID"];
                        ws.Cells[row, 2].Value = dr["TypeName"];
                        ws.Cells[row, 3].Value = Convert.ToDecimal(dr["Price"]);
                        ws.Cells[row, 4].Value = Convert.ToDateTime(dr["CreatedAt"]).ToString("dd/MM/yyyy HH:mm");
                        row++;
                    }

                    // ===== TỔNG KẾT =====
                    ws.Cells[row + 1, 2].Value = "Tổng số vé:";
                    ws.Cells[row + 1, 3].Value = dtThongKe.Rows.Count;

                    decimal tongTien = 0;
                    foreach (DataRow dr in dtThongKe.Rows)
                        tongTien += Convert.ToDecimal(dr["Price"]);

                    ws.Cells[row + 2, 2].Value = "Tổng doanh thu:";
                    ws.Cells[row + 2, 3].Value = tongTien;
                    ws.Cells[row + 2, 3].Style.Numberformat.Format = "#,##0";

                    // ===== AUTO FIT =====
                    ws.Cells.AutoFitColumns();

                    package.Save();
                }

                MessageBox.Show("Xuất Excel thành công!");
            }
        }
    }
}
