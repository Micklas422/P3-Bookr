namespace P3_Bookr.Windows
{
    partial class ServiceSubOptions
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
            this.ServiceOptionFlowOptionInfo1 = new System.Windows.Forms.Label();
            this.ServiceOptionFlowOptionInfo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServiceOptionFlowOptionInfo1
            // 
            this.ServiceOptionFlowOptionInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceOptionFlowOptionInfo1.Location = new System.Drawing.Point(4, 4);
            this.ServiceOptionFlowOptionInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceOptionFlowOptionInfo1.Name = "ServiceOptionFlowOptionInfo1";
            this.ServiceOptionFlowOptionInfo1.Size = new System.Drawing.Size(269, 18);
            this.ServiceOptionFlowOptionInfo1.TabIndex = 0;
            this.ServiceOptionFlowOptionInfo1.Text = "Information om service";
            this.ServiceOptionFlowOptionInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceOptionFlowOptionInfo2
            // 
            this.ServiceOptionFlowOptionInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ServiceOptionFlowOptionInfo2.Location = new System.Drawing.Point(140, 43);
            this.ServiceOptionFlowOptionInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceOptionFlowOptionInfo2.Name = "ServiceOptionFlowOptionInfo2";
            this.ServiceOptionFlowOptionInfo2.Size = new System.Drawing.Size(133, 18);
            this.ServiceOptionFlowOptionInfo2.TabIndex = 1;
            this.ServiceOptionFlowOptionInfo2.Text = "Pris?";
            this.ServiceOptionFlowOptionInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceOptionFlowOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ServiceOptionFlowOptionInfo2);
            this.Controls.Add(this.ServiceOptionFlowOptionInfo1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServiceOptionFlowOption";
            this.Size = new System.Drawing.Size(277, 71);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label ServiceOptionFlowOptionInfo1;
        public System.Windows.Forms.Label ServiceOptionFlowOptionInfo2;
    }
}
