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
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.GroupAddingButton = new System.Windows.Forms.Button();
            this.SaveConfigButton = new System.Windows.Forms.Button();
            this.ReadConfigButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 503);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(88, 36);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Starten";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // GroupAddingButton
            // 
            this.GroupAddingButton.Location = new System.Drawing.Point(107, 505);
            this.GroupAddingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupAddingButton.Name = "GroupAddingButton";
            this.GroupAddingButton.Size = new System.Drawing.Size(149, 36);
            this.GroupAddingButton.TabIndex = 7;
            this.GroupAddingButton.Text = "Füge Gruppe hinzu";
            this.GroupAddingButton.UseVisualStyleBackColor = true;
            this.GroupAddingButton.Click += new System.EventHandler(this.GroupAddingButton_Click);
            // 
            // SaveConfigButton
            // 
            this.SaveConfigButton.Location = new System.Drawing.Point(263, 505);
            this.SaveConfigButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.Size = new System.Drawing.Size(100, 36);
            this.SaveConfigButton.TabIndex = 8;
            this.SaveConfigButton.Text = "Save Config";
            this.SaveConfigButton.UseVisualStyleBackColor = true;
            this.SaveConfigButton.Click += new System.EventHandler(this.SaveConfigButton_Click);
            // 
            // ReadConfigButton
            // 
            this.ReadConfigButton.Location = new System.Drawing.Point(370, 505);
            this.ReadConfigButton.Name = "ReadConfigButton";
            this.ReadConfigButton.Size = new System.Drawing.Size(100, 34);
            this.ReadConfigButton.TabIndex = 9;
            this.ReadConfigButton.Text = "Read Config";
            this.ReadConfigButton.UseVisualStyleBackColor = true;
            this.ReadConfigButton.Click += new System.EventHandler(this.ReadConfigButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ReadConfigButton);
            this.Controls.Add(this.SaveConfigButton);
            this.Controls.Add(this.GroupAddingButton);
            this.Controls.Add(this.StartButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button GroupAddingButton;
        private System.Windows.Forms.Button SaveConfigButton;
        private System.Windows.Forms.Button ReadConfigButton;
    }
}

