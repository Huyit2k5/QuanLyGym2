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
        static string conStr = "Data Source=localhost;Initial Catalog=QL_GYM;Integrated Security=True;";

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

        public DataTable GetData(SqlCommand cmd)
        {
            try
            {
                OpenConn();
                cmd.Connection = conn; // Gán connection cho command
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CloseConn();
                return dt;
            }
            catch (Exception ex)
            {
                CloseConn();
                Console.WriteLine("Lỗi DBConnect.GetData(cmd): " + ex.Message);
                return null;
            }
        }

        /**
         * Hàm này dùng cho INSERT, UPDATE, DELETE (có tham số)
         */
        public bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                OpenConn();
                cmd.Connection = conn; // Gán connection cho command
                cmd.ExecuteNonQuery();
                CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                CloseConn();
                Console.WriteLine("Lỗi DBConnect.ExecuteNonQuery(cmd): " + ex.Message);
                return false;
            }
        }

    }
}
