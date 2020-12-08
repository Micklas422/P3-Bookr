namespace P3_Bookr.Windows
{
    partial class ServicesOverview
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
            this.ServiceOverviewFlow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ServiceOverviewFlow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ServiceOverviewFlowTitel2 = new System.Windows.Forms.Label();
            this.ServiceOverviewFlowTitel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServiceOverviewFlow1
            // 
            this.ServiceOverviewFlow1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServiceOverviewFlow1.BackColor = System.Drawing.Color.White;
            this.ServiceOverviewFlow1.Location = new System.Drawing.Point(10, 33);
            this.ServiceOverviewFlow1.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceOverviewFlow1.Name = "ServiceOverviewFlow1";
            this.ServiceOverviewFlow1.Size = new System.Drawing.Size(580, 98);
            this.ServiceOverviewFlow1.TabIndex = 3;
            // 
            // ServiceOverviewFlow2
            // 
            this.ServiceOverviewFlow2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServiceOverviewFlow2.BackColor = System.Drawing.Color.White;
            this.ServiceOverviewFlow2.Location = new System.Drawing.Point(10, 187);
            this.ServiceOverviewFlow2.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceOverviewFlow2.Name = "ServiceOverviewFlow2";
            this.ServiceOverviewFlow2.Size = new System.Drawing.Size(580, 98);
            this.ServiceOverviewFlow2.TabIndex = 4;
            // 
            // ServiceOverviewFlowTitel2
            // 
            this.ServiceOverviewFlowTitel2.BackColor = System.Drawing.Color.White;
            this.ServiceOverviewFlowTitel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceOverviewFlowTitel2.Location = new System.Drawing.Point(10, 169);
            this.ServiceOverviewFlowTitel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceOverviewFlowTitel2.Name = "ServiceOverviewFlowTitel2";
            this.ServiceOverviewFlowTitel2.Size = new System.Drawing.Size(580, 16);
            this.ServiceOverviewFlowTitel2.TabIndex = 5;
            this.ServiceOverviewFlowTitel2.Text = "ServiceFlow Overskrift";
            this.ServiceOverviewFlowTitel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceOverviewFlowTitel1
            // 
            this.ServiceOverviewFlowTitel1.BackColor = System.Drawing.Color.White;
            this.ServiceOverviewFlowTitel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceOverviewFlowTitel1.Location = new System.Drawing.Point(10, 15);
            this.ServiceOverviewFlowTitel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceOverviewFlowTitel1.Name = "ServiceOverviewFlowTitel1";
            this.ServiceOverviewFlowTitel1.Size = new System.Drawing.Size(580, 16);
            this.ServiceOverviewFlowTitel1.TabIndex = 6;
            this.ServiceOverviewFlowTitel1.Text = "ServiceFlow Overskrift";
            this.ServiceOverviewFlowTitel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.ServiceOverviewFlowTitel1);
            this.Controls.Add(this.ServiceOverviewFlowTitel2);
            this.Controls.Add(this.ServiceOverviewFlow2);
            this.Controls.Add(this.ServiceOverviewFlow1);
            this.Name = "ServicesOverview";
            this.Size = new System.Drawing.Size(600, 350);
            this.Load += new System.EventHandler(this.ServicesOverview_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ServiceOverviewFlow1;
        private System.Windows.Forms.FlowLayoutPanel ServiceOverviewFlow2;
        private System.Windows.Forms.Label ServiceOverviewFlowTitel2;
        private System.Windows.Forms.Label ServiceOverviewFlowTitel1;
    }
}