using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocObjectIntialzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham()
            {
                masanpham = int.Parse(txtMa.Text),
                tensanpham= txtTen.Text,

            };
            listBox1.Items.Add(sp.masanpham+"-"+sp.tensanpham);
        }
    }
}
