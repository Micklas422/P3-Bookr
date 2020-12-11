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
            this.FlowPanelOfFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutTitel1 = new System.Windows.Forms.Label();
            this.FlowPanelOfFlow.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPanelOfFlow
            // 
            this.FlowPanelOfFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelOfFlow.BackColor = System.Drawing.Color.White;
            this.FlowPanelOfFlow.Controls.Add(this.flowLayoutPanel1);
            this.FlowPanelOfFlow.Location = new System.Drawing.Point(13, 41);
            this.FlowPanelOfFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowPanelOfFlow.Name = "FlowPanelOfFlow";
            this.FlowPanelOfFlow.Size = new System.Drawing.Size(773, 375);
            this.FlowPanelOfFlow.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FlowLayoutTitel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 124);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FlowLayoutTitel1
            // 
            this.FlowLayoutTitel1.Location = new System.Drawing.Point(3, 0);
            this.FlowLayoutTitel1.Name = "FlowLayoutTitel1";
            this.FlowLayoutTitel1.Size = new System.Drawing.Size(767, 23);
            this.FlowLayoutTitel1.TabIndex = 0;
            this.FlowLayoutTitel1.Text = "test";
            this.FlowLayoutTitel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.FlowPanelOfFlow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServicesOverview";
            this.Size = new System.Drawing.Size(800, 431);
            this.Load += new System.EventHandler(this.ServicesOverview_Load);
            this.FlowPanelOfFlow.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel FlowPanelOfFlow;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label FlowLayoutTitel1;
    }
}