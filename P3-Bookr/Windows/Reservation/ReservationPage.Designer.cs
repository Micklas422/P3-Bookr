﻿namespace P3_Bookr.Windows.Reservation
{
    partial class ReservationPage
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
            this.reservation1 = new P3_Bookr.Windows.Reservation.Reservation();
            this.reservation2 = new P3_Bookr.Windows.Reservation.Reservation();
            this.reservation3 = new P3_Bookr.Windows.Reservation.Reservation();
            this.SuspendLayout();
            // 
            // reservation1
            // 
            this.reservation1.BackColor = System.Drawing.Color.White;
            this.reservation1.Location = new System.Drawing.Point(17, 118);
            this.reservation1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reservation1.Name = "reservation1";
            this.reservation1.Size = new System.Drawing.Size(1175, 138);
            this.reservation1.TabIndex = 0;
            this.reservation1.Load += new System.EventHandler(this.reservation1_Load);
            // 
            // reservation2
            // 
            this.reservation2.BackColor = System.Drawing.Color.White;
            this.reservation2.Location = new System.Drawing.Point(17, 298);
            this.reservation2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reservation2.Name = "reservation2";
            this.reservation2.Size = new System.Drawing.Size(1175, 138);
            this.reservation2.TabIndex = 1;
            // 
            // reservation3
            // 
            this.reservation3.AutoScroll = true;
            this.reservation3.BackColor = System.Drawing.Color.White;
            this.reservation3.Location = new System.Drawing.Point(17, 473);
            this.reservation3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reservation3.Name = "reservation3";
            this.reservation3.Size = new System.Drawing.Size(1175, 138);
            this.reservation3.TabIndex = 2;
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1231, 554);
            this.Controls.Add(this.reservation3);
            this.Controls.Add(this.reservation2);
            this.Controls.Add(this.reservation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReservationPage";
            this.Text = "ReservationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Reservation reservation1;
        private Reservation reservation2;
        private Reservation reservation3;
    }
}