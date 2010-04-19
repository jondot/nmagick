using System;

namespace paracode.NMagick
{
    public class Quantum
    {

        public static int roundToQuantum(double x)
        {
            if (x <= 0.0)
            {
                return 0;
            }
            else if (x >= Constants.QuantumRange)
            {
                return (int)Math.Round((double)Constants.QuantumRange);
            }
            else
            {
                return (int)(x + 0.5);
            }
        }

        public static double scaleQuantumToMap(double x)
        {
            return Math.Max(0, Math.Min(Constants.MaxMap, x));
        }
    }
}
