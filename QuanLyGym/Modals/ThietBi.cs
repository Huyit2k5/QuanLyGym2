using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.Modals
{
    public class ThietBi
    {
        string maThietBi;
        string tenThietBi;
        string loaiThietBi;
        string ghiChu;

        public string MaThietBi { get => maThietBi; set => maThietBi = value; }
        public string TenThietBi { get => tenThietBi; set => tenThietBi = value; }
        public string LoaiThietBi { get => loaiThietBi; set => loaiThietBi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
