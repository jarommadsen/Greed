using Microsoft.VisualStudio.TestTools.UnitTesting;
using Greed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed.Tests
{
    [TestClass()]
    public class ControlTests
    {
        [TestMethod()]
        public void DiceGroupHasPointsTest()
        {
            List<IDice> list = new List<IDice>();
            Dice6 die = new Dice6();
            die.Face = 3;
            list.Add(die);

            die = new Dice6();
            die.Face = 3;
            list.Add(die);

            die = new Dice6();
            die.Face = 2;
            list.Add(die);
            //Assert.IsFalse(Control.DiceGroupHasPoints(list));

            die = new Dice6();
            die.Face = 3;
            list.Add(die);
            Assert.IsTrue(Control.DiceGroupHasPoints(list));

        }

        [TestMethod()]
        public void GetDicePointsTest()
        {
            List<IDice> list = new List<IDice>();
            Dice6 die = new Dice6();
            die.Face = 1;
            list.Add(die);

            die = new Dice6();
            die.Face = 5;
            list.Add(die);

            die = new Dice6();
            die.Face = 5;
            list.Add(die);

            die = new Dice6();
            die.Face = 5;
            list.Add(die);

            int total = Control.GetDicePoints(list);
            Assert.IsTrue(total == 600, "Total was: " + total);
        }

        [TestMethod()]
        public void DieHasWorthTest()
        {
            Dice6 die;
            List<IDice> group = new List<IDice>();
            int[] array = new int[7] { 3, 3, 3, 1, 5, 2, 4 };

            for (int i = 0; i < 7; i++)
            {
                die = new Dice6();
                die.Face = array[i];
                group.Add(die);
            }

            die = (Dice6)group[0];
            Assert.IsTrue(Control.DieHasWorth(die, group));
            die = (Dice6)group[5];
            Assert.IsFalse(Control.DieHasWorth(die, group));
            die = (Dice6)group[6];
            Assert.IsFalse(Control.DieHasWorth(die, group));
        }

        [TestMethod()]
        public void DiceAreAllPointsTest()
        {
            Dice6 die;
            List<IDice> group = new List<IDice>();
            int[] array = new int[7] { 3, 3, 3, 1, 5, 2, 4 };

            for (int i = 0; i < 7; i++)
            {
                die = new Dice6();
                die.Face = array[i];
                group.Add(die);
            }

            Assert.IsFalse(Control.DiceAreAllPoints(group));

            group.Clear();
            array = new int[7] { 3, 3, 3, 1, 5, 5, 5 };

            for (int i = 0; i < 7; i++)
            {
                die = new Dice6();
                die.Face = array[i];
                group.Add(die);
            }

            Assert.IsTrue(Control.DiceAreAllPoints(group));
        }

        [TestMethod()]
        public void NextPlayerTest()
        {
            Control.AddPlayer(new Player("Jarom"));
            Control.AddPlayer(new Player("Denver"));
            Control.NextPlayer();
            Assert.IsTrue(Control.CurrentPlayer.Name == "Jarom");
            Control.NextPlayer();
            Assert.IsTrue(Control.CurrentPlayer.Name == "Denver");
            Control.NextPlayer();
            Assert.IsTrue(Control.CurrentPlayer.Name == "Jarom");

        }
    }
}