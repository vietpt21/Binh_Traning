using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocToArray22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> lstInt = new List<int>();
            lstInt.AddRange(new int[] { 1, 2, 6, 4, 11, 45 });
            var arr= lstInt.ToArray();
            lblToArray.Text = "";
            for(int i = 0; i < arr.Length; i ++)
            {
                lblToArray.Text += arr[i]+" ";
            }
        }
    }
}
