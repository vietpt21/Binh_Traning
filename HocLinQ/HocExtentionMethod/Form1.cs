using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLibrary1;

namespace HocExtentionMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtN.Text);
            lblKetqua.Text = a.Tinhtong() +"";
        }

        private void btnKqchuoi_Click(object sender, EventArgs e)
        {
            lblKqchuoi.Text = txtChuoi1.Text.Noichuoi(txtChuoi2.Text);
            btnKqchuoi.Doimau();
        }

        private void btnTinhTuoi_Click(object sender, EventArgs e)
        {
            Student sv = new Student();
            sv.Ten = "Viet";
            sv.Ma = 1;
            sv.NamSinh = new DateTime(2001 / 1 / 1);
            int t = sv.TinhTuoi();
        }

    }
}
