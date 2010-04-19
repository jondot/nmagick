using System;

namespace paracode.NMagick
{
    public class Constants {
        public static readonly int    KernelRank = 3;
        public static readonly double MagickEpsilon = 1.0e-10;
        public static readonly double MagickHuge = 1.0e12;
        public static readonly double MagickPI = 3.14159265358979323846264338327950288419716939937510;
        public static readonly double MagickSQ2PI = 2.50662827463100024161235523934010416269302368164062;
	    public static readonly long   MaxMap = (long)Math.Round(Constants.QuantumRange*1.0);
        public static readonly int    OpaqueOpacity = 0;
        public static readonly int    QuantumRange = 255;
        public static readonly double QuantumScale = 1.0/QuantumRange;
        public static readonly int TransparentOpacity = QuantumRange;

        public static double magickSigma(double sigma){
            return (sigma <= MagickEpsilon) ? 1.0 : sigma;
        }
    }
}