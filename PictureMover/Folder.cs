using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureMover
{
    class Folder
    {
        public string From { get; }
        public string To { get; }
        
        public Folder(string From, string To)
        {
            this.From = From;
            this.To = To;
        }
    }
}
