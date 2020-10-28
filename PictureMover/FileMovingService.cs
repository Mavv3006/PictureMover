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
            foreach (Folder folder in Folders)
            {
                if (!new DirectoryInfo(folder.From).Exists)
                {
                    throw new Exception("From directory does not exist");
                }

                if (!new DirectoryInfo(folder.To).Exists)
                {
                    Directory.CreateDirectory(folder.To);
                }

                MoveFiles(folder);
            }
        }

        private void MoveFiles(Folder folder)
        {
            List<string> files = Directory.GetFiles(folder.From, "*.*", SearchOption.AllDirectories).ToList();
            Console.WriteLine("Suche nach Dateien in Pfad: " + folder.From);
            Console.WriteLine("Anzahl gefundener Dateien: " + files.Count);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!new FileInfo(folder.To + "\\" + fileInfo.Name).Exists)
                {
                    string fileName = folder.To + "\\" + fileInfo.Name;
                    fileInfo.MoveTo(fileName);
                    Console.WriteLine("File moved to: " + fileName);
                }
            }
        }
    }
}
