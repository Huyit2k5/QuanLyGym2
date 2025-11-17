using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.BUS
{
    
    public class GoiTapBUS
    {
        DBConnect db = new DBConnect();

        public DataTable GetAllGoiTap()
        {

            string sql = "select * from GoiTap";
            return db.GetData(sql);
        }

        public string TuDongSinhMaGoiTap()
        {
            string sql = "SELECT MAX(MaGoi) FROM GoiTap";
            DataTable dt = db.GetData(sql);

            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
            {
                return "GT01";
            }

            string maxMa = dt.Rows[0][0].ToString();
            string numberPart = maxMa.Substring(2);
            int.TryParse(numberPart, out int num);
            num++;
            return "GT" + num.ToString("D2");
        }
        // Lấy gói tập (Thẻ thành viên) CÒN HẠN của 1 hội viên
        public DataTable GetGoiTap_ByKH(string maKH)
        {
            SqlCommand cmd = new SqlCommand("PROC_GetGoiTap_ByKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", maKH);

            return db.GetData(cmd);
        }

        public DataRow GetActiveTheThanhVien(string maKH)
        {
            SqlCommand cmd = new SqlCommand("PROC_GetGoiTap_ByKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", maKH);

            DataTable dt = db.GetData(cmd);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }

        // Hàm đăng ký
        public bool DangKyGoiMoi(string maKH, string maNV, string maGoi, DateTime ngayBatDau)
        {
            SqlCommand cmd = new SqlCommand("PROC_DangKy_GoiTap");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.Parameters.AddWithValue("@MaNV", maNV);
            cmd.Parameters.AddWithValue("@MaGoi", maGoi);
            cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau.Date;

            // PROC này trả về 1 (Success) hoặc 0 (Fail)
            DataTable dt = db.GetData(cmd);
            return (dt.Rows[0]["Success"].ToString() == "1");
        }






    }
}
