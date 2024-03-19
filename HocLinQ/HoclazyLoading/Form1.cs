using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoclazyLoading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSochan_Click(object sender, EventArgs e)
        {
            var arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            var value = (from x in arr
                        where x % 2 == 0
                        select x);//.tolist()   them tolist de dong goi gia tri
            arr.Add(10);
            arr.Add(11);
            arr.Add(12);
            foreach(var x in value)
            {
                listBox1.Items.Add(x);
            }
        }
    }
}
