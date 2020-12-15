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
            this.SuspendLayout();
            // 
            // FlowPanelOfFlow
            // 
            this.FlowPanelOfFlow.AutoScroll = true;
            this.FlowPanelOfFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelOfFlow.BackColor = System.Drawing.Color.White;
            this.FlowPanelOfFlow.Location = new System.Drawing.Point(13, 41);
            this.FlowPanelOfFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowPanelOfFlow.Name = "FlowPanelOfFlow";
            this.FlowPanelOfFlow.Size = new System.Drawing.Size(1174, 644);
            this.FlowPanelOfFlow.TabIndex = 3;
            // 
            // ServicesOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.FlowPanelOfFlow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServicesOverview";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ServicesOverview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel FlowPanelOfFlow;
    }
}