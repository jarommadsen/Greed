using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    public interface IDice
    {
        /// <summary>
        /// gets or sets the face value of the die
        /// </summary>
        int Face { get; set; }
        /// <summary>
        /// gets the Minimum possible value of the die
        /// </summary>
        int MinValue { get; }
        /// <summary>
        /// gets the Maximum possible value of the die
        /// </summary>
        int MaxValue { get; }

        /// <summary>
        /// Sets the Face to a new random value between MinValue and MaxValue, returns that value (the new Face)
        /// </summary>
        int Roll();
    }
}