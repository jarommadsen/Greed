using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    public static class Control
    {
        /// <summary>
        /// Initializes a set of 7 dice in hand
        /// </summary>
        static Control() // access modifiers not allowed. constructor runs on first* reference to Control (depending on compiler)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the dice that have been set aside for points
        /// </summary>
        public static List<IDice> DiceSetAside
        {
            get
            {
                throw new System.NotImplementedException();
            }

            private set
            {
            }
        }

        /// <summary>
        /// Gets the dice that are still rollable
        /// </summary>
        public static List<IDice> DiceInHand
        {
            get
            {
                throw new System.NotImplementedException();
            }

            private set
            {
            }
        }

        /// <summary>
        /// Players in game
        /// </summary>
        public static List<Player> Players
        {
            get
            {
                throw new System.NotImplementedException();
            }

            private set
            {
            }
        }

        /// <summary>
        /// Player whose turn it is
        /// </summary>
        public static Player CurrentPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// takes a die out of hand and sets it aside
        /// </summary>
        /// <param name="die">die to set aside</param>
        public static void SetAside(IDice die)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// takes in hand a die that was set aside
        /// </summary>
        /// <param name="die">die to take in hand</param>
        public static void SetInHand(IDice die)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Adds a player to the game
        /// </summary>
        /// <param name="player">player to add to game</param>
        public static void AddPlayer(Player player)
        {
            throw new System.NotImplementedException();
        }

        /// <param name="player">player to remove from game</param>
        public static void RemovePlayer(Player player)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// True if the group of dice has a point value greater than zero
        /// </summary>
        /// <param name="diceList">group of dice to check</param>
        public static bool DiceGroupHasPoints(List<IDice> diceList)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// True if all dice in group are part of a point set.  (False if the group has any die that is worth no points)
        /// </summary>
        /// <param name="diceList">group of dice to check</param>
        public static bool DiceAreAllPoints(List<IDice> diceList)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// returns the maximum point value of a group of dice (three 1's is 1000 pts, not 300 pts)
        /// </summary>
        /// <param name="diceList">group of dice to check</param>
        public static int GetDicePoints(List<IDice> diceList)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// true if the specified die has a point value greater than zero in the group of dice (also true if part of a set of 3 or more in the group of dice).  False if die does not belong to the provided group
        /// </summary>
        /// <param name="die">die to check</param>
        /// <param name="group">group of dice holding the specified die</param>
        public static bool DieHasWorth(IDice die, List<IDice> group)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// deletes all players, puts all dice in hand
        /// </summary>
        public static void Reset()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// moves all dice to in-hand
        /// </summary>
        public static void TakeAllDiceInHand()
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }
}