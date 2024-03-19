using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocCacCuPhapLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = { 1, 2, 3, 4, 5, 6, 7 };
        private void button1_Click(object sender, EventArgs e)
        {
            var dsSochan = from x in a
                           where x % 2 == 0
                           select x;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var dsSochan = from x in a where x % 2 == 0select x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dsSochan = a.Where(x => x % 2 == 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dsSochanSapxep = (from x in a
                                  where x % 2 == 0
                                  select x).OrderByDescending(x => x);
        }
    }
}
