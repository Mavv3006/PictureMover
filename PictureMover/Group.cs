using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureMover
{
    class Group
    {
        private Label ToLabel;
        private Label FromLabel;
        private Button ToButton;
        private Button FromButton;
        private GroupBox Box;

        private string groupName;

        public Folder Folder = new Folder();
        public Point GroupLocation;

        public string GroupName
        {
            get { return groupName; }
            set
            {
                groupName= value;
                Folder.Name = value;
            }
        }

        private readonly FolderBrowserDialog FolderBrowserDialog;

        private static readonly int LabelToButtonYOffset = 10;
        private static readonly int LabelXOffset = 53;
        private static readonly int ButtonXOffset = 16;
        private static readonly int ButtonYOffset = 25;
        private static readonly int LabelYOffset = LabelToButtonYOffset + ButtonYOffset;
        private static readonly int RowSpacing = 40;
        private static readonly Size ButtonSize = new Size(29, 29);
        private static readonly Size LabelSize = new Size(170, 17);
        private static readonly Size GroupSize = new Size(250, GroupHeight);
        private static readonly Padding LabelPadding = new Padding(4, 0, 4, 0);
        private static readonly Padding ButtonPadding = new Padding(4);

        public static readonly int GroupHeight = 2 * ButtonSize.Height + RowSpacing;

        public Group(string groupName, Point groupLocation, FolderBrowserDialog folderBrowserDialog)
        {
            GroupLocation = groupLocation;
            this.groupName = groupName;
            Folder.Name = groupName;
            FolderBrowserDialog = folderBrowserDialog;
            InitGroup();
        }

        public Group() { }

        public void SetFolderAndUpdateLabels(Folder folder)
        {
            Folder = folder;
            FromLabel.Text = folder.From;
            ToLabel.Text = folder.To;
        }

        #region Init Windows Form elements

        public void Init()
        {
            if (!HasEnoughData())
            {
                throw new Exception("Provide all the data before initializing a group.");
            }

            InitGroup();
        }

        private bool HasEnoughData()
        {
            return string.IsNullOrEmpty(GroupName) == false && Folder.IsEmpty == false && GroupLocation.IsEmpty == false;
        }

        private void InitGroup()
        {
            InitFromLabel();
            InitToLabel();
            InitFromButton();
            InitToButton();
            InitGroupBox();
        }

        private void InitToLabel()
        {
            Point point = new Point(LabelXOffset, LabelYOffset + RowSpacing);
            Console.WriteLine("To: " + point.ToString());
            ToLabel = new Label
            {
                Location = point,
                Padding = LabelPadding,
                Size = LabelSize,
                Text = Constants.DefaultToFolderText
            };
        }

        private void InitFromLabel()
        {
            Point point = new Point(LabelXOffset, LabelYOffset);
            Console.WriteLine("From: " + point.ToString());
            FromLabel = new Label
            {
                Location = point,
                Padding = LabelPadding,
                Size = LabelSize,
                Text = Constants.DefaultFromFolderText
            };
        }

        private void InitToButton()
        {
            ToButton = new Button
            {
                Location = new Point(ButtonXOffset, ButtonYOffset + RowSpacing),
                Margin = ButtonPadding,
                Size = ButtonSize,
                Text = Constants.FolderButtonText
            };
            ToButton.Click += new EventHandler(ToButton_Clicked);
        }

        private void InitFromButton()
        {
            FromButton = new Button
            {
                Location = new Point(ButtonXOffset, ButtonYOffset),
                Margin = ButtonPadding,
                Size = ButtonSize,
                Text = Constants.FolderButtonText,
            };
            FromButton.Click += new EventHandler(FromButton_Clicked);
        }

        private void InitGroupBox()
        {
            Box = new GroupBox
            {
                AutoSize = true,
                Text = GroupName,
                Location = GroupLocation,
                FlatStyle = FlatStyle.Popup,
                Size = GroupSize,
            };
        }

        private void FromButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                Folder.From = Util.OpenExplorer(FolderBrowserDialog);
                FromLabel.Text = Folder.From;
            }
            catch (Exception)
            {
                Console.WriteLine(e);
            }
        }
        private void ToButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                Folder.To = Util.OpenExplorer(FolderBrowserDialog);
                ToLabel.Text = Folder.To;
            }
            catch (Exception)
            {
                Console.WriteLine(e);
            }
        }

        #endregion

        public void Display(Control.ControlCollection controls)
        {
            Box.Controls.Add(ToLabel);
            Box.Controls.Add(FromLabel);
            Box.Controls.Add(ToButton);
            Box.Controls.Add(FromButton);
            controls.Add(Box);
            Console.WriteLine("Group added");
        }
    }
}
