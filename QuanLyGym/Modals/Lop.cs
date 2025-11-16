using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.Modals
{
    public class Lop
    {
        string maLop;
        string tenLop;
        string maHLV;
        float hocPhi;
        int soLuong;
      

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaHLV { get => maHLV; set => maHLV = value; }
        public float HocPhi { get => hocPhi; set => hocPhi = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public Lop() { }
    }
}
