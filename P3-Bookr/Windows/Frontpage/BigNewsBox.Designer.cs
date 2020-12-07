namespace P3_Bookr.Windows.Frontpage
{
    partial class BigNewsBox
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
            this.BigNewsBoxTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BigNewsBoxTitle
            // 
            this.BigNewsBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigNewsBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.BigNewsBoxTitle.Location = new System.Drawing.Point(0, 162);
            this.BigNewsBoxTitle.Name = "BigNewsBoxTitle";
            this.BigNewsBoxTitle.Size = new System.Drawing.Size(340, 38);
            this.BigNewsBoxTitle.TabIndex = 0;
            this.BigNewsBoxTitle.Text = "Titel";
            this.BigNewsBoxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BigNewsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BigNewsBoxTitle);
            this.Name = "BigNewsBox";
            this.Size = new System.Drawing.Size(340, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BigNewsBoxTitle;
    }
}
