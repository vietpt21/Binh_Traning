using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLinQToSQLServer
{
    public partial class CapNhatSanPham : Form
    {
        public CapNhatSanPham()
        {
            InitializeComponent();
        }
        TestDBDataContext db = new TestDBDataContext();
        private void CapNhatSanPham_Load(object sender, EventArgs e)
        {
            hienthisanpham();
        }
        private void hienthisanpham()
        {

            List<SanPham> lstsp = db.SanPhams.ToList();
            listView1.Items.Clear();
            lstsp.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma + "");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                listView1.Items.Add(lvi);
            });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }//cho phep chon 1 dong
            ListViewItem lvi = listView1.SelectedItems[0];
            //lay muc dau tien cua dong
            int masp = int.Parse(lvi.SubItems[0].Text);
            var sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            if(sp != null)
            {
                txtMa.Text = sp.Ma + "";
                txtTen.Text = sp.Ten;
                txtDonGia.Text = sp.DonGia + "";
               
            }
            
        }

        private void btnCapNhatSp_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMa.Text);
            var sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if(sp!= null)
            {
                sp.Ma = int.Parse(txtMa.Text);
                sp.Ten = txtTen.Text;
                sp.DonGia = int.Parse(txtDonGia.Text);
            }
            db.SubmitChanges();
            hienthisanpham();
        }
    }
}
