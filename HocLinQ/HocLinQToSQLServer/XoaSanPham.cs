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
    public partial class XoaSanPham : Form
    {
        public XoaSanPham()
        {
            InitializeComponent();
        }
        bool isFinish = false;
        private void XoaSanPham_Load(object sender, EventArgs e)
        {
            hienthisanpham();
        }
        TestDBDataContext db = new TestDBDataContext();
        private void hienthisanpham()
        {
            List<SanPham> lstsp = db.SanPhams.ToList();
            listBox1.DataSource = lstsp;
            listBox1.ValueMember = "Ma";
            listBox1.DisplayMember = "Ten";
            isFinish = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            int ma = (int)listBox1.SelectedValue;
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            
            if(sp != null)
            {
                db.SanPhams.DeleteOnSubmit(sp);
                db.SubmitChanges();
                MessageBox.Show("xoa thanh cong");
                hienthisanpham();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
