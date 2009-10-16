namespace paracode.NMagick
{
    public abstract class Gravity
    {
        public abstract int getX(MagickImage img);
        public abstract int getX(MagickImage img, int consideredWidth);
        public abstract int getY(MagickImage img);
        public abstract int getY(MagickImage img, int consideredHeight);

        private Gravity _center = new CenterGravity();
        public Gravity CENTER { get { return _center; } }

        private Gravity _east = new EastGravity();
        public Gravity EAST { get { return _east; } }

        private Gravity _forget = new ForgetGravity();
        public Gravity FORGET { get { return _forget; } }

        private Gravity _north = new NorthGravity();
        public Gravity NORTH { get { return _north; } }

        private Gravity _northEast = new NorthEastGravity();
        public Gravity NORTH_EAST { get { return _northEast; } }

        private Gravity _northWest = new NorthWestGravity();
        public Gravity NORTH_WEST { get { return _northWest; } }

        private Gravity _south = new SouthGravity();
        public Gravity SOUTH { get { return _south; } }

        private Gravity _southEast = new SouthEastGravity();
        public Gravity SOUTH_EAST { get { return _southEast; } }

        private Gravity _west = new WestGravity();
        public Gravity WEST { get { return _west; } }

        private Gravity _southWest = new WestGravity();
        public Gravity SOUTH_WEST { get { return _southWest; } }
    }

    internal class CenterGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return (int)img.getWidth() / 2;
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return (int)(img.getWidth() - consideredWidth) / 2;
        }

        public override int getY(MagickImage img)
        {
            return (int)img.getHeight() / 2;
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return (int)(img.getHeight() - consideredHeight) / 2;
        }
    }

    internal class EastGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return (int)img.getWidth();
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return (int)img.getWidth() - consideredWidth;
        }

        public override int getY(MagickImage img)
        {
            return (int)img.getHeight() / 2;
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return (int)(img.getHeight() - consideredHeight) / 2;
        }
    }

    internal class ForgetGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return 0;
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return 0;
        }

        public override int getY(MagickImage img)
        {
            return 0;
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return 0;
        }
    }


    internal class NorthGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return (int)img.getWidth() / 2;
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return (int)(img.getWidth() - consideredWidth) / 2;
        }

        public override int getY(MagickImage img)
        {
            return 0;
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return 0;
        }
    }

    internal class NorthEastGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return (int)img.getWidth();
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return (int)img.getWidth() - consideredWidth;
        }

        public override int getY(MagickImage img)
        {
            return 0;
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return 0;
        }
    }


    internal class NorthWestGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return 0;
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return 0;
        }

        public override int getY(MagickImage img)
        {
            return 0;
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return 0;
        }
    }

    internal class SouthGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return (int)img.getWidth() / 2; ;
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return (int)(img.getWidth() - consideredWidth) / 2;
        }

        public override int getY(MagickImage img)
        {
            return (int)img.getHeight();
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return (int)img.getHeight() - consideredHeight;
        }
    }



    internal class SouthEastGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return (int)img.getWidth();
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return (int)img.getWidth() - consideredWidth;
        }

        public override int getY(MagickImage img)
        {
            return (int)img.getHeight();
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return (int)img.getHeight() - consideredHeight;
        }
    }

    internal class SouthWestGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return 0;
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return 0;
        }

        public override int getY(MagickImage img)
        {
            return (int)img.getHeight();
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return (int)img.getHeight() - consideredHeight;
        }
    }

    internal class WestGravity : Gravity
    {
        public override int getX(MagickImage img)
        {
            return 0;
        }

        public override int getX(MagickImage img, int consideredWidth)
        {
            return 0;
        }

        public override int getY(MagickImage img)
        {
            return (int)img.getHeight() / 2;
        }

        public override int getY(MagickImage img, int consideredHeight)
        {
            return (int)(img.getHeight() - consideredHeight) / 2;
        }
    }
}