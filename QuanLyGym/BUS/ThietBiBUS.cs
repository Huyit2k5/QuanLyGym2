using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGym.Modals;

namespace QuanLyGym.BUS
{
    internal class ThietBiBUS
    {
        DBConnect db = new DBConnect();

        //====================================================================
        // PHẦN 1: XỬ LÝ BẢNG MASTER (ThietBi - Lưới bên trái)
        //====================================================================

        // (Hàm này của bạn đã có)
        public DataTable GetAllTB_WithCount()
        {
            string sql = "EXEC PROC_GetAllThietBi_WithCount";
            return db.GetData(sql);
        }

        // (Hàm này của bạn đã có)
        public string TuDongSinhMaTB()
        {
            string sql = "SELECT MAX(MaThietBi) FROM ThietBi";
            DataTable dt = db.GetData(sql);

            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
                return "TB001";

            string maxMa = dt.Rows[0][0].ToString();
            string numberPart = new string(maxMa.Where(char.IsDigit).ToArray());
            int.TryParse(numberPart, out int num);
            num++;
            return "TB" + num.ToString("D3");
        }

        // Thêm một "Loại" thiết bị mới
        public bool ThemTB(ThietBi tb)
        {
            try
            {
                db.OpenConn();
                // Giả sử GhiChu là ""
                string sql = "EXEC PROC_THEM_TB '" + TuDongSinhMaTB() + "', N'" + tb.TenThietBi + "', N'" + tb.LoaiThietBi + "', N''";
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch { return false; }
        }

        // Sửa một "Loại" thiết bị
        public bool SuaTB(ThietBi tb)
        {
            try
            {
                db.OpenConn();
                string sql = "EXEC PROC_SUA_TB '" + tb.MaThietBi + "', N'" + tb.TenThietBi + "', N'" + tb.LoaiThietBi + "', N''";
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch { return false; }
        }

        // Xóa một "Loại" thiết bị (và các chi tiết của nó)
        public bool XoaTB(string maThietBi)
        {
            try
            {
                db.OpenConn();
                string sql = "EXEC PROC_XOA_TB '" + maThietBi + "'";
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch { return false; }
        }

        //====================================================================
        // PHẦN 2: XỬ LÝ BẢNG DETAIL (ChiTietThietBi - Lưới bên phải)
        //====================================================================

        // Lấy chi tiết theo MaThietBi (để liên kết 2 lưới)
        public DataTable GetChiTiet_ByMaTB(string maThietBi)
        {
            string sql = "EXEC PROC_GetChiTiet_ByMaTB '" + maThietBi + "'";
            return db.GetData(sql);
        }

        // Tự động sinh mã cho Chi Tiết (ví dụ: CTTB001)
        public string TuDongSinhMaCTTB()
        {
            string sql = "SELECT MAX(MaChiTietTB) FROM ChiTietThietBi";
            DataTable dt = db.GetData(sql);

            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
                return "CTTB001";

            string maxMa = dt.Rows[0][0].ToString();
            string numberPart = new string(maxMa.Where(char.IsDigit).ToArray());
            int.TryParse(numberPart, out int num);
            num++;
            return "CTTB" + num.ToString("D3");
        }

        // Thêm một "cái" máy cụ thể
        public bool ThemCTTB(ChiTietThietBi cttb)
        {
            try
            {
                db.OpenConn();
                string sql = string.Format("EXEC PROC_THEM_CTTB '{0}', '{1}', N'{2}', N'{3}', '{4}', N'{5}'",
                    TuDongSinhMaCTTB(),
                    cttb.MaThietBi,
                    cttb.SoHieuMay,
                    cttb.HangSanXuat,
                    cttb.NgayNhap.ToString("yyyy-MM-dd"), // Format ngày cho SQL
                    cttb.TinhTrang);
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch { return false; }
        }

        // Sửa một "cái" máy cụ thể
        public bool SuaCTTB(ChiTietThietBi cttb)
        {
            try
            {
                db.OpenConn();
                string sql = string.Format("EXEC PROC_SUA_CTTB '{0}', N'{1}', N'{2}', '{3}', N'{4}'",
                    cttb.MaChiTietTB,
                    cttb.SoHieuMay,
                    cttb.HangSanXuat,
                    cttb.NgayNhap.ToString("yyyy-MM-dd"),
                    cttb.TinhTrang);
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch { return false; }
        }

        // Xóa một "cái" máy cụ thể
        public bool XoaCTTB(string maChiTietTB)
        {
            try
            {
                db.OpenConn();
                string sql = "EXEC PROC_XOA_CTTB '" + maChiTietTB + "'";
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch { return false; }
        }


    }

}
