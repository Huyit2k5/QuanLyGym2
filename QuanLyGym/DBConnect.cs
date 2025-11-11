using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym
{
    public class DBConnect
    {
        static string conStr = "Data Source=LAPTOP-KFHR4M8Q;Initial Catalog=QL_GYM;Integrated Security=True;";

        SqlConnection conn = new SqlConnection(conStr);

        // Mở kết nối
        public void OpenConn()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        // Đóng kết nối
        public void CloseConn()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        // Thực thi câu lệnh SQL (INSERT, UPDATE, DELETE) và trả về bảng
        public DataTable GetData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool ExecuteNonQuery(string sql)
        {
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
