namespace P3_Bookr.Windows.Services
{
    partial class ServiceCollection
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
            this.serviceGathering1 = new P3_Bookr.Windows.Services.ServiceGathering();
            //this.servicesTop1 = new P3_Bookr.Windows.Services.ServicesTop();
            this.SuspendLayout();
            // 
            // serviceGathering1
            // 
            this.serviceGathering1.AutoScroll = true;
            this.serviceGathering1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.serviceGathering1.Location = new System.Drawing.Point(24, 77);
            this.serviceGathering1.Name = "serviceGathering1";
            this.serviceGathering1.Size = new System.Drawing.Size(941, 267);
            this.serviceGathering1.TabIndex = 0;
            // 
            // servicesTop1
            // 
            this.servicesTop1.BackColor = System.Drawing.Color.White;
            this.servicesTop1.Location = new System.Drawing.Point(24, 31);
            this.servicesTop1.Name = "servicesTop1";
            this.servicesTop1.Size = new System.Drawing.Size(941, 50);
            this.servicesTop1.TabIndex = 1;
            // 
            // ServiceCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.servicesTop1);
            this.Controls.Add(this.serviceGathering1);
            this.Name = "ServiceCollection";
            this.Size = new System.Drawing.Size(979, 379);
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceGathering serviceGathering1;
        private ServicesTop servicesTop1;
    }
}
