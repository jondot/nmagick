using System;

namespace paracode.NMagick
{
    public class Geometry
    {
        private double height = 0;
        private double width = 0;
        private double x = 0;
        private double y = 0;

        public Geometry(double width, double height)
            : this(width, height, 0, 0)
        { }

        public Geometry(double width, double height, double x, double y)
        {
            this.setWidth(width);
            this.setHeight(height);
            this.setX(x);
            this.setY(y);
        }

        public virtual double calculateHeight(MagickImage image)
        {
            double newHeight = Math.Round(this.getWidth() * image.getHeight() / image.getWidth());
            return Math.Min(newHeight, this.getHeight());
        }

        public virtual double calculateWidth(MagickImage image)
        {
            double newWidth = Math.Round(this.getHeight() * image.getWidth() / image.getHeight());
            return Math.Min(newWidth, this.getWidth());
        }

        public virtual double calculateX(MagickImage image)
        {
            // TODO 
            return this.x;
        }

        public virtual double calculateY(MagickImage image)
        {
            return this.y;
        }

        public double getHeight()
        {
            return this.height;
        }

        public double getWidth()
        {
            return this.width;
        }

        public double getX()
        {
            return this.x;
        }

        public double getY()
        {
            return this.y;
        }

        public void setHeight(double height)
        {
            this.height = Math.Abs(height);
        }

        public void setWidth(double width)
        {
            this.width = Math.Abs(width);
        }

        public void setX(double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }
    }
}
