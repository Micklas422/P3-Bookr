namespace P3_Bookr.Windows.ReservationPanels
{
    partial class ReservationPanel
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
            this.ReservationServiceName = new System.Windows.Forms.Label();
            this.ReservationPrice = new System.Windows.Forms.Label();
            this.ReservationDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ReservationLogo = new System.Windows.Forms.PictureBox();
            this.ReservationAddress = new System.Windows.Forms.Label();
            this.labelReservationId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationServiceName
            // 
            this.ReservationServiceName.AutoSize = true;
            this.ReservationServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationServiceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ReservationServiceName.Location = new System.Drawing.Point(204, 20);
            this.ReservationServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationServiceName.Name = "ReservationServiceName";
            this.ReservationServiceName.Size = new System.Drawing.Size(205, 39);
            this.ReservationServiceName.TabIndex = 1;
            this.ReservationServiceName.Text = "Servicenavn";
            this.ReservationServiceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationPrice
            // 
            this.ReservationPrice.AutoSize = true;
            this.ReservationPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ReservationPrice.Location = new System.Drawing.Point(553, 28);
            this.ReservationPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationPrice.Name = "ReservationPrice";
            this.ReservationPrice.Size = new System.Drawing.Size(55, 29);
            this.ReservationPrice.TabIndex = 3;
            this.ReservationPrice.Text = "Pris";
            this.ReservationPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationDate
            // 
            this.ReservationDate.AutoSize = true;
            this.ReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ReservationDate.Location = new System.Drawing.Point(760, 28);
            this.ReservationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.Size = new System.Drawing.Size(133, 29);
            this.ReservationDate.TabIndex = 4;
            this.ReservationDate.Text = "Dato bestilt";
            this.ReservationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1007, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Anuller\r\nBestilling\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CanselReservation_Click);
            // 
            // ReservationLogo
            // 
            this.ReservationLogo.Location = new System.Drawing.Point(43, 38);
            this.ReservationLogo.Margin = new System.Windows.Forms.Padding(4);
            this.ReservationLogo.Name = "ReservationLogo";
            this.ReservationLogo.Size = new System.Drawing.Size(133, 62);
            this.ReservationLogo.TabIndex = 0;
            this.ReservationLogo.TabStop = false;
            // 
            // ReservationAddress
            // 
            this.ReservationAddress.AutoSize = true;
            this.ReservationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ReservationAddress.Location = new System.Drawing.Point(212, 70);
            this.ReservationAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationAddress.Name = "ReservationAddress";
            this.ReservationAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReservationAddress.Size = new System.Drawing.Size(102, 29);
            this.ReservationAddress.TabIndex = 2;
            this.ReservationAddress.Text = "Adresse";
            this.ReservationAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReservationId
            // 
            this.labelReservationId.AutoSize = true;
            this.labelReservationId.BackColor = System.Drawing.Color.Transparent;
            this.labelReservationId.ForeColor = System.Drawing.Color.Transparent;
            this.labelReservationId.Location = new System.Drawing.Point(4, 4);
            this.labelReservationId.Name = "labelReservationId";
            this.labelReservationId.Size = new System.Drawing.Size(36, 17);
            this.labelReservationId.TabIndex = 6;
            this.labelReservationId.Text = "Test";
            this.labelReservationId.Visible = false;
            // 
            // ReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelReservationId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReservationDate);
            this.Controls.Add(this.ReservationPrice);
            this.Controls.Add(this.ReservationAddress);
            this.Controls.Add(this.ReservationServiceName);
            this.Controls.Add(this.ReservationLogo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationPanel";
            this.Size = new System.Drawing.Size(1175, 138);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ReservationLogo;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label ReservationServiceName;
        public System.Windows.Forms.Label ReservationPrice;
        public System.Windows.Forms.Label ReservationDate;
        public System.Windows.Forms.Label ReservationAddress;
        public System.Windows.Forms.Label labelReservationId;
    }
}
