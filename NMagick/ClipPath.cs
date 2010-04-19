namespace paracode.NMagick
{
    public class ClipPath
    {

        private MagickImage image;
        private string name;

        public ClipPath(string name, int width, int height)
        {
            //        ImageInfo info = new ImageInfo();
            //        info.setBackgroundColor(new PixelPacket(255,255,255,0));
            this.name = name;
            this.image = new MagickImage(width, height/*, info*/);
        }

        public MagickImage getImage()
        {
            return this.image;
        }
    }
}