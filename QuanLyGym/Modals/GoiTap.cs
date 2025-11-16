using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGym.Modals
{
    public class GoiTap
    {
        string maGoi;
        string tenGoi;
        float giaGoi;
        int thoiHanGoi;

        public string MaGoi { get => maGoi; set => maGoi = value; }
        public string TenGoi { get => tenGoi; set => tenGoi = value; }
        public float GiaGoi { get => giaGoi; set => giaGoi = value; }
        public int ThoiHanGoi { get => thoiHanGoi; set => thoiHanGoi = value; }
    }
}
