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
            //coding and coding..

            return 0;
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
            Assert.AreEqual(2, kata.RunnersMeetings(new int[] { 1, 4, 2 }, new int[] { 5, 6, 2 }));
            Assert.AreEqual(-1, kata.RunnersMeetings(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1 }));
            Assert.AreEqual(2, kata.RunnersMeetings(new int[] { 1, 1000 }, new int[] { 23, 22 }));
        }

    }
}
