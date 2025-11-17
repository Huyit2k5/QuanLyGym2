using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.BUS
{
    public class LopBUS
    {
        DBConnect db = new DBConnect();

        public DataTable GetAllLop()
        {
            
            SqlCommand cmd = new SqlCommand("PROC_GetAll_Lop");
            cmd.CommandType = CommandType.StoredProcedure;
            return db.GetData(cmd);
        }

        public DataTable GetAllLopForManage()
        {

            SqlCommand cmd = new SqlCommand("PROC_GetFull_Lop");
            cmd.CommandType = CommandType.StoredProcedure;
            return db.GetData(cmd);
        }


        public bool DangKyLop(string maKH, string maNV, string maLop, DateTime ngayBatDau, int soThang)
        {
            
            SqlCommand cmd = new SqlCommand("PROC_DangKy_Lop");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.Parameters.AddWithValue("@MaNV", maNV);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau.Date;
            cmd.Parameters.AddWithValue("@SoThang", soThang);

            DataTable dt = db.GetData(cmd);
            return (dt.Rows[0]["Success"].ToString() == "1");
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
