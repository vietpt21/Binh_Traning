using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocAnomousType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var x = new
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
                gia = txtGia.Text,
            };
            label4.Text ="ma = " +x.Ma + " ten =" + x.Ten + " gia = " + x.gia;
            label4.Text +="\n"+ x.GetType().ToString();
        }
    }
}
