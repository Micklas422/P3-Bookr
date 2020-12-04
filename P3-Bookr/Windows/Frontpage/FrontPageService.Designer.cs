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
            this.LastUsedPrice = new System.Windows.Forms.Label();
            this.LastUsedUsed = new System.Windows.Forms.Label();
            this.ServiceAdress = new System.Windows.Forms.Label();
            this.ServicePrice = new System.Windows.Forms.Label();
            this.ServiceDate = new System.Windows.Forms.Label();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastUsedAdress
            // 
            this.LastUsedAdress.AutoSize = true;
            this.LastUsedAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedAdress.Location = new System.Drawing.Point(26, 38);
            this.LastUsedAdress.Name = "LastUsedAdress";
            this.LastUsedAdress.Size = new System.Drawing.Size(85, 24);
            this.LastUsedAdress.TabIndex = 0;
            this.LastUsedAdress.Text = "Adresse:";
            // 
            // LastUsedPrice
            // 
            this.LastUsedPrice.AutoSize = true;
            this.LastUsedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedPrice.Location = new System.Drawing.Point(26, 77);
            this.LastUsedPrice.Name = "LastUsedPrice";
            this.LastUsedPrice.Size = new System.Drawing.Size(46, 24);
            this.LastUsedPrice.TabIndex = 1;
            this.LastUsedPrice.Text = "Pris:";
            // 
            // LastUsedUsed
            // 
            this.LastUsedUsed.AutoSize = true;
            this.LastUsedUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUsedUsed.Location = new System.Drawing.Point(26, 112);
            this.LastUsedUsed.Name = "LastUsedUsed";
            this.LastUsedUsed.Size = new System.Drawing.Size(59, 24);
            this.LastUsedUsed.TabIndex = 2;
            this.LastUsedUsed.Text = "Brugt:";
            // 
            // ServiceAdress
            // 
            this.ServiceAdress.AutoSize = true;
            this.ServiceAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceAdress.Location = new System.Drawing.Point(154, 38);
            this.ServiceAdress.Name = "ServiceAdress";
            this.ServiceAdress.Size = new System.Drawing.Size(80, 24);
            this.ServiceAdress.TabIndex = 3;
            this.ServiceAdress.Text = "Adresse";
            // 
            // ServicePrice
            // 
            this.ServicePrice.AutoSize = true;
            this.ServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicePrice.Location = new System.Drawing.Point(154, 77);
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.Size = new System.Drawing.Size(41, 24);
            this.ServicePrice.TabIndex = 4;
            this.ServicePrice.Text = "Pris";
            // 
            // ServiceDate
            // 
            this.ServiceDate.AutoSize = true;
            this.ServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDate.Location = new System.Drawing.Point(154, 112);
            this.ServiceDate.Name = "ServiceDate";
            this.ServiceDate.Size = new System.Drawing.Size(48, 24);
            this.ServiceDate.TabIndex = 5;
            this.ServiceDate.Text = "Dato";
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.BackColor = System.Drawing.Color.White;
            this.ServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceLabel.Location = new System.Drawing.Point(0, 0);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(287, 29);
            this.ServiceLabel.TabIndex = 6;
            this.ServiceLabel.Text = "Service";
            this.ServiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrontPageService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.ServiceLabel);
            this.Controls.Add(this.ServiceDate);
            this.Controls.Add(this.ServicePrice);
            this.Controls.Add(this.ServiceAdress);
            this.Controls.Add(this.LastUsedUsed);
            this.Controls.Add(this.LastUsedPrice);
            this.Controls.Add(this.LastUsedAdress);
            this.Name = "FrontPageService";
            this.Size = new System.Drawing.Size(287, 172);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastUsedAdress;
        private System.Windows.Forms.Label LastUsedPrice;
        private System.Windows.Forms.Label LastUsedUsed;
        private System.Windows.Forms.Label ServiceAdress;
        private System.Windows.Forms.Label ServicePrice;
        private System.Windows.Forms.Label ServiceDate;
        private System.Windows.Forms.Label ServiceLabel;
    }
}
