using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocOfType16
{
    public class NhanVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public virtual double Luong()
        {
            return 5000000;
        }
    }
}
