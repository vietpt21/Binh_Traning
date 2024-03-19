using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLibrary1;

namespace HocExtentionMethod
{
    public static class MyExtentionMethod
    {
        public static int Tinhtong(this int n)
        {
            int x = int.Parse(n.ToString());
            for(int i = 0; i < n; i++)
            {
                x += i;
            }
            return x;
        }
        public static string Noichuoi(this string a, string b)
        {
            return a + b;
        }
        public static void Doimau(this Button btn)
        {
            btn.BackColor = Color.Red;
        }
        public static int TinhTuoi(this Student sv)
        {
            return DateTime.Now.Year - sv.NamSinh.Year + 1;
        }
    }
}
