using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using quanLiXeBuyt.DuLieu;
using System;
using System.Data;
using System.Windows.Forms;

namespace quanLiXeBuyt.GiaoDien
{
    public partial class ucTramDung : UserControl
    {
        KetNoiCSDL db = new KetNoiCSDL();
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        int stopID_DangChon = -1;
        public ucTramDung()
        {
            InitializeComponent();
            KhoiTaoBanDo();
            LoadData();
        }

        private void KhoiTaoBanDo()
        {
            mapTram.MapProvider = GMapProviders.GoogleMap;
            mapTram.Position = new PointLatLng(10.3734, 105.4372); 
            mapTram.MinZoom = 5;
            mapTram.MaxZoom = 20;
            mapTram.Zoom = 14;
            mapTram.Overlays.Add(markersOverlay);
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM Stops";
            DataTable dt = db.LayDuLieu(sql);
            dgvTramDung.DataSource = dt;

            markersOverlay.Markers.Clear();
            foreach (DataRow row in dt.Rows)
            {
                double lat = Convert.ToDouble(row["Latitude"]);
                double lng = Convert.ToDouble(row["Longitude"]);
                string name = row["StopName"].ToString();

                GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_pushpin);
                marker.ToolTipText = name;
                markersOverlay.Markers.Add(marker);
            }
        }

        private void dgvTramDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTramDung.Rows[e.RowIndex];

                stopID_DangChon = Convert.ToInt32(row.Cells["StopID"].Value);

                txtTenTram.Text = row.Cells["StopName"].Value.ToString();
                txtViDo.Text = row.Cells["Latitude"].Value.ToString();
                txtKinhDo.Text = row.Cells["Longitude"].Value.ToString();

                double lat = Convert.ToDouble(row.Cells["Latitude"].Value);
                double lng = Convert.ToDouble(row.Cells["Longitude"].Value);
                mapTram.Position = new PointLatLng(lat, lng);
                mapTram.Zoom = 16;
            }
        }

        private void btnThemTram_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Stops (StopName, Latitude, Longitude) VALUES (@name, @lat, @lng)";
            MySql.Data.MySqlClient.MySqlParameter[] p = {
            new MySql.Data.MySqlClient.MySqlParameter("@name", txtTenTram.Text),
            new MySql.Data.MySqlClient.MySqlParameter("@lat", txtViDo.Text),
            new MySql.Data.MySqlClient.MySqlParameter("@lng", txtKinhDo.Text)
        };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Thêm trạm thành công!");
                LoadData(); 
            }
        }

        
        private void btnXoaTram_Click(object sender, EventArgs e)
        {
            if (stopID_DangChon == -1)
            {
                MessageBox.Show("BẠN chọn trạm muốn xóa đi đã!");
                return;
            }

            DialogResult dr = MessageBox.Show("BẠN có chắc muốn xóa trạm này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string sql = "DELETE FROM Stops WHERE StopID = @id";
                MySqlParameter[] p = { new MySqlParameter("@id", stopID_DangChon) };

                if (db.ThucThi(sql, p) > 0)
                {
                    MessageBox.Show("Xóa xong rồi!");
                    LoadData(); 
                         
                    txtTenTram.Clear(); txtViDo.Clear(); txtKinhDo.Clear();
                    stopID_DangChon = -1;
                }
            }
        }

        private void btnSuaTram_Click(object sender, EventArgs e)
        {
            if (stopID_DangChon == -1)
            {
                MessageBox.Show("BẠN phải chọn một trạm trong bảng để sửa chứ!");
                return;
            }

            string sql = "UPDATE Stops SET StopName = @name, Latitude = @lat, Longitude = @lng WHERE StopID = @id";

            MySqlParameter[] p = {
            new MySqlParameter("@name", txtTenTram.Text),
            new MySqlParameter("@lat", txtViDo.Text),
            new MySqlParameter("@lng", txtKinhDo.Text),
            new MySqlParameter("@id", stopID_DangChon)
        };

            if (db.ThucThi(sql, p) > 0)
            {
                MessageBox.Show("Cập nhật trạm thành công rồi nè!");
                LoadData(); 
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
