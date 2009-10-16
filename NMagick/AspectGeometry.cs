namespace paracode.NMagick
{
    public class AspectGeometry : Geometry
    {
        public AspectGeometry(double width, double height)
            : base(width, height)
        {

        }

        public AspectGeometry(double width, double height, double x, double y)
            : base(width, height, x, y)
        {

        }

        public override double calculateHeight(MagickImage image)
        {
            return this.getHeight();
        }

        public override double calculateWidth(MagickImage image)
        {
            return this.getWidth();
        }
    }
}
