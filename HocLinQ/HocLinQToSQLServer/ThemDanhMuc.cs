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
    public partial class ThemDanhMuc : Form
    {
        public ThemDanhMuc()
        {
            InitializeComponent();
        }
        TestDBDataContext db = new TestDBDataContext();
        private void ThemDanhMuc_Load(object sender, EventArgs e)
        {
           
            hienthidanhmuc();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txtMa.Text);
                DanhMuc dm = new DanhMuc();
                dm.MaDanhMuc = ma;
                dm.TenDanhMuc = txtTen.Text;
                db.DanhMucs.InsertOnSubmit(dm);
                db.SubmitChanges();
                hienthidanhmuc();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void hienthidanhmuc()
        {
            List<DanhMuc> lstdm = db.DanhMucs.ToList();
            listBox1.Items.Clear();
            lstdm.ForEach(x => listBox1.Items.Add(x.MaDanhMuc + ":" + x.TenDanhMuc));
        }
    }
}
