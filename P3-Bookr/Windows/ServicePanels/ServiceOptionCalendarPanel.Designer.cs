namespace P3_Bookr.Windows
{
    partial class ServiceOptionCalendarPanel
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
            this.ServiceOptionTitel1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ServiceOptionBookButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServiceOptionTitel1
            // 
            this.ServiceOptionTitel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceOptionTitel1.Location = new System.Drawing.Point(4, 4);
            this.ServiceOptionTitel1.Name = "ServiceOptionTitel1";
            this.ServiceOptionTitel1.Size = new System.Drawing.Size(232, 15);
            this.ServiceOptionTitel1.TabIndex = 0;
            this.ServiceOptionTitel1.Text = "Beskrivelse af valg";
            this.ServiceOptionTitel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(35, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // ServiceOptionBookButton1
            // 
            this.ServiceOptionBookButton1.Location = new System.Drawing.Point(60, 260);
            this.ServiceOptionBookButton1.Name = "ServiceOptionBookButton1";
            this.ServiceOptionBookButton1.Size = new System.Drawing.Size(120, 30);
            this.ServiceOptionBookButton1.TabIndex = 2;
            this.ServiceOptionBookButton1.Text = "Book/Betal";
            this.ServiceOptionBookButton1.UseVisualStyleBackColor = true;
            // 
            // ServiceOptionCalendarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ServiceOptionBookButton1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ServiceOptionTitel1);
            this.Name = "ServiceOptionCalendarPanel";
            this.Size = new System.Drawing.Size(240, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ServiceOptionTitel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button ServiceOptionBookButton1;
    }
}
