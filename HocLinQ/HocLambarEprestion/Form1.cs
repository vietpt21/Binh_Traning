using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLambarEprestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int Change(int x);
        public int Cong(int x)
        {
            return x + 2;
        }

        private void btnLabda_Click(object sender, EventArgs e)
        {
            Change d = new Change(Cong);
            Change d1 = ((int x) => x + 2);
            Change d2 = x => x + 3;
            Change d4 = delegate (int x)
            {
                return x + 4;
            };
            label1.Text = d(2) + "-" + d1(2) + "-" + d2(2) + "-" + d4(4);
        }
    }
}
