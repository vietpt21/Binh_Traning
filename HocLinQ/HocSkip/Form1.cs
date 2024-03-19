using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSkip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<int> lstInt = new List<int>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            listBox1.Items.Clear();
            for(int i = 0;i<n; i++)
            {
                lstInt.Add(rd.Next(100));
            }
            lstInt.ForEach(x => listBox1.Items.Add(x));
        }

        private void btnNhapSkip_Click(object sender, EventArgs e)
        {
            int skip = int.Parse(txtSkip.Text);
            var moi = lstInt.Skip(skip);
            foreach (var item in moi)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
