using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSkipWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> lstInt = new List<int>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            listBox1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                lstInt.Add(rd.Next(100));
            }
            listBox1.Items.Clear();
            lstInt.ForEach(x => listBox1.Items.Add(x));
        }

        private void btnNhapSkip_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSkip.Text);
            var listkq = lstInt.SkipWhile(x => x>n).ToList();
            listBox2.Items.Clear();
            listkq.ForEach(x => listBox2.Items.Add(x));
        }
    }
}
