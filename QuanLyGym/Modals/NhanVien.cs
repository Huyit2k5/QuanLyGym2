using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.Modals
{
    public class NhanVien
    {
        string maNV;
        string tenNV;
        string gioiTinh;
        string sdt;
        string chucVu;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
