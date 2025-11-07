using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.Modals
{
    public class KhachHang
    {
        string maKH;
        string tenKH;
        int namSinh;
        string sdt;
        string gioiTinh;
        string email;
        string tinhTrang;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
