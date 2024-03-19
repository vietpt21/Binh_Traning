using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocForEach
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

        private void btnForEach_Click(object sender, EventArgs e)
        {
            List<int> arr = new List<int>();
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr.Add(rd.Next(100));
            }
            //c1
            /* foreach (int x in arr)
             {
                 listBox1.Items.Add(x);
             }*/
            //c2
            arr.ForEach(x => listBox1.Items.Add(x));
        }
        List<San_pham> lstsp = new List<San_pham>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            San_pham sp = new San_pham()
            {
                MaSanPham = int.Parse(txtMa.Text),
                TenSanPham = txtTen.Text

            };
            lstsp.Add(sp);
            hienthisanpham();
        }

        private void hienthisanpham()
        {
            lstsp.ForEach(x => hienthi1sanpham(x));
        }
        private void hienthi1sanpham(San_pham sp)
        {
            ListViewItem lvi = new ListViewItem(sp.MaSanPham.ToString());
            lvi.SubItems.Add(sp.TenSanPham);
            listView1.Items.Add(lvi);
        }
    }
}
