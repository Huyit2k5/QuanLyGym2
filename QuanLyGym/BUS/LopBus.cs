using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.BUS
{
    internal class LopBus
    {
        DBConnect db = new DBConnect();

        public DataTable GetAllGoiTap()
        {

            string sql = "select * from Lop";
            return db.GetData(sql);
        }
        public DataTable GetHoiVienByLop(string maLop)
        {
            // (Sử dụng cách gọi an toàn với Parameters)
            SqlCommand cmd = new SqlCommand("PROC_GetHoiVien_ByLop");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            return db.GetData(cmd);
        }
        // Lấy TẤT CẢ các lớp mà hội viên đã đăng ký
        public DataTable GetLop_ByKH(string maKH)
        {
            SqlCommand cmd = new SqlCommand("PROC_GetLop_ByKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", maKH);

            return db.GetData(cmd);
        }
    }
}
