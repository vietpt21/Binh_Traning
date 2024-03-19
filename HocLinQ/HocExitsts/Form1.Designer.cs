namespace HocExitsts
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimsp = new System.Windows.Forms.TextBox();
            this.btnTimsp = new System.Windows.Forms.Button();
            this.btnFindSo = new System.Windows.Forms.Button();
            this.btnFinsp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(98, 31);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhap N";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(98, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(98, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 3;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(98, 324);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 20);
            this.txtTim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tim n";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(224, 326);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(91, 23);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "check ton tai";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            this.listView1.Location = new System.Drawing.Point(352, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(192, 241);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ma San Pham";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ten San Pham";
            // 
            // txtTimsp
            // 
            this.txtTimsp.Location = new System.Drawing.Point(352, 357);
            this.txtTimsp.Name = "txtTimsp";
            this.txtTimsp.Size = new System.Drawing.Size(100, 20);
            this.txtTimsp.TabIndex = 8;
            // 
            // btnTimsp
            // 
            this.btnTimsp.Location = new System.Drawing.Point(469, 354);
            this.btnTimsp.Name = "btnTimsp";
            this.btnTimsp.Size = new System.Drawing.Size(108, 23);
            this.btnTimsp.TabIndex = 9;
            this.btnTimsp.Text = "Check ton tai";
            this.btnTimsp.UseVisualStyleBackColor = true;
            this.btnTimsp.Click += new System.EventHandler(this.btnTimsp_Click);
            // 
            // btnFindSo
            // 
            this.btnFindSo.Location = new System.Drawing.Point(189, 76);
            this.btnFindSo.Name = "btnFindSo";
            this.btnFindSo.Size = new System.Drawing.Size(105, 23);
            this.btnFindSo.TabIndex = 10;
            this.btnFindSo.Text = "Find number";
            this.btnFindSo.UseVisualStyleBackColor = true;
            this.btnFindSo.Click += new System.EventHandler(this.btnFindSo_Click);
            // 
            // btnFinsp
            // 
            this.btnFinsp.Location = new System.Drawing.Point(469, 27);
            this.btnFinsp.Name = "btnFinsp";
            this.btnFinsp.Size = new System.Drawing.Size(75, 23);
            this.btnFinsp.TabIndex = 11;
            this.btnFinsp.Text = "find ten sp";
            this.btnFinsp.UseVisualStyleBackColor = true;
            this.btnFinsp.Click += new System.EventHandler(this.btnFinsp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 406);
            this.Controls.Add(this.btnFinsp);
            this.Controls.Add(this.btnFindSo);
            this.Controls.Add(this.btnTimsp);
            this.Controls.Add(this.txtTimsp);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTim);
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

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtTimsp;
        private System.Windows.Forms.Button btnTimsp;
        private System.Windows.Forms.Button btnFindSo;
        private System.Windows.Forms.Button btnFinsp;
    }
}

