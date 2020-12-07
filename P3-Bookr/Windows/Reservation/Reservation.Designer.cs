namespace P3_Bookr.Windows.Reservation
{
    partial class Reservation
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
            this.ReservationService = new System.Windows.Forms.Label();
            this.ReservationAddress = new System.Windows.Forms.Label();
            this.ReservationPRice = new System.Windows.Forms.Label();
            this.ReservationDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ReservationLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationService
            // 
            this.ReservationService.AutoSize = true;
            this.ReservationService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ReservationService.Location = new System.Drawing.Point(153, 16);
            this.ReservationService.Name = "ReservationService";
            this.ReservationService.Size = new System.Drawing.Size(164, 31);
            this.ReservationService.TabIndex = 1;
            this.ReservationService.Text = "Servicenavn";
            this.ReservationService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationAddress
            // 
            this.ReservationAddress.AutoSize = true;
            this.ReservationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ReservationAddress.Location = new System.Drawing.Point(159, 57);
            this.ReservationAddress.Name = "ReservationAddress";
            this.ReservationAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReservationAddress.Size = new System.Drawing.Size(80, 24);
            this.ReservationAddress.TabIndex = 2;
            this.ReservationAddress.Text = "Adresse";
            this.ReservationAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationPRice
            // 
            this.ReservationPRice.AutoSize = true;
            this.ReservationPRice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationPRice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ReservationPRice.Location = new System.Drawing.Point(415, 23);
            this.ReservationPRice.Name = "ReservationPRice";
            this.ReservationPRice.Size = new System.Drawing.Size(41, 24);
            this.ReservationPRice.TabIndex = 3;
            this.ReservationPRice.Text = "Pris";
            this.ReservationPRice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationDate
            // 
            this.ReservationDate.AutoSize = true;
            this.ReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(88)))));
            this.ReservationDate.Location = new System.Drawing.Point(570, 23);
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.Size = new System.Drawing.Size(100, 24);
            this.ReservationDate.TabIndex = 4;
            this.ReservationDate.Text = "Dato bestilt";
            this.ReservationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(755, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Anuller\r\nBestilling\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ReservationLogo
            // 
            this.ReservationLogo.Location = new System.Drawing.Point(32, 31);
            this.ReservationLogo.Name = "ReservationLogo";
            this.ReservationLogo.Size = new System.Drawing.Size(100, 50);
            this.ReservationLogo.TabIndex = 0;
            this.ReservationLogo.TabStop = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReservationDate);
            this.Controls.Add(this.ReservationPRice);
            this.Controls.Add(this.ReservationAddress);
            this.Controls.Add(this.ReservationService);
            this.Controls.Add(this.ReservationLogo);
            this.Name = "Reservation";
            this.Size = new System.Drawing.Size(881, 112);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ReservationLogo;
        private System.Windows.Forms.Label ReservationService;
        private System.Windows.Forms.Label ReservationAddress;
        private System.Windows.Forms.Label ReservationPRice;
        private System.Windows.Forms.Label ReservationDate;
        private System.Windows.Forms.Button button1;
    }
}
