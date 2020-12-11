namespace P3_Bookr.Windows
{
    partial class ServiceViewForFlow
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
            this.ServiceTitel = new System.Windows.Forms.Label();
            this.ServiceLocation = new System.Windows.Forms.Label();
            this.ServiceInfo = new System.Windows.Forms.Label();
            this.ServiceLocationInfo = new System.Windows.Forms.Label();
            this.ServiceInfoInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServiceTitel
            // 
            this.ServiceTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceTitel.Location = new System.Drawing.Point(0, 0);
            this.ServiceTitel.Name = "ServiceTitel";
            this.ServiceTitel.Size = new System.Drawing.Size(180, 20);
            this.ServiceTitel.TabIndex = 0;
            this.ServiceTitel.Text = "ServiceTitel";
            this.ServiceTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceLocation
            // 
            this.ServiceLocation.Location = new System.Drawing.Point(0, 33);
            this.ServiceLocation.Name = "ServiceLocation";
            this.ServiceLocation.Size = new System.Drawing.Size(55, 20);
            this.ServiceLocation.TabIndex = 1;
            this.ServiceLocation.Text = "Lokale:";
            // 
            // ServiceInfo
            // 
            this.ServiceInfo.Location = new System.Drawing.Point(0, 63);
            this.ServiceInfo.Name = "ServiceInfo";
            this.ServiceInfo.Size = new System.Drawing.Size(55, 20);
            this.ServiceInfo.TabIndex = 2;
            this.ServiceInfo.Text = "Info:";
            this.ServiceInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // ServiceLocationInfo
            // 
            this.ServiceLocationInfo.Location = new System.Drawing.Point(57, 33);
            this.ServiceLocationInfo.Name = "ServiceLocationInfo";
            this.ServiceLocationInfo.Size = new System.Drawing.Size(120, 20);
            this.ServiceLocationInfo.TabIndex = 3;
            this.ServiceLocationInfo.Text = "Lokale addresse";
            // 
            // ServiceInfoInfo
            // 
            this.ServiceInfoInfo.Location = new System.Drawing.Point(60, 63);
            this.ServiceInfoInfo.Name = "ServiceInfoInfo";
            this.ServiceInfoInfo.Size = new System.Drawing.Size(120, 20);
            this.ServiceInfoInfo.TabIndex = 4;
            this.ServiceInfoInfo.Text = "Info information";
            // 
            // ServiceViewForFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ServiceInfoInfo);
            this.Controls.Add(this.ServiceLocationInfo);
            this.Controls.Add(this.ServiceInfo);
            this.Controls.Add(this.ServiceLocation);
            this.Controls.Add(this.ServiceTitel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceViewForFlow";
            this.Size = new System.Drawing.Size(179, 114);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ServiceLocation;
        private System.Windows.Forms.Label ServiceInfo;
        public System.Windows.Forms.Label ServiceTitel;
        public System.Windows.Forms.Label ServiceLocationInfo;
        public System.Windows.Forms.Label ServiceInfoInfo;
    }
}
