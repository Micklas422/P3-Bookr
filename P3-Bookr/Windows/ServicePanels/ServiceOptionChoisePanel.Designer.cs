namespace P3_Bookr.Windows
{
    partial class ServiceOptionChoisePanel
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
            this.ServiceOptionFlow1 = new System.Windows.Forms.FlowLayoutPanel();
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
            // ServiceOptionFlow1
            // 
            this.ServiceOptionFlow1.Location = new System.Drawing.Point(10, 40);
            this.ServiceOptionFlow1.Name = "ServiceOptionFlow1";
            this.ServiceOptionFlow1.Size = new System.Drawing.Size(220, 250);
            this.ServiceOptionFlow1.TabIndex = 1;
            // 
            // ServiceOptionChoisePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ServiceOptionFlow1);
            this.Controls.Add(this.ServiceOptionTitel1);
            this.Name = "ServiceOptionChoisePanel";
            this.Size = new System.Drawing.Size(240, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ServiceOptionTitel1;
        private System.Windows.Forms.FlowLayoutPanel ServiceOptionFlow1;
    }
}
