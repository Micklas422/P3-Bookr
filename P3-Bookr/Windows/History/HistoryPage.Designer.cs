namespace P3_Bookr.Windows.History
{
    partial class HistoryPage
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
            this.historyElement1 = new P3_Bookr.Windows.History.HistoryElement();
            this.historyElement2 = new P3_Bookr.Windows.History.HistoryElement();
            this.historyElement3 = new P3_Bookr.Windows.History.HistoryElement();
            this.SuspendLayout();
            // 
            // historyElement1
            // 
            this.historyElement1.BackColor = System.Drawing.Color.White;
            this.historyElement1.Location = new System.Drawing.Point(11, 86);
            this.historyElement1.Name = "historyElement1";
            this.historyElement1.Size = new System.Drawing.Size(881, 112);
            this.historyElement1.TabIndex = 0;
            // 
            // historyElement2
            // 
            this.historyElement2.BackColor = System.Drawing.Color.White;
            this.historyElement2.Location = new System.Drawing.Point(11, 233);
            this.historyElement2.Name = "historyElement2";
            this.historyElement2.Size = new System.Drawing.Size(881, 112);
            this.historyElement2.TabIndex = 1;
            // 
            // historyElement3
            // 
            this.historyElement3.AutoScroll = true;
            this.historyElement3.BackColor = System.Drawing.Color.White;
            this.historyElement3.Location = new System.Drawing.Point(14, 378);
            this.historyElement3.Name = "historyElement3";
            this.historyElement3.Size = new System.Drawing.Size(881, 112);
            this.historyElement3.TabIndex = 2;
            // 
            // HistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.historyElement3);
            this.Controls.Add(this.historyElement2);
            this.Controls.Add(this.historyElement1);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryPage";
            this.Text = "HistoryPage";
            this.Load += new System.EventHandler(this.HistoryPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HistoryElement historyElement1;
        private HistoryElement historyElement2;
        private HistoryElement historyElement3;
    }
}