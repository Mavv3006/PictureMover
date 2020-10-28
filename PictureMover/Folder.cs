namespace PictureMover
{
    class Folder
    {
        public string From;
        public string To;

        public Folder(string From, string To)
        {
            this.From = From;
            this.To = To;
        }

        public Folder()
        {
        }

        public void setDirection(Direction Direction, string Path)
        {
            switch (Direction)
            {
                case Direction.From:
                    From = Path;
                    break;
                case Direction.To:
                    To = Path;
                    break;
            }
        }

        public enum Direction { From = 0, To = 1 };
    }
}
