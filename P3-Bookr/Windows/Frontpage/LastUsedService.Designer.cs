﻿namespace P3_Bookr.Windows.Frontpage
{
    partial class LastUsedService
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
            this.frontPageService4 = new P3_Bookr.Windows.Frontpage.FrontPageService();
            this.frontPageService3 = new P3_Bookr.Windows.Frontpage.FrontPageService();
            this.frontPageService2 = new P3_Bookr.Windows.Frontpage.FrontPageService();
            this.frontPageService1 = new P3_Bookr.Windows.Frontpage.FrontPageService();
            this.lastUsedServiceText1 = new P3_Bookr.Windows.Frontpage.LastUsedServiceText();
            this.SuspendLayout();
            // 
            // frontPageService4
            // 
            this.frontPageService4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.frontPageService4.Location = new System.Drawing.Point(979, 79);
            this.frontPageService4.Name = "frontPageService4";
            this.frontPageService4.Size = new System.Drawing.Size(287, 172);
            this.frontPageService4.TabIndex = 4;
            // 
            // frontPageService3
            // 
            this.frontPageService3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.frontPageService3.Location = new System.Drawing.Point(660, 79);
            this.frontPageService3.Name = "frontPageService3";
            this.frontPageService3.Size = new System.Drawing.Size(287, 172);
            this.frontPageService3.TabIndex = 2;
            // 
            // frontPageService2
            // 
            this.frontPageService2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.frontPageService2.Location = new System.Drawing.Point(347, 79);
            this.frontPageService2.Name = "frontPageService2";
            this.frontPageService2.Size = new System.Drawing.Size(287, 172);
            this.frontPageService2.TabIndex = 1;
            // 
            // frontPageService1
            // 
            this.frontPageService1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.frontPageService1.Location = new System.Drawing.Point(32, 79);
            this.frontPageService1.Name = "frontPageService1";
            this.frontPageService1.Size = new System.Drawing.Size(287, 172);
            this.frontPageService1.TabIndex = 0;
            // 
            // lastUsedServiceText1
            // 
            this.lastUsedServiceText1.BackColor = System.Drawing.Color.White;
            this.lastUsedServiceText1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastUsedServiceText1.Location = new System.Drawing.Point(0, 0);
            this.lastUsedServiceText1.Name = "lastUsedServiceText1";
            this.lastUsedServiceText1.Size = new System.Drawing.Size(1266, 49);
            this.lastUsedServiceText1.TabIndex = 5;
            // 
            // LastUsedService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.lastUsedServiceText1);
            this.Controls.Add(this.frontPageService4);
            this.Controls.Add(this.frontPageService3);
            this.Controls.Add(this.frontPageService2);
            this.Controls.Add(this.frontPageService1);
            this.Name = "LastUsedService";
            this.Size = new System.Drawing.Size(1113, 265);
            this.ResumeLayout(false);

        }

        #endregion

        private FrontPageService frontPageService1;
        private FrontPageService frontPageService2;
        private FrontPageService frontPageService3;
        private FrontPageService frontPageService4;
        private LastUsedServiceText lastUsedServiceText1;
    }
}
