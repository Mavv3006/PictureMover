using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PictureMover
{
    class ConfigService
    {
        public static readonly string Path = $"{AppContext.BaseDirectory}//config.xml";

        private readonly XmlSerializer XmlSerializer;

        public ConfigService()
        {
            XmlSerializer = new XmlSerializer(typeof(List<Folder>));
        }

        public List<Folder> ConvertFromXML()
        {
            FileStream fs = new FileStream(Path, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);
            List<Folder> folders = (List<Folder>)XmlSerializer.Deserialize(reader);

            fs.Close();
            return folders;
        }

        public void ConvertToXML(List<Folder> folders)
        {
            FileStream file = File.Create(Path);
            XmlSerializer.Serialize(file, folders);
            file.Close();
        }
    }
}
