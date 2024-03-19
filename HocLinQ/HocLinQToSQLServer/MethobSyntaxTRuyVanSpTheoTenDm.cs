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
    public partial class MethobSyntaxTRuyVanSpTheoTenDm : Form
    {
        public MethobSyntaxTRuyVanSpTheoTenDm()
        {
            InitializeComponent();
        }
        TestDBDataContext db = new TestDBDataContext();
        bool isFinish = false;
        private void MethobSyntaxTRuyVanSpTheoTenDm_Load(object sender, EventArgs e)
        {
            List<DanhMuc> dm = db.DanhMucs.ToList();
            listBox1.DataSource = dm;

            listBox1.ValueMember = "MaDanhMuc";
            listBox1.DisplayMember = "TenDanhMuc";
            isFinish = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFinish == false) { return; }
            if(listBox1.SelectedIndex == -1) { return; }
            int madm =(int) listBox1.SelectedValue;
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
    }
}
