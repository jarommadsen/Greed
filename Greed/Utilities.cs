using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    public static class Utilities
    {
        static Random _rnd = new Random();
        /// <summary>
        /// returns a new random int in range
        /// </summary>
        /// <param name="min">from min (inclusive)</param>
        /// <param name="max">to max (exclusive)</param>
        public static int NewRandom(int min, int max)
        {
            return _rnd.Next(min, max);
        }
    }
}