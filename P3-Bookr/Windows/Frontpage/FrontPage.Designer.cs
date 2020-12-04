namespace P3_Bookr.Windows
{
    partial class FrontPage
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
            this.lastUsedService1 = new P3_Bookr.Windows.Frontpage.LastUsedService();
            this.SuspendLayout();
            // 
            // lastUsedService1
            // 
            this.lastUsedService1.AutoScroll = true;
            this.lastUsedService1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.lastUsedService1.Location = new System.Drawing.Point(12, 61);
            this.lastUsedService1.Name = "lastUsedService1";
            this.lastUsedService1.Size = new System.Drawing.Size(1113, 275);
            this.lastUsedService1.TabIndex = 0;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.lastUsedService1);
            this.Name = "FrontPage";
            this.Text = "Bookr";
            this.Load += new System.EventHandler(this.FrontPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Frontpage.LastUsedService lastUsedService1;
    }
}