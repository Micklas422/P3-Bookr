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
            this.ServicesKnap = new System.Windows.Forms.Label();
            this.ReservationerKnap = new System.Windows.Forms.Label();
            this.MitForbrugKnap = new System.Windows.Forms.Label();
            this.IndstillingerKnap = new System.Windows.Forms.Label();
            this.LogUdKnap = new System.Windows.Forms.Label();
            this.BookrLogoKnap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookrLogoKnap)).BeginInit();
            this.SuspendLayout();
            // 
            // ServicesKnap
            // 
            this.ServicesKnap.AutoSize = true;
            this.ServicesKnap.BackColor = System.Drawing.Color.Transparent;
            this.ServicesKnap.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesKnap.Location = new System.Drawing.Point(12, 98);
            this.ServicesKnap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServicesKnap.Name = "ServicesKnap";
            this.ServicesKnap.Size = new System.Drawing.Size(156, 42);
            this.ServicesKnap.TabIndex = 1;
            this.ServicesKnap.Text = "Services";
            // 
            // ReservationerKnap
            // 
            this.ReservationerKnap.AutoSize = true;
            this.ReservationerKnap.BackColor = System.Drawing.Color.Transparent;
            this.ReservationerKnap.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationerKnap.Location = new System.Drawing.Point(12, 172);
            this.ReservationerKnap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationerKnap.Name = "ReservationerKnap";
            this.ReservationerKnap.Size = new System.Drawing.Size(243, 42);
            this.ReservationerKnap.TabIndex = 2;
            this.ReservationerKnap.Text = "Reservationer";
            this.ReservationerKnap.Click += new System.EventHandler(this.ReservationerKnap_Click);
            // 
            // MitForbrugKnap
            // 
            this.MitForbrugKnap.AutoSize = true;
            this.MitForbrugKnap.BackColor = System.Drawing.Color.Transparent;
            this.MitForbrugKnap.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MitForbrugKnap.Location = new System.Drawing.Point(12, 246);
            this.MitForbrugKnap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MitForbrugKnap.Name = "MitForbrugKnap";
            this.MitForbrugKnap.Size = new System.Drawing.Size(207, 42);
            this.MitForbrugKnap.TabIndex = 3;
            this.MitForbrugKnap.Text = "Mit Forbrug";
            this.MitForbrugKnap.Click += new System.EventHandler(this.MitForbrugKnap_Click);
            // 
            // IndstillingerKnap
            // 
            this.IndstillingerKnap.AutoSize = true;
            this.IndstillingerKnap.BackColor = System.Drawing.Color.Transparent;
            this.IndstillingerKnap.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndstillingerKnap.Location = new System.Drawing.Point(12, 320);
            this.IndstillingerKnap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IndstillingerKnap.Name = "IndstillingerKnap";
            this.IndstillingerKnap.Size = new System.Drawing.Size(199, 42);
            this.IndstillingerKnap.TabIndex = 4;
            this.IndstillingerKnap.Text = "Indstillinger";
            this.IndstillingerKnap.Click += new System.EventHandler(this.IndstillingerKnap_Click);
            // 
            // LogUdKnap
            // 
            this.LogUdKnap.AutoSize = true;
            this.LogUdKnap.BackColor = System.Drawing.Color.Transparent;
            this.LogUdKnap.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogUdKnap.Location = new System.Drawing.Point(12, 517);
            this.LogUdKnap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogUdKnap.Name = "LogUdKnap";
            this.LogUdKnap.Size = new System.Drawing.Size(139, 42);
            this.LogUdKnap.TabIndex = 5;
            this.LogUdKnap.Text = "Log Ud";
            // 
            // BookrLogoKnap
            // 
            this.BookrLogoKnap.Image = global::P3_Bookr.Properties.Resources.BookerFullnobackground4;
            this.BookrLogoKnap.Location = new System.Drawing.Point(21, 4);
            this.BookrLogoKnap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookrLogoKnap.Name = "BookrLogoKnap";
            this.BookrLogoKnap.Size = new System.Drawing.Size(241, 62);
            this.BookrLogoKnap.TabIndex = 0;
            this.BookrLogoKnap.TabStop = false;
            this.BookrLogoKnap.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.LogUdKnap);
            this.Controls.Add(this.IndstillingerKnap);
            this.Controls.Add(this.MitForbrugKnap);
            this.Controls.Add(this.ReservationerKnap);
            this.Controls.Add(this.ServicesKnap);
            this.Controls.Add(this.BookrLogoKnap);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SideBar";
            this.Size = new System.Drawing.Size(289, 596);
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
    }
}