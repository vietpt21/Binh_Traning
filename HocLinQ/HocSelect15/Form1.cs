using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSelect15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> lstsv = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            lstsv.Add(new SinhVien { Ma = 1,Ten="Viet",Tuoi= 23,DiaChi="Hai phong" });
            lstsv.Add(new SinhVien { Ma = 2, Ten = "Viet1", Tuoi = 23, DiaChi = "Hai phong" });
            lstsv.Add(new SinhVien { Ma = 3, Ten = "Viet", Tuoi = 20, DiaChi = "Hai phong" });
            lstsv.Add(new SinhVien { Ma = 4, Ten = "Viet3", Tuoi = 23, DiaChi = "Hai phong" });
            listView1.Items.Clear();
            lstsv.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Tuoi+"");
                lvi.SubItems.Add(x.DiaChi);
                listView1.Items.Add(lvi);
            });
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var loc = lstsv.Select(x =>new { x.Ma,x.Ten }) ;
            dataGridView1.DataSource = loc.ToList();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var loc = from x in lstsv
                      select new { x.Ma, x.Ten };
            dataGridView1.DataSource = loc.ToList();

        }

        private void btnQuerySyn_Click(object sender, EventArgs e)
        {
           
            var query = from x in lstsv
                        where x.Ten == txtTen.Text
                        orderby x.Tuoi
                        select x ;
            dataGridView1.DataSource = query.ToList();
        }

        private void btnMethobSyn_Click(object sender, EventArgs e)
        {
            var query = lstsv.Where(x => x.Ten == txtTen.Text).OrderBy(x=>x.Tuoi);
            dataGridView1.DataSource = query.ToList();
        }
    }
}
