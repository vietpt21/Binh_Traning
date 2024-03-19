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
    public partial class CapNhatDanhMuc : Form
    {
        public CapNhatDanhMuc()
        {
            InitializeComponent();
        }
        TestDBDataContext db = new TestDBDataContext();
        bool isFinish = false;
        private void CapNhatDanhMuc_Load(object sender, EventArgs e)
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
            if (isFinish == false) { return; }
            if (listBox1.SelectedItems == null) { return; }
            int madm = (int)listBox1.SelectedValue;
            var dm = db.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == madm);
                
                if(dm != null)
                {
                    txtMa.Text = dm.MaDanhMuc + "";
                    txtTen.Text = dm.TenDanhMuc;
                }
            isFinish = true;
        }
        List<DanhMuc> lstdm = new List<DanhMuc>();
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMa.Text);
            DanhMuc dm = db.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == ma);
            if(dm != null)
            {
                dm.TenDanhMuc = txtTen.Text;
            }
            db.SubmitChanges();
            hienthidanhmuc();
        }
    }
}
