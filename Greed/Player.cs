using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    public class Player
    {
        string _name;
        int _score;
        int _turnScore;
        /// <param name="name">name of the player as it will be displayed</param>
        public Player(string name)
        {
            _name = name;
            _score = 0;
            _turnScore = 0;
        }

        /// <summary>
        /// gets the name of the player
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

        }

        /// <summary>
        /// gets, sets the points banked by this player
        /// </summary>
        public int BankedScore
        {
            get
            {
                return _score;
            }
        }

        /// <summary>
        /// gets, sets the points earned just this round.  May all be lost if the player busts.  Will be added to the Banked score if the player banks before busting.
        /// </summary>
        public int TurnScore
        {
            get
            {
                return _turnScore;
            }
        }
    }
}