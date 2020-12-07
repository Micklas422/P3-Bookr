namespace P3_Bookr.Windows
{
    partial class ServiceDetails
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
            this.ServiceDetailsTitel1 = new System.Windows.Forms.Label();
            this.ServiceDetailsOptionPanel1 = new System.Windows.Forms.Panel();
            this.ServiceDetailsInfoPanel1 = new System.Windows.Forms.Panel();
            this.ServiceBookr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBookr)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceDetailsTitel1
            // 
            this.ServiceDetailsTitel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceDetailsTitel1.Location = new System.Drawing.Point(100, 127);
            this.ServiceDetailsTitel1.Name = "ServiceDetailsTitel1";
            this.ServiceDetailsTitel1.Size = new System.Drawing.Size(800, 20);
            this.ServiceDetailsTitel1.TabIndex = 7;
            this.ServiceDetailsTitel1.Text = "ServiceFlow Overskrift";
            this.ServiceDetailsTitel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceDetailsOptionPanel1
            // 
            this.ServiceDetailsOptionPanel1.BackColor = System.Drawing.Color.White;
            this.ServiceDetailsOptionPanel1.Location = new System.Drawing.Point(580, 150);
            this.ServiceDetailsOptionPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServiceDetailsOptionPanel1.Name = "ServiceDetailsOptionPanel1";
            this.ServiceDetailsOptionPanel1.Size = new System.Drawing.Size(320, 369);
            this.ServiceDetailsOptionPanel1.TabIndex = 8;
            this.ServiceDetailsOptionPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ServiceDetailsInfoPanel1
            // 
            this.ServiceDetailsInfoPanel1.BackColor = System.Drawing.Color.White;
            this.ServiceDetailsInfoPanel1.Location = new System.Drawing.Point(104, 150);
            this.ServiceDetailsInfoPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServiceDetailsInfoPanel1.Name = "ServiceDetailsInfoPanel1";
            this.ServiceDetailsInfoPanel1.Size = new System.Drawing.Size(440, 369);
            this.ServiceDetailsInfoPanel1.TabIndex = 9;
            this.ServiceDetailsInfoPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.ServiceDetailsInfoPanel1_Paint);
            // 
            // ServiceBookr
            // 
            this.ServiceBookr.Image = global::P3_Bookr.Properties.Resources.BookerFullnobackground;
            this.ServiceBookr.Location = new System.Drawing.Point(300, 2);
            this.ServiceBookr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceBookr.Name = "ServiceBookr";
            this.ServiceBookr.Size = new System.Drawing.Size(400, 80);
            this.ServiceBookr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ServiceBookr.TabIndex = 1;
            this.ServiceBookr.TabStop = false;
            this.ServiceBookr.WaitOnLoad = true;
            this.ServiceBookr.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.ServiceDetailsInfoPanel1);
            this.Controls.Add(this.ServiceDetailsOptionPanel1);
            this.Controls.Add(this.ServiceDetailsTitel1);
            this.Controls.Add(this.ServiceBookr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceDetails";
            this.Size = new System.Drawing.Size(1000, 601);
            this.Load += new System.EventHandler(this.ServiceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBookr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ServiceBookr;
        private System.Windows.Forms.Label ServiceDetailsTitel1;
        private System.Windows.Forms.Panel ServiceDetailsOptionPanel1;
        private System.Windows.Forms.Panel ServiceDetailsInfoPanel1;
    }
}