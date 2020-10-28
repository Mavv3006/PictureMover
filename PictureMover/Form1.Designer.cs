namespace PictureMover
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(211, 415);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Starten";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.start_Click);
            // 
            // FromFolderBrowserButton
            // 
            this.FromFolderBrowserButton.Location = new System.Drawing.Point(12, 12);
            this.FromFolderBrowserButton.Name = "FromFolderBrowserButton";
            this.FromFolderBrowserButton.Size = new System.Drawing.Size(29, 29);
            this.FromFolderBrowserButton.TabIndex = 1;
            this.FromFolderBrowserButton.Text = "...";
            this.FromFolderBrowserButton.UseVisualStyleBackColor = true;
            this.FromFolderBrowserButton.Click += new System.EventHandler(this.From_Click);
            // 
            // ToFolderBrowserButton
            // 
            this.ToFolderBrowserButton.Location = new System.Drawing.Point(12, 65);
            this.ToFolderBrowserButton.Name = "ToFolderBrowserButton";
            this.ToFolderBrowserButton.Size = new System.Drawing.Size(29, 29);
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
            this.FromLabel.Location = new System.Drawing.Point(50, 20);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(125, 13);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "Adresse des Startordners";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(50, 73);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(120, 13);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "Adresse des Zielordners";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 415);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(193, 23);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Füge einen weiteren Button hinzu";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.ToFolderBrowserButton);
            this.Controls.Add(this.FromFolderBrowserButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

