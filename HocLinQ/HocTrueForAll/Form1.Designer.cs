namespace HocTrueForAll
{
    partial class Form1
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnKtSole = new System.Windows.Forms.Button();
            this.btnKtSochan = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnKTHandung = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(111, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(111, 78);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhap N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(111, 33);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 4;
            // 
            // btnKtSole
            // 
            this.btnKtSole.Location = new System.Drawing.Point(111, 340);
            this.btnKtSole.Name = "btnKtSole";
            this.btnKtSole.Size = new System.Drawing.Size(75, 23);
            this.btnKtSole.TabIndex = 8;
            this.btnKtSole.Text = "kt so le";
            this.btnKtSole.UseVisualStyleBackColor = true;
            this.btnKtSole.Click += new System.EventHandler(this.btnKtSole_Click);
            // 
            // btnKtSochan
            // 
            this.btnKtSochan.Location = new System.Drawing.Point(111, 389);
            this.btnKtSochan.Name = "btnKtSochan";
            this.btnKtSochan.Size = new System.Drawing.Size(75, 23);
            this.btnKtSochan.TabIndex = 9;
            this.btnKtSochan.Text = "kt so chan";
            this.btnKtSochan.UseVisualStyleBackColor = true;
            this.btnKtSochan.Click += new System.EventHandler(this.btnKtSochan_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(436, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(336, 229);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnKTHandung
            // 
            this.btnKTHandung.Location = new System.Drawing.Point(436, 340);
            this.btnKTHandung.Name = "btnKTHandung";
            this.btnKTHandung.Size = new System.Drawing.Size(142, 34);
            this.btnKTHandung.TabIndex = 11;
            this.btnKTHandung.Text = "kt san pham het han";
            this.btnKTHandung.UseVisualStyleBackColor = true;
            this.btnKTHandung.Click += new System.EventHandler(this.btnKTHandung_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngay het han";
            this.columnHeader3.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKTHandung);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnKtSochan);
            this.Controls.Add(this.btnKtSole);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnKtSole;
        private System.Windows.Forms.Button btnKtSochan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnKTHandung;
    }
}

