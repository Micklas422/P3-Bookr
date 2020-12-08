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
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.pictureBoxBookr = new System.Windows.Forms.PictureBox();
            this.panelSiteView = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookr)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.Location = new System.Drawing.Point(9, 10);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(223, 436);
            this.panelSideBar.TabIndex = 0;
            // 
            // pictureBoxBookr
            // 
            this.pictureBoxBookr.Image = global::P3_Bookr.Properties.Resources.BookerFullnobackground;
            this.pictureBoxBookr.Location = new System.Drawing.Point(326, 10);
            this.pictureBoxBookr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxBookr.Name = "pictureBoxBookr";
            this.pictureBoxBookr.Size = new System.Drawing.Size(370, 84);
            this.pictureBoxBookr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookr.TabIndex = 1;
            this.pictureBoxBookr.TabStop = false;
            // 
            // panelSiteView
            // 
            this.panelSiteView.Location = new System.Drawing.Point(236, 98);
            this.panelSiteView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSiteView.Name = "panelSiteView";
            this.panelSiteView.Size = new System.Drawing.Size(555, 347);
            this.panelSiteView.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.panelSiteView);
            this.Controls.Add(this.pictureBoxBookr);
            this.Controls.Add(this.panelSideBar);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.PictureBox pictureBoxBookr;
        public System.Windows.Forms.Panel panelSiteView;
    }
}