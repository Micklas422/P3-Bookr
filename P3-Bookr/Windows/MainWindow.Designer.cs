namespace P3_Bookr.Windows
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.pictureBoxBookr = new System.Windows.Forms.PictureBox();
            this.panelSiteView = new System.Windows.Forms.Panel();
            this.panelForLogIn = new System.Windows.Forms.Panel();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelUserLoggedIn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookr)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.panelSideBar.Location = new System.Drawing.Point(9, 10);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(223, 660);
            this.panelSideBar.TabIndex = 0;
            // 
            // pictureBoxBookr
            // 
            this.pictureBoxBookr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxBookr.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBookr.Image = global::P3_Bookr.Properties.Resources.BookerFullnobackground;
            this.pictureBoxBookr.Location = new System.Drawing.Point(528, 10);
            this.pictureBoxBookr.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBookr.Name = "pictureBoxBookr";
            this.pictureBoxBookr.Size = new System.Drawing.Size(370, 84);
            this.pictureBoxBookr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookr.TabIndex = 1;
            this.pictureBoxBookr.TabStop = false;
            // 
            // panelSiteView
            // 
            this.panelSiteView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSiteView.AutoScroll = true;
            this.panelSiteView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.panelSiteView.Location = new System.Drawing.Point(236, 98);
            this.panelSiteView.Margin = new System.Windows.Forms.Padding(2);
            this.panelSiteView.Name = "panelSiteView";
            this.panelSiteView.Size = new System.Drawing.Size(1020, 572);
            this.panelSiteView.TabIndex = 2;
            // 
            // panelForLogIn
            // 
            this.panelForLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForLogIn.AutoSize = true;
            this.panelForLogIn.BackColor = System.Drawing.Color.White;
            this.panelForLogIn.Location = new System.Drawing.Point(7, 38);
            this.panelForLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.panelForLogIn.Name = "panelForLogIn";
            this.panelForLogIn.Size = new System.Drawing.Size(1246, 630);
            this.panelForLogIn.TabIndex = 3;
            this.panelForLogIn.Visible = false;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.Location = new System.Drawing.Point(977, 10);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(63, 13);
            this.labelLoggedIn.TabIndex = 0;
            this.labelLoggedIn.Text = "Logged ind:";
            // 
            // labelUserLoggedIn
            // 
            this.labelUserLoggedIn.AutoSize = true;
            this.labelUserLoggedIn.Location = new System.Drawing.Point(1046, 10);
            this.labelUserLoggedIn.Name = "labelUserLoggedIn";
            this.labelUserLoggedIn.Size = new System.Drawing.Size(55, 13);
            this.labelUserLoggedIn.TabIndex = 1;
            this.labelUserLoggedIn.Text = "testBruger";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelUserLoggedIn);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.pictureBoxBookr);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelSiteView);
            this.Controls.Add(this.panelForLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Bookr";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelSideBar;
        public System.Windows.Forms.Panel panelSiteView;
        public System.Windows.Forms.Panel panelForLogIn;
        public System.Windows.Forms.Label labelUserLoggedIn;
        public System.Windows.Forms.Label labelLoggedIn;
        public System.Windows.Forms.PictureBox pictureBoxBookr;
    }
}