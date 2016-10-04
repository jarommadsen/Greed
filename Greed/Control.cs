using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    public static class Control
    {
        static List<IDice> _diceHand = new List<IDice>();
        static List<IDice> _diceAside = new List<IDice>();
        static Player _currentPlayer;
        static List<Player> _playerList = new List<Player>();

        /// <summary>
        /// Initializes a set of 7 dice in hand
        /// </summary>
        static Control() // access modifiers not allowed. constructor runs on first* reference to Control (depending on compiler)
        {
            for(int i = 0; i < 7; i++)
            {
                _diceHand.Add(new Dice6());
            }
        }

        /// <summary>
        /// Gets the dice that have been set aside for points
        /// </summary>
        public static List<IDice> DiceSetAside
        {
            get
            {
                return _diceAside;
            }
        }

        /// <summary>
        /// Gets the dice that are still rollable
        /// </summary>
        public static List<IDice> DiceInHand
        {
            get
            {
                return _diceHand;
            }
            
        }

        /// <summary>
        /// gets a list of the players
        /// </summary>
        public static List<Player> Players
        {
            get
            {
                return _playerList;
            }

            private set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// gets the player whose turn it currently is
        /// </summary>
        public static Player CurrentPlayer
        {
            get
            {
                return _currentPlayer;
            }
        }

        /// <summary>
        /// takes a die out of hand and sets it aside
        /// </summary>
        /// <param name="die">die to set aside</param>
        public static void SetAside(IDice die)
        {
            if (_diceHand.Contains(die))
            {
                _diceHand.Remove((Dice6)die);
                _diceAside.Add((Dice6)die);
            }else
            {
                throw new Exception("Specified dice did not exist in hand");
            }
        }

        /// <summary>
        /// takes in hand a die that was set aside
        /// </summary>
        /// <param name="die">die to take in hand</param>
        public static void SetInHand(IDice die)
        {
            if (_diceAside.Contains(die))
            {
                _diceAside.Remove((Dice6)die);
                _diceHand.Add((Dice6)die);
            }
            else
            {
                throw new Exception("Specified dice did not exist in set aside dice");
            }
        }

        /// <summary>
        /// Adds a player to the game
        /// </summary>
        /// <param name="player">player to add to game</param>
        public static void AddPlayer(Player player)
        {
            _playerList.Add(player);
        }

        /// <param name="player">player to remove from game</param>
        public static void RemovePlayer(Player player)
        {
            if (_playerList.Contains(player))
            {
                _playerList.Remove(player);
            }else
            {
                throw new Exception("'player' does not exist in list of players");
            }
        }

        /// <summary>
        /// True if the group of dice has a point value greater than zero
        /// </summary>
        /// <param name="diceList">group of dice to check</param>
        public static bool DiceGroupHasPoints(List<IDice> diceList)
        {
            return GetDicePoints(diceList) > 0;
        }

        /// <summary>
        /// True if all dice in group are part of a point set.  (False if the group has any die that is worth no points)
        /// </summary>
        /// <param name="diceList">group of dice to check</param>
        public static bool DiceAreAllPoints(List<IDice> diceList)
        {
            foreach(IDice element in diceList)
            {
                if (!DieHasWorth((Dice6)element, diceList)) return false;
            }
            return true;
        }

        /// <summary>
        /// returns the maximum point value of a group of dice (three 1's is 1000 pts, not 300 pts)
        /// </summary>
        /// <param name="diceList">group of dice to check</param>
        public static int GetDicePoints(List<IDice> diceList)
        {
            //1's are 100
            //5's are worth 50
            //set's of 3 are worth 100x their face besides 1's and 5's
            //each additional die doubles their value (4 is double, 5 is double of 4, etc.);
            int total = 0;//the total points
            int[] numbers = GetDiceCountArray(diceList);
            int val;
            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] > 0)
                {
                    switch (i + 1)
                    {
                        case 1:
                            val = 100;
                            break;
                        case 5:
                            val = 50;
                            break;
                        default:
                            val = (i + 1) * 10;
                            break;
                    }
                    if (numbers[i] >= 3)
                    {
                        val *= 10;
                        if (numbers[i] > 3)
                        {
                            val *= (int)Math.Pow(2, numbers[i] - 3);
                        }
                    }
                    else
                    {
                        if (i != 0 && i != 4)
                        {
                            val = 0;
                        }
                    }
                    total += val;
                }
            }
            return total;
        }

        private static int[] GetDiceCountArray(List<IDice> diceList)
        {
            int[] numbers = new int[6];//how many of each number there is
            foreach (IDice element in diceList)
            {
                numbers[element.Face - 1]++;
            }

            return numbers;
        }

        /// <summary>
        /// true if the specified die has a point value greater than zero in the
        /// group of dice (also true if part of a set of 3 or more in the group of dice).  
        /// False if die does not belong to the provided group
        /// </summary>
        /// <param name="die">die to check</param>
        /// <param name="group">group of dice holding the specified die</param>
        public static bool DieHasWorth(IDice die, List<IDice> group)
        {
            if (die.Face == 1 || die.Face == 5) return true;
            int[] numbers = GetDiceCountArray(group);
            return numbers[die.Face - 1] >= 3;
        }

        /// <summary>
        /// deletes all players, puts all dice in hand
        /// </summary>
        public static void Reset()
        {
            _playerList.Clear();
            TakeAllDiceInHand();
        }

        /// <summary>
        /// moves all dice to in-hand
        /// </summary>
        public static void TakeAllDiceInHand()
        {
            foreach (IDice element in _diceAside)
            {
                _diceAside.Remove(element);
                _diceHand.Add(element);
            }
        }

        /// <summary>
        /// called when the roll button is clicked.  Rolls the dice in hand. If there are no possible points after rolling the dice then show a dialog explaining that the player busted.
        /// </summary>
        public static void RollEventHandler()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// called when a die is clicked.  If it is part of a set that has a point value, then all those dice are added to the DiceSetAside and the turn score is updated
        /// </summary>
        public static void DiceClickEventHandler()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// updates the form to display all the appropriate information
        /// </summary>
        public static void UpdateView()
        {
            foreach(IDice element in DiceInHand)
            {

            }
        }

        /// <summary>
        /// called when the Bank button is clicked.  Collects points from the dice that are left and adds the total turn points to the banked points value.
        /// </summary>
        public static void BankEventHandler()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sets the current player to the next one, with all seven dice
        /// </summary>
        public static void NextPlayer()
        {
            if (_currentPlayer == null)
            {
                _currentPlayer = Players[0];
            } else {
                int i = Players.IndexOf(_currentPlayer) + 1;
                if (i >= Players.Count()) i = 0;
                _currentPlayer = Players[i];
            }
        }
    }
}