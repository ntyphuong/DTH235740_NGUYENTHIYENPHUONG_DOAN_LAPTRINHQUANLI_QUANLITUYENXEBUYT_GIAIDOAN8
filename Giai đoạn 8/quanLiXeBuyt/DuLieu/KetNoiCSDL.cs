using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace quanLiXeBuyt.DuLieu
{
    public class KetNoiCSDL
    {
        private string chuoiKetNoi = "Server=localhost;Database=quanlyxebuyt;Uid=root;Pwd=123456;Charset=utf8mb4";

        public MySqlConnection LayKetNoi()
        {
            return new MySqlConnection(chuoiKetNoi);
        }

        public DataTable LayDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = LayKetNoi())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable LayDuLieuVoiThamSo(string sql, MySqlParameter[] thamSo)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = LayKetNoi())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (thamSo != null) cmd.Parameters.AddRange(thamSo);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public int ThucThi(string sql, MySqlParameter[] thamSo = null)
        {
            using (MySqlConnection conn = LayKetNoi())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}