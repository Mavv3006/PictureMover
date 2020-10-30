using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureMover
{
    class Util
    {
        public static string OpenExplorer(FolderBrowserDialog folderBrowserDialog)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                return folderBrowserDialog.SelectedPath;
            } else
            {
                throw new Exception("No folder selected");
            }
        }
    }
}
