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
    public partial class MethobSyntaxChitietDm : Form
    {
        public MethobSyntaxChitietDm()
        {
            InitializeComponent();
        }
        bool isfinish = false;
        TestDBDataContext db = new TestDBDataContext();
        private void MethobSyntaxChitietDm_Load(object sender, EventArgs e)
        {
            List<DanhMuc> dsdm = db.DanhMucs.ToList();
            cbDanhMuc.DataSource = dsdm;
            cbDanhMuc.ValueMember = "MaDanhMuc";
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            isfinish = true;
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isfinish == false) { return; }
            if (cbDanhMuc.SelectedIndex == -1) { return; }
            int madm =(int) cbDanhMuc.SelectedValue;
            var dm = (from x in db.DanhMucs
                     where x.MaDanhMuc == madm
                     select x).FirstOrDefault();
            if(dm != null)
            {
                txtMa.Text = dm.MaDanhMuc + "";
                txtTen.Text = dm.TenDanhMuc;
            }

                    
        }
    }
}
