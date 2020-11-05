namespace PictureMover
{
    public class Folder
    {
        public string From;
        public string To;
        public string Name;

        public Folder(string From, string To)
        {
            this.From = From;
            this.To = To;
        }

        public Folder()
        {
        }

        public override string ToString()
        {
            return $"Folder {{ name: '{Name}', from: '{From}', to: '{To}' }}";
        }

        public bool IsEmpty
        {
            get
            {
                return string.IsNullOrEmpty(To) || string.IsNullOrEmpty(From);
            }
        }
    }
}
