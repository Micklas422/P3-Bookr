namespace P3_Bookr.Windows.AdminTools
{
    partial class AdministrateService
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
            this.buttonSeeAllServiceGroups = new System.Windows.Forms.Button();
            this.buttonSeeAllServices = new System.Windows.Forms.Button();
            this.buttonNewServiceGroup = new System.Windows.Forms.Button();
            this.buttonNewService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSeeAllServiceGroups
            // 
            this.buttonSeeAllServiceGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.buttonSeeAllServiceGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeAllServiceGroups.ForeColor = System.Drawing.Color.White;
            this.buttonSeeAllServiceGroups.Location = new System.Drawing.Point(940, 197);
            this.buttonSeeAllServiceGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSeeAllServiceGroups.Name = "buttonSeeAllServiceGroups";
            this.buttonSeeAllServiceGroups.Size = new System.Drawing.Size(200, 74);
            this.buttonSeeAllServiceGroups.TabIndex = 14;
            this.buttonSeeAllServiceGroups.Text = "Se alle servicegrupper";
            this.buttonSeeAllServiceGroups.UseVisualStyleBackColor = false;
            // 
            // buttonSeeAllServices
            // 
            this.buttonSeeAllServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.buttonSeeAllServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeAllServices.ForeColor = System.Drawing.Color.White;
            this.buttonSeeAllServices.Location = new System.Drawing.Point(687, 197);
            this.buttonSeeAllServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSeeAllServices.Name = "buttonSeeAllServices";
            this.buttonSeeAllServices.Size = new System.Drawing.Size(200, 74);
            this.buttonSeeAllServices.TabIndex = 13;
            this.buttonSeeAllServices.Text = "Se alle services";
            this.buttonSeeAllServices.UseVisualStyleBackColor = false;
            // 
            // buttonNewServiceGroup
            // 
            this.buttonNewServiceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.buttonNewServiceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewServiceGroup.ForeColor = System.Drawing.Color.White;
            this.buttonNewServiceGroup.Location = new System.Drawing.Point(433, 197);
            this.buttonNewServiceGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewServiceGroup.Name = "buttonNewServiceGroup";
            this.buttonNewServiceGroup.Size = new System.Drawing.Size(200, 74);
            this.buttonNewServiceGroup.TabIndex = 12;
            this.buttonNewServiceGroup.Text = "Opret ny servicegruppe";
            this.buttonNewServiceGroup.UseVisualStyleBackColor = false;
            // 
            // buttonNewService
            // 
            this.buttonNewService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.buttonNewService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewService.ForeColor = System.Drawing.Color.White;
            this.buttonNewService.Location = new System.Drawing.Point(180, 197);
            this.buttonNewService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewService.Name = "buttonNewService";
            this.buttonNewService.Size = new System.Drawing.Size(200, 74);
            this.buttonNewService.TabIndex = 11;
            this.buttonNewService.Text = "Opret ny service";
            this.buttonNewService.UseVisualStyleBackColor = false;
            this.buttonNewService.Click += new System.EventHandler(this.buttonNewService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 58);
            this.label2.TabIndex = 10;
            this.label2.Text = "Administrering af services";
            // 
            // AdministrateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.buttonSeeAllServiceGroups);
            this.Controls.Add(this.buttonSeeAllServices);
            this.Controls.Add(this.buttonNewServiceGroup);
            this.Controls.Add(this.buttonNewService);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdministrateService";
            this.Size = new System.Drawing.Size(1360, 332);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeeAllServiceGroups;
        private System.Windows.Forms.Button buttonSeeAllServices;
        private System.Windows.Forms.Button buttonNewServiceGroup;
        private System.Windows.Forms.Button buttonNewService;
        private System.Windows.Forms.Label label2;
    }
}
