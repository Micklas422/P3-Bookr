namespace P3_Bookr.Windows
{
    partial class ServiceInfoPanel
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
            this.ServiceAddressLabel1 = new System.Windows.Forms.Label();
            this.ServiceAdressInfo1 = new System.Windows.Forms.Label();
            this.ServiceDescriptionInfo1 = new System.Windows.Forms.Label();
            this.ServiceBookButton1 = new System.Windows.Forms.Button();
            this.ServiceDetailsPicture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDetailsPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceAddressLabel1
            // 
            this.ServiceAddressLabel1.AutoSize = true;
            this.ServiceAddressLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServiceAddressLabel1.Location = new System.Drawing.Point(4, 12);
            this.ServiceAddressLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceAddressLabel1.Name = "ServiceAddressLabel1";
            this.ServiceAddressLabel1.Size = new System.Drawing.Size(64, 17);
            this.ServiceAddressLabel1.TabIndex = 0;
            this.ServiceAddressLabel1.Text = "Adresse:";
            this.ServiceAddressLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceAdressInfo1
            // 
            this.ServiceAdressInfo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServiceAdressInfo1.Location = new System.Drawing.Point(77, 12);
            this.ServiceAdressInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceAdressInfo1.Name = "ServiceAdressInfo1";
            this.ServiceAdressInfo1.Size = new System.Drawing.Size(353, 16);
            this.ServiceAdressInfo1.TabIndex = 1;
            this.ServiceAdressInfo1.Text = "Adresse info";
            this.ServiceAdressInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceDescriptionInfo1
            // 
            this.ServiceDescriptionInfo1.Location = new System.Drawing.Point(204, 76);
            this.ServiceDescriptionInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceDescriptionInfo1.Name = "ServiceDescriptionInfo1";
            this.ServiceDescriptionInfo1.Size = new System.Drawing.Size(227, 185);
            this.ServiceDescriptionInfo1.TabIndex = 3;
            this.ServiceDescriptionInfo1.Text = "Info omkring service her";
            this.ServiceDescriptionInfo1.Click += new System.EventHandler(this.ServiceDescriptionInfo1_Click);
            // 
            // ServiceBookButton1
            // 
            this.ServiceBookButton1.Location = new System.Drawing.Point(140, 329);
            this.ServiceBookButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServiceBookButton1.Name = "ServiceBookButton1";
            this.ServiceBookButton1.Size = new System.Drawing.Size(160, 37);
            this.ServiceBookButton1.TabIndex = 4;
            this.ServiceBookButton1.Text = "Book/Betal";
            this.ServiceBookButton1.UseVisualStyleBackColor = true;
            // 
            // ServiceDetailsPicture1
            // 
            this.ServiceDetailsPicture1.Location = new System.Drawing.Point(8, 76);
            this.ServiceDetailsPicture1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServiceDetailsPicture1.Name = "ServiceDetailsPicture1";
            this.ServiceDetailsPicture1.Size = new System.Drawing.Size(187, 172);
            this.ServiceDetailsPicture1.TabIndex = 2;
            this.ServiceDetailsPicture1.TabStop = false;
            // 
            // ServiceInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ServiceBookButton1);
            this.Controls.Add(this.ServiceDescriptionInfo1);
            this.Controls.Add(this.ServiceDetailsPicture1);
            this.Controls.Add(this.ServiceAdressInfo1);
            this.Controls.Add(this.ServiceAddressLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServiceInfoPanel";
            this.Size = new System.Drawing.Size(440, 369);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDetailsPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceAddressLabel1;
        private System.Windows.Forms.PictureBox ServiceDetailsPicture1;
        private System.Windows.Forms.Button ServiceBookButton1;
        public System.Windows.Forms.Label ServiceAdressInfo1;
        public System.Windows.Forms.Label ServiceDescriptionInfo1;
    }
}
