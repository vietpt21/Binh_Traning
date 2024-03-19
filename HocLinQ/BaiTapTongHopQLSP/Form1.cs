using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTongHopQLSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TestDBDataContext db = new TestDBDataContext();
        bool isFinish = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            hienthidanhmuc();     
        }
        private void hienthidanhmuc()
        {
            List<DanhMuc> lstdm = db.DanhMucs.ToList();
            listBox1.DataSource = lstdm;
            listBox1.ValueMember = "MaDanhMuc";
            listBox1.DisplayMember = "TenDanhMuc";
            isFinish = true;
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isFinish == false) { return; }
            if(listBox1.SelectedValue == null) { return; }
            hienthisanphamlenlistview();
        }
        private void hienthisanphamlenlistview()
        {
            int madm = (int)listBox1.SelectedValue;
            List<SanPham> lstsp = db.SanPhams.Where(x => x.MaDanhMuc == madm).ToList();
            listView1.Items.Clear();
            lstsp.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma + "");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                listView1.Items.Add(lvi);
            });
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtMaSp.Text);
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            if(sp == null)
            {
                sp = new SanPham();
                sp.Ma = masp;
                sp.Ten = txtTenSp.Text;
                sp.DonGia = int.Parse(txtDonGiaSp.Text);
                sp.MaDanhMuc = (int)listBox1.SelectedValue;
                db.SanPhams.InsertOnSubmit(sp);
                

            }
            else
            {
                SanPham sanpham = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
                if(sanpham != null)
                {
                    sanpham.MaDanhMuc = (int)listBox1.SelectedValue;
                    sanpham.Ten = txtTenSp.Text;
                    sanpham.DonGia = int.Parse(txtDonGiaSp.Text.ToString());
                }
            }
            db.SubmitChanges();
            hienthisanphamlenlistview();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0) { return; }
            ListViewItem lvi = listView1.SelectedItems[0];
            int masp = int.Parse(lvi.SubItems[0].Text);
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            if(sp != null)
            {
                txtMaSp.Text = sp.Ma + "";
                txtTenSp.Text = sp.Ten;
                txtDonGiaSp.Text = sp.DonGia + "";
            }
            
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMaSp.Clear();
            txtTenSp.Clear();
            txtDonGiaSp.Clear();
            txtMaSp.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaSp.Text);
            var sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if(sp!= null)
            {
                db.SanPhams.DeleteOnSubmit(sp);
                db.SubmitChanges();
            }
            hienthisanphamlenlistview();
        }
    }
}
