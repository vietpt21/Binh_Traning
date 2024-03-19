using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocOfType16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<NhanVien> lstnv = new List<NhanVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = null;
            if (ckbThoiVu.Checked)
            {
                nv= new NhanVienThoiVu();
                nv.MaSinhVien = txtMa.Text;
                nv.TenSinhVien = txtTen.Text;
            }
            else
            {
                nv = new NhanVienChinhThuc();
                nv.MaSinhVien = txtMa.Text;
                nv.TenSinhVien = txtTen.Text;
            }
            lstnv.Add(nv);
            hienthilenlistview();
        }

        private void hienthilenlistview()
        {
            listView1.Items.Clear();
            lstnv.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.MaSinhVien);
                lvi.SubItems.Add(x.TenSinhVien);
                listView1.Items.Add(lvi);
                if (x is NhanVienChinhThuc)
                {
                    lvi.ForeColor = Color.Red;
                }
                else if (x is NhanVienThoiVu)
                    lvi.ForeColor = Color.Blue;  
                
            });
        }

        private void btnChinhThuc_Click(object sender, EventArgs e)
        {
            var nvct = lstnv.OfType<NhanVienChinhThuc>();
            foreach (var x in nvct)
            {
                ListViewItem lvi = new ListViewItem(x.MaSinhVien);
                lvi.SubItems.Add(x.TenSinhVien);
                listView2.Items.Add(lvi);
            }
          
        }
    }
}
