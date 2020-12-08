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
            this.panelSideBar.Location = new System.Drawing.Point(12, 12);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(297, 536);
            this.panelSideBar.TabIndex = 0;
            // 
            // pictureBoxBookr
            // 
            this.pictureBoxBookr.Image = global::P3_Bookr.Properties.Resources.BookerFullnobackground;
            this.pictureBoxBookr.Location = new System.Drawing.Point(435, 12);
            this.pictureBoxBookr.Name = "pictureBoxBookr";
            this.pictureBoxBookr.Size = new System.Drawing.Size(494, 103);
            this.pictureBoxBookr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookr.TabIndex = 1;
            this.pictureBoxBookr.TabStop = false;
            // 
            // panelSiteView
            // 
            this.panelSiteView.Location = new System.Drawing.Point(315, 121);
            this.panelSiteView.Name = "panelSiteView";
            this.panelSiteView.Size = new System.Drawing.Size(740, 427);
            this.panelSiteView.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.panelSiteView);
            this.Controls.Add(this.pictureBoxBookr);
            this.Controls.Add(this.panelSideBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.PictureBox pictureBoxBookr;
        private System.Windows.Forms.Panel panelSiteView;
    }
}