using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170812_AreTheyTheSame
{
    [TestClass]
    public class AreTheySameTests
    {

        [TestMethod]
        public void input_2_and_4_should_return_true()
        {
            var a = new[] { 2 };
            var b = new[] { 4 };

            TheySameShouldBeTrue(a, b);
        }

        [TestMethod]
        public void input_2_and_5_should_return_false()
        {
            var a = new[] { 2 };
            var b = new[] { 5 };

            TheySameShouldBeFalse(a, b);
        }

        [TestMethod]
        public void input_1_2_and_1_4_should_return_true()
        {
            var a = new[] { 1, 2 };
            var b = new[] { 1, 4 };

            TheySameShouldBeTrue(a, b);
        }

        [TestMethod]
        public void input_1_2_and_4_1_should_return_true()
        {
            var a = new[] { 1, 2 };
            var b = new[] { 4, 1 };

            TheySameShouldBeTrue(a, b);
        }

        [TestMethod]
        public void input_121_144_19_161_19_144_19_11_should_return_true()
        {
            var a = new[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            var b = new[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };

            TheySameShouldBeTrue(a, b);
        }

        [TestMethod]
        public void input_2_2_3_and_4_9_9_should_return_true()
        {
            var a = new[] { 2, 2, 3 };
            var b = new[] { 4, 9, 9 };

            TheySameShouldBeFalse(a, b);
        }

        [TestMethod]
        public void input_null_and_4_9_9_should_return_true()
        {
            int[] a = null;
            var b = new[] { 4, 9, 9 };

            TheySameShouldBeFalse(a, b);
        }

        private static void TheySameShouldBeFalse(int[] a, int[] b)
        {
            Assert.IsFalse(new AreTheySame().comp(a, b));
        }

        private static void TheySameShouldBeTrue(int[] a, int[] b)
        {
            Assert.IsTrue(new AreTheySame().comp(a, b));
        }
    }

    public class AreTheySame
    {
        public bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            return a.Select(i => i * i).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x)); 
        }
    }
}
