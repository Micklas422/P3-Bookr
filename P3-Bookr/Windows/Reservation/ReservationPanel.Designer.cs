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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ReservationLogo = new System.Windows.Forms.PictureBox();
            this.ReservationAddressLabel = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelCancel = new System.Windows.Forms.Label();
            this.labelCancelDate = new System.Windows.Forms.Label();
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
            this.ReservationPrice.Location = new System.Drawing.Point(449, 28);
            this.ReservationPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationPrice.Name = "ReservationPrice";
            this.ReservationPrice.Size = new System.Drawing.Size(110, 29);
            this.ReservationPrice.TabIndex = 3;
            this.ReservationPrice.Text = "Pris DKK";
            this.ReservationPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationDate
            // 
            this.ReservationDate.AutoSize = true;
            this.ReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ReservationDate.Location = new System.Drawing.Point(569, 28);
            this.ReservationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.Size = new System.Drawing.Size(133, 29);
            this.ReservationDate.TabIndex = 4;
            this.ReservationDate.Text = "Dato bestilt";
            this.ReservationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(1007, 28);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 71);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Anuller\r\nBestilling\r\n";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.CanselReservation_Click);
            // 
            // ReservationLogo
            // 
            this.ReservationLogo.Location = new System.Drawing.Point(43, 38);
            this.ReservationLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReservationLogo.Name = "ReservationLogo";
            this.ReservationLogo.Size = new System.Drawing.Size(133, 62);
            this.ReservationLogo.TabIndex = 0;
            this.ReservationLogo.TabStop = false;
            // 
            // ReservationAddressLabel
            // 
            this.ReservationAddressLabel.AutoSize = true;
            this.ReservationAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ReservationAddressLabel.Location = new System.Drawing.Point(212, 70);
            this.ReservationAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationAddressLabel.Name = "ReservationAddressLabel";
            this.ReservationAddressLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReservationAddressLabel.Size = new System.Drawing.Size(102, 29);
            this.ReservationAddressLabel.TabIndex = 2;
            this.ReservationAddressLabel.Text = "Adresse";
            this.ReservationAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPrice.Location = new System.Drawing.Point(451, 58);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 20);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "1000";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.labelOrderDate.Location = new System.Drawing.Point(571, 70);
            this.labelOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(95, 20);
            this.labelOrderDate.TabIndex = 7;
            this.labelOrderDate.Text = "Dato bestilt";
            this.labelOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCancel
            // 
            this.labelCancel.AutoSize = true;
            this.labelCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.labelCancel.Location = new System.Drawing.Point(737, 28);
            this.labelCancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(152, 29);
            this.labelCancel.TabIndex = 8;
            this.labelCancel.Text = "Dato afbestilt";
            this.labelCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCancelDate
            // 
            this.labelCancelDate.AutoSize = true;
            this.labelCancelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCancelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.labelCancelDate.Location = new System.Drawing.Point(739, 70);
            this.labelCancelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCancelDate.Name = "labelCancelDate";
            this.labelCancelDate.Size = new System.Drawing.Size(95, 20);
            this.labelCancelDate.TabIndex = 9;
            this.labelCancelDate.Text = "Dato bestilt";
            this.labelCancelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelCancelDate);
            this.Controls.Add(this.labelCancel);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ReservationDate);
            this.Controls.Add(this.ReservationPrice);
            this.Controls.Add(this.ReservationAddressLabel);
            this.Controls.Add(this.ReservationServiceName);
            this.Controls.Add(this.ReservationLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReservationPanel";
            this.Size = new System.Drawing.Size(1175, 138);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ReservationLogo;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Label ReservationServiceName;
        public System.Windows.Forms.Label ReservationPrice;
        public System.Windows.Forms.Label ReservationDate;
        public System.Windows.Forms.Label ReservationAddressLabel;
        private System.Windows.Forms.Label labelPrice;
        public System.Windows.Forms.Label labelOrderDate;
        public System.Windows.Forms.Label labelCancel;
        public System.Windows.Forms.Label labelCancelDate;
    }
}
