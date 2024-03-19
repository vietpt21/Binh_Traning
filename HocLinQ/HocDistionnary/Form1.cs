using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDistionnary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> lstSv =new List<SinhVien>();
        private void button1_Click(object sender, EventArgs e)
        {
            lstSv.Add(new SinhVien() { MaSinhVien = "sv1", TenSinhVien = "Viet1" });
            lstSv.Add(new SinhVien() { MaSinhVien = "sv2", TenSinhVien = "Viet2" });
            lstSv.Add(new SinhVien() { MaSinhVien = "sv3", TenSinhVien = "Viet3" });
            lstSv.Add(new SinhVien() { MaSinhVien = "sv4", TenSinhVien = "Viet4" });
            Dictionary<string, SinhVien> dic = lstSv.ToDictionary(x=>x.MaSinhVien);
            listView1.Items.Clear();
            foreach (KeyValuePair<string,SinhVien> item  in dic)
            {
                ListViewItem lvi = new ListViewItem(item.Key);
                lvi.SubItems.Add(item.Value.TenSinhVien);
                listView1.Items.Add(lvi);
            }
        }
    }
}
