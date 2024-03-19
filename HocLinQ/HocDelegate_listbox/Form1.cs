using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDelegate_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSole_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString());
                if (x % 2 != 0)
                {
                    listBox1.SelectedIndex = i;
                }
            }
        }

        private void btnSochan_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString());
                if (x % 2 == 0)
                {
                    listBox1.SelectedIndex = i;
                }

            }
          
        }
        public bool IsSonguyento(int x)
        {
            int dem = 0;
            for(int i = 0; i < x;i++)
            {
                if(x % i == 0)
                {
                    dem++;
                }
             
            }
            return dem == 2;
        }

        private void btnSonguyento_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString());
                if (IsSonguyento(x))
                {
                    listBox1.SelectedIndex = i;
                }

            }
        }
    }
}
