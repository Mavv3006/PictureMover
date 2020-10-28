using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureMover
{
    interface IFileMovingService
    {
        public void MoveAll();
        public void AddFolder(Folder folder);
    }
}
