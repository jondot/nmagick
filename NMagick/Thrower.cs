using System;

namespace paracode.NMagick
{
    public class Thrower
    {
        public static Exception throwAny(Exception throwable)
        {
            throw new Exception("thrower",throwable);
        }
    }
}
