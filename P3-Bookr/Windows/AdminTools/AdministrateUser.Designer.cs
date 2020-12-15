namespace P3_Bookr.Windows.AdminTools
{
    partial class AdministrateUser
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
            this.buttonSeeAllUserGroups = new System.Windows.Forms.Button();
            this.buttonSeeAllUsers = new System.Windows.Forms.Button();
            this.buttonNewUserGroup = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSeeAllUserGroups
            // 
            this.buttonSeeAllUserGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.buttonSeeAllUserGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeAllUserGroups.ForeColor = System.Drawing.Color.White;
            this.buttonSeeAllUserGroups.Location = new System.Drawing.Point(705, 160);
            this.buttonSeeAllUserGroups.Name = "buttonSeeAllUserGroups";
            this.buttonSeeAllUserGroups.Size = new System.Drawing.Size(150, 60);
            this.buttonSeeAllUserGroups.TabIndex = 9;
            this.buttonSeeAllUserGroups.Text = "Se alle brugergrupper";
            this.buttonSeeAllUserGroups.UseVisualStyleBackColor = false;
            // 
            // buttonSeeAllUsers
            // 
            this.buttonSeeAllUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.buttonSeeAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeAllUsers.ForeColor = System.Drawing.Color.White;
            this.buttonSeeAllUsers.Location = new System.Drawing.Point(515, 160);
            this.buttonSeeAllUsers.Name = "buttonSeeAllUsers";
            this.buttonSeeAllUsers.Size = new System.Drawing.Size(150, 60);
            this.buttonSeeAllUsers.TabIndex = 8;
            this.buttonSeeAllUsers.Text = "Se alle brugere";
            this.buttonSeeAllUsers.UseVisualStyleBackColor = false;
            // 
            // buttonNewUserGroup
            // 
            this.buttonNewUserGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.buttonNewUserGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewUserGroup.ForeColor = System.Drawing.Color.White;
            this.buttonNewUserGroup.Location = new System.Drawing.Point(325, 160);
            this.buttonNewUserGroup.Name = "buttonNewUserGroup";
            this.buttonNewUserGroup.Size = new System.Drawing.Size(150, 60);
            this.buttonNewUserGroup.TabIndex = 7;
            this.buttonNewUserGroup.Text = "Opret ny brugergruppe";
            this.buttonNewUserGroup.UseVisualStyleBackColor = false;
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(172)))), ((int)(((byte)(44)))));
            this.buttonNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewUser.ForeColor = System.Drawing.Color.White;
            this.buttonNewUser.Location = new System.Drawing.Point(135, 160);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(150, 60);
            this.buttonNewUser.TabIndex = 6;
            this.buttonNewUser.Text = "Opret ny bruger";
            this.buttonNewUser.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Administrering af brugere";
            // 
            // AdministrateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.buttonSeeAllUserGroups);
            this.Controls.Add(this.buttonSeeAllUsers);
            this.Controls.Add(this.buttonNewUserGroup);
            this.Controls.Add(this.buttonNewUser);
            this.Controls.Add(this.label1);
            this.Name = "AdministrateUser";
            this.Size = new System.Drawing.Size(1020, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeeAllUserGroups;
        private System.Windows.Forms.Button buttonSeeAllUsers;
        private System.Windows.Forms.Button buttonNewUserGroup;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Label label1;
    }
}
