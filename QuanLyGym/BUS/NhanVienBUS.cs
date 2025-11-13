using QuanLyGym.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.BUS
{
    public class NhanVienBUS
    {
        DBConnect db = new DBConnect();

        public string TuDongSinhMaNV()
        {
            string sql = "SELECT MAX(MaNV) FROM NhanVien";
            DataTable dt = db.GetData(sql);

            if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
            {
                return "NV001"; // Nếu chưa có khách hàng nào
            }

            string maxMa = dt.Rows[0][0].ToString(); // VD: "KH005"
            string numberPart = new string(maxMa.Where(char.IsDigit).ToArray()); // => "005"

            int num = 0;
            int.TryParse(numberPart, out num);
            num++;

            return "NV" + num.ToString("D3"); // => KH006
        }

        public DataTable LoadNV()
        {
            string sql = "SELECT * FROM NhanVien";
            DataTable dt = db.GetData(sql);
            return dt;
        }
        public bool ThemNV(NhanVien nv)
        {
            try
            {
                db.OpenConn();
                string sql = "EXEC ThemNhanVien @MaNV = '"+nv.MaNV+"', @TenNV = N'"+nv.TenNV+"', @GioiTinh = N'"+nv.GioiTinh+"', @SDT = '"+nv.Sdt+"', @ChucVu = N'"+nv.ChucVu+"';";
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
