using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGym.Forms
{
    public partial class frmLogin : Form
    {
        DBConnect db = new DBConnect();
        
        public frmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load;
            this.btn_Login.Click += Btn_Login_Click;
        }

        private bool CheckLoginExists(string username)
        {
            string query = "SELECT COUNT(*) AS CountLogin FROM sys.server_principals WHERE name = '"+username+"' AND type_desc = 'SQL_LOGIN' AND is_disabled = 0";

            DataTable dt = db.GetData(query);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["CountLogin"]) > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        private bool TryConnect(string username, string password)
        {
            string connStr = $"Data Source=localhost;Initial Catalog=QL_GYM;User ID={username};Password={password};";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                return true; // mở kết nối thành công -> đăng nhập đúng
                
            }
            catch
            {
                return false;
            }
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.Trim();
            string password = txt_Password.Text.Trim();

            if (!CheckLoginExists(username))
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc đã bị vô hiệu hóa.", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TryConnect(username, password))
            {
                DataTable rolesTable = db.GetUserRoles(username);

                bool isAdmin = false;

                string roleName = rolesTable.Rows[0]["RoleName"].ToString();

                if (rolesTable.Rows.Count > 0)
                {

                    if (roleName.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        isAdmin = true;
                    }
                }

                if (isAdmin)
                {
                    this.Hide();
                    frmAdmin AdminForm = new frmAdmin();
                    AdminForm.ShowDialog();
                }
                else
                {
                    if (cbo_Server.Text == "Admin")
                    {
                        MessageBox.Show("Tài khoản không có quyền");
                        return;
                    }
                    this.Hide();
                    frmMain mainForm = new frmMain();
                    mainForm.ShowDialog();
                    

                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cbo_Server.Items.Add("Admin");
            cbo_Server.Items.Add("NhanVien");
            cbo_Server.SelectedIndex = 0;
        }
    }
}

