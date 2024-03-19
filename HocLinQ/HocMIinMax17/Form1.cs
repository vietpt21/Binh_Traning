using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocMIinMax17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> listInt = new List<int>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            for(int i =0; i<n; i++)
            {
                listInt.Add(rd.Next(100));
            }
            listInt.ForEach(x => listBox1.Items.Add(x));
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = listInt.Max();
            MessageBox.Show("so lon nhat la : " + max);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = listInt.Min();
            MessageBox.Show("so nho nhat la : " + min);
        }
    }
}
