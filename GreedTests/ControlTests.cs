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
            Assert.IsTrue(total == 600,"Total was: "+total);
        }
    }
}