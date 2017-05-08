﻿namespace mRemoteNG.UI.Forms
{
    partial class CredentialManagerUpgradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredentialManagerUpgradeForm));
            this.newCredRepoPathDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new mRemoteNG.UI.Controls.HeadlessTabControl();
            this.tabPageWelcome = new System.Windows.Forms.TabPage();
            this.textBoxConfConPathTab1 = new System.Windows.Forms.TextBox();
            this.labelConfConsPathHeaderOnTab1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDescriptionOfUpgrade = new System.Windows.Forms.Label();
            this.buttonPerformUpgrade = new System.Windows.Forms.Button();
            this.buttonNewFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.tabPageUpgradeOptions = new System.Windows.Forms.TabPage();
            this.buttonNewRepoPathBrowse = new System.Windows.Forms.Button();
            this.labelWhereToSaveCredFile = new System.Windows.Forms.Label();
            this.textBoxCredRepoPath = new System.Windows.Forms.TextBox();
            this.buttonExecuteUpgrade = new System.Windows.Forms.Button();
            this.labelSetPassword = new System.Windows.Forms.Label();
            this.newPasswordWithVerification1 = new mRemoteNG.UI.Controls.NewPasswordWithVerification();
            this.labelConfConsPathHeaderOnTab2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxConfConPathTab2 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageWelcome.SuspendLayout();
            this.tabPageUpgradeOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // newCredRepoPathDialog
            // 
            this.newCredRepoPathDialog.Filter = "Xml|*.xml|All files|*.*";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageWelcome);
            this.tabControl.Controls.Add(this.tabPageUpgradeOptions);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(60, 20);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(420, 364);
            this.tabControl.TabIndex = 5;
            // 
            // tabPageWelcome
            // 
            this.tabPageWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageWelcome.Controls.Add(this.textBoxConfConPathTab1);
            this.tabPageWelcome.Controls.Add(this.labelConfConsPathHeaderOnTab1);
            this.tabPageWelcome.Controls.Add(this.buttonExit);
            this.tabPageWelcome.Controls.Add(this.labelDescriptionOfUpgrade);
            this.tabPageWelcome.Controls.Add(this.buttonPerformUpgrade);
            this.tabPageWelcome.Controls.Add(this.buttonNewFile);
            this.tabPageWelcome.Controls.Add(this.buttonOpenFile);
            this.tabPageWelcome.Location = new System.Drawing.Point(4, 24);
            this.tabPageWelcome.Name = "tabPageWelcome";
            this.tabPageWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWelcome.Size = new System.Drawing.Size(412, 336);
            this.tabPageWelcome.TabIndex = 0;
            this.tabPageWelcome.Text = "welcomePage";
            // 
            // textBoxConfConPathTab1
            // 
            this.textBoxConfConPathTab1.Location = new System.Drawing.Point(28, 156);
            this.textBoxConfConPathTab1.Multiline = true;
            this.textBoxConfConPathTab1.Name = "textBoxConfConPathTab1";
            this.textBoxConfConPathTab1.ReadOnly = true;
            this.textBoxConfConPathTab1.Size = new System.Drawing.Size(376, 44);
            this.textBoxConfConPathTab1.TabIndex = 6;
            // 
            // labelConfConsPathHeaderOnTab1
            // 
            this.labelConfConsPathHeaderOnTab1.AutoSize = true;
            this.labelConfConsPathHeaderOnTab1.Location = new System.Drawing.Point(8, 140);
            this.labelConfConsPathHeaderOnTab1.Name = "labelConfConsPathHeaderOnTab1";
            this.labelConfConsPathHeaderOnTab1.Size = new System.Drawing.Size(104, 13);
            this.labelConfConsPathHeaderOnTab1.TabIndex = 5;
            this.labelConfConsPathHeaderOnTab1.Text = "Connection file path:";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.Location = new System.Drawing.Point(142, 305);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDescriptionOfUpgrade
            // 
            this.labelDescriptionOfUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescriptionOfUpgrade.Location = new System.Drawing.Point(6, 20);
            this.labelDescriptionOfUpgrade.Name = "labelDescriptionOfUpgrade";
            this.labelDescriptionOfUpgrade.Size = new System.Drawing.Size(400, 120);
            this.labelDescriptionOfUpgrade.TabIndex = 0;
            this.labelDescriptionOfUpgrade.Text = resources.GetString("labelDescriptionOfUpgrade.Text");
            // 
            // buttonPerformUpgrade
            // 
            this.buttonPerformUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPerformUpgrade.Location = new System.Drawing.Point(142, 218);
            this.buttonPerformUpgrade.Name = "buttonPerformUpgrade";
            this.buttonPerformUpgrade.Size = new System.Drawing.Size(139, 23);
            this.buttonPerformUpgrade.TabIndex = 1;
            this.buttonPerformUpgrade.Text = "Upgrade";
            this.buttonPerformUpgrade.UseVisualStyleBackColor = true;
            this.buttonPerformUpgrade.Click += new System.EventHandler(this.buttonPerformUpgrade_Click);
            // 
            // buttonNewFile
            // 
            this.buttonNewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewFile.Location = new System.Drawing.Point(142, 276);
            this.buttonNewFile.Name = "buttonNewFile";
            this.buttonNewFile.Size = new System.Drawing.Size(139, 23);
            this.buttonNewFile.TabIndex = 3;
            this.buttonNewFile.Text = "Create and open new file";
            this.buttonNewFile.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile.Location = new System.Drawing.Point(142, 247);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(139, 23);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Open a different file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // tabPageUpgradeOptions
            // 
            this.tabPageUpgradeOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageUpgradeOptions.Controls.Add(this.textBoxConfConPathTab2);
            this.tabPageUpgradeOptions.Controls.Add(this.buttonNewRepoPathBrowse);
            this.tabPageUpgradeOptions.Controls.Add(this.labelWhereToSaveCredFile);
            this.tabPageUpgradeOptions.Controls.Add(this.textBoxCredRepoPath);
            this.tabPageUpgradeOptions.Controls.Add(this.buttonExecuteUpgrade);
            this.tabPageUpgradeOptions.Controls.Add(this.labelSetPassword);
            this.tabPageUpgradeOptions.Controls.Add(this.newPasswordWithVerification1);
            this.tabPageUpgradeOptions.Controls.Add(this.labelConfConsPathHeaderOnTab2);
            this.tabPageUpgradeOptions.Controls.Add(this.buttonBack);
            this.tabPageUpgradeOptions.Location = new System.Drawing.Point(4, 24);
            this.tabPageUpgradeOptions.Name = "tabPageUpgradeOptions";
            this.tabPageUpgradeOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpgradeOptions.Size = new System.Drawing.Size(412, 336);
            this.tabPageUpgradeOptions.TabIndex = 1;
            this.tabPageUpgradeOptions.Text = "upgradePage";
            // 
            // buttonNewRepoPathBrowse
            // 
            this.buttonNewRepoPathBrowse.Location = new System.Drawing.Point(329, 143);
            this.buttonNewRepoPathBrowse.Name = "buttonNewRepoPathBrowse";
            this.buttonNewRepoPathBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonNewRepoPathBrowse.TabIndex = 8;
            this.buttonNewRepoPathBrowse.Text = "Browse";
            this.buttonNewRepoPathBrowse.UseVisualStyleBackColor = true;
            this.buttonNewRepoPathBrowse.Click += new System.EventHandler(this.buttonNewRepoPathBrowse_Click);
            // 
            // labelWhereToSaveCredFile
            // 
            this.labelWhereToSaveCredFile.AutoSize = true;
            this.labelWhereToSaveCredFile.Location = new System.Drawing.Point(14, 98);
            this.labelWhereToSaveCredFile.Name = "labelWhereToSaveCredFile";
            this.labelWhereToSaveCredFile.Size = new System.Drawing.Size(228, 13);
            this.labelWhereToSaveCredFile.TabIndex = 7;
            this.labelWhereToSaveCredFile.Text = "Where should we save the new credential file?";
            // 
            // textBoxCredRepoPath
            // 
            this.textBoxCredRepoPath.Location = new System.Drawing.Point(14, 117);
            this.textBoxCredRepoPath.Name = "textBoxCredRepoPath";
            this.textBoxCredRepoPath.Size = new System.Drawing.Size(390, 20);
            this.textBoxCredRepoPath.TabIndex = 6;
            // 
            // buttonExecuteUpgrade
            // 
            this.buttonExecuteUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecuteUpgrade.Location = new System.Drawing.Point(329, 305);
            this.buttonExecuteUpgrade.Name = "buttonExecuteUpgrade";
            this.buttonExecuteUpgrade.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuteUpgrade.TabIndex = 5;
            this.buttonExecuteUpgrade.Text = "Upgrade";
            this.buttonExecuteUpgrade.UseVisualStyleBackColor = true;
            // 
            // labelSetPassword
            // 
            this.labelSetPassword.AutoSize = true;
            this.labelSetPassword.Location = new System.Drawing.Point(13, 160);
            this.labelSetPassword.Name = "labelSetPassword";
            this.labelSetPassword.Size = new System.Drawing.Size(80, 13);
            this.labelSetPassword.TabIndex = 4;
            this.labelSetPassword.Text = "Set a password";
            // 
            // newPasswordWithVerification1
            // 
            this.newPasswordWithVerification1.Location = new System.Drawing.Point(27, 186);
            this.newPasswordWithVerification1.MinimumSize = new System.Drawing.Size(0, 100);
            this.newPasswordWithVerification1.Name = "newPasswordWithVerification1";
            this.newPasswordWithVerification1.PasswordChar = '\0';
            this.newPasswordWithVerification1.Size = new System.Drawing.Size(272, 100);
            this.newPasswordWithVerification1.TabIndex = 3;
            this.newPasswordWithVerification1.UseSystemPasswordChar = false;
            // 
            // labelConfConsPathHeaderOnTab2
            // 
            this.labelConfConsPathHeaderOnTab2.AutoSize = true;
            this.labelConfConsPathHeaderOnTab2.Location = new System.Drawing.Point(6, 16);
            this.labelConfConsPathHeaderOnTab2.Name = "labelConfConsPathHeaderOnTab2";
            this.labelConfConsPathHeaderOnTab2.Size = new System.Drawing.Size(85, 13);
            this.labelConfConsPathHeaderOnTab2.TabIndex = 1;
            this.labelConfConsPathHeaderOnTab2.Text = "Connections file:";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(248, 305);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxConfConPathTab2
            // 
            this.textBoxConfConPathTab2.Location = new System.Drawing.Point(27, 32);
            this.textBoxConfConPathTab2.Multiline = true;
            this.textBoxConfConPathTab2.Name = "textBoxConfConPathTab2";
            this.textBoxConfConPathTab2.ReadOnly = true;
            this.textBoxConfConPathTab2.Size = new System.Drawing.Size(377, 41);
            this.textBoxConfConPathTab2.TabIndex = 9;
            // 
            // CredentialManagerUpgradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 364);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CredentialManagerUpgradeForm";
            this.ShowInTaskbar = false;
            this.Text = "Credential Manager Upgrade";
            this.tabControl.ResumeLayout(false);
            this.tabPageWelcome.ResumeLayout(false);
            this.tabPageWelcome.PerformLayout();
            this.tabPageUpgradeOptions.ResumeLayout(false);
            this.tabPageUpgradeOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDescriptionOfUpgrade;
        private System.Windows.Forms.Button buttonPerformUpgrade;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonNewFile;
        private System.Windows.Forms.Button buttonExit;
        private mRemoteNG.UI.Controls.HeadlessTabControl tabControl;
        private System.Windows.Forms.TabPage tabPageWelcome;
        private System.Windows.Forms.TabPage tabPageUpgradeOptions;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelConfConsPathHeaderOnTab2;
        private System.Windows.Forms.Button buttonExecuteUpgrade;
        private System.Windows.Forms.Label labelSetPassword;
        private Controls.NewPasswordWithVerification newPasswordWithVerification1;
        private System.Windows.Forms.Label labelWhereToSaveCredFile;
        private System.Windows.Forms.TextBox textBoxCredRepoPath;
        private System.Windows.Forms.SaveFileDialog newCredRepoPathDialog;
        private System.Windows.Forms.Button buttonNewRepoPathBrowse;
        private System.Windows.Forms.Label labelConfConsPathHeaderOnTab1;
        private System.Windows.Forms.TextBox textBoxConfConPathTab1;
        private System.Windows.Forms.TextBox textBoxConfConPathTab2;
    }
}