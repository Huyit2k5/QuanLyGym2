using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyGym.BUS
{
    internal class LichBUS
    {
        DBConnect db = new DBConnect();

        public DataTable GetLichLop(string maHLV)
        {
            // 1. Tạo Command và chỉ định tên PROC
            SqlCommand cmd = new SqlCommand("PROC_GetSchedule_LopTrongTuan");
            cmd.CommandType = CommandType.StoredProcedure;

            // 2. Xử lý tham số MaHLV (có thể là NULL)
            if (string.IsNullOrEmpty(maHLV))
            {
                // Nếu không lọc, gửi DBNull
                cmd.Parameters.AddWithValue("@MaHLV", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@MaHLV", maHLV);
            }

            // 3. Gọi hàm GetData(cmd) đã nâng cấp trong DBConnect
            return db.GetData(cmd);
        }

        /**
         * Lấy danh sách LỊCH PT (linh hoạt) trong 1 tuần cụ thể
         * (Gọi PROC_GetSchedule_PTTrongTuan)
         */
        public DataTable GetLichPT(DateTime ngayBatDauTuan, DateTime ngayKetThucTuan, string maHLV)
        {
            // 1. Tạo Command và chỉ định tên PROC
            SqlCommand cmd = new SqlCommand("PROC_GetSchedule_PTTrongTuan");
            cmd.CommandType = CommandType.StoredProcedure;

            // 2. Thêm tham số ngày (chỉ gửi Date, không gửi Time)
            cmd.Parameters.Add("@NgayBatDauTuan", SqlDbType.Date).Value = ngayBatDauTuan.Date;
            cmd.Parameters.Add("@NgayKetThucTuan", SqlDbType.Date).Value = ngayKetThucTuan.Date;

            // 3. Xử lý tham số MaHLV (có thể là NULL)
            if (string.IsNullOrEmpty(maHLV))
            {
                cmd.Parameters.AddWithValue("@MaHLV", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@MaHLV", maHLV);
            }

            // 4. Gọi hàm GetData(cmd) đã nâng cấp trong DBConnect
            return db.GetData(cmd);
        }


        
        public DataTable GetLichLop_ByKH(string maKH, DateTime ngayBatDauTuan, DateTime ngayKetThucTuan) // << THÊM THAM SỐ
        {
            SqlCommand cmd = new SqlCommand("PROC_GetSchedule_Lop_ByKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", maKH);

            // Thêm 2 tham số ngày
            cmd.Parameters.Add("@NgayBatDauTuan", SqlDbType.Date).Value = ngayBatDauTuan.Date;
            cmd.Parameters.Add("@NgayKetThucTuan", SqlDbType.Date).Value = ngayKetThucTuan.Date;

            return db.GetData(cmd);
        }

        /**
         * Lấy danh sách LỊCH PT (linh hoạt) của MỘT HỘI VIÊN
         */
        public DataTable GetLichPT_ByKH(string maKH, DateTime ngayBatDauTuan, DateTime ngayKetThucTuan)
        {
            SqlCommand cmd = new SqlCommand("PROC_GetSchedule_PT_ByKH");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.Parameters.Add("@NgayBatDauTuan", SqlDbType.Date).Value = ngayBatDauTuan.Date;
            cmd.Parameters.Add("@NgayKetThucTuan", SqlDbType.Date).Value = ngayKetThucTuan.Date;

            return db.GetData(cmd);
        }

    }
}

