using QuanLyGym.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.BUS
{
    public class KhachHangBUS
    {
        DBConnect db = new DBConnect();

        public string TuDongSinhMaKH()
        {
            string sql = "SELECT MAX(MaKH) FROM KhachHang";
            DataTable dt = db.GetData(sql);


            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
            {
                return "KH001"; // Nếu chưa có khách hàng nào
            }

            string maxMa = dt.Rows[0][0].ToString(); // VD: "KH005"
            string numberPart = new string(maxMa.Where(char.IsDigit).ToArray()); // => "005"

            int num = 0;
            int.TryParse(numberPart, out num);
            num++;

            return "KH" + num.ToString("D3"); // => KH006
        }

        public bool ThemKH(KhachHang kh)
        {
            // Tạo Command và chỉ định tên PROC
            SqlCommand cmd = new SqlCommand("THEM_KH");
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm Parameters
            cmd.Parameters.AddWithValue("@MAKH", TuDongSinhMaKH());
            cmd.Parameters.AddWithValue("@TENKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@NAMSINH", kh.NamSinh);
            cmd.Parameters.AddWithValue("@SDT", kh.Sdt);
            cmd.Parameters.AddWithValue("@GIOITINH", kh.GioiTinh);
            cmd.Parameters.AddWithValue("@EMAIL", kh.Email);

            if (string.IsNullOrEmpty(kh.HinhAnh))
                cmd.Parameters.AddWithValue("@HinhAnh", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@HinhAnh", kh.HinhAnh);

            return db.ExecuteNonQuery(cmd);
        }

        public bool XoaKH(string pMaKhoa)
        {
            try
            {
                db.OpenConn();
                string sql = "EXEC XOA_KH '" + pMaKhoa + "'";
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool SuaKH(KhachHang kh)
        {
            SqlCommand cmd = new SqlCommand("PROC_SUA_KH");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MAKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@TENKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@NAMSINH", kh.NamSinh);
            cmd.Parameters.AddWithValue("@SDT", kh.Sdt);
            cmd.Parameters.AddWithValue("@GIOITINH", kh.GioiTinh);
            cmd.Parameters.AddWithValue("@EMAIL", kh.Email);
            cmd.Parameters.AddWithValue("@TINHTRANG", kh.TinhTrang); 

            if (string.IsNullOrEmpty(kh.HinhAnh))
                cmd.Parameters.AddWithValue("@HinhAnh", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@HinhAnh", kh.HinhAnh);

            return db.ExecuteNonQuery(cmd);
        }

        public DataTable GetAllKH()
        {
            string sql = "SELECT MaKH, TenKH, SDT, GioiTinh, TinhTrang FROM KhachHang";
            return db.GetData(sql);
        }

        /// <summary>
        /// Lấy thông tin chi tiết của MỘT khách hàng bằng Mã
        /// </summary>
        /// <param name="maKH">Mã khách hàng cần lấy</param>
        /// <returns>Một DataRow chứa thông tin, hoặc null nếu không tìm thấy</returns>
        public DataRow GetKH_ById(string maKH)
        {
            string sql = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";

            SqlCommand cmd = new SqlCommand(sql); 
            cmd.Parameters.AddWithValue("@MaKH", maKH);

            DataTable dt = db.GetData(cmd); 
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }
    }
}
