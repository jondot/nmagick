
// TODO Finish

using System.Drawing;

namespace paracode.NMagick
{
    class SpaceTransformation
    {

        double[,] matrix;

        public SpaceTransformation()
        {
            this.matrix = new double[3, 3];

            this.matrix[0, 0] = 1;
            this.matrix[0, 1] = 0;
            this.matrix[0, 2] = 0;
            this.matrix[1, 0] = 0;
            this.matrix[1, 1] = 1;
            this.matrix[1, 2] = 0;
            this.matrix[2, 0] = 0;
            this.matrix[2, 1] = 0;
            this.matrix[2, 2] = 0;
        }

        public void compose(double sx, double rx, double ry, double sy, double tx, double ty)
        {
            double[,] newMatrix = new double[3, 3];
            // Serabe: Yeap, I do know what a nested loop is.
            newMatrix[2, 0] = 0;
            newMatrix[2, 1] = 0;
            newMatrix[2, 2] = 1;
            newMatrix[0, 0] = this.matrix[0, 0] * sx + this.matrix[0, 1] * rx;
            newMatrix[0, 1] = this.matrix[0, 0] * ry + this.matrix[0, 1] * sy;
            newMatrix[0, 2] = this.matrix[0, 0] * tx + this.matrix[0, 1] * ty + this.matrix[0, 2];
            newMatrix[1, 0] = this.matrix[1, 0] * sx + this.matrix[1, 1] * rx;
            newMatrix[1, 1] = this.matrix[1, 0] * ry + this.matrix[1, 1] * sy;
            newMatrix[1, 2] = this.matrix[1, 0] * tx + this.matrix[1, 1] * ty + this.matrix[1, 2];
            this.matrix = newMatrix;
        }

        public PointF transform(double x, double y)
        {
            return new PointF((float)(this.matrix[0, 0] * x + this.matrix[0, 1] * y + this.matrix[0, 2]),
                                        (float)(this.matrix[1, 0] * x + this.matrix[1, 1] * y + this.matrix[1, 2]));
        }

        public PointF transform(PointF point)
        {
            return this.transform(point.X, point.Y);
        }

        // TODO a transformShape method?
    }
}