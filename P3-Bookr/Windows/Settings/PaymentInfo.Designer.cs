namespace P3_Bookr.Windows.Settings
{
    partial class PaymentInfo
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
            this.PaymentPlatform = new System.Windows.Forms.Label();
            this.CardNumber = new System.Windows.Forms.Label();
            this.PaymentTop = new System.Windows.Forms.Label();
            this.PaymentEditButton = new System.Windows.Forms.Button();
            this.PaymentPlatformEdit = new System.Windows.Forms.TextBox();
            this.CardNumberEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PaymentPlatform
            // 
            this.PaymentPlatform.AutoSize = true;
            this.PaymentPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPlatform.Location = new System.Drawing.Point(30, 93);
            this.PaymentPlatform.Name = "PaymentPlatform";
            this.PaymentPlatform.Size = new System.Drawing.Size(232, 31);
            this.PaymentPlatform.TabIndex = 0;
            this.PaymentPlatform.Text = "Betalingsplatform:";
            this.PaymentPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardNumber
            // 
            this.CardNumber.AutoSize = true;
            this.CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber.Location = new System.Drawing.Point(30, 152);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(170, 31);
            this.CardNumber.TabIndex = 1;
            this.CardNumber.Text = "Kortnummer:";
            this.CardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentTop
            // 
            this.PaymentTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.PaymentTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTop.ForeColor = System.Drawing.Color.White;
            this.PaymentTop.Location = new System.Drawing.Point(0, 0);
            this.PaymentTop.Name = "PaymentTop";
            this.PaymentTop.Size = new System.Drawing.Size(889, 57);
            this.PaymentTop.TabIndex = 6;
            this.PaymentTop.Text = "Betalings Oplysninger";
            this.PaymentTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentEditButton
            // 
            this.PaymentEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.PaymentEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentEditButton.ForeColor = System.Drawing.Color.White;
            this.PaymentEditButton.Location = new System.Drawing.Point(378, 207);
            this.PaymentEditButton.Name = "PaymentEditButton";
            this.PaymentEditButton.Size = new System.Drawing.Size(136, 50);
            this.PaymentEditButton.TabIndex = 7;
            this.PaymentEditButton.Text = "Rediger";
            this.PaymentEditButton.UseVisualStyleBackColor = false;
            // 
            // PaymentPlatformEdit
            // 
            this.PaymentPlatformEdit.BackColor = System.Drawing.Color.White;
            this.PaymentPlatformEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentPlatformEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPlatformEdit.Location = new System.Drawing.Point(268, 90);
            this.PaymentPlatformEdit.Name = "PaymentPlatformEdit";
            this.PaymentPlatformEdit.ReadOnly = true;
            this.PaymentPlatformEdit.Size = new System.Drawing.Size(583, 31);
            this.PaymentPlatformEdit.TabIndex = 8;
            // 
            // CardNumberEdit
            // 
            this.CardNumberEdit.BackColor = System.Drawing.Color.White;
            this.CardNumberEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardNumberEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberEdit.Location = new System.Drawing.Point(206, 149);
            this.CardNumberEdit.Name = "CardNumberEdit";
            this.CardNumberEdit.ReadOnly = true;
            this.CardNumberEdit.Size = new System.Drawing.Size(645, 31);
            this.CardNumberEdit.TabIndex = 9;
            // 
            // PaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CardNumberEdit);
            this.Controls.Add(this.PaymentPlatformEdit);
            this.Controls.Add(this.PaymentEditButton);
            this.Controls.Add(this.PaymentTop);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.PaymentPlatform);
            this.Name = "PaymentInfo";
            this.Size = new System.Drawing.Size(889, 271);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentPlatform;
        private System.Windows.Forms.Label CardNumber;
        private System.Windows.Forms.Label PaymentTop;
        private System.Windows.Forms.Button PaymentEditButton;
        public System.Windows.Forms.TextBox PaymentPlatformEdit;
        public System.Windows.Forms.TextBox CardNumberEdit;
    }
}
