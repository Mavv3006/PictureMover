using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace PictureMover
{
    public partial class MainForm : Form
    {
        private static readonly int GroupLeftSpacing = 10;
        private static readonly int GroupTopSpacing = 10;
        private static readonly int GroupToGroupTopSpacing = 20;

        private IFileMovingService FileMovingService = new FileMovingService();
        private int GroupCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Button Callbacks

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                FileMovingService.MoveAll();
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

            IGroup group = new Group(input, GetNewGroupCoords(), FolderBrowserDialog);
            FileMovingService.AddFolder(group.GetFolder());

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
        }
    }
}
