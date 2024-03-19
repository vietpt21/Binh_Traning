using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsSo = new List<int>();
        private void btnTaoDs_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSo.Text);
            Random rd = new Random();
            for (int i = 0;i<n; i++)
            {
               int x = rd.Next(100);
                dsSo.Add(x);

            }
            lstSo.Items.Clear();
            for(int i = 0; i < dsSo.Count; i++)
            {
                lstSo.Items.Add(dsSo[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSo.SelectedIndex != -1)
            {
                txtSua.Text = dsSo[lstSo.SelectedIndex] +"";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lstSo.SelectedIndex != -1)
            {
                /*dsSo[lstSo.SelectedIndex] = int.Parse(txtSua.Text);
                lstSo.Items[lstSo.SelectedIndex] = dsSo[lstSo.SelectedIndex].ToString();*/
                lstSo.Items[lstSo.SelectedIndex] = txtSua.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstSo.SelectedIndex != 1)
            {
                dsSo.RemoveAt(lstSo.SelectedIndex);
                lstSo.Items.Clear();
                for(int i = 0;i< dsSo.Count; i++)
                {
                    lstSo.Items.Add(dsSo[i]);
                }
            }
        }
        Dictionary<int, string> lsSV = new Dictionary<int, string>();

      

        private void HienThiSinhVien()
        {
            lstSinhVien.Items.Clear();
            foreach(KeyValuePair<int,string> item in lsSV)
            {
                ListViewItem lvi = new ListViewItem(item.Key + "");
                lvi.SubItems.Add(item.Value);
                lstSinhVien.Items.Add(lvi);
            }
        }

        private void btnThemD_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMa.Text);
            string ten = txtTen.Text;
            lsSV.Add(ma, ten);
            txtMa.Text = "";
            txtTen.Text = "";
            HienThiSinhVien();
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lstSinhVien.SelectedItems[0];
            int ma = int.Parse(lvi.SubItems[0].Text);
            string ten = lsSV[ma];
            txtMa.Text = ma + "";
            txtTen.Text = ten;
        }
        private void btnSuaD_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMa.Text);
            lsSV.Remove(ma);
            HienThiSinhVien();

        }
    }
}
