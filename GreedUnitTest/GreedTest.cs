using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreedGameTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore;

namespace GreedGameTest.Tests
{
    [TestClass()]
    public class GreedTest
    {
        GameCore.GameCore obj = null;

        [TestMethod]
        public void RunWithValue()
        {          
            int[] runArr = new int[] { 1, 1,1, 5, 1 };
            Assert.AreEqual(checkScore(runArr),1150);

            runArr = new int[] { 2, 3, 4, 6, 2 };
            Assert.AreEqual(checkScore(runArr), 0);

            runArr = new int[] { 3, 4, 5, 3, 3 };
            Assert.AreEqual(checkScore(runArr), 350);

            runArr = new int[] { 1, 5, 1, 2, 4 };
            Assert.AreEqual(checkScore(runArr), 250);

            runArr = new int[] { 5, 5, 5, 5, 5 };
            Assert.AreEqual(checkScore(runArr), 600);
        }

        private int checkScore(int[] array)
        {
            obj = new GameCore.GameCore();
            obj.Combinations = array;
            return obj.CalculateScore();
        }
    }
}