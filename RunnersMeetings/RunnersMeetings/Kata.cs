using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnersMeetings
{
    public class Kata
    {
        public int RunnersMeetings(int[] StartPosition, int[] speed)
        {
            int length = speed.Length;
            var speeds = speed.Select(x => x / 60.00).ToArray();
            var startPositions = StartPosition.Select(x => x).ToArray();
            var time = 0;
            var currentPositions = new List<double>();

            while (true)
            {
                currentPositions.Clear();
                for (int i = 0; i < length; i++)
                {
                    currentPositions.Add(startPositions[i] + speeds[i] * time);
                }
                var maxCount = currentPositions.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Count();
                if (maxCount > 1)
                {
                    return maxCount;
                }
                time++;
                if (time > 100000) break;
            }

            return -1;
        }
    }

    [TestFixture]
    public class myjinxin
    {

        [Test]
        public void BasicTests()
        {
            var kata = new Kata();
            Assert.AreEqual(3, kata.RunnersMeetings(new int[] { 1, 4, 2 }, new int[] { 27, 18, 24 }));
        }

        [Test]
        public void BasicTests2()
        {
            var kata = new Kata();
            Assert.AreEqual(2, kata.RunnersMeetings(new int[] { 1, 4, 2 }, new int[] { 5, 6, 2 }));
        }

        [Test]
        public void BasicTests3()
        {
            var kata = new Kata();
            Assert.AreEqual(-1, kata.RunnersMeetings(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1 }));
        }

        [Test]
        public void BasicTests4()
        {
            var kata = new Kata();
            Assert.AreEqual(2, kata.RunnersMeetings(new int[] { 1, 1000 }, new int[] { 23, 22 }));
        }

    }
}
