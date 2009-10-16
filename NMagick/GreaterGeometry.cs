namespace paracode.NMagick
{
    public class GreaterGeometry : Geometry
    {

        public GreaterGeometry(double width, double height)
            : base(width, height)
        {

        }

        public GreaterGeometry(double width, double height, double x, double y)
            : base(width, height, x, y)
        {
        }


        public override double calculateHeight(MagickImage image)
        {
            if (image.getWidth() > this.getWidth() && image.getHeight() > this.getHeight())
            {
                return new Geometry(this.getWidth(),
                                    this.getHeight(),
                                    this.getX(),
                                    this.getY()).calculateHeight(image);
            }
            else
            {
                return image.getHeight();
            }
        }


        public override double calculateWidth(MagickImage image)
        {
            if (image.getWidth() > this.getWidth() && image.getHeight() > this.getHeight())
            {
                return new Geometry(this.getWidth(),
                                    this.getHeight(),
                                    this.getX(),
                                    this.getY()).calculateWidth(image);
            }
            else
            {
                return image.getWidth();
            }
        }
    }
}
