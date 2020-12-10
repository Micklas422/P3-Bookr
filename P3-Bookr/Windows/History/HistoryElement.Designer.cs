namespace P3_Bookr.Windows.History
{
    partial class HistoryElement
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
            this.HistoryServiceLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceAddress = new System.Windows.Forms.Label();
            this.UsedServiceDate = new System.Windows.Forms.Label();
            this.UsedServicePrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryServiceLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryServiceLogo
            // 
            this.HistoryServiceLogo.Location = new System.Drawing.Point(35, 32);
            this.HistoryServiceLogo.Name = "HistoryServiceLogo";
            this.HistoryServiceLogo.Size = new System.Drawing.Size(100, 50);
            this.HistoryServiceLogo.TabIndex = 1;
            this.HistoryServiceLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(154, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servicenavn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceAddress
            // 
            this.ServiceAddress.AutoSize = true;
            this.ServiceAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ServiceAddress.Location = new System.Drawing.Point(156, 58);
            this.ServiceAddress.Name = "ServiceAddress";
            this.ServiceAddress.Size = new System.Drawing.Size(80, 24);
            this.ServiceAddress.TabIndex = 3;
            this.ServiceAddress.Text = "Adresse";
            // 
            // UsedServiceDate
            // 
            this.UsedServiceDate.AutoSize = true;
            this.UsedServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedServiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.UsedServiceDate.Location = new System.Drawing.Point(590, 23);
            this.UsedServiceDate.Name = "UsedServiceDate";
            this.UsedServiceDate.Size = new System.Drawing.Size(59, 24);
            this.UsedServiceDate.TabIndex = 4;
            this.UsedServiceDate.Text = "Brugt:";
            // 
            // UsedServicePrice
            // 
            this.UsedServicePrice.AutoSize = true;
            this.UsedServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedServicePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.UsedServicePrice.Location = new System.Drawing.Point(418, 23);
            this.UsedServicePrice.Name = "UsedServicePrice";
            this.UsedServicePrice.Size = new System.Drawing.Size(41, 24);
            this.UsedServicePrice.TabIndex = 5;
            this.UsedServicePrice.Text = "Pris";
            // 
            // HistoryElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UsedServicePrice);
            this.Controls.Add(this.UsedServiceDate);
            this.Controls.Add(this.ServiceAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoryServiceLogo);
            this.Name = "HistoryElement";
            this.Size = new System.Drawing.Size(881, 112);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryServiceLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HistoryServiceLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ServiceAddress;
        private System.Windows.Forms.Label UsedServiceDate;
        private System.Windows.Forms.Label UsedServicePrice;
    }
}
