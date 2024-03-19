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
    public partial class QuerrySyntaxLayDanhSachSp : Form
    {
        public QuerrySyntaxLayDanhSachSp()
        {
            InitializeComponent();
        }

        private void QuerrySyntaxLayDanhSachSp_Load(object sender, EventArgs e)
        {
            TestDBDataContext db = new TestDBDataContext();
            var list = from x in db.SanPhams
                       select x;
            foreach (var x in list)
            {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                listView1.Items.Add(lvi);
                
            }
        }
    }
}
