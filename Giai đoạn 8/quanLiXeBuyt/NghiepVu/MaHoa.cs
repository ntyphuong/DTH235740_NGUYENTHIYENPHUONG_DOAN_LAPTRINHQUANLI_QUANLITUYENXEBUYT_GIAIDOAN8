using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace quanLiXeBuyt.NghiepVu
{
    internal class MaHoa
    {       
        public static string BamMatKhau(string matKhau)
        {
            return BCrypt.Net.BCrypt.HashPassword(matKhau);
        }
        public static bool KiemTra(string matKhau, string matKhauBam)
        {
            return BCrypt.Net.BCrypt.Verify(matKhau, matKhauBam);
        }
    }
}
