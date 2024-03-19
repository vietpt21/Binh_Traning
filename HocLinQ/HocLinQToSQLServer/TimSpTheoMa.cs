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
    public partial class TimSpTheoMa : Form
    {
        public TimSpTheoMa()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TestDBDataContext db = new TestDBDataContext();
            int ma = int.Parse(txtMa.Text);
            var sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            ListViewItem lvi = new ListViewItem(sp.Ma+"");
            lvi.SubItems.Add(sp.Ten);
            lvi.SubItems.Add(sp.DonGia + "");
            listView1.Items.Add(lvi);
           
            
        }

        private void btnQQuerryTim_Click(object sender, EventArgs e)
        {
            TestDBDataContext db = new TestDBDataContext();
            int ma = int.Parse(txtMa.Text);
            var sp = (from x in db.SanPhams
                        where x.Ma == ma
                        select x).FirstOrDefault();

            ListViewItem lvi = new ListViewItem(sp.Ma + "");
            lvi.SubItems.Add(sp.Ten);
            lvi.SubItems.Add(sp.DonGia + "");
            listView1.Items.Add(lvi);

        }
    }
}
