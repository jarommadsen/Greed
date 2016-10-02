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
    public class Dice6Tests
    {
        [TestMethod()]
        public void Dice6Test()
        {
            // arrange
            IDice defaultDie = new Dice6();
            IDice d1 = new Dice6();
            
            // act
            d1.Face = 2;

            // assert
            Assert.IsTrue(defaultDie.Face > 0 && defaultDie.Face <= 6);
            Assert.IsTrue(defaultDie.MinValue == 1 && defaultDie.MaxValue == 6);
            Assert.IsTrue(d1.Face == 2);
        }

        [TestMethod()]
        public void RollTest()
        {
            // arrange
            IDice d1 = new Dice6();

            int times = 1000;
            for (int i = 0; i < times; i++)
            {
                // act
                d1.Roll();

                // assert
                Assert.IsTrue(d1.Face >= d1.MinValue && d1.Face <= d1.MaxValue);
            }
        }
    }
}