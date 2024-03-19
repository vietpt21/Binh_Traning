using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLinQToSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMethoblaysp_Click(object sender, EventArgs e)
        {
            MethobsyntaxLayDanhSachSp frm = new MethobsyntaxLayDanhSachSp();
            frm.Show();
        }

       

        private void btnQurery_Click(object sender, EventArgs e)
        {
            QuerrySyntaxLayDanhSachSp frm = new QuerrySyntaxLayDanhSachSp();
            frm.Show();
        }

        private void btnTimSpTheoGia_Click(object sender, EventArgs e)
        {
            TimSpTheoDonGia frm = new TimSpTheoDonGia();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimSpTheoMa frm = new TimSpTheoMa();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XemChiTietDanhMucFlowlayoutPanel frm = new XemChiTietDanhMucFlowlayoutPanel();
            frm.Show();
        }

        private void btnMethobSyntaxChitietDM_Click(object sender, EventArgs e)
        {
            MethobSyntaxChitietDm frm = new MethobSyntaxChitietDm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MethobSyntaxTRuyVanSpTheoTenDm frm = new MethobSyntaxTRuyVanSpTheoTenDm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuerysyntaxTruyVanTheoTenDM frm = new QuerysyntaxTruyVanTheoTenDM();
            frm.Show();
        }

        private void btnThemDm_Click(object sender, EventArgs e)
        {
            ThemDanhMuc frm = new ThemDanhMuc();
            frm.Show();
        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {
            ThemSanPham frm = new ThemSanPham();
            frm.Show();
        }

        private void btnThemNhieuSp_Click(object sender, EventArgs e)
        {
            ThemNhieuSanPham frm = new ThemNhieuSanPham();
            frm.Show();
        }

        private void btnCapNhapSp_Click(object sender, EventArgs e)
        {
            CapNhatSanPham frm = new CapNhatSanPham();
            frm.Show();
        }

        private void btnCapnhatDm_Click(object sender, EventArgs e)
        {
            CapNhatDanhMuc frm = new CapNhatDanhMuc();
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSanPham frm = new XoaSanPham();
            frm.Show();
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            XoaDanhMuc frm = new XoaDanhMuc();
            frm.Show();

        }
    }
}
