using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;

namespace PictureMover
{
    public partial class MainForm : Form
    {
        private static readonly int GroupLeftSpacing = 10;
        private static readonly int GroupTopSpacing = 10;
        private static readonly int GroupToGroupTopSpacing = 20;

        private readonly FileMovingService FileMovingService = new FileMovingService();

        private List<Group> GroupList = new List<Group>();
        private int GroupCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Button Callbacks

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                FileMovingService.MoveAll();
                MessageBox.Show("Files moved", "File Mover Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidDataException)
            {
                Console.WriteLine(e);
            }
        }

        private void GroupAddingButton_Click(object sender, EventArgs e)
        {
            string prompt = "Gebe hier den Namen der neuen Gruppe ein:";
            string title = "Name für eine weitere Gruppe";
            string input = Microsoft.VisualBasic.Interaction.InputBox(prompt, title);

            Group group = new Group(input, GetNewGroupCoords(), FolderBrowserDialog);
            FileMovingService.AddFolder(group.Folder);
            GroupList.Add(group);
            group.Display(Controls);
        }

        #endregion

        private Point GetNewGroupCoords()
        {
            return new Point(GroupLeftSpacing, GroupTopSpacing + GroupCount++ * (Group.GroupHeight + GroupToGroupTopSpacing));
        }

        private void SaveConfigButton_Click(object sender, EventArgs e)
        {
            FileMovingService.ConvertToXML();
            MessageBox.Show("Configuration saved", "Configuration file", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReadConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileMovingService.InitFromXML();
                List<Folder> folders = FileMovingService.GetFolders();
                GroupList = new List<Group>();
                foreach (Folder folder in folders)
                {
                    Group group = new Group(folder.Name, GetNewGroupCoords(), FolderBrowserDialog);
                    group.SetFolderAndUpdateLabels(folder);
                    group.Display(Controls);
                    GroupList.Add(group);
                }
                MessageBox.Show("Configuration restored.", "Configuration file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No configuration file found.", "Configuration file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
