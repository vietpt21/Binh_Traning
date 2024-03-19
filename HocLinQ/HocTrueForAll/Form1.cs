using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTrueForAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> lstInt = new List<int>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            lstInt.Add(n);
            listBox1.Items.Clear();
            txtN.Text = "";
            lstInt.ForEach(x => listBox1.Items.Add(x));
        }

        private void btnKtSole_Click(object sender, EventArgs e)
        {
           bool kt = lstInt.TrueForAll(x => x % 2 != 0);
            if (kt == true)
            {
                MessageBox.Show("Deu la so le");
            }
            else
            {
                MessageBox.Show("K phai tat ca so le");
            }
        }

        private void btnKtSochan_Click(object sender, EventArgs e)
        {
            bool kt = lstInt.TrueForAll(x => x % 2 == 0);
            if (kt == true)
            {
                MessageBox.Show("Deu la so chan");
            }
            else
            {
                MessageBox.Show("K phai tat ca so chan");
            }
        }
        List<Sanpham> lstsp = new List<Sanpham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            lstsp.Add(new Sanpham() { Ma = "sp01", Ten = "Cocacola", Ngay = new DateTime (2024,3,10) });
            lstsp.Add(new Sanpham() { Ma = "sp02", Ten = "Sting", Ngay = new DateTime(2024 ,3, 10) });
            lstsp.Add(new Sanpham() { Ma = "sp03", Ten = "C2", Ngay = new DateTime(2024 ,4,11) });
            lstsp.Add(new Sanpham() { Ma = "sp04", Ten = "Pessi", Ngay = new DateTime(2024,3, 12) });
            listView1.Items.Clear();
            lstsp.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Ngay.ToString("dd/MM/yyyy"));
                listView1.Items.Add(lvi);
            });
        }

        private void btnKTHandung_Click(object sender, EventArgs e)
        {
            bool kt = lstsp.TrueForAll(x => x.Ngay > DateTime.Now.Date);
            if (kt == true)
            {
                MessageBox.Show("Tat ca san pham con han su dung");
            }
            else
            {
                MessageBox.Show("Co san pham khong con han su dung");
            }
           
        }
    }
}
