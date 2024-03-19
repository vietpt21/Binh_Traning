namespace HocLinQ
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
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnTaoDs = new System.Windows.Forms.Button();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSua = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstSinhVien = new System.Windows.Forms.ListView();
            this.btnSuaD = new System.Windows.Forms.Button();
            this.btnThemD = new System.Windows.Forms.Button();
            this.Ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.Location = new System.Drawing.Point(24, 73);
            this.lstSo.Name = "lstSo";
            this.lstSo.Size = new System.Drawing.Size(192, 199);
            this.lstSo.TabIndex = 0;
            this.lstSo.SelectedIndexChanged += new System.EventHandler(this.lstSo_SelectedIndexChanged);
            // 
            // btnTaoDs
            // 
            this.btnTaoDs.Location = new System.Drawing.Point(37, 29);
            this.btnTaoDs.Name = "btnTaoDs";
            this.btnTaoDs.Size = new System.Drawing.Size(125, 23);
            this.btnTaoDs.TabIndex = 1;
            this.btnTaoDs.Text = "Tao danh sach";
            this.btnTaoDs.UseVisualStyleBackColor = true;
            this.btnTaoDs.Click += new System.EventHandler(this.btnTaoDs_Click);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(218, 31);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(171, 20);
            this.txtSo.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(252, 340);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sua gia tri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSua
            // 
            this.txtSua.Location = new System.Drawing.Point(106, 343);
            this.txtSua.Name = "txtSua";
            this.txtSua.Size = new System.Drawing.Size(100, 20);
            this.txtSua.TabIndex = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(252, 386);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ma,
            this.Ten});
            this.lstSinhVien.FullRowSelect = true;
            this.lstSinhVien.GridLines = true;
            this.lstSinhVien.HideSelection = false;
            this.lstSinhVien.Location = new System.Drawing.Point(525, 101);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(181, 203);
            this.lstSinhVien.TabIndex = 7;
            this.lstSinhVien.UseCompatibleStateImageBehavior = false;
            this.lstSinhVien.View = System.Windows.Forms.View.Details;
            this.lstSinhVien.SelectedIndexChanged += new System.EventHandler(this.lstSinhVien_SelectedIndexChanged);
            // 
            // btnSuaD
            // 
            this.btnSuaD.Location = new System.Drawing.Point(525, 339);
            this.btnSuaD.Name = "btnSuaD";
            this.btnSuaD.Size = new System.Drawing.Size(75, 23);
            this.btnSuaD.TabIndex = 8;
            this.btnSuaD.Text = "Sua";
            this.btnSuaD.UseVisualStyleBackColor = true;
            this.btnSuaD.Click += new System.EventHandler(this.btnSuaD_Click);
            // 
            // btnThemD
            // 
            this.btnThemD.Location = new System.Drawing.Point(525, 386);
            this.btnThemD.Name = "btnThemD";
            this.btnThemD.Size = new System.Drawing.Size(75, 23);
            this.btnThemD.TabIndex = 9;
            this.btnThemD.Text = "Them";
            this.btnThemD.UseVisualStyleBackColor = true;
            this.btnThemD.Click += new System.EventHandler(this.btnThemD_Click);
            // 
            // Ma
            // 
            this.Ma.Text = "Ma";
            // 
            // Ten
            // 
            this.Ten.Text = "Ten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ten";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(601, 6);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(150, 20);
            this.txtMa.TabIndex = 12;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(601, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 20);
            this.txtTen.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemD);
            this.Controls.Add(this.btnSuaD);
            this.Controls.Add(this.lstSinhVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.btnTaoDs);
            this.Controls.Add(this.lstSo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnTaoDs;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lstSinhVien;
        private System.Windows.Forms.Button btnSuaD;
        private System.Windows.Forms.Button btnThemD;
        private System.Windows.Forms.ColumnHeader Ma;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
    }
}

