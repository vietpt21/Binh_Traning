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
    public partial class MethobsyntaxLayDanhSachSp : Form
    {
        public MethobsyntaxLayDanhSachSp()
        {
            InitializeComponent();
        }

        private void MethobsyntaxLayDanhSachSp_Load(object sender, EventArgs e)
        {
            TestDBDataContext db = new TestDBDataContext();
            List<SanPham> lstsp= db.SanPhams.ToList();
           
            foreach (SanPham sp in lstsp)
            {
                sp.DanhMuc = null;
            }
            dataGridView1.DataSource = lstsp;

        }
    }
}
