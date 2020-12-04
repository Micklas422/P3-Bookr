namespace P3_Bookr.Windows
{
    partial class ServiceDetails
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
            this.ServiceFlow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ServiceBookr = new System.Windows.Forms.PictureBox();
            this.ServiceFlowTitel1 = new System.Windows.Forms.Label();
            this.ServiceFlow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ServiceFlowTitel2 = new System.Windows.Forms.Label();
            this.serviceViewForFlow1 = new P3_Bookr.Windows.ServiceViewForFlow();
            this.serviceViewForFlow2 = new P3_Bookr.Windows.ServiceViewForFlow();
            this.serviceViewForFlow3 = new P3_Bookr.Windows.ServiceViewForFlow();
            this.ServiceFlow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBookr)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceFlow1
            // 
            this.ServiceFlow1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServiceFlow1.Controls.Add(this.serviceViewForFlow1);
            this.ServiceFlow1.Controls.Add(this.serviceViewForFlow2);
            this.ServiceFlow1.Controls.Add(this.serviceViewForFlow3);
            this.ServiceFlow1.Location = new System.Drawing.Point(100, 150);
            this.ServiceFlow1.Name = "ServiceFlow1";
            this.ServiceFlow1.Size = new System.Drawing.Size(800, 120);
            this.ServiceFlow1.TabIndex = 0;
            // 
            // ServiceBookr
            // 
            this.ServiceBookr.Image = global::P3_Bookr.Properties.Resources.BookerFullnobackground;
            this.ServiceBookr.Location = new System.Drawing.Point(300, 3);
            this.ServiceBookr.Name = "ServiceBookr";
            this.ServiceBookr.Size = new System.Drawing.Size(400, 80);
            this.ServiceBookr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ServiceBookr.TabIndex = 1;
            this.ServiceBookr.TabStop = false;
            this.ServiceBookr.WaitOnLoad = true;
            this.ServiceBookr.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ServiceFlowTitel1
            // 
            this.ServiceFlowTitel1.Location = new System.Drawing.Point(100, 127);
            this.ServiceFlowTitel1.Name = "ServiceFlowTitel1";
            this.ServiceFlowTitel1.Size = new System.Drawing.Size(800, 20);
            this.ServiceFlowTitel1.TabIndex = 2;
            this.ServiceFlowTitel1.Text = "ServiceFlow Overskrift";
            this.ServiceFlowTitel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceFlow2
            // 
            this.ServiceFlow2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServiceFlow2.Location = new System.Drawing.Point(100, 320);
            this.ServiceFlow2.Name = "ServiceFlow2";
            this.ServiceFlow2.Size = new System.Drawing.Size(800, 120);
            this.ServiceFlow2.TabIndex = 3;
            // 
            // ServiceFlowTitel2
            // 
            this.ServiceFlowTitel2.Location = new System.Drawing.Point(100, 297);
            this.ServiceFlowTitel2.Name = "ServiceFlowTitel2";
            this.ServiceFlowTitel2.Size = new System.Drawing.Size(800, 20);
            this.ServiceFlowTitel2.TabIndex = 4;
            this.ServiceFlowTitel2.Text = "ServiceFlow Overskrift";
            this.ServiceFlowTitel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serviceViewForFlow1
            // 
            this.serviceViewForFlow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceViewForFlow1.Location = new System.Drawing.Point(3, 3);
            this.serviceViewForFlow1.Name = "serviceViewForFlow1";
            this.serviceViewForFlow1.Size = new System.Drawing.Size(178, 114);
            this.serviceViewForFlow1.TabIndex = 0;
            // 
            // serviceViewForFlow2
            // 
            this.serviceViewForFlow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceViewForFlow2.Location = new System.Drawing.Point(187, 3);
            this.serviceViewForFlow2.Name = "serviceViewForFlow2";
            this.serviceViewForFlow2.Size = new System.Drawing.Size(178, 114);
            this.serviceViewForFlow2.TabIndex = 1;
            // 
            // serviceViewForFlow3
            // 
            this.serviceViewForFlow3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceViewForFlow3.Location = new System.Drawing.Point(371, 3);
            this.serviceViewForFlow3.Name = "serviceViewForFlow3";
            this.serviceViewForFlow3.Size = new System.Drawing.Size(178, 114);
            this.serviceViewForFlow3.TabIndex = 2;
            // 
            // ServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServiceFlowTitel2);
            this.Controls.Add(this.ServiceFlow2);
            this.Controls.Add(this.ServiceFlowTitel1);
            this.Controls.Add(this.ServiceBookr);
            this.Controls.Add(this.ServiceFlow1);
            this.Name = "ServiceDetails";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.ServiceDetails_Load);
            this.ServiceFlow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBookr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ServiceFlow1;
        private System.Windows.Forms.PictureBox ServiceBookr;
        private System.Windows.Forms.Label ServiceFlowTitel1;
        private System.Windows.Forms.FlowLayoutPanel ServiceFlow2;
        private System.Windows.Forms.Label ServiceFlowTitel2;
        private ServiceViewForFlow serviceViewForFlow1;
        private ServiceViewForFlow serviceViewForFlow2;
        private ServiceViewForFlow serviceViewForFlow3;
    }
}