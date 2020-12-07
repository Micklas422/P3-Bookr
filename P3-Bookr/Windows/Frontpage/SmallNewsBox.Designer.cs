namespace P3_Bookr.Windows.Frontpage
{
    partial class SmallNewsBox
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
            this.SmallNewsBoxTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SmallNewsBoxTitle
            // 
            this.SmallNewsBoxTitle.BackColor = System.Drawing.Color.White;
            this.SmallNewsBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallNewsBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.SmallNewsBoxTitle.Location = new System.Drawing.Point(0, 130);
            this.SmallNewsBoxTitle.Name = "SmallNewsBoxTitle";
            this.SmallNewsBoxTitle.Size = new System.Drawing.Size(253, 33);
            this.SmallNewsBoxTitle.TabIndex = 0;
            this.SmallNewsBoxTitle.Text = "Titel";
            this.SmallNewsBoxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SmallNewsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SmallNewsBoxTitle);
            this.Name = "SmallNewsBox";
            this.Size = new System.Drawing.Size(253, 163);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SmallNewsBoxTitle;
    }
}
