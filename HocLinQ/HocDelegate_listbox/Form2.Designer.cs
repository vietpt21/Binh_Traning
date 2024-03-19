namespace HocDelegate_listbox
{
    partial class Form2
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
            this.btnSonguyento = new System.Windows.Forms.Button();
            this.btnSochan = new System.Windows.Forms.Button();
            this.btnSole = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSonguyento
            // 
            this.btnSonguyento.Location = new System.Drawing.Point(282, 198);
            this.btnSonguyento.Name = "btnSonguyento";
            this.btnSonguyento.Size = new System.Drawing.Size(112, 23);
            this.btnSonguyento.TabIndex = 7;
            this.btnSonguyento.Text = "Chon so nguyen to";
            this.btnSonguyento.UseVisualStyleBackColor = true;
            this.btnSonguyento.Click += new System.EventHandler(this.btnSonguyento_Click);
            // 
            // btnSochan
            // 
            this.btnSochan.Location = new System.Drawing.Point(282, 140);
            this.btnSochan.Name = "btnSochan";
            this.btnSochan.Size = new System.Drawing.Size(112, 23);
            this.btnSochan.TabIndex = 6;
            this.btnSochan.Text = "Chon so chan";
            this.btnSochan.UseVisualStyleBackColor = true;
            this.btnSochan.Click += new System.EventHandler(this.btnSochan_Click);
            // 
            // btnSole
            // 
            this.btnSole.Location = new System.Drawing.Point(282, 82);
            this.btnSole.Name = "btnSole";
            this.btnSole.Size = new System.Drawing.Size(112, 23);
            this.btnSole.TabIndex = 5;
            this.btnSole.Text = "Chon so le";
            this.btnSole.UseVisualStyleBackColor = true;
            this.btnSole.Click += new System.EventHandler(this.btnSole_Click);
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
            this.listBox1.Location = new System.Drawing.Point(69, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSonguyento);
            this.Controls.Add(this.btnSochan);
            this.Controls.Add(this.btnSole);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSonguyento;
        private System.Windows.Forms.Button btnSochan;
        private System.Windows.Forms.Button btnSole;
        private System.Windows.Forms.ListBox listBox1;
    }
}