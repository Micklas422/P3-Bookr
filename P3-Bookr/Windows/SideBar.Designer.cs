namespace P3_Bookr.Windows
{
    partial class SideBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBar));
            this.ServicesKnap = new System.Windows.Forms.Label();
            this.ReservationerKnap = new System.Windows.Forms.Label();
            this.MitForbrugKnap = new System.Windows.Forms.Label();
            this.IndstillingerKnap = new System.Windows.Forms.Label();
            this.LogUdKnap = new System.Windows.Forms.Label();
            this.BookrLogoKnap = new System.Windows.Forms.PictureBox();
            this.LabelAdminTools = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookrLogoKnap)).BeginInit();
            this.SuspendLayout();
            // 
            // ServicesKnap
            // 
            resources.ApplyResources(this.ServicesKnap, "ServicesKnap");
            this.ServicesKnap.BackColor = System.Drawing.Color.Transparent;
            this.ServicesKnap.Name = "ServicesKnap";
            this.ServicesKnap.Click += new System.EventHandler(this.ServicesKnap_Click);
            // 
            // ReservationerKnap
            // 
            resources.ApplyResources(this.ReservationerKnap, "ReservationerKnap");
            this.ReservationerKnap.BackColor = System.Drawing.Color.Transparent;
            this.ReservationerKnap.Name = "ReservationerKnap";
            this.ReservationerKnap.Click += new System.EventHandler(this.ReservationerKnap_Click);
            // 
            // MitForbrugKnap
            // 
            resources.ApplyResources(this.MitForbrugKnap, "MitForbrugKnap");
            this.MitForbrugKnap.BackColor = System.Drawing.Color.Transparent;
            this.MitForbrugKnap.Name = "MitForbrugKnap";
            this.MitForbrugKnap.Click += new System.EventHandler(this.MitForbrugKnap_Click);
            // 
            // IndstillingerKnap
            // 
            resources.ApplyResources(this.IndstillingerKnap, "IndstillingerKnap");
            this.IndstillingerKnap.BackColor = System.Drawing.Color.Transparent;
            this.IndstillingerKnap.Name = "IndstillingerKnap";
            this.IndstillingerKnap.Click += new System.EventHandler(this.IndstillingerKnap_Click);
            // 
            // LogUdKnap
            // 
            resources.ApplyResources(this.LogUdKnap, "LogUdKnap");
            this.LogUdKnap.BackColor = System.Drawing.Color.Transparent;
            this.LogUdKnap.Name = "LogUdKnap";
            this.LogUdKnap.Click += new System.EventHandler(this.LogUdKnap_Click);
            // 
            // BookrLogoKnap
            // 
            this.BookrLogoKnap.Image = global::P3_Bookr.Properties.Resources.BookerFullnobackground4;
            resources.ApplyResources(this.BookrLogoKnap, "BookrLogoKnap");
            this.BookrLogoKnap.Name = "BookrLogoKnap";
            this.BookrLogoKnap.TabStop = false;
            this.BookrLogoKnap.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabelAdminTools
            // 
            resources.ApplyResources(this.LabelAdminTools, "LabelAdminTools");
            this.LabelAdminTools.BackColor = System.Drawing.Color.Transparent;
            this.LabelAdminTools.Name = "LabelAdminTools";
            this.LabelAdminTools.Click += new System.EventHandler(this.LabelAdminTools_Click);
            // 
            // SideBar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.LabelAdminTools);
            this.Controls.Add(this.LogUdKnap);
            this.Controls.Add(this.IndstillingerKnap);
            this.Controls.Add(this.MitForbrugKnap);
            this.Controls.Add(this.ReservationerKnap);
            this.Controls.Add(this.ServicesKnap);
            this.Controls.Add(this.BookrLogoKnap);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SideBar";
            this.Load += new System.EventHandler(this.SideBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookrLogoKnap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BookrLogoKnap;
        private System.Windows.Forms.Label ServicesKnap;
        private System.Windows.Forms.Label ReservationerKnap;
        private System.Windows.Forms.Label MitForbrugKnap;
        private System.Windows.Forms.Label IndstillingerKnap;
        private System.Windows.Forms.Label LogUdKnap;
        public System.Windows.Forms.Label LabelAdminTools;
    }
}