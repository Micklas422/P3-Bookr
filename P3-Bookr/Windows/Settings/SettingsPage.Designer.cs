namespace P3_Bookr.Windows.Settings
{
    partial class SettingsPage
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
            this.personalInfo1 = new P3_Bookr.Windows.Settings.PersonalInfo();
            this.paymentInfo1 = new P3_Bookr.Windows.Settings.PaymentInfo();
            this.SuspendLayout();
            // 
            // personalInfo1
            // 
            this.personalInfo1.BackColor = System.Drawing.Color.White;
            this.personalInfo1.Location = new System.Drawing.Point(66, 20);
            this.personalInfo1.Name = "personalInfo1";
            this.personalInfo1.Size = new System.Drawing.Size(888, 318);
            this.personalInfo1.TabIndex = 0;
            // 
            // paymentInfo1
            // 
            this.paymentInfo1.BackColor = System.Drawing.Color.White;
            this.paymentInfo1.Location = new System.Drawing.Point(66, 358);
            this.paymentInfo1.Name = "paymentInfo1";
            this.paymentInfo1.Size = new System.Drawing.Size(888, 271);
            this.paymentInfo1.TabIndex = 1;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.paymentInfo1);
            this.Controls.Add(this.personalInfo1);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(1020, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonalInfo personalInfo1;
        private PaymentInfo paymentInfo1;
    }
}