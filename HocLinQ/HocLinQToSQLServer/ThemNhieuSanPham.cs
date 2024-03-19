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
    public partial class ThemNhieuSanPham : Form
    {
        public ThemNhieuSanPham()
        {
            InitializeComponent();
        }
        TestDBDataContext db = new TestDBDataContext();
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThemNhieuSanPham_Load(object sender, EventArgs e)
        {
            hienthisanpham();
            hienthidanhmuc();
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
        private void hienthidanhmuc()
        {
            List<DanhMuc> lstdm = db.DanhMucs.ToList();
            cbMaDanhMuc.DataSource = lstdm;
            cbMaDanhMuc.ValueMember = "MaDanhMuc";
            cbMaDanhMuc.DisplayMember = "TenDanhMuc";

        }
        List<SanPham> lstsp = new List<SanPham>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbMaDanhMuc.SelectedIndex == 0)
                {
                    MessageBox.Show("Chon ten danh muc");
                    return;
                }
                SanPham sp = new SanPham();
                sp.Ma = int.Parse(txtMa.Text);
                sp.Ten = txtTen.Text;
                sp.DonGia = int.Parse(txtDonGia.Text);
                int madm = (int)cbMaDanhMuc.SelectedValue;
                sp.MaDanhMuc = madm;
                lstsp.Add(sp);
                txtMa.Text = "";
                txtTen.Text = "";
                txtDonGia.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Ban co muon luu "+lstsp.Count +"san pham nay khong?",
                "hoi", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
           if(dr== DialogResult.Yes)
            {
                db.SanPhams.InsertAllOnSubmit(lstsp);
                db.SubmitChanges();
                MessageBox.Show("Them san pham thanh cong");
                hienthisanpham();
            }
        }
    }
}
