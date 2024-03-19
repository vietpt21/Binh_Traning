namespace HocExtentionMethod
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
            this.btnKetqua = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuoi1 = new System.Windows.Forms.TextBox();
            this.txtChuoi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKqchuoi = new System.Windows.Forms.Label();
            this.btnKqchuoi = new System.Windows.Forms.Button();
            this.btnTinhTuoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tinh tong tu 0 den N";
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(65, 87);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(75, 23);
            this.btnKetqua.TabIndex = 1;
            this.btnKetqua.Text = "Ket qua";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(172, 34);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(133, 20);
            this.txtN.TabIndex = 2;
            // 
            // lblKetqua
            // 
            this.lblKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKetqua.Location = new System.Drawing.Point(169, 87);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(144, 42);
            this.lblKetqua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chuoi 1";
            // 
            // txtChuoi1
            // 
            this.txtChuoi1.Location = new System.Drawing.Point(476, 38);
            this.txtChuoi1.Name = "txtChuoi1";
            this.txtChuoi1.Size = new System.Drawing.Size(133, 20);
            this.txtChuoi1.TabIndex = 5;
            // 
            // txtChuoi2
            // 
            this.txtChuoi2.Location = new System.Drawing.Point(476, 90);
            this.txtChuoi2.Name = "txtChuoi2";
            this.txtChuoi2.Size = new System.Drawing.Size(133, 20);
            this.txtChuoi2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chuoi 2";
            // 
            // lblKqchuoi
            // 
            this.lblKqchuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKqchuoi.Location = new System.Drawing.Point(476, 142);
            this.lblKqchuoi.Name = "lblKqchuoi";
            this.lblKqchuoi.Size = new System.Drawing.Size(183, 66);
            this.lblKqchuoi.TabIndex = 9;
            // 
            // btnKqchuoi
            // 
            this.btnKqchuoi.Location = new System.Drawing.Point(638, 88);
            this.btnKqchuoi.Name = "btnKqchuoi";
            this.btnKqchuoi.Size = new System.Drawing.Size(75, 23);
            this.btnKqchuoi.TabIndex = 10;
            this.btnKqchuoi.Text = "Ket qua";
            this.btnKqchuoi.UseVisualStyleBackColor = true;
            this.btnKqchuoi.Click += new System.EventHandler(this.btnKqchuoi_Click);
            // 
            // btnTinhTuoi
            // 
            this.btnTinhTuoi.Location = new System.Drawing.Point(91, 281);
            this.btnTinhTuoi.Name = "btnTinhTuoi";
            this.btnTinhTuoi.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTuoi.TabIndex = 11;
            this.btnTinhTuoi.Text = "Tinh tuoi";
            this.btnTinhTuoi.UseVisualStyleBackColor = true;
            this.btnTinhTuoi.Click += new System.EventHandler(this.btnTinhTuoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhTuoi);
            this.Controls.Add(this.btnKqchuoi);
            this.Controls.Add(this.lblKqchuoi);
            this.Controls.Add(this.txtChuoi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChuoi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKetqua;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuoi1;
        private System.Windows.Forms.TextBox txtChuoi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKqchuoi;
        private System.Windows.Forms.Button btnKqchuoi;
        private System.Windows.Forms.Button btnTinhTuoi;
    }
}

