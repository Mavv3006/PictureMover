using System;
using System.Windows.Forms;

namespace PictureMover
{
    public partial class Form1 : Form
    {
        private Folder Folder = new Folder();
        private IFileMovingService FileMovingService = new FileMovingService();

        private Label GeneratedLabel;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Folder.From) && !string.IsNullOrEmpty(Folder.To))
            {
                FileMovingService.AddFolder(Folder);
                FileMovingService.MoveAll();
            }
            else
            {
                Console.WriteLine("Bitte wähle erst zwei Ordner aus");
            }
        }

        private void From_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.Description = "Wähle den Startordner aus";
            OpenExplorer(Folder.Direction.From);
            FromLabel.Text = Folder.From;
        }

        private void To_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.Description = "Wähle den Zielordner aus";
            OpenExplorer(Folder.Direction.To);
            ToLabel.Text = Folder.To;
        }

        private void OpenExplorer(Folder.Direction direction)
        {
            DialogResult result = FolderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowserDialog.SelectedPath))
            {
                Folder.setDirection(direction, FolderBrowserDialog.SelectedPath);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CreateButton Clicked");
            GeneratedLabel = new Label();
            GeneratedLabel.AutoSize = true;
            GeneratedLabel.Location = new System.Drawing.Point(ToLabel.Location.X, ToLabel.Location.Y + 25);
            GeneratedLabel.Name = "GeneratedLabel";
            GeneratedLabel.Size = new System.Drawing.Size(125, 13);
            GeneratedLabel.TabIndex = 3;
            GeneratedLabel.Text = "GeneratedLabel";
            Controls.Add(GeneratedLabel);
        }
    }
}
