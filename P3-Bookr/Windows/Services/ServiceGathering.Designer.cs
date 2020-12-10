namespace P3_Bookr.Windows.Services
{
    partial class ServiceGathering
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
            this.serviceElement1 = new P3_Bookr.Windows.Services.ServiceElement();
            this.serviceElement2 = new P3_Bookr.Windows.Services.ServiceElement();
            this.serviceElement3 = new P3_Bookr.Windows.Services.ServiceElement();
            this.serviceElement4 = new P3_Bookr.Windows.Services.ServiceElement();
            this.SuspendLayout();
            // 
            // serviceElement1
            // 
            this.serviceElement1.BackColor = System.Drawing.Color.White;
            this.serviceElement1.Location = new System.Drawing.Point(29, 39);
            this.serviceElement1.Name = "serviceElement1";
            this.serviceElement1.Size = new System.Drawing.Size(267, 190);
            this.serviceElement1.TabIndex = 0;
            // 
            // serviceElement2
            // 
            this.serviceElement2.BackColor = System.Drawing.Color.White;
            this.serviceElement2.Location = new System.Drawing.Point(329, 39);
            this.serviceElement2.Name = "serviceElement2";
            this.serviceElement2.Size = new System.Drawing.Size(267, 190);
            this.serviceElement2.TabIndex = 1;
            // 
            // serviceElement3
            // 
            this.serviceElement3.BackColor = System.Drawing.Color.White;
            this.serviceElement3.Location = new System.Drawing.Point(629, 39);
            this.serviceElement3.Name = "serviceElement3";
            this.serviceElement3.Size = new System.Drawing.Size(267, 190);
            this.serviceElement3.TabIndex = 2;
            // 
            // serviceElement4
            // 
            this.serviceElement4.BackColor = System.Drawing.Color.White;
            this.serviceElement4.Location = new System.Drawing.Point(929, 39);
            this.serviceElement4.Name = "serviceElement4";
            this.serviceElement4.Size = new System.Drawing.Size(267, 190);
            this.serviceElement4.TabIndex = 3;
            // 
            // ServiceGathering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.serviceElement4);
            this.Controls.Add(this.serviceElement3);
            this.Controls.Add(this.serviceElement2);
            this.Controls.Add(this.serviceElement1);
            this.Name = "ServiceGathering";
            this.Size = new System.Drawing.Size(922, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceElement serviceElement1;
        private ServiceElement serviceElement2;
        private ServiceElement serviceElement3;
        private ServiceElement serviceElement4;        
    }
}
