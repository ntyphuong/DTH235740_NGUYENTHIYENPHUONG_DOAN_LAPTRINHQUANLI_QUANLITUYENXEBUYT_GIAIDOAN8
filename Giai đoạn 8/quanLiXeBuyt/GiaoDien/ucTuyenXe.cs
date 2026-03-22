using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using MySql.Data.MySqlClient;
using quanLiXeBuyt.DuLieu;

namespace quanLiXeBuyt.GiaoDien
{
    public partial class ucTuyenXe : UserControl
    {
        KetNoiCSDL db = new KetNoiCSDL();
        GMapOverlay routeOverlay = new GMapOverlay("routes");
        string tuyenID_DangChon = "";

        public ucTuyenXe()
        {
            InitializeComponent();
            KhoiTaoBanDo();
            LoadComboBoxStops();
            LoadDataTuyen();
        }

        private void KhoiTaoBanDo()
        {          
            mapTuyen.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            mapTuyen.MinZoom = 2;
            mapTuyen.MaxZoom = 20;
            mapTuyen.Zoom = 16; 

            mapTuyen.Position = new PointLatLng(10.3734, 105.4372);

            mapTuyen.CanDragMap = true;
            mapTuyen.DragButton = MouseButtons.Left;

            mapTuyen.Overlays.Add(routeOverlay);
        }

        private void LoadComboBoxStops()
        {
            string sql = "SELECT StopID, StopName FROM Stops";
            DataTable dt = db.LayDuLieu(sql);

            cboTramDau.DataSource = dt;
            cboTramDau.DisplayMember = "StopName";
            cboTramDau.ValueMember = "StopID";

            cboTramCuoi.DataSource = dt.Copy();
            cboTramCuoi.DisplayMember = "StopName";
            cboTramCuoi.ValueMember = "StopID";
        }

        private void LoadDataTuyen()
        {

            string sql = @"SELECT r.RouteID, r.RouteName, r.BaseFare, 
                   s1.StopName as StartStop, s2.StopName as EndStop,
                   r.StartStopID, r.EndStopID
                   FROM routes r
                   JOIN stops s1 ON r.StartStopID = s1.StopID
                   JOIN stops s2 ON r.EndStopID = s2.StopID";
            dgvTuyenXe.DataSource = db.LayDuLieu(sql);
        }

