namespace P3_Bookr.Windows
{
    partial class ServiceDetailsCalendar
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
            this.ServiceCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ServiceCalendarBookr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceCalendarBookr)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceCalendar1
            // 
            this.ServiceCalendar1.Location = new System.Drawing.Point(314, 142);
            this.ServiceCalendar1.Name = "ServiceCalendar1";
            this.ServiceCalendar1.TabIndex = 0;
            this.ServiceCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ServiceCalendar1_DateChanged);
            // 
            // ServiceCalendarBookr
            // 
            this.ServiceCalendarBookr.Image = global::P3_Bookr.Properties.Resources.BookerFullnobackground;
            this.ServiceCalendarBookr.Location = new System.Drawing.Point(225, 2);
            this.ServiceCalendarBookr.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceCalendarBookr.Name = "ServiceCalendarBookr";
            this.ServiceCalendarBookr.Size = new System.Drawing.Size(300, 65);
            this.ServiceCalendarBookr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ServiceCalendarBookr.TabIndex = 2;
            this.ServiceCalendarBookr.TabStop = false;
            this.ServiceCalendarBookr.WaitOnLoad = true;
            // 
            // ServiceDetailsCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServiceCalendarBookr);
            this.Controls.Add(this.ServiceCalendar1);
            this.Name = "ServiceDetailsCalendar";
            this.Size = new System.Drawing.Size(750, 488);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceCalendarBookr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar ServiceCalendar1;
        private System.Windows.Forms.PictureBox ServiceCalendarBookr;
    }
}