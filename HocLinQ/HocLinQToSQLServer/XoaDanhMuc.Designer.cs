namespace HocLinQToSQLServer
{
    partial class XoaDanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnXoaDanhmuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(63, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 251);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnXoaDanhmuc
            // 
            this.btnXoaDanhmuc.Location = new System.Drawing.Point(92, 293);
            this.btnXoaDanhmuc.Name = "btnXoaDanhmuc";
            this.btnXoaDanhmuc.Size = new System.Drawing.Size(116, 23);
            this.btnXoaDanhmuc.TabIndex = 1;
            this.btnXoaDanhmuc.Text = "Xoa danh muc";
            this.btnXoaDanhmuc.UseVisualStyleBackColor = true;
            this.btnXoaDanhmuc.Click += new System.EventHandler(this.btnXoaDanhmuc_Click);
            // 
            // XoaDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoaDanhmuc);
            this.Controls.Add(this.listBox1);
            this.Name = "XoaDanhMuc";
            this.Text = "XoaDanhMuc";
            this.Load += new System.EventHandler(this.XoaDanhMuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnXoaDanhmuc;
    }
}