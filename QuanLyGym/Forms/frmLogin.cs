using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGym.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                cbo_Server.Items.Clear();

                DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();

                foreach (DataRow row in table.Rows)
                {
                    string serverName = row["ServerName"].ToString();
                    string instanceName = row["InstanceName"].ToString();

                    string fullName = string.IsNullOrEmpty(instanceName)
                        ? serverName
                        : $"{serverName}\\{instanceName}";

                    // tránh duplicate
                    if (!cbo_Server.Items.Contains(fullName))
                        cbo_Server.Items.Add(fullName);
                }

                // Nếu không tìm thấy gì, thêm fallback cho local SQLEXPRESS
                if (cbo_Server.Items.Count == 0)
                {
                    string localExpress = Environment.MachineName + @"\SQLEXPRESS";
                    cbo_Server.Items.Add(localExpress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi liệt kê SQL Server instances:\n" + ex.Message);
                // thêm fallback chổ này nếu cần
                cbo_Server.Items.Add(Environment.MachineName + @"\SQLEXPRESS");
            }
        }

        //try
        //{
        //    RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
        //    String[] instances = (String[])rk.GetValue("InstalledInstances");
        //    if (instances.Length > 0)
        //    {
        //        foreach (String element in instances)
        //        {
        //            if (element == "MSSQLSERVER")
        //            {
        //                cbo_Server.Items.Add(Environment.MachineName);
        //            }
        //            else
        //            {
        //                cbo_Server.Items.Add(Environment.MachineName + @"\" + element);
        //            }
        //        }
        //        cbo_Server.SelectedIndex = 0;
        //    }
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Lỗi lấy tên server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        //try
        //{
        //    cbo_Server.Items.Clear();

        //    RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
        //    if (rk == null)
        //    {
        //        // Nếu không tìm thấy, thử thêm nhánh 64-bit
        //        rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Microsoft SQL Server");
        //    }

        //    if (rk != null)
        //    {
        //        string[] instances = (string[])rk.GetValue("InstalledInstances");

        //        if (instances != null && instances.Length > 0)
        //        {
        //            foreach (string instance in instances)
        //            {
        //                string serverName = instance.Equals("MSSQLSERVER", StringComparison.OrdinalIgnoreCase)
        //                    ? Environment.MachineName
        //                    : Environment.MachineName + @"\" + instance;

        //                cbo_Server.Items.Add(serverName);
        //            }

        //            cbo_Server.SelectedIndex = 0;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không tìm thấy instance SQL Server nào trên máy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không thể truy cập registry để lấy danh sách server.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Lỗi lấy tên server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
    }
    }

