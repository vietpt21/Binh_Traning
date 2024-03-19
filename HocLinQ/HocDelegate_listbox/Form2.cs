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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSole_Click(object sender, EventArgs e)
        {
            listBox1.ToSotrongListbox(x => x % 2 != 0);
        }

        private void btnSochan_Click(object sender, EventArgs e)
        {
            listBox1.ToSotrongListbox(x => x % 2 == 0);
        }
      
        private void btnSonguyento_Click(object sender, EventArgs e)
        {
            listBox1.ToSotrongListbox(x => x.IsSonguyento());
        }
    }
}
