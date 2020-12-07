namespace P3_Bookr.Windows.Frontpage
{
    partial class NewsTop
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
            this.NewsTopLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewsTopLabel
            // 
            this.NewsTopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsTopLabel.AutoSize = true;
            this.NewsTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.NewsTopLabel.Location = new System.Drawing.Point(399, 10);
            this.NewsTopLabel.Name = "NewsTopLabel";
            this.NewsTopLabel.Size = new System.Drawing.Size(117, 31);
            this.NewsTopLabel.TabIndex = 0;
            this.NewsTopLabel.Text = "Nyheder";
            this.NewsTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewsTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NewsTopLabel);
            this.Name = "NewsTop";
            this.Size = new System.Drawing.Size(876, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewsTopLabel;
    }
}
