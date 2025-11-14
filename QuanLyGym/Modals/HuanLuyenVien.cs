using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.Modals
{
    public class HuanLuyenVien
    {
        string maHLV;
        string tenHLV;
        string sdt;
        string gioiTinh;
        string chuyenMon;
        int namKinhNghiem;

        public string MaHLV { get => maHLV; set => maHLV = value; }
        public string TenHLV { get => tenHLV; set => tenHLV = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
        public int NamKinhNghiem { get => namKinhNghiem; set => namKinhNghiem = value; }
    }
}
