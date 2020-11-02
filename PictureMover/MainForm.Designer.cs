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
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(9, 409);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(66, 29);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Starten";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.start_Click);
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // GroupAddingButton
            // 
            this.GroupAddingButton.Location = new System.Drawing.Point(80, 410);
            this.GroupAddingButton.Margin = new System.Windows.Forms.Padding(2);
            this.GroupAddingButton.Name = "GroupAddingButton";
            this.GroupAddingButton.Size = new System.Drawing.Size(112, 29);
            this.GroupAddingButton.TabIndex = 7;
            this.GroupAddingButton.Text = "Füge Gruppe hinzu";
            this.GroupAddingButton.UseVisualStyleBackColor = true;
            this.GroupAddingButton.Click += new System.EventHandler(this.GroupAddingButton_Click);
            // 
            // SaveConfigButton
            // 
            this.SaveConfigButton.Location = new System.Drawing.Point(197, 410);
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.Size = new System.Drawing.Size(75, 29);
            this.SaveConfigButton.TabIndex = 8;
            this.SaveConfigButton.Text = "Save Config";
            this.SaveConfigButton.UseVisualStyleBackColor = true;
            this.SaveConfigButton.Click += new System.EventHandler(this.SaveConfigButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveConfigButton);
            this.Controls.Add(this.GroupAddingButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button GroupAddingButton;
        private System.Windows.Forms.Button SaveConfigButton;
    }
}

