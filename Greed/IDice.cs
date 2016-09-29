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
        int MinValue { get; set; }
        /// <summary>
        /// gets the Maximum possible value of the die
        /// </summary>
        int MaxValue { get; set; }

        /// <summary>
        /// Sets the die's value to a new random value in the range available to the die
        /// </summary>
        int Roll();
    }
}