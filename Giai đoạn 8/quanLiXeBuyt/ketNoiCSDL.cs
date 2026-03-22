using System;
using System.Data;
using MySql.Data.MySqlClient; 

namespace quanLiLoTrinhXeBuyt.DuLieu
{
    public class KetNoiCSDL
    {
        private string chuoiKetNoi = "Server=localhost;Database=quanLiLoTrinhXeBuyt;Uid=root;Pwd=123456;Charset=utf8mb4";

        public MySqlConnection LayKetNoi()
        {
            return new MySqlConnection(chuoiKetNoi);
        }

        public DataTable LayDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = LayKetNoi())
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
            }
            return dt;
        }

        public int ThucThi(string sql, MySqlParameter[] thamSo = null)
        {
            int ketQua = 0;
            try
            {
                using (MySqlConnection conn = LayKetNoi())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                    ketQua = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thực thi: " + ex.Message);
            }
            return ketQua;
        }
    }
}