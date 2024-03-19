using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocExitsts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> lstint = new List<int>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            for(int i = 0;i< n; i++)
            {
                lstint.Add(rd.Next(100));
            }
            lstint.ForEach(x => listBox1.Items.Add(x));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtTim.Text);
            bool kq = lstint.Exists(x => x == n);
            if (kq == true)
            {
                MessageBox.Show(n + " co trong list");
            }
            else
            {
                MessageBox.Show(n + " khong co tron list");
            }
        }
         List<SanPham> lstsp = new List<SanPham>();
        public void TaoSanPham()
        {
            SanPham sp = new SanPham()
            {
               masanpham = "sp1",
               tensanpham="pessi",
            };
            SanPham sp1 = new SanPham()
            {
                masanpham = "sp2",
                tensanpham = "cocacola",
            };
            SanPham sp2 = new SanPham()
            {
                masanpham = "sp3",
                tensanpham = "sting",
            };
            lstsp.Add(sp);
            lstsp.Add(sp1);
            lstsp.Add(sp2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoSanPham();
            lstsp.ForEach(x =>
                {
                    ListViewItem lvi = new ListViewItem(listView1.Items.Count + 1 + "");
                    lvi.SubItems.Add(x.masanpham);
                    lvi.SubItems.Add(x.tensanpham);
                    listView1.Items.Add(lvi);

                }

            );
        }

        private void btnTimsp_Click(object sender, EventArgs e)
        {
            bool kt = lstsp.Exists(x => x.tensanpham == txtTimsp.Text);
            if (kt == true)
            {
                MessageBox.Show(txtTimsp.Text + " co trong list");
            }
            else
            {
                MessageBox.Show(txtTimsp.Text+ " khong co tron list");
            }
        }

        private void btnFindSo_Click(object sender, EventArgs e)
        {
            int a =int.Parse( txtTim.Text);
            int kt = lstint.Find(x => x == a);
            if(kt!= null)
            {
                MessageBox.Show(kt + "dc tim thay");
            }
            else
            {
                MessageBox.Show("khong tim thay");
            }
        }

        private void btnFinsp_Click(object sender, EventArgs e)
        {
           
            SanPham kt = lstsp.Find(x => txtTimsp.Text==x.tensanpham.ToString());
            if (kt != null)
            {
                MessageBox.Show(txtTimsp.Text + " dc tim thay");
            }
            else
            {
                MessageBox.Show(txtTimsp.Text +" khong tim thay");
            }
        }
    }
}