        private void btnThemTram_Click(object sender, EventArgs e)
        {
            // Kiểm tra không để trống Mã tuyến và Tên tuyến
            if (string.IsNullOrEmpty(txtMaTuyen.Text) || string.IsNullOrEmpty(txtTenTuyen.Text))
            {
                MessageBox.Show("Bạn nhập đầy đủ Mã và Tên tuyến giúp tui nha!");
                return;
            }

            // Kiểm tra giá vé phải là số 
            if (!int.TryParse(txtGiaVe.Text, out int giaVe))
            {
                MessageBox.Show("Giá vé phải là số nha!");
                return;
            }

            string sql = "INSERT INTO routes (RouteID, RouteName, BaseFare, StartStopID, EndStopID) VALUES (@id, @name, @fare, @start, @end)";

            MySqlParameter[] p = {
            new MySqlParameter("@id", txtMaTuyen.Text.Trim()),
            new MySqlParameter("@name", txtTenTuyen.Text.Trim()),
            new MySqlParameter("@fare", giaVe),
            new MySqlParameter("@start", cboTramDau.SelectedValue),
            new MySqlParameter("@end", cboTramCuoi.SelectedValue)
        };

            try
            {
                if (db.ThucThi(sql, p) > 0)
                {
                    MessageBox.Show("Thêm tuyến " + txtMaTuyen.Text + " thành công rồi nè!");
                    LoadDataTuyen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi: " + ex.Message);
            }
        }

        private void btnSuaTram_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE routes SET RouteName = @name, BaseFare = @fare, StartStopID = @start, EndStopID = @end WHERE RouteID = @id";

            MySqlParameter[] p = {
            new MySqlParameter("@name", txtTenTuyen.Text.Trim()),
            new MySqlParameter("@fare", txtGiaVe.Text),
            new MySqlParameter("@start", cboTramDau.SelectedValue),
            new MySqlParameter("@end", cboTramCuoi.SelectedValue),
            new MySqlParameter("@id", txtMaTuyen.Text.Trim())
    };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Đã cập nhật xong tuyến " + txtMaTuyen.Text);
                LoadDataTuyen();
            }
        }
        private void btnXoaTram_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tuyenID_DangChon))
            {
                MessageBox.Show("Bạn chọn tuyến cần xóa trong bảng trước đã nhen!");
                return;
            }

            if (MessageBox.Show("Xóa tuyến này bạn chắc chứ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM routes WHERE RouteID = @id";
                MySqlParameter[] p = { new MySqlParameter("@id", tuyenID_DangChon) };

                if (db.ThucThi(sql, p) > 0)
                {
                    MessageBox.Show("Xóa xong rồi nhen!");
                    LoadDataTuyen();
                    tuyenID_DangChon = "";

                    txtMaTuyen.Clear();
                    txtTenTuyen.Clear();
                    txtGiaVe.Clear();
                }
            }
        }

        private void dgvTuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTuyenXe.Rows[e.RowIndex];
                tuyenID_DangChon = row.Cells["RouteID"].Value.ToString();

                txtMaTuyen.Text = tuyenID_DangChon;
                txtTenTuyen.Text = row.Cells["RouteName"].Value.ToString();
                txtGiaVe.Text = row.Cells["BaseFare"].Value.ToString();

                cboTramDau.SelectedValue = row.Cells["StartStopID"].Value;
                cboTramCuoi.SelectedValue = row.Cells["EndStopID"].Value;

                VeTuyenDuong(row.Cells["StartStopID"].Value.ToString(), row.Cells["EndStopID"].Value.ToString());
            }
        }
        private void VeTuyenDuong(string startStopID, string endStopID)
        {
            if (string.IsNullOrEmpty(startStopID) || string.IsNullOrEmpty(endStopID)) return;

            routeOverlay.Routes.Clear();
            routeOverlay.Markers.Clear(); 
                                          
            DataTable dt1 = db.LayDuLieu("SELECT Latitude, Longitude FROM stops WHERE StopID = '" + startStopID + "'");
            DataTable dt2 = db.LayDuLieu("SELECT Latitude, Longitude FROM stops WHERE StopID = '" + endStopID + "'");

            if (dt1.Rows.Count > 0 && dt2.Rows.Count > 0)
            {
                PointLatLng p1 = new PointLatLng(Convert.ToDouble(dt1.Rows[0]["Latitude"]), Convert.ToDouble(dt1.Rows[0]["Longitude"]));
                PointLatLng p2 = new PointLatLng(Convert.ToDouble(dt2.Rows[0]["Latitude"]), Convert.ToDouble(dt2.Rows[0]["Longitude"]));

                // Vẽ đường nối
                GMapRoute route = new GMapRoute(new List<PointLatLng> { p1, p2 }, "TuyenDuong");
                route.Stroke = new Pen(Color.Red, 3);
                routeOverlay.Routes.Add(route);

                routeOverlay.Markers.Add(new GMap.NET.WindowsForms.Markers.GMarkerGoogle(p1, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_dot));
                routeOverlay.Markers.Add(new GMap.NET.WindowsForms.Markers.GMarkerGoogle(p2, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot));

                mapTuyen.ZoomAndCenterRoute(route);
                mapTuyen.Refresh();
            }
        }     
        private void cboTramDau_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboTramDau.SelectedValue != null && cboTramCuoi.SelectedValue != null)
            {
                if (cboTramDau.SelectedValue is string && cboTramCuoi.SelectedValue is string)
                {
                    VeTuyenDuong(cboTramDau.SelectedValue.ToString(), cboTramCuoi.SelectedValue.ToString());
                }
            }
        }      
    }
}