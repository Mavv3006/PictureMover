using System;
using System.Windows.Forms;
using System.Drawing;

namespace PictureMover
{
    public partial class MainForm : Form
    {
        private Folder Folder = new Folder();
        private IFileMovingService FileMovingService = new FileMovingService();

        private Label GeneratedLabel;

        public MainForm()
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
            FolderBrowserDialog.Description = Constants.DefaultFromFolderText;
            Folder.From = Util.OpenExplorer(FolderBrowserDialog);
            FromLabel.Text = Folder.From;
        }

        private void To_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.Description = Constants.DefaultToFolderText;
            Folder.To = Util.OpenExplorer(FolderBrowserDialog);
            ToLabel.Text = Folder.To;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CreateButton Clicked");
            GeneratedLabel = new Label();
            GeneratedLabel.AutoSize = true;
            GeneratedLabel.Location = new Point(ToLabel.Location.X, ToLabel.Location.Y + 25);
            GeneratedLabel.Name = "GeneratedLabel";
            GeneratedLabel.Size = new Size(125, 13);
            GeneratedLabel.TabIndex = 3;
            GeneratedLabel.Text = "GeneratedLabel";
            Controls.Add(GeneratedLabel);
        }

        private void GroupAddingButton_Click(object sender, EventArgs e)
        {
            string prompt = "Gebe hier den Namen der neuen Gruppe ein:";
            string title = "Name für eine weitere Gruppe";
            string input = Microsoft.VisualBasic.Interaction.InputBox(prompt, title);
            IGroup group = new Group(input, new Point(150, 150), FolderBrowserDialog);
            group.Display(Controls);
        }
    }
}
