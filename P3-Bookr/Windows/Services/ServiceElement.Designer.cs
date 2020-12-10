namespace P3_Bookr.Windows.Services
{
    partial class ServiceElement
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
            this.ServiceAddress = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.Label();
            this.ServiceProperty = new System.Windows.Forms.Label();
            this.Property = new System.Windows.Forms.Label();
            this.ServiceRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServiceAddress
            // 
            this.ServiceAddress.BackColor = System.Drawing.Color.White;
            this.ServiceAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.ServiceAddress.Location = new System.Drawing.Point(0, 0);
            this.ServiceAddress.Name = "ServiceAddress";
            this.ServiceAddress.Size = new System.Drawing.Size(267, 33);
            this.ServiceAddress.TabIndex = 7;
            this.ServiceAddress.Text = "Adresse";
            this.ServiceAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room.Location = new System.Drawing.Point(147, 52);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(65, 24);
            this.Room.TabIndex = 13;
            this.Room.Text = "Lokale";
            // 
            // ServiceProperty
            // 
            this.ServiceProperty.AutoSize = true;
            this.ServiceProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceProperty.Location = new System.Drawing.Point(28, 107);
            this.ServiceProperty.Name = "ServiceProperty";
            this.ServiceProperty.Size = new System.Drawing.Size(100, 24);
            this.ServiceProperty.TabIndex = 12;
            this.ServiceProperty.Text = "Egenskab:";
            // 
            // Property
            // 
            this.Property.AutoSize = true;
            this.Property.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Property.Location = new System.Drawing.Point(147, 107);
            this.Property.Name = "Property";
            this.Property.Size = new System.Drawing.Size(95, 24);
            this.Property.TabIndex = 11;
            this.Property.Text = "Egenskab";
            // 
            // ServiceRoom
            // 
            this.ServiceRoom.AutoSize = true;
            this.ServiceRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceRoom.Location = new System.Drawing.Point(28, 52);
            this.ServiceRoom.Name = "ServiceRoom";
            this.ServiceRoom.Size = new System.Drawing.Size(70, 24);
            this.ServiceRoom.TabIndex = 8;
            this.ServiceRoom.Text = "Lokale:";
            // 
            // ServiceElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Room);
            this.Controls.Add(this.ServiceProperty);
            this.Controls.Add(this.Property);
            this.Controls.Add(this.ServiceRoom);
            this.Controls.Add(this.ServiceAddress);
            this.Name = "ServiceElement";
            this.Size = new System.Drawing.Size(267, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceAddress;
        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.Label ServiceProperty;
        private System.Windows.Forms.Label Property;
        private System.Windows.Forms.Label ServiceRoom;
    }
}
