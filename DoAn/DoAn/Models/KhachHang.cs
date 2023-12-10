using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class KhachHang
    {
        private string maKH;
        private string tenKH;
        private string sdt;
        private string gioitinh;
        private int sove;
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Sove { get => sove; set => sove = value; }
    }
}
