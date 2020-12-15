namespace P3_Bookr.Windows
{
    partial class ServicesTop
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
            this.LastUsedTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.LastUsedTopLabel.Location = new System.Drawing.Point(3, 0);
            this.LastUsedTopLabel.Name = "LastUsedTopLabel";
            this.LastUsedTopLabel.Size = new System.Drawing.Size(939, 50);
            this.LastUsedTopLabel.TabIndex = 1;
            this.LastUsedTopLabel.Text = "Service";
            this.LastUsedTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LastUsedTopLabel);
            this.Name = "ServicesTop";
            this.Size = new System.Drawing.Size(945, 50);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LastUsedTopLabel;
    }
}
