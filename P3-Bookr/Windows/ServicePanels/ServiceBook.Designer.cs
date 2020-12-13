namespace P3_Bookr.Windows
{
    partial class ServiceBook
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
            this.ButtonBook = new System.Windows.Forms.Button();
            this.dateTimePickerServicerBook = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanelOfferings = new System.Windows.Forms.FlowLayoutPanel();
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
            // ButtonBook
            // 
            this.ButtonBook.Location = new System.Drawing.Point(60, 260);
            this.ButtonBook.Name = "ButtonBook";
            this.ButtonBook.Size = new System.Drawing.Size(120, 30);
            this.ButtonBook.TabIndex = 2;
            this.ButtonBook.Text = "Book/Betal";
            this.ButtonBook.UseVisualStyleBackColor = true;
            this.ButtonBook.Click += new System.EventHandler(this.ButtonBook_Click);
            // 
            // dateTimePickerServicerBook
            // 
            this.dateTimePickerServicerBook.Location = new System.Drawing.Point(7, 236);
            this.dateTimePickerServicerBook.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerServicerBook.Name = "dateTimePickerServicerBook";
            this.dateTimePickerServicerBook.Size = new System.Drawing.Size(228, 20);
            this.dateTimePickerServicerBook.TabIndex = 3;
            // 
            // flowLayoutPanelOfferings
            // 
            this.flowLayoutPanelOfferings.Location = new System.Drawing.Point(2, 21);
            this.flowLayoutPanelOfferings.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelOfferings.Name = "flowLayoutPanelOfferings";
            this.flowLayoutPanelOfferings.Size = new System.Drawing.Size(233, 199);
            this.flowLayoutPanelOfferings.TabIndex = 4;
            // 
            // ServiceBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanelOfferings);
            this.Controls.Add(this.dateTimePickerServicerBook);
            this.Controls.Add(this.ButtonBook);
            this.Controls.Add(this.ServiceOptionTitel1);
            this.Name = "ServiceBook";
            this.Size = new System.Drawing.Size(240, 300);
            this.Load += new System.EventHandler(this.ServiceBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ServiceOptionTitel1;
        private System.Windows.Forms.Button ButtonBook;
        private System.Windows.Forms.DateTimePicker dateTimePickerServicerBook;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOfferings;
    }
}
