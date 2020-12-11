namespace P3_Bookr.Windows.Frontpage
{
    partial class LastUsedServices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frontPageService1 = new P3_Bookr.Windows.Frontpage.FrontPageService();
            this.frontPageService2 = new P3_Bookr.Windows.Frontpage.FrontPageService();
            this.frontPageService3 = new P3_Bookr.Windows.Frontpage.FrontPageService();
            this.frontPageService4 = new P3_Bookr.Windows.Frontpage.FrontPageService();
            this.SuspendLayout();
            // 
            // frontPageService1
            // 
            this.frontPageService1.BackColor = System.Drawing.Color.White;
            this.frontPageService1.Location = new System.Drawing.Point(39, 64);
            this.frontPageService1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.frontPageService1.Name = "frontPageService1";
            this.frontPageService1.Size = new System.Drawing.Size(356, 234);
            this.frontPageService1.TabIndex = 4;
            this.frontPageService1.Click += new System.EventHandler(this.frontPageService1_Click);
            // 
            // frontPageService2
            // 
            this.frontPageService2.BackColor = System.Drawing.Color.White;
            this.frontPageService2.Location = new System.Drawing.Point(429, 64);
            this.frontPageService2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.frontPageService2.Name = "frontPageService2";
            this.frontPageService2.Size = new System.Drawing.Size(356, 234);
            this.frontPageService2.TabIndex = 5;
            // 
            // frontPageService3
            // 
            this.frontPageService3.BackColor = System.Drawing.Color.White;
            this.frontPageService3.Location = new System.Drawing.Point(820, 64);
            this.frontPageService3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.frontPageService3.Name = "frontPageService3";
            this.frontPageService3.Size = new System.Drawing.Size(356, 234);
            this.frontPageService3.TabIndex = 6;
            // 
            // frontPageService4
            // 
            this.frontPageService4.BackColor = System.Drawing.Color.White;
            this.frontPageService4.Location = new System.Drawing.Point(1207, 64);
            this.frontPageService4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.frontPageService4.Name = "frontPageService4";
            this.frontPageService4.Size = new System.Drawing.Size(356, 234);
            this.frontPageService4.TabIndex = 7;
            // 
            // LastUsedServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.frontPageService4);
            this.Controls.Add(this.frontPageService3);
            this.Controls.Add(this.frontPageService2);
            this.Controls.Add(this.frontPageService1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LastUsedServices";
            this.Size = new System.Drawing.Size(1229, 329);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontPageService frontPageService1;
        private FrontPageService frontPageService2;
        private FrontPageService frontPageService3;
        private FrontPageService frontPageService4;
    }
}
