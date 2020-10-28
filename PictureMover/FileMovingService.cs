using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PictureMover
{
    class FileMovingService : IFileMovingService
    {
        private readonly List<Folder> Folders;

        public FileMovingService()
        {
            Folders = new List<Folder>();
        }

        public void AddFolder(Folder folder)
        {
            Folders.Add(folder);
        }

        public void MoveAll()
        {
            foreach(Folder folder in Folders)
            {
                DirectoryInfo fromDirectoryInfo = new DirectoryInfo(folder.From);
                DirectoryInfo toDirectoryInfo = new DirectoryInfo(folder.To);

                if (!fromDirectoryInfo.Exists)
                {
                    throw new Exception("From directory does not exist");
                }

                if (!toDirectoryInfo.Exists)
                {
                    Directory.CreateDirectory(folder.To);
                }

                MoveFiles(folder, toDirectoryInfo);
            }
        }

        private void MoveFiles(Folder folder, DirectoryInfo toDirectoryInfo)
        {
            List<string> files = Directory.GetFiles(folder.To, "*.*", SearchOption.TopDirectoryOnly).ToList();

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!new FileInfo(toDirectoryInfo + "\\" + fileInfo.Name).Exists)
                {
                    fileInfo.MoveTo(toDirectoryInfo + "\\" + fileInfo.Name);
                }
            }
        }
    }
}
