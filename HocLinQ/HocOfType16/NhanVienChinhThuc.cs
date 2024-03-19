using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocOfType16
{
    internal class NhanVienChinhThuc:NhanVien
    {
        public override double Luong()
        {
            return base.Luong()+700000;
        }
    }
}
