namespace PictureMover
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.FromFolderBrowserButton = new System.Windows.Forms.Button();
            this.ToFolderBrowserButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.FolderGroup1 = new System.Windows.Forms.GroupBox();
            this.GroupAddingButton = new System.Windows.Forms.Button();
            this.FolderGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(281, 503);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(88, 36);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Starten";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.start_Click);
            // 
            // FromFolderBrowserButton
            // 
            this.FromFolderBrowserButton.Location = new System.Drawing.Point(16, 25);
            this.FromFolderBrowserButton.Margin = new System.Windows.Forms.Padding(4);
            this.FromFolderBrowserButton.Name = "FromFolderBrowserButton";
            this.FromFolderBrowserButton.Size = new System.Drawing.Size(39, 36);
            this.FromFolderBrowserButton.TabIndex = 1;
            this.FromFolderBrowserButton.Text = "...";
            this.FromFolderBrowserButton.UseVisualStyleBackColor = true;
            this.FromFolderBrowserButton.Click += new System.EventHandler(this.From_Click);
            // 
            // ToFolderBrowserButton
            // 
            this.ToFolderBrowserButton.Location = new System.Drawing.Point(16, 78);
            this.ToFolderBrowserButton.Margin = new System.Windows.Forms.Padding(4);
            this.ToFolderBrowserButton.Name = "ToFolderBrowserButton";
            this.ToFolderBrowserButton.Size = new System.Drawing.Size(39, 36);
            this.ToFolderBrowserButton.TabIndex = 2;
            this.ToFolderBrowserButton.Text = "...";
            this.ToFolderBrowserButton.UseVisualStyleBackColor = true;
            this.ToFolderBrowserButton.Click += new System.EventHandler(this.To_Click);
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(63, 35);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(170, 17);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "Adresse des Startordners";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(63, 88);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(163, 17);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "Adresse des Zielordners";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(16, 503);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(257, 36);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Füge einen weiteren Button hinzu";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // FolderGroup1
            // 
            this.FolderGroup1.AutoSize = true;
            this.FolderGroup1.Controls.Add(this.FromFolderBrowserButton);
            this.FolderGroup1.Controls.Add(this.ToFolderBrowserButton);
            this.FolderGroup1.Controls.Add(this.ToLabel);
            this.FolderGroup1.Controls.Add(this.FromLabel);
            this.FolderGroup1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FolderGroup1.Location = new System.Drawing.Point(12, 12);
            this.FolderGroup1.Name = "FolderGroup1";
            this.FolderGroup1.Size = new System.Drawing.Size(268, 136);
            this.FolderGroup1.TabIndex = 6;
            this.FolderGroup1.TabStop = false;
            this.FolderGroup1.Text = "Gruppe 1";
            // 
            // GroupAddingButton
            // 
            this.GroupAddingButton.Location = new System.Drawing.Point(376, 503);
            this.GroupAddingButton.Name = "GroupAddingButton";
            this.GroupAddingButton.Size = new System.Drawing.Size(150, 36);
            this.GroupAddingButton.TabIndex = 7;
            this.GroupAddingButton.Text = "Füge Gruppe hinzu";
            this.GroupAddingButton.UseVisualStyleBackColor = true;
            this.GroupAddingButton.Click += new System.EventHandler(this.GroupAddingButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GroupAddingButton);
            this.Controls.Add(this.FolderGroup1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.StartButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FolderGroup1.ResumeLayout(false);
            this.FolderGroup1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button FromFolderBrowserButton;
        private System.Windows.Forms.Button ToFolderBrowserButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.GroupBox FolderGroup1;
        private System.Windows.Forms.Button GroupAddingButton;
    }
}

