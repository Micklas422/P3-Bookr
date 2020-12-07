namespace P3_Bookr.Windows.Frontpage
{
    partial class LastUsedServiceTop
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
            this.LastUsedTopLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastUsedTopLabel
            // 
            this.LastUsedTopLabel.AutoSize = true;
            this.LastUsedTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.LastUsedTopLabel.Location = new System.Drawing.Point(298, 10);
            this.LastUsedTopLabel.Name = "LastUsedTopLabel";
            this.LastUsedTopLabel.Size = new System.Drawing.Size(309, 31);
            this.LastUsedTopLabel.TabIndex = 0;
            this.LastUsedTopLabel.Text = "Sidst Anvendte Services";
            this.LastUsedTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LastUsedTopLabel.Click += new System.EventHandler(this.LastUsedTopLabel_Click);
            // 
            // LastUsedServiceTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LastUsedTopLabel);
            this.Name = "LastUsedServiceTop";
            this.Size = new System.Drawing.Size(939, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastUsedTopLabel;
    }
}
