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
    public partial class XoaDanhMuc : Form
    {
        public XoaDanhMuc()
        {
            InitializeComponent();
        }
        TestDBDataContext db = new TestDBDataContext();
        private void XoaDanhMuc_Load(object sender, EventArgs e)
        {
            hienthidanhmuc();
        }

        private void hienthidanhmuc()
        {
            List<DanhMuc> lstdm = db.DanhMucs.ToList();
            listBox1.DataSource = lstdm;
            listBox1.ValueMember = "MaDanhMuc";
            listBox1.DisplayMember = "TenDanhMuc";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnXoaDanhmuc_Click(object sender, EventArgs e)
        {
            int ma = (int)listBox1.SelectedValue;
            var dm = db.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == ma);
            if (dm!=null)
            {
                if (dm.SanPhams.Count > 0)
                { 
                    MessageBox.Show("danh muc nay co" + dm.SanPhams.Count + "san pham"); 
                }
                db.DanhMucs.DeleteOnSubmit(dm);
                db.SubmitChanges();
                hienthidanhmuc();
                MessageBox.Show("Xoa thanh cong");
            }

        }
    }
}
