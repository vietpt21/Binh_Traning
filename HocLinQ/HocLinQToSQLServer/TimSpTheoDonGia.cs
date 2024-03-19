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
    public partial class TimSpTheoDonGia : Form
    {
        public TimSpTheoDonGia()
        {
            InitializeComponent();
        }
        List<SanPham> lstSp = new List<SanPham>();
        private void btnTim_Click(object sender, EventArgs e)
        {
            TestDBDataContext db = new TestDBDataContext();
            int min = int.Parse(txtMin.Text);
            int max = int.Parse(txtMax.Text);
            var ds = db.SanPhams.Where(x => x.DonGia > min && x.DonGia < max).ToList();
            listView1.Items.Clear();
            ds.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma + "");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                listView1.Items.Add(lvi);
            });

        }

        private void TimSpTheoDonGia_Load(object sender, EventArgs e)
        {

        }
    }
}
