namespace P3_Bookr.Windows.Frontpage
{
    partial class LastUsedServiceText
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
            this.LastUsedTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastUsedTitle
            // 
            this.LastUsedTitle.AutoSize = true;
            this.LastUsedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.LastUsedTitle.Location = new System.Drawing.Point(176, 9);
            this.LastUsedTitle.Name = "LastUsedTitle";
            this.LastUsedTitle.Size = new System.Drawing.Size(309, 31);
            this.LastUsedTitle.TabIndex = 0;
            this.LastUsedTitle.Text = "Sidst Anvendte Services";
            this.LastUsedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastUsedServiceText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LastUsedTitle);
            this.Name = "LastUsedServiceText";
            this.Size = new System.Drawing.Size(647, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastUsedTitle;
    }
}
