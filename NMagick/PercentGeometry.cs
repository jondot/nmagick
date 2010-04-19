namespace paracode.NMagick
{
    public class PercentGeometry : Geometry
    {

        public PercentGeometry(double width, double height)
            : base(width, height)
        {

        }

        public PercentGeometry(double width, double height, double x, double y)
            : base(width, height, x, y)
        {

        }

        public override double calculateHeight(MagickImage image)
        {
            return image.getHeight() * this.getHeight() / 100;
        }

        public override double calculateWidth(MagickImage image)
        {
            return image.getWidth() * this.getWidth() / 100;
        }
    }
}