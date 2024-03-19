using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int Change(int a);
        public int Tru(int a)
        {
            return a - 2;
        }
        public int Cong(int a)
        {
            return a + 2;
        }
        private void btnDategate_Click(object sender, EventArgs e)
        {
            Change x = new Change(Cong);
            label1.Text = x(100) +"";
               
        }
    }
}
