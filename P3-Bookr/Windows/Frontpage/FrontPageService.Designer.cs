namespace P3_Bookr.Windows.Frontpage
{
    partial class FrontPageService
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
            this.LastUsedAdress = new System.Windows.Forms.Label();
            this.ServiceLastUsedDate = new System.Windows.Forms.Label();
            this.LastUsedUsed = new System.Windows.Forms.Label();
            this.ServicePrice = new System.Windows.Forms.Label();
            this.LastUsedPrice = new System.Windows.Forms.Label();
            this.ServiceAdress = new System.Windows.Forms.Label();
            this.LastUsedService = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastUsedAdress
            // 
            this.LastUsedAdress.AutoSize = true;
            this.LastUsedAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedAdress.Location = new System.Drawing.Point(27, 54);
            this.LastUsedAdress.Name = "LastUsedAdress";
            this.LastUsedAdress.Size = new System.Drawing.Size(85, 24);
            this.LastUsedAdress.TabIndex = 0;
            this.LastUsedAdress.Text = "Adresse:";
            // 
            // ServiceLastUsedDate
            // 
            this.ServiceLastUsedDate.AutoSize = true;
            this.ServiceLastUsedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLastUsedDate.Location = new System.Drawing.Point(146, 148);
            this.ServiceLastUsedDate.Name = "ServiceLastUsedDate";
            this.ServiceLastUsedDate.Size = new System.Drawing.Size(48, 24);
            this.ServiceLastUsedDate.TabIndex = 1;
            this.ServiceLastUsedDate.Text = "Dato";
            // 
            // LastUsedUsed
            // 
            this.LastUsedUsed.AutoSize = true;
            this.LastUsedUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedUsed.Location = new System.Drawing.Point(27, 148);
            this.LastUsedUsed.Name = "LastUsedUsed";
            this.LastUsedUsed.Size = new System.Drawing.Size(59, 24);
            this.LastUsedUsed.TabIndex = 2;
            this.LastUsedUsed.Text = "Brugt:";
            // 
            // ServicePrice
            // 
            this.ServicePrice.AutoSize = true;
            this.ServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicePrice.Location = new System.Drawing.Point(146, 109);
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.Size = new System.Drawing.Size(41, 24);
            this.ServicePrice.TabIndex = 3;
            this.ServicePrice.Text = "Pris";
            // 
            // LastUsedPrice
            // 
            this.LastUsedPrice.AutoSize = true;
            this.LastUsedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedPrice.Location = new System.Drawing.Point(27, 109);
            this.LastUsedPrice.Name = "LastUsedPrice";
            this.LastUsedPrice.Size = new System.Drawing.Size(46, 24);
            this.LastUsedPrice.TabIndex = 4;
            this.LastUsedPrice.Text = "Pris:";
            // 
            // ServiceAdress
            // 
            this.ServiceAdress.AutoSize = true;
            this.ServiceAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceAdress.Location = new System.Drawing.Point(146, 54);
            this.ServiceAdress.Name = "ServiceAdress";
            this.ServiceAdress.Size = new System.Drawing.Size(80, 24);
            this.ServiceAdress.TabIndex = 5;
            this.ServiceAdress.Text = "Adresse";
            // 
            // LastUsedService
            // 
            this.LastUsedService.BackColor = System.Drawing.Color.White;
            this.LastUsedService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.LastUsedService.Location = new System.Drawing.Point(0, 0);
            this.LastUsedService.Name = "LastUsedService";
            this.LastUsedService.Size = new System.Drawing.Size(267, 33);
            this.LastUsedService.TabIndex = 6;
            this.LastUsedService.Text = "Service";
            this.LastUsedService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrontPageService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LastUsedService);
            this.Controls.Add(this.ServiceAdress);
            this.Controls.Add(this.LastUsedPrice);
            this.Controls.Add(this.ServicePrice);
            this.Controls.Add(this.LastUsedUsed);
            this.Controls.Add(this.ServiceLastUsedDate);
            this.Controls.Add(this.LastUsedAdress);
            this.Name = "FrontPageService";
            this.Size = new System.Drawing.Size(267, 190);
            this.Load += new System.EventHandler(this.FrontPageService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastUsedAdress;
        private System.Windows.Forms.Label ServiceLastUsedDate;
        private System.Windows.Forms.Label LastUsedUsed;
        private System.Windows.Forms.Label ServicePrice;
        private System.Windows.Forms.Label LastUsedPrice;
        private System.Windows.Forms.Label ServiceAdress;
        private System.Windows.Forms.Label LastUsedService;
    }
}
