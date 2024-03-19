using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapQLSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CSDLSachDataContext db = new CSDLSachDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Hienthitacgialenlistbox();

        }

        private void Hienthitacgialenlistbox()
        {
            List<Pulisher> lsttg = db.Pulishers.ToList();
            lsttg.ForEach(x => listBox1.Items.Add(x));
            listBox1.DataSource = lsttg;
            listBox1.ValueMember = "PulisherCode";
            listBox1.DisplayMember = " PulisherName";
            isFinish = true;
        }

        private void picHinh_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                picHinh.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        bool isFinish = false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue == null) { return; }
            if (isFinish == false) { return; }
            hienthidanhsachBooklenlistview();
           
        }

        private void hienthidanhsachBooklenlistview()
        {
            string matacgia = (string)listBox1.SelectedValue;
            List<Book> lstsach = db.Books.Where(x => x.PublisherCode == matacgia).ToList();
            listView1.Items.Clear();
            lstsach.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(listView1.Items.Count+1+"");
                lvi.SubItems.Add(x.BookCode);
                lvi.SubItems.Add(x.BookName);
                lvi.SubItems.Add(x.Discription);
                listView1.Items.Add(lvi);
            });
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            SaveImage("d",picHinh);

            string masach = txtMasach.Text;
            Book sach = db.Books.FirstOrDefault(x => x.BookCode == masach);
            listView1.Items.Clear();
            if(sach == null)
            {
                sach = new Book();
                sach.BookCode = txtMasach.Text;
                sach.BookName = txtTensach.Text;
                sach.Discription = txtMota.Text;
                sach.PublisherCode = (string)listBox1.SelectedValue;
                if(picHinh.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    picHinh.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] arrByteHinh = new byte[ms.Length];
                    ms.Write(arrByteHinh, 0, arrByteHinh.Length);
                    sach.Image = new System.Data.Linq.Binary(arrByteHinh);
                }
                db.Books.InsertOnSubmit(sach);
                db.SubmitChanges();
                MessageBox.Show("thanh cong");
                hienthidanhsachBooklenlistview();
            }

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count ==  0) { return; }
            ListViewItem lvi = listView1.SelectedItems[0];
            var masach = lvi.SubItems[1].Text;
            Book sach = db.Books.FirstOrDefault(x => x.BookCode == masach);
            if(sach != null)
            {
                sach.BookCode = txtMasach.Text;
                sach.BookName = txtTensach.Text;
                sach.Discription = txtMota.Text;

            }
        }

        private void picHinh_Click(object sender, EventArgs e)
        {
            
        }


        public string SaveImage(string path,PictureBox pictureBox)
        {
            string extension = "";
            string fileName = Path.ChangeExtension(
                Path.GetRandomFileName(),
                extension
            );


            pictureBox.Image.Save(@"D:\"+fileName+".png", ImageFormat.Png);
            return extension;
        }
    }
}
