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
                db.OpenConn();
                string sql = string.Format("EXEC PROC_THEM_HLV '{0}', N'{1}', N'{2}', N'{3}', '{4}', {5}",
                    TuDongSinhMaHLV(),
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
    }
}
