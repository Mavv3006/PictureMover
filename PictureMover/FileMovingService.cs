using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PictureMover
{
    class FileMovingService : IFileMovingService
    {
        private List<Folder> Folders;
        private readonly ConfigService ConfigService;

        public FileMovingService()
        {
            ConfigService = new ConfigService();
            Folders = new List<Folder>();
        }

        public void AddFolder(Folder folder)
        {
            Folders.Add(folder);
        }

        public void ConvertToXML()
        {
            ConfigService.ConvertToXML(Folders);
        }

        public void ConvertFromXML()
        {
            Folders = ConfigService.ConvertFromXML();
        }

        public void MoveAll()
        {
            foreach (Folder folder in Folders)
            {
                if (!CheckFolderIsValid(folder))
                {
                    throw new InvalidDataException("Fill in both folders first");
                }
                MakeSureTheFolderExist(folder);
                MoveFiles(folder);
            }
        }

        private bool CheckFolderIsValid(Folder folder)
        {
            return !string.IsNullOrEmpty(folder.From) && !string.IsNullOrEmpty(folder.To);
        }

        private void MakeSureTheFolderExist(Folder folder)
        {
            if (!new DirectoryInfo(folder.From).Exists)
            {
                throw new Exception("From directory does not exist");
            }

            if (!new DirectoryInfo(folder.To).Exists)
            {
                Directory.CreateDirectory(folder.To);
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
