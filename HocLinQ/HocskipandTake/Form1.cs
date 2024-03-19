using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocskipandTake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> lstINt = new List<int>();
        Random rd = new Random();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            listBox1.Items.Clear();
            for(int i = 0; i< n; i++)
            {
                lstINt.Add(rd.Next(100));
            }
            lstINt.ForEach(x => listBox1.Items.Add(x));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtText.Text);
            var take = lstINt.Take(n);
            take.ToList().ForEach(x => listBox2.Items.Add(x));
        }
        List<DanhBa> lstdb = new List<DanhBa>();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            for(int i = 0; i < 100; i++)
            {
               

                DanhBa db = new DanhBa();
                db.Ten = "ten"+i;
                string phone = "031";
                for(int j =0;j<7;j++)
                    phone += rd.Next(10);
                db.SoDienThoai = phone;
                lstdb.Add(db);
            }
            hienthilenlistview();
          
        }
        int skip = 0;
        int take = 10
;        private void hienthilenlistview()
        {
            listView1.Items.Clear();
            var locdb = lstdb.Skip(skip).Take(take);
            locdb.ToList().ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ten);
                lvi.SubItems.Add(x.SoDienThoai);
                listView1.Items.Add(lvi);
            });
            lblSotrang.Text = skip/10+1+ "/" + lstdb.Count/10;
        }

        private void btnVeSau_Click(object sender, EventArgs e)
        {
            skip += take;
            hienthilenlistview();
        }

        private void btnVeTruoc_Click(object sender, EventArgs e)
        {
            skip -= take;
            hienthilenlistview();
        }

        private void btnVedau_Click(object sender, EventArgs e)
        {
            skip = 0;
            hienthilenlistview();
        }

        private void btnVeCuoi_Click(object sender, EventArgs e)
        {
            skip = lstdb.Count-10;
            hienthilenlistview();
        }
    }
}
