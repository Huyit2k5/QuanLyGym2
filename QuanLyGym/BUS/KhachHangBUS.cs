using QuanLyGym.Modals;
using System;
using System.Collections.Generic;
using System.Data;
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
            try
            {
                db.OpenConn();
                string sql = "EXEC THEM_KH '"+ TuDongSinhMaKH() + "', N'"+kh.TenKH+"', '"+kh.NamSinh+"', '"+kh.Sdt+"', N'"+kh.GioiTinh+"', '"+kh.Email+"', N'"+kh.TinhTrang+"'";
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
            
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

        //public bool SuaKH(KhachHang kh)
        //{
        //    try
        //    {
        //        db.OpenConn();
        //        string sql = "EXEC SUA_KH '" + kh.MaKH + "', N'" + kh.TenKH + "', '" + kh.NamSinh + "', '" + kh.Sdt + "', N'" + kh.GioiTinh + "', '" + kh.Email + "', N'" + kh.TinhTrang + "'";
        //        db.ExecuteNonQuery(sql);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public DataTable GetAllKH()
        {
            string sql = "SELECT MaKH, TenKH, SDT, GioiTinh, TinhTrang FROM KhachHang";
            return db.GetData(sql);
        }
    }
}
