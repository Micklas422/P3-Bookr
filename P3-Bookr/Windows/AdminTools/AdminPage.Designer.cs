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
            this.panelServiceAdminTool = new System.Windows.Forms.Panel();
            this.panelAdministrateUserAdminTool = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelAdministratingTools
            // 
            this.labelAdministratingTools.AutoSize = true;
            this.labelAdministratingTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdministratingTools.Location = new System.Drawing.Point(239, 25);
            this.labelAdministratingTools.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdministratingTools.Name = "labelAdministratingTools";
            this.labelAdministratingTools.Size = new System.Drawing.Size(815, 76);
            this.labelAdministratingTools.TabIndex = 0;
            this.labelAdministratingTools.Text = "Administrerende værktøjer";
            // 
            // panelServiceAdminTool
            // 
            this.panelServiceAdminTool.Location = new System.Drawing.Point(0, 578);
            this.panelServiceAdminTool.Name = "panelServiceAdminTool";
            this.panelServiceAdminTool.Size = new System.Drawing.Size(1360, 332);
            this.panelServiceAdminTool.TabIndex = 2;
            // 
            // panelAdministrateUserAdminTool
            // 
            this.panelAdministrateUserAdminTool.Location = new System.Drawing.Point(0, 131);
            this.panelAdministrateUserAdminTool.Name = "panelAdministrateUserAdminTool";
            this.panelAdministrateUserAdminTool.Size = new System.Drawing.Size(1360, 332);
            this.panelAdministrateUserAdminTool.TabIndex = 3;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelAdministrateUserAdminTool);
            this.Controls.Add(this.panelServiceAdminTool);
            this.Controls.Add(this.labelAdministratingTools);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(1360, 886);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdministratingTools;
        private System.Windows.Forms.Panel panelServiceAdminTool;
        private System.Windows.Forms.Panel panelAdministrateUserAdminTool;
    }
}
