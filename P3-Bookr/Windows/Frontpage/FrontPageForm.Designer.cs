namespace P3_Bookr.Windows.Frontpage
{
    partial class FrontPageForm
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
            this.newsTop1 = new P3_Bookr.Windows.Frontpage.NewsTop();
            this.lastUsedServiceTop1 = new P3_Bookr.Windows.Frontpage.LastUsedServiceTop();
            this.lastUsedServices1 = new P3_Bookr.Windows.Frontpage.LastUsedServices();
            this.bigNewsBox1 = new P3_Bookr.Windows.Frontpage.BigNewsBox();
            this.smallNewsBox1 = new P3_Bookr.Windows.Frontpage.SmallNewsBox();
            this.smallNewsBox2 = new P3_Bookr.Windows.Frontpage.SmallNewsBox();
            this.bigNewsBox2 = new P3_Bookr.Windows.Frontpage.BigNewsBox();
            this.smallNewsBox3 = new P3_Bookr.Windows.Frontpage.SmallNewsBox();
            this.smallNewsBox4 = new P3_Bookr.Windows.Frontpage.SmallNewsBox();
            this.SuspendLayout();
            // 
            // newsTop1
            // 
            this.newsTop1.BackColor = System.Drawing.Color.White;
            this.newsTop1.Location = new System.Drawing.Point(32, 562);
            this.newsTop1.Name = "newsTop1";
            this.newsTop1.Size = new System.Drawing.Size(876, 50);
            this.newsTop1.TabIndex = 2;
            // 
            // lastUsedServiceTop1
            // 
            this.lastUsedServiceTop1.BackColor = System.Drawing.Color.White;
            this.lastUsedServiceTop1.Location = new System.Drawing.Point(32, 220);
            this.lastUsedServiceTop1.Name = "lastUsedServiceTop1";
            this.lastUsedServiceTop1.Size = new System.Drawing.Size(876, 50);
            this.lastUsedServiceTop1.TabIndex = 1;
            // 
            // lastUsedServices1
            // 
            this.lastUsedServices1.AutoScroll = true;
            this.lastUsedServices1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.lastUsedServices1.Location = new System.Drawing.Point(32, 220);
            this.lastUsedServices1.Name = "lastUsedServices1";
            this.lastUsedServices1.Size = new System.Drawing.Size(876, 309);
            this.lastUsedServices1.TabIndex = 0;
            // 
            // bigNewsBox1
            // 
            this.bigNewsBox1.BackColor = System.Drawing.Color.White;
            this.bigNewsBox1.Location = new System.Drawing.Point(32, 630);
            this.bigNewsBox1.Name = "bigNewsBox1";
            this.bigNewsBox1.Size = new System.Drawing.Size(340, 200);
            this.bigNewsBox1.TabIndex = 3;
            // 
            // smallNewsBox1
            // 
            this.smallNewsBox1.BackColor = System.Drawing.Color.White;
            this.smallNewsBox1.Location = new System.Drawing.Point(390, 630);
            this.smallNewsBox1.Name = "smallNewsBox1";
            this.smallNewsBox1.Size = new System.Drawing.Size(253, 163);
            this.smallNewsBox1.TabIndex = 4;
            // 
            // smallNewsBox2
            // 
            this.smallNewsBox2.BackColor = System.Drawing.Color.White;
            this.smallNewsBox2.Location = new System.Drawing.Point(655, 630);
            this.smallNewsBox2.Name = "smallNewsBox2";
            this.smallNewsBox2.Size = new System.Drawing.Size(253, 163);
            this.smallNewsBox2.TabIndex = 5;
            // 
            // bigNewsBox2
            // 
            this.bigNewsBox2.BackColor = System.Drawing.Color.White;
            this.bigNewsBox2.Location = new System.Drawing.Point(568, 811);
            this.bigNewsBox2.Name = "bigNewsBox2";
            this.bigNewsBox2.Size = new System.Drawing.Size(340, 200);
            this.bigNewsBox2.TabIndex = 6;
            // 
            // smallNewsBox3
            // 
            this.smallNewsBox3.BackColor = System.Drawing.Color.White;
            this.smallNewsBox3.Location = new System.Drawing.Point(32, 848);
            this.smallNewsBox3.Name = "smallNewsBox3";
            this.smallNewsBox3.Size = new System.Drawing.Size(253, 163);
            this.smallNewsBox3.TabIndex = 7;
            // 
            // smallNewsBox4
            // 
            this.smallNewsBox4.BackColor = System.Drawing.Color.White;
            this.smallNewsBox4.Location = new System.Drawing.Point(300, 848);
            this.smallNewsBox4.Name = "smallNewsBox4";
            this.smallNewsBox4.Size = new System.Drawing.Size(253, 163);
            this.smallNewsBox4.TabIndex = 8;
            // 
            // FrontPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.smallNewsBox4);
            this.Controls.Add(this.smallNewsBox3);
            this.Controls.Add(this.bigNewsBox2);
            this.Controls.Add(this.smallNewsBox2);
            this.Controls.Add(this.smallNewsBox1);
            this.Controls.Add(this.bigNewsBox1);
            this.Controls.Add(this.newsTop1);
            this.Controls.Add(this.lastUsedServiceTop1);
            this.Controls.Add(this.lastUsedServices1);
            this.Name = "FrontPageForm";
            this.Text = "FrontPageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LastUsedServices lastUsedServices1;
        private LastUsedServiceTop lastUsedServiceTop1;
        private NewsTop newsTop1;
        private BigNewsBox bigNewsBox1;
        private SmallNewsBox smallNewsBox1;
        private SmallNewsBox smallNewsBox2;
        private BigNewsBox bigNewsBox2;
        private SmallNewsBox smallNewsBox3;
        private SmallNewsBox smallNewsBox4;
    }
}