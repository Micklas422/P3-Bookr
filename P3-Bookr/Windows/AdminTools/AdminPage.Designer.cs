namespace P3_Bookr.Windows.AdminTools
{
    partial class AdminPage
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
            this.labelAdministratingTools = new System.Windows.Forms.Label();
            this.administrateUser1 = new P3_Bookr.Windows.AdminTools.AdministrateUser();
            this.administrateService1 = new P3_Bookr.Windows.AdminTools.AdministrateService();
            this.SuspendLayout();
            // 
            // labelAdministratingTools
            // 
            this.labelAdministratingTools.AutoSize = true;
            this.labelAdministratingTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdministratingTools.Location = new System.Drawing.Point(179, 20);
            this.labelAdministratingTools.Name = "labelAdministratingTools";
            this.labelAdministratingTools.Size = new System.Drawing.Size(662, 63);
            this.labelAdministratingTools.TabIndex = 0;
            this.labelAdministratingTools.Text = "Administrerende værktøjer";
            // 
            // administrateUser1
            // 
            this.administrateUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.administrateUser1.Location = new System.Drawing.Point(0, 120);
            this.administrateUser1.Name = "administrateUser1";
            this.administrateUser1.Size = new System.Drawing.Size(1020, 270);
            this.administrateUser1.TabIndex = 1;
            // 
            // administrateService1
            // 
            this.administrateService1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.administrateService1.Location = new System.Drawing.Point(0, 450);
            this.administrateService1.Name = "administrateService1";
            this.administrateService1.Size = new System.Drawing.Size(1020, 270);
            this.administrateService1.TabIndex = 2;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.administrateService1);
            this.Controls.Add(this.administrateUser1);
            this.Controls.Add(this.labelAdministratingTools);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(1020, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdministratingTools;
        private AdministrateUser administrateUser1;
        private AdministrateService administrateService1;
    }
}
