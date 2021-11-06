using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.DTO
{
    class NCC
    {
        int mancc;
        string tenncc;
        string diachi;
        string sdt;

        public int Mancc { get => mancc; set => mancc = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public NCC(int mancc, string tenncc, string diachi, string sdt)
        {
            this.Mancc = mancc;
            this.Tenncc = tenncc;
            this.Diachi = diachi;
            this.Sdt = sdt;
        }

        public NCC()
        {
        }
    }
}
