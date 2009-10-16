namespace paracode.NMagick
{
    public class Pattern
    {
        private MagickImage image;
        private int x;
        private int y;
        private string name;

        public Pattern(string name, int x, int y, int width, int height)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.image = new MagickImage(width, height);
        }

        public MagickImage getImage()
        {
            return this.image;
        }

        public string getName()
        {
            return this.name;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }
    }
}