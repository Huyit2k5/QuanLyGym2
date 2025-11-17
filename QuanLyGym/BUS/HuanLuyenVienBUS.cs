using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGym.Modals;

namespace QuanLyGym.BUS
{
    public class HuanLuyenVienBUS
    {
        DBConnect db = new DBConnect();

        //Lấy tất cả Huấn luyện viên
        public DataTable GetAllHLV()
        {

            string sql = "SELECT MaHLV, TenHLV, GioiTinh, ChuyenMon, SDT, NamKinhNghiem FROM HuanLuyenVien";
            return db.GetData(sql);
        }


        public string TuDongSinhMaHLV()
        {
            string sql = "SELECT MAX(MaHLV) FROM HuanLuyenVien";
            DataTable dt = db.GetData(sql);

            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
            {
                return "HLV001";
            }

            string maxMa = dt.Rows[0][0].ToString();
            string numberPart = new string(maxMa.Where(char.IsDigit).ToArray());
            int.TryParse(numberPart, out int num);
            num++;
            return "HLV" + num.ToString("D3");
        }

        //Thêm Huấn luyện viên
        public bool ThemHLV(HuanLuyenVien hlv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PROC_THEM_HLV");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHLV", TuDongSinhMaHLV());
                cmd.Parameters.AddWithValue("@TenHLV", hlv.TenHLV);
                cmd.Parameters.AddWithValue("@GioiTinh", hlv.GioiTinh);
                cmd.Parameters.AddWithValue("@ChuyenMon", hlv.ChuyenMon);
                cmd.Parameters.AddWithValue("@SDT", hlv.Sdt);
                cmd.Parameters.AddWithValue("@NamKinhNghiem", hlv.NamKinhNghiem);

                // Thêm logic HinhAnh
                if (string.IsNullOrEmpty(hlv.HinhAnh))
                {
                    cmd.Parameters.AddWithValue("@HinhAnh", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@HinhAnh", hlv.HinhAnh);
                }

                return db.ExecuteNonQuery(cmd); // Dùng hàm an toàn
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi BUS ThemHLV: " + ex.Message);
                return false;
            }
        }

        //Sửa Huấn luyện viên
        public bool SuaHLV(HuanLuyenVien hlv)
        {
            try
            {
                db.OpenConn();
                string sql = string.Format("EXEC PROC_SUA_HLV '{0}', N'{1}', N'{2}', N'{3}', '{4}', {5}",
                    hlv.MaHLV,
                    hlv.TenHLV,
                    hlv.GioiTinh,
                    hlv.ChuyenMon,
                    hlv.Sdt,
                    hlv.NamKinhNghiem);

                db.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Xóa Huấn luyện viên
        public bool XoaHLV(string maHLV)
        {
            try
            {
                db.OpenConn();
                string sql = "EXEC PROC_XOA_HLV '" + maHLV + "'";
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public DataTable GetHocVien_ByHLV(string maHLV)
        {
            string sql = "EXEC PROC_GetHocVien_ByHLV '" + maHLV + "'";
            return db.GetData(sql);
        }


        public DataTable GetLop_ByHLV(string maHLV)
        {
            string sql = "EXEC PROC_GetLop_ByHLV '" + maHLV + "'";
            return db.GetData(sql);


        }

        // Lấy gói PT CÒN HẠN của 1 hội viên

        public DataTable GetPT_ByKH(string maKH)
        {
            SqlCommand cmd = new SqlCommand("PROC_GetPT_ByKH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", maKH);

            return db.GetData(cmd);
        }

        public DataTable GetLichDayLop(string maHLV)
        {
            SqlCommand cmd = new SqlCommand("PROC_GetLichDayLop_ByHLV"); // Giả sử PROC này chưa có, xem bên dưới
                                                                         // Hoặc dùng PROC_GetSchedule_LopTrongTuan (vì logic giống nhau)
                                                                         // Nếu dùng PROC_GetSchedule_LopTrongTuan, bạn phải đổi tham số một chút

            // Cách đơn giản nhất: Dùng PROC_GetSchedule_LopTrongTuan mà bạn đã có
            // Vì PROC này đã lọc theo MaHLV rồi.
            cmd = new SqlCommand("PROC_GetSchedule_LopTrongTuan");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHLV", maHLV);
            return db.GetData(cmd);
        }

        //Lấy lịch dạy PT của HLV 
        public DataTable GetLichDayPT(string maHLV, DateTime batDau, DateTime ketThuc)
        {
            SqlCommand cmd = new SqlCommand("PROC_GetLichDayPT_ByHLV");
            cmd.CommandType = CommandType.StoredProcedure;

            // 1. Thêm tham số HLV
            cmd.Parameters.AddWithValue("@MaHLV", maHLV);

            // 2. THÊM ĐỦ 2 THAM SỐ NGÀY (QUAN TRỌNG)
            // Lưu ý: Tên tham số phải khớp với trong SQL (@TuNgay, @DenNgay)
            cmd.Parameters.Add("@TuNgay", SqlDbType.Date).Value = batDau.Date;
            cmd.Parameters.Add("@DenNgay", SqlDbType.Date).Value = ketThuc.Date;

            return db.GetData(cmd);
        }
        // Trong HuanLuyenVienBUS.cs

        public bool DangKyGoiPT(string maKH, string maGoiPT, DateTime ngayBatDau) // << Bỏ string maNV
        {
            SqlCommand cmd = new SqlCommand("PROC_DangKy_GoiPT");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", maKH);
            // cmd.Parameters.AddWithValue("@MaNV", maNV); // << XÓA DÒNG NÀY
            cmd.Parameters.AddWithValue("@MaGoiPT", maGoiPT);
            cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau.Date;

            DataTable dt = db.GetData(cmd);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Success"].ToString() == "1";
            }
            return false;
        }

        public DataTable GetAllGoiPT()
        {
            // Gọi PROC để lấy danh sách: Mã, Tên, Số buổi, Đơn giá
            SqlCommand cmd = new SqlCommand("PROC_GetAll_GoiPT");
            cmd.CommandType = CommandType.StoredProcedure;

            return db.GetData(cmd);
        }

        public DataTable GetOnlyPT()
        {
            SqlCommand cmd = new SqlCommand("PROC_GetOnlyPT");
            cmd.CommandType = CommandType.StoredProcedure;
            return db.GetData(cmd);
        }

    }
}
