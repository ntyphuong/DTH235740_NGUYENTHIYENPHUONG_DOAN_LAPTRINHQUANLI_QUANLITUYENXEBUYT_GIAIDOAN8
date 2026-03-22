using MySql.Data.MySqlClient;
using quanLiXeBuyt.DuLieu;
using quanLiXeBuyt.NghiepVu;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KetNoiCSDL db = new KetNoiCSDL();
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text;

            string sql = "SELECT * FROM Users WHERE Username = @user AND Password = @pass";

            MySqlParameter[] p = {
                new MySqlParameter("@user", user),
                new MySqlParameter("@pass", pass)
            };

            DataTable dt = db.LayDuLieuVoiThamSo(sql, p);

            if (dt.Rows.Count > 0)
            {
                PhanQuyen.FullName = dt.Rows[0]["FullName"].ToString();
                PhanQuyen.RoleID = Convert.ToInt32(dt.Rows[0]["RoleID"]);

                MessageBox.Show("Chào mừng " + PhanQuyen.FullName);

                this.Hide();
                frmChinh f = new frmChinh();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai rồi! Vui lòng nhập lại!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
