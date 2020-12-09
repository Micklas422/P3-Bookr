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
            this.SuspendLayout();
            // 
            // ServiceDetailsTitel1
            // 
            this.ServiceDetailsTitel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceDetailsTitel1.Location = new System.Drawing.Point(10, 19);
            this.ServiceDetailsTitel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceDetailsTitel1.Name = "ServiceDetailsTitel1";
            this.ServiceDetailsTitel1.Size = new System.Drawing.Size(580, 16);
            this.ServiceDetailsTitel1.TabIndex = 7;
            this.ServiceDetailsTitel1.Text = "ServiceFlow Overskrift";
            this.ServiceDetailsTitel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceDetailsOptionPanel1
            // 
            this.ServiceDetailsOptionPanel1.BackColor = System.Drawing.Color.White;
            this.ServiceDetailsOptionPanel1.Location = new System.Drawing.Point(350, 38);
            this.ServiceDetailsOptionPanel1.Name = "ServiceDetailsOptionPanel1";
            this.ServiceDetailsOptionPanel1.Size = new System.Drawing.Size(240, 300);
            this.ServiceDetailsOptionPanel1.TabIndex = 8;
            // 
            // ServiceDetailsInfoPanel1
            // 
            this.ServiceDetailsInfoPanel1.BackColor = System.Drawing.Color.White;
            this.ServiceDetailsInfoPanel1.Location = new System.Drawing.Point(10, 38);
            this.ServiceDetailsInfoPanel1.Name = "ServiceDetailsInfoPanel1";
            this.ServiceDetailsInfoPanel1.Size = new System.Drawing.Size(330, 300);
            this.ServiceDetailsInfoPanel1.TabIndex = 9;
            // 
            // ServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.ServiceDetailsInfoPanel1);
            this.Controls.Add(this.ServiceDetailsOptionPanel1);
            this.Controls.Add(this.ServiceDetailsTitel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ServiceDetails";
            this.Size = new System.Drawing.Size(600, 350);
            this.Load += new System.EventHandler(this.ServiceDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ServiceDetailsTitel1;
        private System.Windows.Forms.Panel ServiceDetailsOptionPanel1;
        private System.Windows.Forms.Panel ServiceDetailsInfoPanel1;
    }
}