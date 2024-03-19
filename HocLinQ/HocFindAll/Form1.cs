using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SanPham> lstsp = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham()
            {
                MaSanPham = "sp1",
                TenSanPham = "Mi",
                gia = 1000
            };
            SanPham sp1 = new SanPham()
            {
                MaSanPham = "sp2",
                TenSanPham = "Cocacola",
                gia = 7000
            };
            SanPham sp2 = new SanPham()
            {
                MaSanPham = "sp3",
                TenSanPham = "Mu",
                gia = 10000
            };
            lstsp.Add(sp1);
            lstsp.Add(sp2);
            lstsp.Add(sp);
            listView1.Items.Clear();
            lstsp.ForEach(x =>
            {

                ListViewItem lvi = new ListViewItem(x.MaSanPham);
                lvi.SubItems.Add(x.TenSanPham);
                lvi.SubItems.Add(x.gia + "");
                listView1.Items.Add(lvi);

            });
        }

        private void btnTImsp_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtMIn.Text);
            int max = int.Parse(txtMax.Text);
            List<SanPham> ktsp = lstsp.FindAll(x => x.gia > min && x.gia < max);
            listView2.Items.Clear();
            ktsp.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.MaSanPham);
                lvi.SubItems.Add(x.TenSanPham);
                lvi.SubItems.Add(x.gia + "");
                listView2.Items.Add(lvi);
            });
        }
    }
}
