using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    public class Dice6 : IDice
    {
        int _face;
        int _minValue = 1;
        int _maxValue = 6;

        /// <summary>
        /// Makes a new 6-sided die, with a random face value
        /// </summary>
        public Dice6()
        {
            _face = Roll();
        }


        /// <summary>
        /// gets and sets the face value of the die
        /// </summary>
        public int Face
        {
            get
            {
                return _face;
            }
            set
            {
                _face = value;
            }
        }

        /// <summary>
        /// gets the Minimum possible value of the die
        /// </summary>
        public int MinValue {
            get
            {
                return _minValue;
            }
        }

        /// <summary>
        /// gets the Maximum possible value of the die
        /// </summary>
        public int MaxValue
        {
            get
            {
                return _maxValue;
            }
        }

        /// <summary>
        /// Sets the die's value to a new random value in the range available to the die
        /// </summary>
        public int Roll()
        {
            int val = Utilities.NewRandom(_minValue,_maxValue+1);
            _face = val;
            return val;
        }
    }
}