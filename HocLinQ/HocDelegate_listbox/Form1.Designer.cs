namespace HocDelegate_listbox
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
            this.btnSole = new System.Windows.Forms.Button();
            this.btnSochan = new System.Windows.Forms.Button();
            this.btnSonguyento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.listBox1.Location = new System.Drawing.Point(52, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 0;
            // 
            // btnSole
            // 
            this.btnSole.Location = new System.Drawing.Point(265, 133);
            this.btnSole.Name = "btnSole";
            this.btnSole.Size = new System.Drawing.Size(112, 23);
            this.btnSole.TabIndex = 1;
            this.btnSole.Text = "Chon so le";
            this.btnSole.UseVisualStyleBackColor = true;
            this.btnSole.Click += new System.EventHandler(this.btnSole_Click);
            // 
            // btnSochan
            // 
            this.btnSochan.Location = new System.Drawing.Point(265, 191);
            this.btnSochan.Name = "btnSochan";
            this.btnSochan.Size = new System.Drawing.Size(112, 23);
            this.btnSochan.TabIndex = 2;
            this.btnSochan.Text = "Chon so chan";
            this.btnSochan.UseVisualStyleBackColor = true;
            this.btnSochan.Click += new System.EventHandler(this.btnSochan_Click);
            // 
            // btnSonguyento
            // 
            this.btnSonguyento.Location = new System.Drawing.Point(265, 249);
            this.btnSonguyento.Name = "btnSonguyento";
            this.btnSonguyento.Size = new System.Drawing.Size(112, 23);
            this.btnSonguyento.TabIndex = 3;
            this.btnSonguyento.Text = "Chon so nguyen to";
            this.btnSonguyento.UseVisualStyleBackColor = true;
            this.btnSonguyento.Click += new System.EventHandler(this.btnSonguyento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSonguyento);
            this.Controls.Add(this.btnSochan);
            this.Controls.Add(this.btnSole);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSole;
        private System.Windows.Forms.Button btnSochan;
        private System.Windows.Forms.Button btnSonguyento;
    }
}

