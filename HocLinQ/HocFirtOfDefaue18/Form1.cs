using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFirtOfDefaue18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SanPham> lstsp = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            lstsp.Add(new SanPham() { Ma = "sp1", Ten = "pessi", Gia = 5000 });
            lstsp.Add(new SanPham() { Ma = "sp2", Ten = "cocacola", Gia = 9000 });
            lstsp.Add(new SanPham() { Ma = "sp3", Ten = "sting", Gia = 8000 });
            dataGridView1.DataSource = lstsp;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var tim = lstsp.FirstOrDefault(x => x.Gia > 8000);
            if (tim != null)
            {
                textBox1.Text = tim.Ma;
                textBox2.Text = tim.Ten;
                textBox3.Text = tim.Gia + "";
            }
        }
    }
}
