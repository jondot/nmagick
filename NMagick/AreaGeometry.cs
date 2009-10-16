using System;

namespace paracode.NMagick
{
    public class AreaGeometry : Geometry
    {
        public AreaGeometry(double width, double height)
            : base(width, height)
        {

        }

        public AreaGeometry(double width, double height, double x, double y)
            : base(width, height, x, y)
        {

        }

        public override double calculateHeight(MagickImage image)
        {
            return Math.Round(Math.Sqrt(this.getWidth() * image.getHeight() / image.getWidth()));
        }

        public override double calculateWidth(MagickImage image)
        {
            return Math.Round(Math.Sqrt(this.getWidth() * image.getWidth() / image.getHeight()));
        }
    }
}
