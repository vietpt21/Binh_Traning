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
    public partial class XemChiTietDanhMucFlowlayoutPanel : Form
    {
        public XemChiTietDanhMucFlowlayoutPanel()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            TestDBDataContext db = new TestDBDataContext();
            var dm = (from x in db.DanhMucs
                      select x).ToList();
            flowLayoutPanel1.Controls.Clear();
            dm.ForEach(x =>
            {
                Button btn = new Button();
                btn.Text = x.TenDanhMuc;
                btn.Tag = x.MaDanhMuc;
                btn.Width = 120;
                btn.Height = 60;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
            });
        }
        Button previous = null;
        private void Btn_Click(object sender, EventArgs e)
        {
          
            Button btn = sender as Button;
            if (previous != null)
            {
                previous.BackColor = Color.WhiteSmoke;
            }
            previous = btn;
            btn.BackColor = Color.Yellow;
            
            int ma = (int)btn.Tag;
            TestDBDataContext db = new TestDBDataContext();
            var dm = (from x in db.DanhMucs
                      where x.MaDanhMuc == ma
                      select x).FirstOrDefault();
            if(dm != null)
            {
                txtMa.Text = dm.MaDanhMuc + "";
                txtTen.Text = dm.TenDanhMuc;
            }
        }
    }
}
