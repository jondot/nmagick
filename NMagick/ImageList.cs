using System.Collections.Generic;

namespace paracode.NMagick
{
    public class ImageList
    {
        private List<MagickImage> images;

        public ImageList(params MagickImage[] images)
        {
            this.images = new List<MagickImage>(images);
        }

        public List<MagickImage> getImages()
        {
            return images;
        }
    }
}
