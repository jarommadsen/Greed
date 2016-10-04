﻿using System;
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
        /// returns the name of the player
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            
        }

        /// <summary>
        /// point total banked for this player
        /// </summary>
        public int BankedScore
        {
            get
            {
                return _score;
            }
        }

        /// <summary>
        /// Just a means of storing and retrieving a score that represents the temporary
        /// points earned this turn.  This score is increased by rolling dice, is lost by busting,
        /// and is added to the banked score if the player stops rolling.
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