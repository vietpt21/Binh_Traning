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
    public partial class QuerysyntaxTruyVanTheoTenDM : Form
    {
        public QuerysyntaxTruyVanTheoTenDM()
        {
            InitializeComponent();
        }
        TestDBDataContext db = new TestDBDataContext();
        private void QuerysyntaxTruyVanTheoTenDM_Load(object sender, EventArgs e)
        {
            List<DanhMuc> lstdm = db.DanhMucs.ToList();
            treeView1.Nodes.Clear();
            foreach (DanhMuc dm in lstdm)
            {
                TreeNode nodeDM = new TreeNode(dm.TenDanhMuc);
                nodeDM.Tag = dm.MaDanhMuc;
                treeView1.Nodes.Add(nodeDM);
                List<SanPham> lstSp = (from x in db.SanPhams
                                       where x.MaDanhMuc == dm.MaDanhMuc
                                       select x).ToList();
                foreach (SanPham sp in lstSp)
                {
                    TreeNode nodeSp = new TreeNode(sp.Ten);
                    nodeSp.Tag = sp.Ma;
                    nodeDM.Nodes.Add(nodeSp);

                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node == null) { return; }
           
            if(e.Node.Level == 0)
            {
                int madm = (int)e.Node.Tag;
                hienthisanphamlenlistview(madm);
            }
            else if (e.Node.Level == 1)
            {
                int masp =(int) e.Node.Tag;
                hienthitungsanphamlenlistview(masp);
            }
        }

        private void hienthitungsanphamlenlistview(int masp)
        {
            var sp = (from x in db.SanPhams
                      where x.Ma == masp
                      select x).FirstOrDefault();
            if(sp != null)
            {
                listView1.Items.Clear();
                ListViewItem lvi = new ListViewItem(sp.Ma + "");
                lvi.SubItems.Add(sp.Ten);
                lvi.SubItems.Add(sp.DonGia + "");
                listView1.Items.Add(lvi);
            }
        }

        private void hienthisanphamlenlistview(int madm)
        {
            List<SanPham> lstsp = (from x in db.SanPhams
                                   where x.MaDanhMuc == madm
                                   select x).ToList();
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
