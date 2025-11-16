using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.BUS
{
    
    internal class GoiTapBUS
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
            string numberPart = new string(maxMa.Where(char.IsDigit).ToArray());
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

        
        
        
      

       
        
    }
}
