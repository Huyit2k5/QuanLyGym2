using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.Modals
{
    public class ChiTietThietBi
    {
        string maChiTietTB;
        string maThietBi;
        string soHieuMay;
        string hangSanXuat;
        DateTime ngayNhap;
        string tinhTrang;

        public string MaChiTietTB { get => maChiTietTB; set => maChiTietTB = value; }
        public string MaThietBi { get => maThietBi; set => maThietBi = value; }
        public string SoHieuMay { get => soHieuMay; set => soHieuMay = value; }
        public string HangSanXuat { get => hangSanXuat; set => hangSanXuat = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
