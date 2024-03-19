namespace HocskipandTake
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnVedau = new System.Windows.Forms.Button();
            this.btnVeTruoc = new System.Windows.Forms.Button();
            this.btnVeSau = new System.Windows.Forms.Button();
            this.btnVeCuoi = new System.Windows.Forms.Button();
            this.lblSotrang = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nhap N";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(71, 62);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 24;
            this.btnNhap.Text = "Nhap";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(71, 36);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 212);
            this.listBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Take N";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Take";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(249, 36);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 27;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(191, 86);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(158, 212);
            this.listBox2.TabIndex = 26;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(434, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(354, 274);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnVedau
            // 
            this.btnVedau.Location = new System.Drawing.Point(432, 355);
            this.btnVedau.Name = "btnVedau";
            this.btnVedau.Size = new System.Drawing.Size(75, 23);
            this.btnVedau.TabIndex = 31;
            this.btnVedau.Text = "|<<";
            this.btnVedau.UseVisualStyleBackColor = true;
            this.btnVedau.Click += new System.EventHandler(this.btnVedau_Click);
            // 
            // btnVeTruoc
            // 
            this.btnVeTruoc.Location = new System.Drawing.Point(513, 354);
            this.btnVeTruoc.Name = "btnVeTruoc";
            this.btnVeTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnVeTruoc.TabIndex = 32;
            this.btnVeTruoc.Text = "<";
            this.btnVeTruoc.UseVisualStyleBackColor = true;
            this.btnVeTruoc.Click += new System.EventHandler(this.btnVeTruoc_Click);
            // 
            // btnVeSau
            // 
            this.btnVeSau.Location = new System.Drawing.Point(637, 355);
            this.btnVeSau.Name = "btnVeSau";
            this.btnVeSau.Size = new System.Drawing.Size(75, 23);
            this.btnVeSau.TabIndex = 33;
            this.btnVeSau.Text = ">";
            this.btnVeSau.UseVisualStyleBackColor = true;
            this.btnVeSau.Click += new System.EventHandler(this.btnVeSau_Click);
            // 
            // btnVeCuoi
            // 
            this.btnVeCuoi.Location = new System.Drawing.Point(718, 354);
            this.btnVeCuoi.Name = "btnVeCuoi";
            this.btnVeCuoi.Size = new System.Drawing.Size(75, 23);
            this.btnVeCuoi.TabIndex = 34;
            this.btnVeCuoi.Text = ">>|";
            this.btnVeCuoi.UseVisualStyleBackColor = true;
            this.btnVeCuoi.Click += new System.EventHandler(this.btnVeCuoi_Click);
            // 
            // lblSotrang
            // 
            this.lblSotrang.AutoSize = true;
            this.lblSotrang.Location = new System.Drawing.Point(596, 359);
            this.lblSotrang.Name = "lblSotrang";
            this.lblSotrang.Size = new System.Drawing.Size(35, 13);
            this.lblSotrang.TabIndex = 35;
            this.lblSotrang.Text = "label3";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ten";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "So dien thoai";
            this.columnHeader2.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSotrang);
            this.Controls.Add(this.btnVeCuoi);
            this.Controls.Add(this.btnVeSau);
            this.Controls.Add(this.btnVeTruoc);
            this.Controls.Add(this.btnVedau);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnVedau;
        private System.Windows.Forms.Button btnVeTruoc;
        private System.Windows.Forms.Button btnVeSau;
        private System.Windows.Forms.Button btnVeCuoi;
        private System.Windows.Forms.Label lblSotrang;
    }
}

