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
            this.ServiceOptionBookButton1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ServiceOptionTitel1
            // 
            this.ServiceOptionTitel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceOptionTitel1.Location = new System.Drawing.Point(5, 5);
            this.ServiceOptionTitel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceOptionTitel1.Name = "ServiceOptionTitel1";
            this.ServiceOptionTitel1.Size = new System.Drawing.Size(309, 18);
            this.ServiceOptionTitel1.TabIndex = 0;
            this.ServiceOptionTitel1.Text = "Beskrivelse af valg";
            this.ServiceOptionTitel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceOptionBookButton1
            // 
            this.ServiceOptionBookButton1.Location = new System.Drawing.Point(80, 320);
            this.ServiceOptionBookButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServiceOptionBookButton1.Name = "ServiceOptionBookButton1";
            this.ServiceOptionBookButton1.Size = new System.Drawing.Size(160, 37);
            this.ServiceOptionBookButton1.TabIndex = 2;
            this.ServiceOptionBookButton1.Text = "Book/Betal";
            this.ServiceOptionBookButton1.UseVisualStyleBackColor = true;
            this.ServiceOptionBookButton1.Click += new System.EventHandler(this.ServiceOptionBookButton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 291);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 245);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ServiceOptionCalendarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ServiceOptionBookButton1);
            this.Controls.Add(this.ServiceOptionTitel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServiceOptionCalendarPanel";
            this.Size = new System.Drawing.Size(320, 369);
            this.Load += new System.EventHandler(this.ServiceOptionCalendarPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ServiceOptionTitel1;
        private System.Windows.Forms.Button ServiceOptionBookButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
