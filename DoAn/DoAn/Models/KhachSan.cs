using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class KhachSan
    {
        private string maKS;
        private string tenKS;
        private int giaKS;
        private string diachi;
        private string maloaiKS;

        public string MaKS { get => maKS; set => maKS = value; }
        public string TenKS { get => tenKS; set => tenKS = value; }
        public int GiaKS { get => giaKS; set => giaKS = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string MaloaiKS { get => maloaiKS; set => maloaiKS = value; }
    }
}
