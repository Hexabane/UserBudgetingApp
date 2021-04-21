
namespace UserBudgetingApp
{
    partial class BudgetPlanningApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetPlanningApp));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dropDownTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonViewUsers = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropDownTools,
            this.dropDownFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dropDownTools
            // 
            this.dropDownTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRestart,
            this.menuItemExit});
            this.dropDownTools.Image = global::UserBudgetingApp.Properties.Resources.tools2;
            this.dropDownTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropDownTools.Name = "dropDownTools";
            this.dropDownTools.Size = new System.Drawing.Size(78, 24);
            this.dropDownTools.Text = "Tools";
            // 
            // menuItemRestart
            // 
            this.menuItemRestart.Image = global::UserBudgetingApp.Properties.Resources.restart;
            this.menuItemRestart.Name = "menuItemRestart";
            this.menuItemRestart.Size = new System.Drawing.Size(138, 26);
            this.menuItemRestart.Text = "Restart";
            this.menuItemRestart.Click += new System.EventHandler(this.menuItemRestart_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = global::UserBudgetingApp.Properties.Resources.Exit;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(138, 26);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // dropDownFile
            // 
            this.dropDownFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddUser,
            this.menuItemViewUser});
            this.dropDownFile.Image = global::UserBudgetingApp.Properties.Resources.File;
            this.dropDownFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropDownFile.Name = "dropDownFile";
            this.dropDownFile.Size = new System.Drawing.Size(66, 24);
            this.dropDownFile.Text = "File";
            // 
            // menuItemAddUser
            // 
            this.menuItemAddUser.Image = global::UserBudgetingApp.Properties.Resources.Add_User;
            this.menuItemAddUser.Name = "menuItemAddUser";
            this.menuItemAddUser.Size = new System.Drawing.Size(157, 26);
            this.menuItemAddUser.Text = "Add User";
            this.menuItemAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // menuItemViewUser
            // 
            this.menuItemViewUser.Image = global::UserBudgetingApp.Properties.Resources.View_Users;
            this.menuItemViewUser.Name = "menuItemViewUser";
            this.menuItemViewUser.Size = new System.Drawing.Size(157, 26);
            this.menuItemViewUser.Text = "View User";
            this.menuItemViewUser.Click += new System.EventHandler(this.buttonViewUsers_Click);
            // 
            // buttonViewUsers
            // 
            this.buttonViewUsers.AutoSize = true;
            this.buttonViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewUsers.Image = global::UserBudgetingApp.Properties.Resources.View_Users;
            this.buttonViewUsers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonViewUsers.Location = new System.Drawing.Point(153, 300);
            this.buttonViewUsers.Name = "buttonViewUsers";
            this.buttonViewUsers.Size = new System.Drawing.Size(189, 77);
            this.buttonViewUsers.TabIndex = 2;
            this.buttonViewUsers.Text = "View Users";
            this.buttonViewUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonViewUsers.UseVisualStyleBackColor = true;
            this.buttonViewUsers.Click += new System.EventHandler(this.buttonViewUsers_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.AutoSize = true;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.Image = global::UserBudgetingApp.Properties.Resources.Add_User;
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddUser.Location = new System.Drawing.Point(153, 193);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(189, 73);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUDGET PLANNING APP";
            // 
            // BudgetPlanningApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(521, 483);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonViewUsers);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BudgetPlanningApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Planning App";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonViewUsers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton dropDownTools;
        private System.Windows.Forms.ToolStripMenuItem menuItemRestart;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripDropDownButton dropDownFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewUser;
    }
}

