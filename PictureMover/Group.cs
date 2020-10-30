using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureMover
{
    class Group : IGroup
    {
        private Label ToLabel;
        private Label FromLabel;
        private Button ToButton;
        private Button FromButton;
        private GroupBox Box;
        private Point GroupLocation;
        private string GroupName;
        private FolderBrowserDialog FolderBrowserDialog;

        private readonly Folder Folder = new Folder();

        private static readonly int LabelToButtonYOffset = 10;
        private static readonly int LabelXOffset = 53;
        private static readonly int ButtonXOffset = 16;
        private static readonly int ButtonYOffset = 25;
        private static readonly int LabelYOffset = LabelToButtonYOffset + ButtonYOffset;
        private static readonly int RowSpacing = 40;
        private static readonly Size ButtonSize = new Size(29, 29);
        private static readonly Size LabelSize = new Size(170, 17);
        private static readonly Size GroupSize = new Size(250, 2 * (ButtonSize.Height + RowSpacing));
        private static readonly Padding LabelPadding = new Padding(4, 0, 4, 0);
        private static readonly Padding ButtonPadding = new Padding(4);

        public Group(string groupName, Point groupLocation, FolderBrowserDialog folderBrowserDialog)
        {
            GroupLocation = groupLocation;
            GroupName = groupName;
            FolderBrowserDialog = folderBrowserDialog;
            Console.WriteLine("LabelYOffset: {0:D}", LabelYOffset);
            InitFromLabel();
            InitToLabel();
            InitFromButton();
            InitToButton();
            InitGroupBox();
        }

        #region Init Windows Form elements

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
            }
            catch (Exception)
            {
                // nothing happens
            }
        }
        private void ToButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                Folder.To = Util.OpenExplorer(FolderBrowserDialog);
            }
            catch (Exception)
            {
                // nothing happens
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

        public Folder GetFolder()
        {
            return Folder;
        }
    }
}
